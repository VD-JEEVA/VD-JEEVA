function tosscoin(){
    return new Promise((success,failure)=>{
        const rand=Math.floor(Math.random()*2)
        console.log(rand)
        if(rand==0)
        success()
     else
    failure()
})
}

tosscoin().then(()=>console.log("congrats !!its head"))
tosscoin().catch(()=>console.log("sorry you lost"))
