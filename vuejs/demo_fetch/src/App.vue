<script setup lang="ts">
import type { PostDTO } from './services/postDTO';
import { buscarTodosPosts } from './services/postService';
import { ref } from 'vue';

const posts = ref<PostDTO[]>([]);
const erro = ref<Error>();

async function handleClick() {
  try {
    posts.value = [];
    posts.value = await buscarTodosPosts();
  } catch (error) {
    erro.value = error as Error;
  }
}

</script>

<template>
  <h1>Posts</h1>
  <button @click="handleClick">Buscar</button>
  <p v-if="erro">Erro encontrado: {{ erro.message }}</p>
  <p v-else-if="posts.length === 0">Sem dados</p>
  <ul v-else>
    <li v-for="post in posts">
      {{ post.id }} - {{ post.title }}
    </li>
  </ul>
</template>

<style scoped>

</style>
