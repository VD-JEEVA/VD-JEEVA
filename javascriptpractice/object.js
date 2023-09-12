class players{
    constructor(name,game){
        this.name=name;
        this.game=game;
}
winner()
{
    console.log(`${this.name} ${this.game}is winner`);
}
runner()
{
    console.log(`${this.name} ${this.game} is runner of the match`);
}
participant()
{
    console.log(`${this.name} ${this.game} is participated in game`);
}

 } 
 const player1=new players("ashok","chess");
 const player2=new players("aravind","chess");
 const player3=new players("ajay","chess");

 player1.participant();
 player2.participant();
 player2.runner();
 player3.participant();
 player3.winner();
 
 
 

