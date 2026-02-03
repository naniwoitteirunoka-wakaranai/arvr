const express = require('express');
const path = require('path');
const app = express();

app.use(express.static(path.join(__dirname, 'public')));

// ADD THIS TEST ROUTE:
app.get('/', (req, res) => {
    res.send('<h1> Meow <h1>');
});

const PORT = process.env.PORT || 3000;
app.listen(PORT, '0.0.0.0', () => {
    // Corrected to http://
    console.log(`Server running on http://localhost:${PORT}`);
});
