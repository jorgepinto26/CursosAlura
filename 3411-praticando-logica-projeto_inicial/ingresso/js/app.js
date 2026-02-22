let pistaTotal = document.getElementById('qtd-pista');
let superiorTotal = document.getElementById('qtd-superior');
let inferiorTotal = document.getElementById('qtd-inferior');

function comprar(){
    // Recupera tipo e quantidade de ingressos
    let tipoIngresso = document.getElementById('tipo-ingresso').value;
    let quantidade = document.getElementById('qtd').value;
    let ingressos = 0;
    //Validação do tipo de ingresso recuperado
    if (!tipoIngresso || tipoIngresso.trim() === ""){
        alert('Escolha de ingresso inválida.');
        return;
    }

    //Validação da quantidade de ingressos
    if(isNaN(quantidade) || quantidade <= 0){
        alert('Escolha de quantidade inválida.');
        return;
    }

    //Recupera quantidade de ingresso por tipos
    if(tipoIngresso === 'pista'){
        let pista = pistaTotal.textContent - quantidade;
        ingressos = pistaTotal.textContent;
        //Verifica se quantidade escolhida é maior que a quantidade disponível de ingressos
        if((parseInt(quantidade) > parseInt(ingressos)) && (pistaTotal.textContent != 0)){
            alert('Escolha de quantidade inválida');
        }else{
            if(pista >= 0){
                pistaTotal.textContent = pistaTotal.textContent - quantidade;
            }else{
                alert('Ingressos esgotados na pista.');           
            }
        }
    }else if(tipoIngresso === 'inferior'){
        let inferior = inferiorTotal.textContent - quantidade;
        ingressos = inferiorTotal.textContent;

        if((parseInt(quantidade) > parseInt(ingressos)) && (inferiorTotal.textContent != 0)){
            alert('Escolha de quantidade inválida');
        }else{
            if(inferior >= 0){
                inferiorTotal.textContent = inferiorTotal.textContent - quantidade;
            }else{
                alert('Ingressos esgotados nas cadeiras inferiores.');           
            }
        }
    } else {
        let superior = superiorTotal.textContent - quantidade;
        ingressos = superiorTotal.textContent;

        if((parseInt(quantidade) > parseInt(ingressos)) && (superiorTotal.textContent != 0)){
            alert('Escolha de quantidade inválida');
        }else{
            if(superior >= 0){
                superiorTotal.textContent = superiorTotal.textContent - quantidade;
            }else{
                alert('Ingressos esgotados nas cadeiras superiores.');           
            }
        }       
    }
}

/* 
//Solução da ALURA

function comprar() {
    let tipo = document.getElementById('tipo-ingresso');
    let qtd = document.getElementById('qtd').value;

    if (tipo.value == 'pista') {
        comprarPista(qtd);
    } else if (tipo.value == 'superior') {
        comprarSuperior(qtd);
    } else {
        comprarInferior(qtd);
    }
}

function comprarPista(qtd) {
    let qtdPista = parseInt(document.getElementById('qtd-pista').textContent);
    if (qtd > qtdPista) {
        alert('Quantidade indisponível para tipo pista');
    } else {
        qtdPista = qtdPista - qtd;
        document.getElementById('qtd-pista').textContent = qtdPista;
        alert('Compra realizada com sucesso!');
    }
}

function comprarSuperior(qtd) {
    let qtdSuperior = parseInt(document.getElementById('qtd-superior').textContent);
    if (qtd > qtdSuperior) {
        alert('Quantidade indisponível para tipo superior');
    } else {
        qtdSuperior = qtdSuperior - qtd;
        document.getElementById('qtd-superior').textContent = qtdSuperior;
        alert('Compra realizada com sucesso!');
    }
}

function comprarInferior(qtd) {
    let qtdInferior = parseInt(document.getElementById('qtd-inferior').textContent);
    if (qtd > qtdInferior) {
        alert('Quantidade indisponível para tipo inferior');
    } else {
        qtdInferior = qtdInferior - qtd;
        document.getElementById('qtd-inferior').textContent = qtdInferior;
        alert('Compra realizada com sucesso!');
    }
}
*/