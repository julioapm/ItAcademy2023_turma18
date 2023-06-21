class Pessoa {
    constructor(public nome: string, public idade: number){}
}

interface Nomeado {
    nome: string;
}

function saudar(coisa: Nomeado) {
    return `Alô, ${coisa.nome}!`;
}

const p = new Pessoa('John Doe', 22);
console.log(saudar(p));


interface Predicado<T> {
    (item: T): boolean;
}

function filtrar<T>(array: T[], filtro: Predicado<T>): T[] {
    const resultado: T[] = [];
    array.forEach((objeto, posicao) => {
        if (filtro(objeto)) {
            console.log(objeto);
            console.log(posicao);
            resultado.push(objeto);
        }
    });
    return resultado;
}

const numeros = [1,2,3,4,5,6,7,8,9,10];
const resultado = filtrar(numeros, n => n%2 === 0);
console.log(resultado);