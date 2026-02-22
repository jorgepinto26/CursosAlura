let palavra = prompt("Digite a palavra");

let separacaoDasLetras = palavra.split("");
let palavraInvertida = separacaoDasLetras.reverse();
palavraInvertida = palavraInvertida.join("");

if (palavra == palavraInvertida){
    console.log("A palavra " + palavra + " é um palíndromo.");
}else{
    console.log("A palavra " + palavra + " não é um palíndromo.");
}