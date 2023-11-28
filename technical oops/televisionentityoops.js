class telivision {
    constructor(CompanyName, Size_Inch, Year, Price) {
        this.CompanyName = CompanyName;
        this.Size_Inch = Size_Inch;
        this.Year = Year;
        this.Price = Price; 
    }

    remotebtn() {
            return "display channel.NO 1 program";
    }
}

class internalcompounents {
    constructor() {
        this.displayPanel = "oled";
        this.processor = "CPU";
        this.powersupply = "powersupplyunit";
        this.backlight = "LED";
    }
}

class airtel extends telivision {
    constructor(CompanyName) {
        super(CompanyName);
    }

    remotebtn() {
        button==1
        return "sun tv in channel 1";
    }
}   


