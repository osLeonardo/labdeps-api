const express = require('express');
const app = express();
const path = require('path');
const appPath = path.join(__dirname, 'C:\\Users\\jhuli\\OneDrive\\Documentos\\programação\\DEPS\\labdeps-api\\frontend\\src\\index.html');

app.use(express.static(appPath));
app.set('trust proxy', true);
app.get('*', (req, res) => {
  res.sendFile(path.join(appPath, 'index.html'));
});

const port = process.env.PORT || 4200;
app.listen(port, () => {
  console.log(`Servidor Express.js executando na porta ${port}`);
});





