function saudar() {
    console.log('Alô, mundo!');
}

saudar();

function saudarComNome(nome: string) {
    console.log(`Alô, ${nome}!`);
}

saudarComNome('Júlio Machado');

function criarSaudacao(nome: string): string {
    return `Alô, ${nome}!`;
}

console.log(criarSaudacao('Júlio Machado'));

//Função anônima
const saudarAnonima = function (nome: string) {
    return `Alô, ${nome}!`;  
};

console.log(saudarAnonima);
console.log(saudarAnonima('Júlio Machado'));

//Função arrow
const saudarArrow = (nome: string) => {
    console.log(`Alô, ${nome}!`);
};

saudarArrow('Júlio Machado');

function calcularAreaCirculo(raio: number) {
    return Math.PI * raio ** 2;
}

console.log(calcularAreaCirculo(12.5));

function fatorial(n: number): number {
    if (n === 0) return 1;
    return n * fatorial(n-1);
}

console.log(fatorial(4));
