import { area, potenciaDois as pot2 } from './circulo_funcoes';
import Circulo from './circulo_objeto';
import * as fs from 'node:fs';
import * as fsasync from 'node:fs/promises';

console.log(area(5));
let c = new Circulo(5);
console.log(c.area());
console.log(pot2(3));

const json = JSON.stringify(c);
fs.writeFileSync('dados.json', json);
/*
fs.readFile('dados.json', 'utf-8', (err, data) => {
    if (err) {
        console.error('Falha de leitura do arquivo');
        console.error(err.message);
    } else {
        console.log(data);
    }
});
*/
/*
fsasync.readFile('dados.json', 'utf-8')
       .then(data => console.log(data))
       .catch(err => {
            console.error('Falha de leitura do arquivo');
            console.log(err);
       });
*/
async function main() {
    try {
        const data = await fsasync.readFile('dados.json', 'utf-8');
        console.log(data);
    } catch (err) {
        console.error('Falha de leitura do arquivo');
        console.log(err);
    }   
}

main();