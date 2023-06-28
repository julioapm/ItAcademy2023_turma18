<script setup lang="ts">
import { ref } from "vue";
const valorTexto = ref('');
function handleInput(event: Event) {
    valorTexto.value = (event.target as HTMLInputElement).value;
}
</script>

<template>
    <div>
        <input type="text" placeholder="Digite seu nome"
            :value="valorTexto"
            @input="handleInput"
        />
        <span>{{ valorTexto }}</span>
    </div>
</template>