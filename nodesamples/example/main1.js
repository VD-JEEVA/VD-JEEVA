var express= require('express');
var app=express();
var employee=require('./method.js');
app.use('/employee',employee);
app.listen(3000);