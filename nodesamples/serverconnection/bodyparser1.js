const express=require("express")
const app=express();
app.get('/json',(req,res)=>{
    const requestData=req.body;
    res.json({message:'received json data',data:requestdata});

    
});
const port=80;
app.listen(port,()=>{
    console.log(`node connected in port 80 ${port}`);
});