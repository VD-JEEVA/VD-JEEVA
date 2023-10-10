var express =require('express');
var app=express();
app.get('/home',function(req,res){
res.send("HI VUEDATA EMPLOYEES!!!");
});
app.get('/',function(res,req){
    res.send("invaild url");

});
app.use('*',function(res,req));
app.listen(3000);