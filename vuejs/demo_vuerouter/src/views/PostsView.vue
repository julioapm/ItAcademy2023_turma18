<script setup lang="ts">
import { useRoute } from 'vue-router';
import { useFetch } from '@vueuse/core';

const baseUrl = 'https://jsonplaceholder.typicode.com';
const route = useRoute();
const postId = route.params.postId;
const url = `${baseUrl}/posts/${postId}`;
const {data, error, isFetching} = useFetch(url);

</script>

<template>
    <h1>Post {{ $route.params.postId }}</h1>
    <p v-if="error">Erro encontrado: {{ error.message }}</p>
    <p v-else-if="isFetching">Carregando...</p>
    <p v-else-if="!data">Sem dados</p>
    <p v-else>{{ data }}</p>
</template>