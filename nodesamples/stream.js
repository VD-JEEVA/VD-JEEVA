const fs =require('fs');
const {Transform} = require('stream');
const readStream=fs.createReadStream('C:/vueproject/ex1.txt','utf8');
const writeStream=fs.createWriteStream('C:/vueproject/ex1.txt','utf8');
 
readStream.on('data',(chunk)=>{
    console.log('data' ,chunk);
});

