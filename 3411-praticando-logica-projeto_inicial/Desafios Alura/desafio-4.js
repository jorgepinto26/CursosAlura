function ordenaNumeros(a,b,c){
    const numerosOrdenados = [a,b,c].sort((x, y) => x - y);
    console.log(`Números ordenados: ${numerosOrdenados.join(',')}`);
}

ordenaNumeros(2,10,3);