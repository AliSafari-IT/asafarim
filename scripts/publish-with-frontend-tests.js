// Script to run frontend tests and publish the application
import fs from 'fs';
import path from 'path';
import { execSync } from 'child_process';
import { fileURLToPath } from 'url';
import readline from 'readline';

// Get current directory
const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

// Function to log with timestamp
function log(message) {
  const timestamp = new Date().toISOString().replace('T', ' ').substring(0, 19);
  console.log(`${timestamp} - ${message}`);
}

// Function to run a command and log output
function runCommand(command, cwd = process.cwd()) {
  log(`Running command: ${command}`);
  try {
    const output = execSync(command, { 
      cwd, 
      stdio: 'inherit',
      encoding: 'utf8'
    });
    return { success: true, output };
  } catch (error) {
    log(`❌ Command failed with error: ${error.message}`);
    return { success: false, error };
  }
}

// Create test directories
const testsDir = path.join(process.cwd(), 'tests');
const backendTestsDir = path.join(testsDir, 'backend');
const frontendTestsDir = path.join(testsDir, 'frontend');

if (!fs.existsSync(backendTestsDir)) {
  fs.mkdirSync(backendTestsDir, { recursive: true });
}

if (!fs.existsSync(frontendTestsDir)) {
  fs.mkdirSync(frontendTestsDir, { recursive: true });
}

// Run backend tests
log('Running backend tests...');
const backendTestResult = runCommand('yarn test:backend');
if (!backendTestResult.success) {
  log('❌ Backend tests failed. Aborting deployment.');
  process.exit(1);
}

// Verify backend tests
log('Verifying backend test results...');
const verifyResult = runCommand('yarn test:verify');
if (!verifyResult.success) {
  log('❌ Backend test verification failed. Aborting deployment.');
  process.exit(1);
}

// Run frontend tests
log('Running frontend tests...');
const frontendTestResult = runCommand('yarn test');
if (!frontendTestResult.success) {
  log('❌ Frontend tests failed. Aborting deployment.');
  process.exit(1);
}

// Ask user which components to deploy
log('******* Deploying ASafariM Application *******');
console.log('');
console.log(' ******* Deploying ASafariM Application *******');
console.log('1: Frontend (asafarim-ui)');
console.log('2: Backend (ASafariM.Api)');
console.log('3: Both (Frontend & Backend)');
console.log('4: Blog');
console.log('5: Bibliography');
console.log('0: Exit');
console.log('');
console.log('You can select multiple options using commas (e.g., "1,4,5" to deploy Frontend, Blog, and Bibliography)');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

rl.question('Enter deploy mode(s): ', (deployModes) => {
  if (deployModes === '0') {
    log('Exiting...');
    rl.close();
    process.exit(0);
  }

  // Ask about database migration
  console.log(' ******* Database Migration update *******');
  rl.question('Apply database migration? (y/n): ', (dbMode) => {
    rl.close();
    
    const deployModeArray = deployModes.split(',').map(mode => mode.trim());
    log(`Selected deployment modes: ${deployModes}`);

    // Deploy frontend if selected
    if (deployModeArray.includes('1') || deployModeArray.includes('3')) {
      log('Starting Frontend Deployment...');
      const frontendResult = runCommand('yarn workspace asafarim-ui build');
      if (!frontendResult.success) {
        log('❌ Frontend build failed. Aborting deployment.');
        process.exit(1);
      }
      log('✅ Frontend built successfully.');
    }

    // Deploy backend if selected
    if (deployModeArray.includes('2') || deployModeArray.includes('3')) {
      log('Starting Backend Deployment...');
      const backendResult = runCommand('yarn api:build');
      if (!backendResult.success) {
        log('❌ Backend build failed. Aborting deployment.');
        process.exit(1);
      }
      log('✅ Backend built successfully.');
    }

    // Deploy blog if selected
    if (deployModeArray.includes('4')) {
      log('Starting Blog Deployment...');
      const blogResult = runCommand('yarn workspace asafarim-blog build');
      if (!blogResult.success) {
        log('❌ Blog build failed. Aborting deployment.');
        process.exit(1);
      }
      log('✅ Blog built successfully.');
    }

    // Deploy bibliography if selected
    if (deployModeArray.includes('5')) {
      log('Starting Bibliography Deployment...');
      const bibliographyResult = runCommand('yarn workspace asafarim-bibliography build');
      if (!bibliographyResult.success) {
        log('❌ Bibliography build failed. Aborting deployment.');
        process.exit(1);
      }
      log('✅ Bibliography built successfully.');
    }

    log('Deployment completed successfully!');
    console.log('');
    console.log('  Deployment completed successfully!  ');
  });
});
