<script setup lang="ts">
import { useFetch } from '../services/useFetch';
import type { PostDTO } from '../services/postDTO';

const {dados, erro} = useFetch<PostDTO[]>('https://jsonplaceholder.typicode.com/posts');

</script>

<template>
    <h1>Posts</h1>
    <p v-if="erro">Erro encontrado: {{ erro.message }}</p>
    <p v-else-if="!dados">Sem dados</p>
    <ul v-else>
        <li v-for="post in dados">
            {{ post.id }} - {{ post.title }}
        </li>
    </ul>
</template>