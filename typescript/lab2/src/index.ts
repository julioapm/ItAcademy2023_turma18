//Exercício 7
function calcularFrequencia(array: number[]): Map<number,number> {
    const tabela = new Map<number,number>();
    array.forEach(numero => {
        if (!tabela.has(numero)) {
            tabela.set(numero,1);
        } else {
            const contagemAtual = tabela.get(numero)!;
            tabela.set(numero, contagemAtual+1);
        }
    });
    return tabela;
}
console.log(calcularFrequencia([1,2,3,1,2,0,2]));

function calcularFrequenciaComReducao(array: number[]) {
    return array.reduce(
        (tabela, numero) =>  tabela.set(numero, (tabela.get(numero)||0)+1),
        new Map<number,number>()
    );
}
console.log(calcularFrequenciaComReducao([1,2,3,1,2,0,2]));
