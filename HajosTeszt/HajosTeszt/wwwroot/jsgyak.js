window.onload = () => {
    let szam = 1
    let hova = document.getElementById("szamsor")
    for (var sor = 0; sor < 10; sor++) {
        let sor = document.createElement("div")
        hova.appendChild(sor)
        sor.innerText = (szam)
        szam++
        sor.classList.add("doboz")
        sor.style.color = `rgb(0,0,${255 / 10 * szam})`
    }
    

}