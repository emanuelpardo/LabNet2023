let fondoHtml = document.getElementById("fondo");
const ColorBlanco = "#FFFFFF";
const urlimagenVictoria = "url('ganaste.jpg')";
let puntuacionMaxima = 0;
let puntuacionInicial = 0;
let numero_a_adivinar = 0;
let bit = 0;

function setearVariables(i) {
    if (i === 0) {
        puntuacionMaxima = 0;
    }
    puntuacionInicial = 20;
    numero_a_adivinar = numeroAleatorio(1, 20);
    bit = 0;
}

function MostrarLabelsScore() {

    document.getElementById("spanScore").innerHTML = puntuacionInicial;
    document.getElementById("spanHscore").innerHTML = puntuacionMaxima;
}

function numeroAleatorio(min, max) {
    return Math.round(Math.random() * (max - min) + min);
}

function reiniciar() {

    setearVariables(1);
    document.getElementById("mensajeResultado").innerText = "";
    MostrarLabelsScore();
    setearFondoHTML(0);
    imprimir();

}

function setearFondoHTML(i){
    if(i === 0){
        fondoHtml.style.backgroundColor = ColorBlanco;
        fondoHtml.style.backgroundImage = "";
    }
    else if(i === 1){
        fondoHtml.style.backgroundImage = urlimagenVictoria;
    }
    else if(i === 2){
        fondoHtml.style.backgroundImage = urlimagenVictoria;
    }
}

function probar() {
    setearFondoHTML(0)
    let numeroElegido = parseInt(document.getElementById("idNumeroUsuario").value);
    if (bit === 0) {
        if (numeroElegido === numero_a_adivinar) {
            document.getElementById("mensajeResultado").innerText = "Número Correcto!";
            setearFondoHTML(1);
            puntuacionInicial += 5;
            numero_a_adivinar = numeroAleatorio(1, 20);
            if (puntuacionInicial > puntuacionMaxima) {
                puntuacionMaxima = puntuacionInicial;
            }
        }

        else if (numeroElegido < numero_a_adivinar) {
            document.getElementById("mensajeResultado").innerText = "Más Alto";
            puntuacionInicial--;
        }
        else if (numeroElegido > numero_a_adivinar) {
            document.getElementById("mensajeResultado").innerText = "Más Bajo";
            puntuacionInicial--;
        }

        if (puntuacionInicial === 0) {
            document.getElementById("mensajeResultado").innerText = "PERDISTE";
            bit = 1;
            alert("PERDISTE! volverás a empezar desde 0");
        }

        MostrarLabelsScore();
    }

    if (bit === 1) {
        reiniciar();
    }
    imprimir();
}

function Inicio() {
    fondoHtml.style.backgroundColor = ColorBlanco
    setearVariables(0);
    MostrarLabelsScore();
}

function imprimir(){
    console.log(puntuacionMaxima);
    console.log(puntuacionInicial);
    console.log(numero_a_adivinar);
}

Inicio();


