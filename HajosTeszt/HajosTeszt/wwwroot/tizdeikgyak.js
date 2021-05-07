var hotList = [];           //Az éppen gyakoroltatott kérdések listája 
var questionsInHotList = 3; //Ez majd 7 lesz, teszteléshez jobb a 3. 
var displayedQuestion;      //A hotList-ből éppen ez a kérdés van kint
var numberOfQuestions;      //Kérdések száma a teljes adatbázisban
var nextQuestion = 1;       //A következő kérdés száma a teljes listában


function init() {
    for (let i = 0; i < questionsInHotList; i++) {

        hotList[i] = {
            question: {},
            goodAnswers: 0
        }
    }

    fetch("/questions/count")
        .then(result => result.text())
        .then(n => { numberOfQuestions = parseInt(n) })

    if (localStorage.getItem("hotList")) {
        hotList = JSON.parse(localStorage.getItem("hotList"))
    }

    if (localStorage.getItem("displayedQuestion")) {
        displayedQuestion = parseInt(localStorage.getItem("displayedQuestion"))
    }

    if (localStorage.getItem("nextQuestion")) {
        nextQuestion = parseInt(localStorage.getItem("nextQuestion"))
    }


    for (let i = 0; i < questionsInHotList; i++) {

        kérsésbetöltés(nextQuestion, i);
        nextQuestion++;
    }
}


function kérsésbetöltés(questionNumber, destination) {
    fetch(`/questions/${questionNumber}`)
        .then(result => {
            if (!result.ok) {
                console.error(`Hibás letöltés: ${result.status}`);
                return null;
            }
            else {
                return result.json();
            }
        })
        .then(q => {
            hotList[destination].question = q;
            hotList[destination].goodAnswers = 0;
            console.log(`${questionNumber}. kédés a hotlist ${destination}. helyére`)
            if (displayedQuestion == undefined && destination == 0) {
                displayedQuestion = 0;
                kérdésjelenités();
            }
        })
}

function kérdésjelenités() {
    let kérdés = hotList[displayedQuestion].question;

    document.getElementById("Kérdés_szöveg").innerHTML = kérdés.questionText;
    document.getElementById("válasz1").innerText = kérdés.answer1;
    document.getElementById("válasz2").innerText = kérdés.answer2;
    document.getElementById("válasz3").innerText = kérdés.answer3;

    if (kérdés.image) {
        document.getElementById("kép1").scr = kérdés.image;
        document.getElementById("kép1").style.display = "block";
    }

    else {
        document.getElementById("kép1").style.display = "none";
    }

    for (var i = 1; i < 4; i++) {
        document.getElementById("válasz" + i).classList.remove("jó", "rossz")
        document.getElementById("válaszok").style.pointerEvents = "auto"
    }
}


window.onload = function () {
    init();
    kérdésjelenités();
    document.getElementById("elöre").onclick = function () {
        displayedQuestion++;
        if (displayedQuestion === questionsInHotList) displayedQuestion = 0;
        kérdésjelenités();

    }

    document.getElementById("vissza").onclick = function () {
        displayedQuestion--;
        if (displayedQuestion < 0) displayedQuestion = questionsInHotList - 1;
        kérdésjelenités();
    }
}

function választás(n) {
    let kérdés = hotList[displayedQuestion].question;
    if (n === kérdés.correctAnswer) {
        document.getElementById("válasz" + n).classList.add("jó")
        hotList[displayedQuestion].goodAnswers++;
        if (hotList[displayedQuestion].goodAnswers===3) {
            kérsésbetöltés(nextQuestion, displayedQuestion);
            nextQuestion++;

        }
    }
    else {
        document.getElementById("válasz" + n).classList.add("rossz")
        document.getElementById("válasz" + kérdés.correctAnswer).classList.add("jó")
        hotList[displayedQuestion].goodAnswers=0;
    }

    document.getElementById("válaszok").style.pointerEvents = "none";

    localStorage.setItem("hotList", JSON.stringify(hotList));
    localStorage.setItem("displayedQuestion",displayedQuestion);
    localStorage.setItem("nextQuestion", nextQuestion);
}