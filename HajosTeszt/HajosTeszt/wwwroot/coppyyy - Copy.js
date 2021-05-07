window.onload = init;

var kérdés;
var hotList = [];           //Az éppen gyakoroltatott kérdések listája 
var questionsInHotList = 3; //Ez majd 7 lesz, teszteléshez jobb a 3. 
var displayedQuestion;      //A hotList-ből éppen ez a kérdés van kint
var numberOfQuestions;      //Kérdések száma a teljes adatbázisban
var nextQuestion = 1;       //A következő kérdés száma a teljes listában
var timeoutHandler;


let i = 1;

function kérdésBetöltés(questionNumber, destination) {
    fetch(`/questions/${questionNumber}`)
        .then(
            result => {
                if (!result.ok) {
                    console.error(`Hibás letöltés: ${response.status}`)
                }
                else {
                    return result.json()
                }
            }
        )
        .then(
            q => {
                hotList[destination].question = q;
                hotList[destination].goodAnswers = 0;
                console.log(`A ${questionNumber}. kérdés letöltve a hot list ${destination}. helyére`)
                if (displayedQuestion == undefined && destination == 0) {
                    displayedQuestion = 0;
                    kérdésMegjelenítés();
                }
            }
        );
}

function init() {
    let l = window.localStorage.getItem("lista")
    if (l) {
        console.log("Volt már listánk")
        hotList = JSON.parse(l);
        displayedQuestion = 0;
        kérdésMegjelenítés();

    }
    else {
        console.log("Még nem volt listánk")
        for (var i = 0; i < questionsInHotList; i++) {
            let q = {
                question: {},
                goodAnswers: 0
            }
            hotList[i] = q;
        }


        for (var i = 0; i < questionsInHotList; i++) {
            console.log("***" + nextQuestion)
            kérdésBetöltés(nextQuestion, i);
            nextQuestion++;
        }

    }

}


function kérdésMegjelenítés() {

    let kérdés = hotList[displayedQuestion].question;
    console.log(kérdés);
    document.getElementById("Kérdés_szöveg").innerText = kérdés.questionText
    document.getElementById("válasz1").innerText = kérdés.answer1
    document.getElementById("válasz2").innerText = kérdés.answer2
    document.getElementById("válasz3").innerText = kérdés.answer3

    if (kérdés.image != "") {
        document.getElementById("kép1").src = "https://szoft1.comeback.hu/hajo/" + kérdés.image;
        document.getElementById("kép1").style.visibility = 'visible';
    }
    else {
        document.getElementById("kép1").style.visibility = 'hidden';
    }

    function előre() {
        osztálytisztitás();
        displayedQuestion++;
        clearTimeout(timeoutHandler)
        if (displayedQuestion == questionsInHotList) displayedQuestion = 0;
        kérdésMegjelenítés()

    }


    document.getElementById("elöre").onclick = előre;
    document.getElementById("elöre").onclick = function vissza() {
        osztálytisztitás();
        i--;
        if (i == 0) {
            alert('Elértél az első kérdéshez!');

        }
        else {

            fetch('/questions/' + (i))
                .then(response => {
                    if (!response.ok) {
                        console.error(`Hibás válasz: $ {response.status}`)
                    }
                    else {
                        return response.json()
                    }
                })
                .then(data => kérdésMegjelenítés(data));
        }
    }

    function osztálytisztitás() {
        document.getElementById("válasz1").classList.remove("jó")
        document.getElementById("válasz1").classList.remove("rossz")
        document.getElementById("válasz2").classList.remove("jó")
        document.getElementById("válasz2").classList.remove("rossz")
        document.getElementById("válasz3").classList.remove("jó")
        document.getElementById("válasz3").classList.remove("rossz")
    }

    /*function visszaszín() {
        document.getElementById("válasz1").style.backgroundColor = '#FFFFFF';
        document.getElementById("válasz2").style.backgroundColor = '#FFFFFF';
        document.getElementById("válasz3").style.backgroundColor = '#FFFFFF';
    }
    */

    document.getElementById("válasz1").onclick = function válasz1() {
        timeoutHandler = setTimeout(előre, 3000);
        if (kérdés.correctAnswer == 1) {
            document.getElementById("válasz1").classList.add("jó");
            hotList[displayedQuestion].goodAnswers++;
            if (hotList[displayedQuestion].goodAnswers == 3) {
                kérdésBetöltés(nextQuestion, displayedQuestion);
                nextQuestion++
            }
        }
        else {
            document.getElementById("válasz1").classList.add("rossz");
            hotList[displayedQuestion].goodAnswers = 0;
        }
        window.localStorage.setItem("lista", JSON.stringify(hotList))
    }
    document.getElementById("válasz2").onclick = function válasz2() {
        timeoutHandler = setTimeout(előre, 3000);
        if (kérdés.correctAnswer == 2) {
            document.getElementById("válasz2").classList.add("jó");
            hotList[displayedQuestion].goodAnswers++;
            if (hotList[displayedQuestion].goodAnswers == 3) {
                kérdésBetöltés(nextQuestion, displayedQuestion);
                nextQuestion++
            }
        }
        else {
            document.getElementById("válasz2").classList.add("rossz");
            hotList[displayedQuestion].goodAnswers = 0;
        }
        window.localStorage.setItem("lista", JSON.stringify(hotList))
    }
    document.getElementById("válasz3").onclick = function válasz3() {
        timeoutHandler = setTimeout(előre, 3000);
        if (kérdés.correctAnswer == 3) {
            document.getElementById("válasz3").classList.add("jó");
            hotList[displayedQuestion].goodAnswers++;
            if (hotList[displayedQuestion].goodAnswers == 3) {
                kérdésBetöltés(nextQuestion, displayedQuestion);
                nextQuestion++
            }
        }
        else {
            document.getElementById("válasz3").classList.add("rossz");
            hotList[displayedQuestion].goodAnswers = 0;
        }
        window.localStorage.setItem("lista", JSON.stringify(hotList))
    }


}



