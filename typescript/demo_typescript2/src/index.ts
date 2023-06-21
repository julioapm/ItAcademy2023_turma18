let pessoa = {
    nome: 'John Doe',
    idade: 22
};

console.log(typeof pessoa);
console.log(pessoa);
console.log(pessoa.nome);
pessoa.idade = 23;
console.log(pessoa.idade);

function alo(pessoa: {nome:string, idade:number}) {
    return `Alô, ${pessoa.nome}!`;
}
console.log(alo(pessoa));

let {nome, idade} = pessoa;
console.log(nome);
console.log(idade);

let outraPessoa = {
    nome: 'Mary Doe',
    idade: 25,
    nacionalidade: 'Brasileira'
};
console.log(alo(outraPessoa));

let maisUmaPessoa = {
    nome: 'Joane Doe',
    idade: 18,
    saudar() {
        return `Alô, ${this.nome}`;
    }
};
console.log(maisUmaPessoa);
nome = 'teste';
console.log(maisUmaPessoa.saudar());

const json = JSON.stringify(maisUmaPessoa);
console.log(json);
const objeto = JSON.parse(json);
console.log(objeto);
console.log(objeto.saudar());//não funciona!