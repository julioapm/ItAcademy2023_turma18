import { area, potenciaDois as pot2 } from './circulo_funcoes';
import Circulo from './circulo_objeto';
import * as fs from 'node:fs';

console.log(area(5));
let c = new Circulo(5);
console.log(c.area());
console.log(pot2(3));

const json = JSON.stringify(c);
fs.writeFileSync('dados.json', json);