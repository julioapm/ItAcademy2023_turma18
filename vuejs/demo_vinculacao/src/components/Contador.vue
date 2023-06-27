<script setup lang="ts">
import { ref } from 'vue';

const contagem = ref(0);

function incrementarContagem() {
    contagem.value++;
}

function handleClick() {
    incrementarContagem();
}

</script>

<template>
    <div>
        <button @click="handleClick">Clique Aqui</button>
        <span>foi clicado {{ contagem }} vezes</span>
    </div>
</template>