let array = [1,2,3,4,5,6,7,8,9,10];
console.log(array.length);
console.log(array);
console.log(array[9]);
console.log(array[10]);
array.length = 15;
console.log(array.length);
console.log(array);
console.log(array[9]);
console.log(array[10]);

let numeros = [1,2,3,4,5];
let resultado = numeros.findIndex(n => n+1==4);
console.log(resultado);

let palavras = ['oi', 'teste', 'alfa', 'bravo', 'charlie', 'delta'];
let resultado2 = palavras.find(p => p.length === 5);
console.log(resultado2);

console.log(palavras.filter(p => p.length >= 6));
console.log(palavras.map(p => p.length));
console.log(numeros.reduce((valorAnterior,valorAtual) => valorAnterior + valorAtual,0));
