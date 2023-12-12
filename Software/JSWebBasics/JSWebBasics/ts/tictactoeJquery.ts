const x = "X";
const o = "O";
let currentTurn = x;
let gameover = false;
let msg: Element;
let allspots: Element[] = [];
const winningSets: Element[][] = [];
let checkPlayComputer = () => (document.querySelector("#rdPlayComputer") as HTMLInputElement).checked;
$(document).ready(function () {
    msg = document.querySelector("#msg");
    allspots = [...document.querySelectorAll(".spot")];
    $(allspots).click(takeSpot);
    setupWinningSets();
    startGame();
});

function setupWinningSets() {
    for (let i = 1; i < 4; i++) {
        winningSets.push([...$(`.r${i}`)])
        winningSets.push([...$(`.c${i}`)])
        if (i < 3) {
            winningSets.push([...$(`.d${i}`)])
        }
    }
}

function startGame() {
    gameover == false;
    currentTurn = x;
    showCurrentTurn();
    $(allspots).text("").removeClass("tie").removeClass("winner");
}

function takeSpot(event: JQuery.Event) {
    const btn = event.target as Element;
    doTakeSpot(btn);
}

function doTakeSpot(btn: Element) {
    if (btn.textContent != "") {
        return;
    }

    btn.textContent = currentTurn;
    CheckWinnerTie();
    if (gameover == false) {
        currentTurn = currentTurn == x ? o : x;
        showCurrentTurn();
        if (checkPlayComputer() && currentTurn == o) {
            doComputerTurn();
        }
    }
}

function doComputerTurn() {
    const btn = allspots.find(s => s.textContent == "");
    if (btn) {
        doTakeSpot(btn);
    }
}

function CheckWinnerTie() {
    winningSets.forEach(w => {
        if (w.every(s => s.textContent == x) || w.every(s => s.textContent == o)) {
            gameover = true;
            $(w).addClass("winner");
            msg.textContent = "Winner is";
        }
    });
    if (gameover == false) {
        if (allspots.every(s => s.textContent != "")) {
            gameover = true;
            msg.textContent = "Tie!";
            $(allspots).addClass("tie");
        }
    }

}

function showCurrentTurn() {
    msg.textContent = "Current turn is " + currentTurn;
}