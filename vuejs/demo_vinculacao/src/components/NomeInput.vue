<script setup lang="ts">
import { ref } from 'vue';

const texto = ref('teste');

function handleChange(event: Event) {
    texto.value = (event.target as HTMLInputElement).value;
}

</script>

<template>
    <div>
        <input type="text" :value="texto" @change="handleChange"/>
        <span>Seu nome é {{ texto }}</span>
    </div>
</template>