function myfun(solve) {

    document.getElementById("sample").innerHTML = solve;
  
  }
  
   
  
  function mul(num1, num2, Callback) {
  
    let mult = num1 * num2;
  
    Callback(mult);
  
  }
  
   
  
  mul(5, 5, myfun);
  
  