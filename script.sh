# cargar nvm
# source ~/.zshrc
source ~/.bashrc
# . ~/.profile
source ~/.nvm/nvm.sh

nvm install node

nvm use node

node --version

export PATH=$PATH:$NVM_DIR/versions/node/$(nvm version node)/bin

echo "using node!"