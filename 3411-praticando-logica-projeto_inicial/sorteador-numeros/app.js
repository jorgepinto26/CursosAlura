function sortear(){
    let quantidade = parseInt(document.getElementById('quantidade').value);
    let de = parseInt(document.getElementById('de').value);
    let ate = parseInt(document.getElementById('ate').value);

    if(quantidade > (ate-de+1)){
        alert('A quantidade de números não pode ser maior que o intervalo');
        return
    }
    if (de >= ate){
        alert('O limite inferior não pode ser maior que o limite superior!!');
        return;
    } else {

        let numero;
        let sorteados = [];

        for (let i=1; i<=quantidade;i++){
            numero = gerarNumeroAleatorio(de,ate);
            while(sorteados.includes(numero)){
                numero = gerarNumeroAleatorio(de,ate);
            }
            sorteados.push(numero);  
        }

        let resultado = document.getElementById('resultado');
        if (quantidade > 1) {
            resultado.innerHTML = `<label class="texto__paragrafo">Números sorteados: ${sorteados}</label>`;
        }else{
            resultado.innerHTML = `<label class="texto__paragrafo">Número sorteado: ${sorteados}</label>`;
        }
   
        alterarStatusBotao();
    }
}

function reiniciar(){
    document.getElementById('quantidade').value = '';
    document.getElementById('de').value = '';
    document.getElementById('ate').value = '';
    resultado.innerHTML = `<label class="texto__paragrafo">Números sorteados: Nenhum até agora.</label>`;
    alterarStatusBotao();
}

function gerarNumeroAleatorio(min, max){
   return parseInt(Math.random()*(max-min + 1) + min);
}

function alterarStatusBotao(){
    let botao = document.getElementById('btn-reiniciar');
    if(botao.classList.contains('container__botao-desabilitado')){
        botao.classList.remove('container__botao-desabilitado');
        botao.classList.add('container__botao');
    }else{
        botao.classList.remove('container__botao');
        botao.classList.add('container__botao-desabilitado');
    }
}