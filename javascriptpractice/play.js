class players {
  constructor(name, game) {
    this.name = name;
    this.game = game;
  }

  participant() {
    console.log(`${this.name}  is participated in the ${this.game} game`);
  }

  runner() {
    console.log(`${this.name}  is the runner of the ${this.game} game`);
  }

  winner() {
    console.log(`${this.name}  is the winner of the ${this.game} game`);
  }
}

class ChessPlayer extends players {
  constructor(name) {
    super(name, "chess");
  }
  winner() {
    console.log(`${this.name}  is the chess winner of the ${this.game} game`);
  }
  
}

const player1 = new ChessPlayer("ashok");

const player2 = new ChessPlayer("aravind");

const player3 = new ChessPlayer("ajay");

player1.participant();

player2.participant();

player2.runner();

player3.participant();

player3.winner();
