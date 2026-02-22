let precoFinal;
limpar();


function adicionar(){
   //Recupera produto e quantidade
   let produto = document.getElementById('produto').value;
   let quantidade = document.getElementById('quantidade').value;

   //Verificação se produto é válido
   if(!produto || produto.trim() === ""){
      alert("Selecione um produto válido.");
      return;
   }

   if(isNaN(quantidade) || quantidade <= 0){
      alert("Insira uma quantidade válida.");
      return;
   }

   //Extrai o nome e o preço do produto, depois calcula o custo total
   let nomeDoProduto = produto.split('-')[0];
   let precoUnidade = produto.split('R$')[1];
   let preco = quantidade * precoUnidade;

   //Adiciona produto no carrinho
   let carrinho = document.getElementById('lista-produtos');
   carrinho.innerHTML = carrinho.innerHTML + `<section class="carrinho__produtos__produto">
          <span class="texto-azul">${quantidade}x</span> ${nomeDoProduto} <span class="texto-azul">R$${precoUnidade}</span>
        </section>`;

   //Calcula valor total do carrinho
   precoFinal = precoFinal + preco;
   let total = document.getElementById('valor-total');
   total.textContent = `R$ ${precoFinal}`;
   document.getElementById('quantidade').value = 0;
}

function limpar(){
   precoFinal = 0;
   document.getElementById('lista-produtos').innerHTML = '';
   document.getElementById('valor-total').textContent = 'R$ 0';
   document.getElementById('quantidade').value = 0;
}

