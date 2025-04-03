#!/bin/bash

# Force the prompt to appear
export PS1='root@asafarim:${PWD}$ '

# Print current shell and terminal info
echo "Shell: $SHELL"
echo "Terminal: $TERM"
echo "Current PS1: $PS1"

# Check if we're in an interactive shell
if [[ $- == *i* ]]; then
  echo "This is an interactive shell"
else
  echo "This is NOT an interactive shell"
fi

# Force interactive mode
export BASH_INTERACTIVE=1
export PS1='root@asafarim:${PWD}$ '

# Add this to your .bashrc if not already there
if ! grep -q "BASH_INTERACTIVE" ~/.bashrc; then
  echo -e "\n# Force interactive mode for VS Code terminals\nexport BASH_INTERACTIVE=1\nexport PS1='root@asafarim:\${PWD}\$ '" >> ~/.bashrc
  echo "Added interactive mode settings to .bashrc"
fi

# Create a helper script to restart the shell
cat > /var/www/asafarim/restart_shell.sh << 'EOF'
#!/bin/bash
exec bash -i
EOF
chmod +x /var/www/asafarim/restart_shell.sh

echo ""
echo "Your prompt should now be visible in new terminals."
echo "To fix current terminals, run:"
echo "  ./restart_shell.sh"
echo ""
echo "Current directory: $(pwd)"
echo ""
