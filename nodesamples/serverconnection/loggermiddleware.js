const loggermiddleware=(req,res,next)=>{
    console.log(`[${new Date()}]${req.method}${req.url}`);
    next();
}
app.use(loggermiddleware)
app.get('/',(req,res)=>{
    res.send("THIS CONNENT IS NOW EXPORTED");
});
const port=80;
app.listen(port,()=>{
    console.log(`node connected in port 80 ${port}`);
});