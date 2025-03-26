// Script to verify test results and determine if deployment can proceed
import fs from 'fs';
import path from 'path';
import { execSync } from 'child_process';
import { fileURLToPath } from 'url';

// Get current directory
const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

// Function to log with timestamp
function log(message) {
  const timestamp = new Date().toISOString().replace('T', ' ').substring(0, 19);
  console.log(`${timestamp} - ${message}`);
}

// Default test results file path
const testResultsFile = process.argv[2] || path.join(process.cwd(), 'ASafariM.Test', 'TestResults', 'tests', 'backend', 'backend_test_results.trx');

// Check if the file exists
if (!fs.existsSync(testResultsFile)) {
  log(`❌ Test results file not found at: ${testResultsFile}`);
  process.exit(1);
}

// Read the test results file
const testResults = fs.readFileSync(testResultsFile, 'utf8');

// Extract test counts using regex
function extractCount(regex) {
  const match = testResults.match(regex);
  return match ? parseInt(match[1], 10) : 0;
}

const totalTests = extractCount(/total="(\d+)"/);
const executedTests = extractCount(/executed="(\d+)"/);
const passedTests = extractCount(/passed="(\d+)"/);
const failedTests = extractCount(/failed="(\d+)"/);

// Display test summary
log('Test Summary:');
log(`  Total tests: ${totalTests}`);
log(`  Executed: ${executedTests}`);
log(`  Passed: ${passedTests}`);
log(`  Failed: ${failedTests}`);

if (failedTests > 0) {
  log(`❌ ${failedTests} tests failed. Deployment cannot proceed.`);
  
  // List failed tests if any
  const failedTestsRegex = /<UnitTestResult.*?outcome="Failed".*?testName="(.*?)"/g;
  let match;
  log('Failed Tests:');
  while ((match = failedTestsRegex.exec(testResults)) !== null) {
    log(`  - ${match[1]}`);
  }
  
  process.exit(1);
} else {
  log('✅ All tests passed! Deployment can proceed.');
  process.exit(0);
}
