import fetch from 'node-fetch';
import { PostDTO } from './postDto';

async function main() {
    const uriBase = 'https://jsonplaceholder.typicode.com';
    try {
        /*
        //GET
        const resposta = await fetch(`${uriBase}/posts`);
        if (resposta.ok) {
            const dados = await resposta.json() as PostDTO[];
            console.log(dados[0]);
        } else {
            console.log('GET status:', resposta.status);
            console.log('GET statusText:', resposta.statusText);
        }
        */
       /*
        //GET
        const id = 200;
        const resposta = await fetch(`${uriBase}/posts/${id}`);
        if (resposta.ok) {
            const dados = await resposta.json() as PostDTO;
            console.log(dados);
        } else {
            console.log('GET status:', resposta.status);
            console.log('GET statusText:', resposta.statusText);
        }
        */
        /*
        //DELETE
        const id = 1;
        const resposta = await fetch(`${uriBase}/posts/${id}`, {method: 'DELETE'});
        if (resposta.ok) {
            console.log('DELETE efetuado com sucesso');
        } else {
            console.log('DELETE status:', resposta.status);
            console.log('DELETE statusText:', resposta.statusText);
        }
        */
        //POST
        const postagem: PostDTO = {
            userId: 1,
            title: 'Um teste de postagem',
            body: 'Um texto de mensagem'
        };
        const resposta = await fetch(`${uriBase}/posts`, {
            method: 'POST',
            headers: {
                'Content-type': 'application/json; charset=UTF-8',
            },
            body: JSON.stringify(postagem)
        });
        if (resposta.ok) {
            const dados = await resposta.json() as PostDTO;
            console.log(dados);
            const urlRecurso = resposta.headers.get('Location');
            console.log(urlRecurso);
        } else {
            console.log('POST status:', resposta.status);
            console.log('POST statusText:', resposta.statusText);
        }
    } catch (error) {
        console.error('Falha na requisição HTTP');
        console.error(error);
    }
}

main();