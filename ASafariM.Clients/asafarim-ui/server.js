const express = require('express');
const fs = require('fs');
const path = require('path');

const app = express();
app.use(express.json());

app.get('/users/edit/:id', (req, res) => {
    res.send('Hello World!');
});

app.post('/api/logs', (req, res) => {
    const { message, level } = req.body;

    console.log('Received log message:', message, 'with level:', level); // Debugging log

    // Get the current date and format it
    const now = new Date();
    const formattedDate = `${now.getFullYear()}${String(now.getMonth() + 1).padStart(2, '0')}${String(now.getDate()).padStart(2, '0')}`;
    const logFileName = `log-ui_${formattedDate}.txt`;

    const logDirectory = process.env.NODE_ENV === 'production' 
        ? '/var/www/asafarim/Logs' 
        : 'E:/ASafariM/Logs';

    // Ensure the log directory exists
    fs.mkdir(logDirectory, { recursive: true }, (err) => {
        if (err) {
            console.error('Failed to create log directory:', err);
            return res.status(500).send('Failed to create log directory');
        }

        const logFilePath = path.join(logDirectory, logFileName);
        const logMessage = `${new Date().toISOString()} [${level}]: ${message}\n`;

        console.log('Writing log to:', logFilePath); // Debugging log

        fs.appendFile(logFilePath, logMessage, (err) => {
            if (err) {
                console.error('Failed to write log:', err);
                return res.status(500).send('Failed to write log');
            }
            console.log('Log written successfully'); // Debugging log
            res.status(200).send('Log written');
        });
    });
});

app.listen(3000, () => {
    console.log('Server running on port 3000');
});