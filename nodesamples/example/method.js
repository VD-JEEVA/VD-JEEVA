var express=require('express');
var router=express.Router();
router.get('/',function(req,res){
    res.send('employees get route called.');
});
router.post('/',function(res,req){
    res.send('employees POST route called.');
});
module.exports=router;