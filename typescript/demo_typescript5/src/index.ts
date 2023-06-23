import fetch from 'node-fetch';
import { PostDTO } from './postDto';

async function main() {
    const uriBase = 'https://jsonplaceholder.typicode.com';
    try {
        //GET
        const resposta = await fetch(`${uriBase}/posts`);
        if (resposta.ok) {
            const dados = await resposta.json() as PostDTO[];
            console.log(dados[0]);
        } else {
            console.log('GET status:', resposta.status);
            console.log('GET statusText:', resposta.statusText);
        }
    } catch (error) {
        console.error('Falha na requisição HTTP');
        console.error(error);
    }
}

main();