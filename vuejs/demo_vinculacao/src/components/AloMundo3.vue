<script setup lang="ts">
    function handleClick(event: MouseEvent) {
        const botaoClicado = event.currentTarget as HTMLButtonElement;
        alert(`Alô, ${botaoClicado.name}`);
    }
</script>

<template>
    <button @click="handleClick" name="botaoAlo">Diga Alô</button>
</template>