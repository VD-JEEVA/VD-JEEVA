var http=require("http");
http.createServer(function(resquest,response){
    response.writeHead(200,{'content-Typ':'text/plain'});
    response.end('HELLO VUEDATA\n');
}).listen(8081);
console.log('server running at http://127.0.0.1:8081/');

