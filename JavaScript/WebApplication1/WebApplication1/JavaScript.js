
var Balance = Number("100");
var cardValues = ["ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"];
var cardSuits = [" of Hearts", " of Diamonds", " of Spades", " of Clubs"];
var card1 = 0;
var card2 = 0;
var card3 = 0;
var card4 = 0;
var card5 = 0;
var ID1;
var ID2;
var ID3;
var ID4;
var ID5;
var CardCount = 0;


function newCard() {

    var ID;
    var value;
    do {

        var randSuit;
        var randValue;
        randSuit = cardSuits[Math.floor(Math.random() * 4)];
        randValue = cardValues[Math.floor(Math.random() * 13)];
        //set id and value of card
        ID = randValue + randSuit;
        //ID = "Jack of Hearts";
        switch (randValue) {
            case "ace":
                value = 11;
                break;
            case "2":
                value = 2;
                break;
            case "3":
                value = 3;
                break;
            case "4":
                value = 4;
                break;
            case "5":
                value = 5;
                break;
            case "6":
                value = 6;
                break;
            case "7":
                value = 7;
                break;
            case "8":
                value = 8;
                break;
            case "9":
                value = 9;
                break;
            case "10":
                value = 10;
                break;
            case "Jack":
                value = 10;
                break;
            case "Queen":
                value = 10;
                break;
            case "King":
                value = 10;
                break;
        }

    } while (ID === ID1 && ID === ID2 && ID === ID3 && ID === ID4 && ID === ID5) {
        CardCount++;
        switch (CardCount) {
            case 1:
                card1 = value;
                ID1 = ID;
                break;
            case 2:
                card2 = value;
                ID2 = ID;
                break;
            case 3:
                card3 = value;
                ID3 = ID;
                break;
            case 4:
                card4 = value;
                ID4 = ID;
                break;
            case 5:
                card5 = value;
                ID5 = ID;
                break;
        }
    }
    //var rtnArray = [value, ID];
    //return rtnArray;
    document.getElementById("total").innerHTML = card1 + card2 + card3 + card4 + card5;
}
function onLoad() {
    document.getElementById("currentBal").innerHTML = Balance;
    document.getElementById("Stand").disabled = true;
    document.getElementById("Hit").disabled = true;
}
function dealerHand() {
    return Math.floor((Math.random() * 8) + 17); //random value between 16 and 23
}
function EndGame() {
    var total = Number("0");

    if (card1 = 11 && total > 21) {
        total -= 10;
    }
    if (card2 = 11 && total > 21) {
        total -= 10;
    }
    if (card3 = 11 && total > 21) {
        total -= 10;
    }
    if (card4 = 11 && total > 21) {
        total -= 10;
    }
    if (card5 = 11 && total > 21) {
        total -= 10;
    }
  
    total = card1 + card2 + card3 + card4 + card5;

    // Bet needed to be cast as a number to avoid concatenation with balance.
    var Bet = Number(document.getElementById("betAmount").value);
    var dealerScore = dealerHand();
    if (card1 != "" && card2 != "" && card3 != "" && card4 != "" && card5 != "" && total < 22) {
        document.getElementById("dealerHand").innerHTML = dealerScore;
        document.getElementById("outcome").innerHTML = "Charlie Rule <br> You Win $" + Bet + "!";
        Balance += Bet;
    }
    else if (total > 21) {
        
        document.getElementById("outcome").innerHTML = "You Bust! <br> You Lose $" + Bet + "!";
        document.getElementById("dealerHand").innerHTML = dealerScore;
        Balance -= Bet;
    }
    else if (dealerScore > 21) {
        document.getElementById("outcome").innerHTML = "Dealer Bust! <br> You Win $" + Bet + "!";
        document.getElementById("dealerHand").innerHTML = dealerScore;
        Balance += Bet;
    }
    else if (total > dealerScore) {
        document.getElementById("outcome").innerHTML = "You Win $" + Bet + "!";
        Balance += Bet;
        document.getElementById("dealerHand").innerHTML = dealerScore;
    }
    else if (total < dealerScore) {
        document.getElementById("outcome").innerHTML = "You Lose $" + Bet + "!";
        Balance -= Bet;
        document.getElementById("dealerHand").innerHTML = dealerScore;
    }
    else if (total == dealerScore) {
        document.getElementById("outcome").innerHTML = "Tie: House Wins <br> You Lose $" + Bet + "!";

        Balance -= Bet;
        document.getElementById("dealerHand").innerHTML = dealerScore;
    }
    document.getElementById("Stand").disabled = true;
    document.getElementById("Hit").disabled = true;
    document.getElementById("NewGame").disabled = false;
    document.getElementById("currentBal").innerHTML = Balance;

}



function NewGame() {
    if (CardCount > 1) {
        document.getElementById("card1").innerHTML = "";
        document.getElementById("card2").innerHTML = "";
        document.getElementById("card3").innerHTML = "";
        document.getElementById("card4").innerHTML = "";
        document.getElementById("card5").innerHTML = "";
        document.getElementById("card1").style.backgroundImage = "url('/images/cardback.png')";
        document.getElementById("card2").style.backgroundImage = "url('/images/cardback.png')";
        document.getElementById("card3").style.backgroundImage = "url('/images/cardback.png')";
        document.getElementById("card4").style.backgroundImage = "url('/images/cardback.png')";
        document.getElementById("card5").style.backgroundImage = "url('/images/cardback.png')";
    }
    document.getElementById("NewGame").disabled = true;

    CardCount = 0;
    card1 = 0;
    card2 = 0;
    card3 = 0;
    card4 = 0;
    card5 = 0;
    ID1 = "";
    ID2 = "";
    ID3 = "";
    ID4 = "";
    ID5 = "";
    newCard();
    newCard();
    document.getElementById("card1").innerHTML = ID1;
    document.getElementById("card2").innerHTML = ID2;
    document.getElementById("card1").style.background = "#fcf8f2";
    document.getElementById("card2").style.background = "#fcf8f2";
    document.getElementById("Stand").disabled = false;
    document.getElementById("Hit").disabled = false;
    
    

}
function Hit() {
    if (CardCount > 1) {
        newCard();
    }
    switch (CardCount) {
        case 3:
            document.getElementById("card3").innerHTML = ID3;
            document.getElementById("card3").style.background = "#fcf8f2";
            break;
        case 4:
            document.getElementById("card4").innerHTML = ID4;
            document.getElementById("card4").style.background = "#fcf8f2";
            break;
        case 5:
            document.getElementById("card5").innerHTML = ID5;
            document.getElementById("card5").style.background = "#fcf8f2";
            break;
    }
}