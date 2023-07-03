import type { PostDTO } from "./postDTO";

const uriBase = 'https://jsonplaceholder.typicode.com';

export async function buscarTodosPosts() {
    const resposta = await fetch(`${uriBase}/posts`);
    if (resposta.ok) {
        return await resposta.json() as PostDTO[];
    } else {
        throw new Error(`GET status: ${resposta.status}`);
    }
}

export async function buscarPostPorId(id: number) {
    const resposta = await fetch(`${uriBase}/posts/${id}`);
    if (resposta.ok) {
        return await resposta.json() as PostDTO;
    } else {
        throw new Error(`GET status: ${resposta.status}`);
    }
}