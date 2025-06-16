#!/usr/bin/env python3
import subprocess
import logging
import os
import sys
import time

# Created by Ali Safari, Senior Software Engineer at ASafariM
# Specializing in React, C# .NET, and AI-driven development tools and efficient workflows
# Contact: ali@asafarim.com

# Configure logging
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')

# Try to import dependencies with fallback
OPENAI_AVAILABLE = False
client = None

try:
    from openai import OpenAI, OpenAIError, RateLimitError
    from dotenv import load_dotenv
    
    # Load environment variables from .env file
    load_dotenv()
    
    # Initialize OpenAI client
    api_key = os.getenv("OPENAI_API_KEY")
    if api_key:
        client = OpenAI(
            organization=os.getenv("OPENAI_ORG_ID"), 
            api_key=api_key
        )
        OPENAI_AVAILABLE = True
        logging.info("OpenAI client initialized successfully")
    else:
        logging.warning("OPENAI_API_KEY not found in environment variables")
        
except ImportError as e:
    logging.warning(f"OpenAI dependencies not available: {e}")
    logging.info("Falling back to simple commit message generation")
except Exception as e:
    logging.warning(f"Failed to initialize OpenAI client: {e}")
    logging.info("Falling back to simple commit message generation")


def get_git_diff():
    """Get a summary of changes from git."""
    try:
        # Check if there are staged changes
        staged_status = subprocess.check_output(
            ["git", "diff", "--cached", "--name-only"], encoding="utf-8"
        ).strip()
        
        if not staged_status:
            logging.info("No staged changes found")
            return None
            
        # Get list of changed files
        files_changed = subprocess.check_output(
            ["git", "diff", "--cached", "--name-status"], encoding="utf-8"
        )
        
        # Get a limited diff (first 100 lines)
        diff_summary = subprocess.check_output(
            ["git", "diff", "--cached", "--stat"], encoding="utf-8"
        )
        
        # Get actual diff but limit it
        full_diff = subprocess.check_output(
            ["git", "diff", "--cached", "--unified=3"], encoding="utf-8"
        )
        
        # Limit the full diff to first 1000 characters
        limited_diff = full_diff[:1000] + ("\n... [diff truncated]" if len(full_diff) > 1000 else "")
        
        return f"Files changed:\n{files_changed}\nSummary:\n{diff_summary}\nPartial diff:\n{limited_diff}"
    except subprocess.CalledProcessError as e:
        logging.error(f"Error getting git diff: {e}")
        return None


def generate_simple_commit_message(diff):
    """Generate a simple commit message based on file changes."""
    if not diff:
        return "chore: update files"
    
    # Simple logic based on file extensions and content
    if ".py" in diff:
        return "feat(scripts): update Python scripts"
    elif ".json" in diff and "package.json" in diff:
        return "chore(deps): update package configuration"
    elif ".md" in diff:
        return "docs: update documentation"
    elif any(ext in diff for ext in [".js", ".ts", ".jsx", ".tsx", ".vue"]):
        return "feat(frontend): update frontend code"
    elif ".cs" in diff:
        return "feat(backend): update backend code"
    elif ".yml" in diff or ".yaml" in diff:
        return "chore(config): update configuration files"
    elif ".sql" in diff:
        return "feat(database): update database schema"
    elif ".sh" in diff or ".bash" in diff:
        return "chore(scripts): update shell scripts"
    else:
        return "chore: update files"


def generate_commit_message(diff):
    """Generate a commit message using OpenAI's GPT model or fallback."""
    if not OPENAI_AVAILABLE or not client:
        logging.info("Using simple commit message generation")
        return generate_simple_commit_message(diff)
    
    prompt = (
        "Generate a concise, conventional commit message for the following changes.\n"
        "Use the format: <type>(<scope>): <description>\n"
        "Types: feat, fix, docs, style, refactor, test, chore\n"
        "Example: feat(ui): add new login component\n\n"
        f"Changes:\n{diff}"
    )

    retries = 3
    for i in range(retries):
        try:
            response = client.chat.completions.create(
                model="gpt-3.5-turbo",
                messages=[{"role": "user", "content": prompt}],
                max_tokens=100
            )
            message = response.choices[0].message.content
            # Remove backticks and 'commit message:' prefix if present
            message = message.strip('`').replace('commit message:', '').strip()
            return message
        except (OpenAIError, RateLimitError) as e:
            logging.warning(f"Attempt {i + 1}: Error generating commit message: {e}")
            time.sleep(2 ** i)  # Exponential backoff
        except Exception as e:
            logging.error(f"Unexpected error: {e}")
            break
    
    # Fallback to simple generation if AI fails
    logging.warning("AI generation failed, using simple fallback")
    return generate_simple_commit_message(diff)


def main():
    # Remove the automatic staging since it's done in package.json
    diff = get_git_diff()
    if diff:
        commit_message = generate_commit_message(diff)
        if commit_message:
            logging.info(f'Generated Commit Message: {commit_message}')

            # Create the commit with the generated message
            try:
                subprocess.run(['git', 'commit', '-m', commit_message], check=True)
                logging.info('Commit created successfully!')
            except subprocess.CalledProcessError as e:
                logging.error(f'Error creating commit: {e}')
                sys.exit(1)
        else:
            logging.warning('Failed to generate commit message. Using fallback.')
            # Fallback commit message
            try:
                subprocess.run(['git', 'commit', '-m', 'chore: update files'], check=True)
                logging.info('Fallback commit created successfully!')
            except subprocess.CalledProcessError as e:
                logging.error(f'Error creating fallback commit: {e}')
                sys.exit(1)
    else:
        logging.info('No staged changes found.')
        sys.exit(0)


if __name__ == "__main__":
    main()
