class telivision {
    constructor(CompanyName, Size_Inch, Year, Price) {
        this.CompanyName = CompanyName;
        this.Size_Inch = Size_Inch;
        this.Year = Year;
        this.Price = Price; // Corrected this line
    }

    dish() {
        let button = 1; // Corrected this line
        if (button == 1)
            return "display channel program";
        else
            return "blank screen";
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

    dish() {
        return "sun tv in channel 1";
    }
}

// Example usage:
const myTV = new airtel("Sony");
console.log(myTV.dish()); // Outputs: "sun tv in channel 1"
