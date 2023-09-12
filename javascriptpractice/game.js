class players{
    constructor(name){
        this.name=name;
    }
    gameplay()
    {
        return "Game names";
    }
  }
  class player1 extends players{
    constructor(name){
        super(name);
    }
    gameplay(){
        return "volleyball";
    }
  }
  class player2 extends players{
    constructor(name){
        super(name);
    }
    gameplay(){
        return "basketball";
    }
}
    class player3 extends players{
        constructor(name){
            super(name);
        }
        gameplay(){
            return "football";
        }
    }
    const myplayer1=new player1("jeevan");
    const myplayer2=new player2("vinoth");
    const myplayer3=new player3("naresh");
     

    console.log(`${myplayer1.name}plays: ${myplayer1.gameplay()}`)
    console.log(`${myplayer2.name}plays: ${myplayer2.gameplay()}`)
    console.log(`${myplayer3.name}plays: ${myplayer3.gameplay()}`)
    
    
    

