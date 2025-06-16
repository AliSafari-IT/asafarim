# Commit Message Generator

An automated tool that generates conventional commit messages using OpenAI's GPT model.

## Features
- Generates commit messages in conventional commit format
- Handles branch synchronization and conflict resolution
- Automatically stages changes before committing
- Includes error handling and logging

## Installation
1. Clone the repository
2. Install dependencies:
   ```bash
   pip install -r requirements.txt
   ```
3. Create a `.env` file with your OpenAI credentials:
   ```
   OPENAI_API_KEY=your_api_key
   OPENAI_ORG_ID=your_org_id
   ```

## Usage
Run the script:
```bash
python generate_commit_message.py
```

The script will:
1. Check if your branch is up-to-date
2. Pull changes if necessary
3. Generate a commit message
4. Create the commit

## Configuration
You can modify the GPT model used by editing the `gpt_engine` variable in the script.

## Requirements
- Python 3.8+
- Git
- OpenAI API key
