//recuperar valores do html - let variavel = document.getElementById('Id da variavel que quero recuperar');
// escrever trecho html - variavel.innerHTML = 'código em html'
// declarar vetor = vector = [];
// verificar se elemento existe no vetor = vector.includes(elemento).
// inserir elemento no vetor = vector.push(elemento);
//verificar se classe faz parte de um botão por exemplo:
    // 1. Pegar botão pelo id: let botao = document.getElementById('id do botao');
    // 2. Verificar se uma classe está aplicada ao botao: botao.classList.contains('nome da classe');
    // 3. Remover classe: botao.classList.remove('nome da classe');
    // 4. Adicionar classe: botao.classList.add('nome da classe');

/*
function alterarStatus(s){
        let botao = document.querySelectorAll('a');
        let img = document.querySelectorAll('div');

        if(botao.item(s-1).classList.contains('dashboard__item__button--return')){
            botao.item(s-1).classList.remove('dashboard__item__button--return');
            img.item(s+1).classList.remove('dashboard__item__img--rented');
            botao.item(s-1).innerHTML = 'Alugar';
        }else{
            botao.item(s-1).classList.add('dashboard__item__button--return');
            img.item(s+1).classList.add('dashboard__item__img--rented');
            botao.item(s-1).innerHTML = 'Devolver';
        }      
    }
*/

//O script acima foi a primeira tentativa de resolução do problema, apesar de resolver o problema, a solução abaixo está mais coerente com a estrutura deixada no html.

function alterarStatus(id){
    let game = document.getElementById(`game-${id}`);
    let img = game.querySelector('.dashboard__item__img');
    let botao = game.querySelector('.dashboard__item__button');

    if(botao.textContent == 'Alugar'){
        img.classList.add('dashboard__item__img--rented');
        botao.classList.add('dashboard__item__button--return');
        botao.textContent = 'Devolver';
    }else{
        if(confirm("Deseja continuar com a devolução?")){
            alert("Devolução concluída!");
        }else{
            alert("Devolução cancelada");
            return;
        }
        img.classList.remove('dashboard__item__img--rented');
        botao.classList.remove('dashboard__item__button--return');
        botao.textContent = 'Alugar';
    }
    console.log(`Quantidade de jogos alugados: ${qtdJogosAlugados()}`);
}

function qtdJogosAlugados(){
    let qtdGames = 3;
    let contador = 0;
    for(let i=1;i<=qtdGames;i++){
        let game = document.getElementById(`game-${i}`);
        let botao = game.querySelector('.dashboard__item__button');
        if(botao.textContent == 'Devolver'){
            contador = contador + 1;
        }
    }
    return contador;
}

/* Solução desenvolvida pela ALURA: A diferença é que no meu eu chego pelo texto Alugar ou Devolver referente ao botão,
já na da Alura, eles checam a classe da imagem para saber se contém a classe referente ao jogo alugado 

function alterarStatus(id) {
    let gameClicado = document.getElementById(`game-${id}`);
    let imagem = gameClicado.querySelector('.dashboard__item__img');
    let botao = gameClicado.querySelector('.dashboard__item__button');
    let nomeJogo = gameClicado.querySelector('.dashboard__item__name');

    if (imagem.classList.contains('dashboard__item__img--rented')) {
        imagem.classList.remove('dashboard__item__img--rented');""
        botao.classList.remove('dashboard__item__button--return');
        botao.textContent = 'Alugar';
    } else {
        imagem.classList.add('dashboard__item__img--rented');
        botao.classList.add('dashboard__item__button--return');
        botao.textContent = 'Devolver';
    }
}

*/