var kérdések;
var kérdésSorSzám = 0;
var kérdéshossz;


function letöltés() {
    fetch('/quastions.json')
        .then(response => response.json())
        .then(data => letöltésBefejezödöt(data))
}

function letöltésBefejezödöt(d) {
    console.log("sikeres letöltés")
    console.log(d)
    kérdések = d
    kérséMegjelenítés(kérdésSorSzám);
}

function kérséMegjelenítés(kérdésszám) {
    let kérdés_szöveg = document.getElementById("Kérdés_szöveg")
    let válasz1 = document.getElementById("válasz1")
    let válasz2 = document.getElementById("válasz2")
    let válasz3 = document.getElementById("válasz3")
    let kép = document.getElementById("kép1")

    kérdés_szöveg.innerHTML = kérdések[kérdésszám].questionText
    válasz1.innerText = kérdések[kérdésszám].answer1
    válasz2.innerText = kérdések[kérdésszám].answer2
    válasz3.innerText = kérdések[kérdésszám].answer3
    kép.scr = "https://szoft1.comeback.hu/hajo/"+kérdések[kérdésszám].image

}

window.onload = function () {
    letöltés();   
    document.getElementById("elöre").onclick = function () {
        kérdésSorSzám++
        kérséMegjelenítés(kérdésSorSzám)
    }
    document.getElementById("vissza").onclick = function () {
        if (kérdésSorSzám != 0) {
            kérdésSorSzám--
            kérséMegjelenítés(kérdésSorSzám)
        }
    }
    document.getElementById("válasz1").onclick = function () {
        if (kérdések[kérdésSorSzám].correctAnswer == 1) {
            let k = document.getElementById("válasz1").classList.add("jó")
        }
        else {
            let k = document.getElementById("válasz1").classList.add("rossz")
        }
    }
    document.getElementById("válasz2").onclick = function () {
        if (kérdések[kérdésSorSzám].correctAnswer == 2) {
            let k = document.getElementById("válasz2").classList.add("jó")
        }
        else {
            let k = document.getElementById("válasz2").classList.add("rossz")
        }
    }
    document.getElementById("válasz3").onclick = function () {
        if (kérdések[kérdésSorSzám].correctAnswer == 3) {
            let k = document.getElementById("válasz3").classList.add("jó")
        }
        else {
            let k = document.getElementById("válasz3").classList.add("rossz")
        }
    }
}