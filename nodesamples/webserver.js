const http = require("http");

const fs = require("fs");

// const { type } = require('os');

const server = http.createServer((req, res) => {
  if (req.url == "/api/data") {
    const responseData = { message: "Hello, Client!" };

    res.writeHead(200, { "content-type": "application/json" });

    res.end(JSON.stringify(responseData));
  } else {
    res.writeHead(404, { "content-type": "text/plain" });

    res.end("Not Found");
  }
});

const port = 3000;

server.listen(port, () => {
  console.log(`Server is listening on port ${port}`);
});
