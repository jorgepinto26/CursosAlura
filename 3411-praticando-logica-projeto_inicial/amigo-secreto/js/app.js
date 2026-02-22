let listaAmigos = document.getElementById('lista-amigos');

function adicionar(){
    let nome = document.getElementById('nome-amigo');
    
    if (nome.value == ""){
        alert("Nenhum nome foi informado!");
        return;
    }

    if (listaAmigos.textContent == ""){
        listaAmigos.textContent = listaAmigos.textContent + `${nome.value}`;
    } else {
        listaAmigos.textContent = listaAmigos.textContent + `, ${nome.value}`;
    }

    nome.value = "";
    
}

function sortear(){
    if(listaAmigos.textContent == ""){
        alert('Informar nomes para sorteio!');
        return;
    }

  
    let sorteio = document.getElementById('lista-sorteio');
    sorteio.textContent ="";
    let vetorAmigos = [];
    let j;
    let verificador = [];
    vetorAmigos = listaAmigos.textContent.split(',');

    if(vetorAmigos.length < 2){
      alert('Quantidade de nomes insuficiente para sorteio');
      return;
    }

    let vetorSorteio = [vetorAmigos.length - 1];

    for(let i = 1; i < vetorAmigos.length; i++){
        vetorSorteio[i-1] = vetorAmigos[i];
    }
    vetorSorteio[vetorSorteio.length] = vetorAmigos[0];
        
    for(let i = 0; i < vetorSorteio.length; i++){
        sorteio.innerHTML = sorteio.innerHTML + vetorAmigos[i] + ' -> ' + vetorSorteio[i] + '<br>';
    } 
}

function reiniciar(){
    document.getElementById('nome-amigo').value = "";
    document.getElementById('lista-amigos').textContent = "";
    document.getElementById('lista-sorteio').textContent = "";
}

/* Código da ALURA
let amigos = [];

function adicionar() {
    let amigo = document.getElementById('nome-amigo');
    let lista = document.getElementById('lista-amigos');

    amigos.push(amigo.value);

    if (lista.textContent == '') {
        lista.textContent = amigo.value;
    } else {
        lista.textContent = lista.textContent + ', ' + amigo.value;
    }

    amigo.value = '';
}

function sortear() {
    embaralhar(amigos);

    let sorteio = document.getElementById('lista-sorteio');
    for (let i = 0; i < amigos.length; i++) {
        if (i == amigos.length - 1) {
            sorteio.innerHTML = sorteio.innerHTML + amigos[i] +' --> ' +amigos[0] + '<br/>';
        } else {
            sorteio.innerHTML = sorteio.innerHTML + amigos[i] +' --> ' +amigos[i + 1] + '<br/>';
        }
    }
}

function embaralhar(lista) {
    for (let indice = lista.length; indice; indice--) {
        const indiceAleatorio = Math.floor(Math.random() * indice);
        [lista[indice - 1], lista[indiceAleatorio]] = [lista[indiceAleatorio], lista[indice - 1]];
    }
}

function reiniciar() {
    amigos = [];
    document.getElementById('lista-amigos').innerHTML = '';
    document.getElementById('lista-sorteio').innerHTML = '';
}

Desafios:
let amigos = [];


function adicionar() {
    let amigo = document.getElementById('nome-amigo');
    let lista = document.getElementById('lista-amigos');


    amigos.push(amigo.value);


    if (lista.textContent == '') {
        lista.textContent = amigo.value;
    } else {
        lista.textContent = lista.textContent + ', ' + amigo.value;
    }


    amigo.value = '';


    atualizarLista();
    atualizarSorteio();
}


function sortear() {
    embaralhar(amigos);


    let sorteio = document.getElementById('lista-sorteio');
    for (let i = 0; i < amigos.length; i++) {
        if (i == amigos.length - 1) {
            sorteio.innerHTML = sorteio.innerHTML + amigos[i] +' --> ' +amigos[0] + '<br/>';
        } else {
            sorteio.innerHTML = sorteio.innerHTML + amigos[i] +' --> ' +amigos[i + 1] + '<br/>';
        }
    }
}


function excluirAmigo(index) {
    amigos.splice(index, 1);
    atualizarLista();
    atualizarSorteio();
}


function embaralhar(lista) {
    for (let indice = lista.length; indice; indice--) {
        const indiceAleatorio = Math.floor(Math.random() * indice);
        [lista[indice - 1], lista[indiceAleatorio]] = [lista[indiceAleatorio], lista[indice - 1]];
    }
}


function atualizarSorteio() {
    let sorteio = document.getElementById('lista-sorteio');
    sorteio.innerHTML = '';
}


function atualizarLista() {
    let lista = document.getElementById('lista-amigos');
    lista.innerHTML = '';


    for (let i = 0; i < amigos.length; i++) {
        // Cria um elemento de parágrafo para cada amigo
        let paragrafo = document.createElement('p');
        paragrafo.textContent = amigos[i];
       
        // Adiciona um evento de clique para excluir o amigo
        paragrafo.addEventListener('click', function() {
            excluirAmigo(i);
        });


        // Adiciona o parágrafo à lista
        lista.appendChild(paragrafo);
    }
}


function reiniciar() {
    amigos = [];
    document.getElementById('lista-amigos').innerHTML = '';
    document.getElementById('lista-sorteio').innerHTML = '';
}
// Declarando uma variável do tipo array
let minhaLista = [];

// Adicionando elementos com push
minhaLista.push(1, 2, 3);
console.log("Adicionando elementos:", minhaLista);

// Criando uma nova variável
let outrosNumeros = [4, 5, 6];

// Concatenando arrays
let novaLista = minhaLista.concat(outrosNumeros);
console.log("Juntando Arrays:", novaLista);

// Removendo o último elemento
novaLista.pop();
console.log("Desafio 4:", novaLista);


function embaralharArray(array) {
  for (let i = array.length - 1; i > 0; i--) {
    const j = Math.floor(Math.random() * (i + 1));
    [array[i], array[j]] = [array[j], array[i]];
  }
  return array;
}

// Embaralhando novaLista
novaLista = embaralharArray(novaLista);
console.log("Embaralhando a Lista:", novaLista);


// Função para remover duplicatas de um array
function removerDuplicatas(array) {
  return [...new Set(array)];
}

// Testando a função com novaLista
let novaListaSemDuplicatas = removerDuplicatas(novaLista);
console.log("Remover duplicatas:", novaListaSemDuplicatas);

*/

/*
Projeto final ALURA

let amigos = [];

function adicionar() {
    let amigo = document.getElementById('nome-amigo');
    if (amigo.value == '') {
        alert('Informe o nome do amigo!');
        return;
    }

    if (amigos.includes(amigo.value)) {
        alert('Nome já adicionado!');
        return;
    }

    let lista = document.getElementById('lista-amigos');

    amigos.push(amigo.value);

    if (lista.textContent == '') {
        lista.textContent = amigo.value;
    } else {
        lista.textContent = lista.textContent + ', ' + amigo.value;
    }

    amigo.value = '';
}

function sortear() {
    if (amigos.length < 4) {
        alert('Adicione pelo menos 4 amigos!');
        return;
    }

    embaralhar(amigos);

    let sorteio = document.getElementById('lista-sorteio');
    for (let i = 0; i < amigos.length; i++) {
        if (i == amigos.length - 1) {
            sorteio.innerHTML = sorteio.innerHTML + amigos[i] +' --> ' +amigos[0] + '<br/>';
        } else {
            sorteio.innerHTML = sorteio.innerHTML + amigos[i] +' --> ' +amigos[i + 1] + '<br/>';
        }
    }
}

function embaralhar(lista) {
    for (let indice = lista.length; indice; indice--) {
        const indiceAleatorio = Math.floor(Math.random() * indice);
        [lista[indice - 1], lista[indiceAleatorio]] = [lista[indiceAleatorio], lista[indice - 1]];
    }
}

function reiniciar() {
    amigos = [];
    document.getElementById('lista-amigos').innerHTML = '';
    document.getElementById('lista-sorteio').innerHTML = '';
}

*/