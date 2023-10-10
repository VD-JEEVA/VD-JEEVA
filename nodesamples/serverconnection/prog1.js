const express=require("express");
const app=express();
const morgan=require('moragn');

//bring post content

const {getposts}=require("./posts");//getting post file in postroutes variable
const myownmiddleware=(req,res,next)=>{
    console.log("middleware is apply here!")
    next();
}
app.use(morgan("dev"));
app.use(myownmiddleware);
app.get('/',getposts);//importing file postroutes and invoking its getsposts function


const port=80;
app.listen(port,()=>{
    console.log(`node connected in port 80 ${port}`);
});