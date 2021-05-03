var kérdések;
var kérdésSorSzám = 3;
var kérdéshossz;


function kérdésBetöltés(id) {
    fetch(`/questions/${id}`)
        .then(response => {
            if (!response.ok) {
                console.error(`Hibás válasz: ${response.status}`)
            }
            else {
                return response.json()
            }
        })
        .then(data => letöltésbef(data));
}

function letöltésbef(d) {
    console.log("siker")
    console.log(d)
    kérdések = d
    kérdésMegjelenítés(d)
}

function kérdésMegjelenítés(kérdés) {
    console.log(kérdés);
    document.getElementById("Kérdés_szöveg").innerText = kérdés.questionText
    document.getElementById("válasz1").innerText = kérdés.answer1
    document.getElementById("válasz2").innerText = kérdés.answer2
    document.getElementById("válasz3").innerText = kérdés.answer3
    if (!kérdés.image == 0) {
        document.getElementById("kép1").src = "https://szoft1.comeback.hu/hajo/" + kérdés.image;
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

window.onload = function () {
    kérdésBetöltés(kérdésSorSzám);
    document.getElementById("elöre").onclick = function () {
        kérdésSorSzám++
        kérdésBetöltés(kérdésSorSzám)

        osztálytisztitás()

    }
    document.getElementById("vissza").onclick = function () {
        if (kérdésSorSzám != 0) {
            kérdésSorSzám--
            kérdésBetöltés(kérdésSorSzám)

            osztálytisztitás()

        }
    }
    document.getElementById("válasz1").onclick = function () {
        if (kérdések.correctAnswer == 1) {
            let k = document.getElementById("válasz1").classList.add("jó")
        }
        else {
            let k = document.getElementById("válasz1").classList.add("rossz")
        }
    }
    document.getElementById("válasz2").onclick = function () {
        if (kérdések.correctAnswer == 2) {
            let k = document.getElementById("válasz2").classList.add("jó")
        }
        else {
            let k = document.getElementById("válasz2").classList.add("rossz")
        }
    }
    document.getElementById("válasz3").onclick = function () {
        if (kérdések.correctAnswer == 3) {
            let k = document.getElementById("válasz3").classList.add("jó")
        }
        else {
            let k = document.getElementById("válasz3").classList.add("rossz")
        }
    }
}