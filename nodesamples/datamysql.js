const mysql=require('mysql2');
const pool=mysql.createConnection({
    host:'localhost',
    user:'root',
    password:'VueData@2023',
    database:'meeting_room',
    connectionLimit:10,
});
pool.query('SELECT * FROM employee_details',(err,results)=>{
    if(err){
        console.error(err);
        return;
    }
    console.log('Query result',results);
    
});
