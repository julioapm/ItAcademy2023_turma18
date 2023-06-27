<script setup lang="ts">
import AloMundo from './components/AloMundo.vue';
import AloMundo2 from './components/AloMundo2.vue';
import AloMundo3 from './components/AloMundo3.vue';
import Contador from './components/Contador.vue';
import NomeInput from './components/NomeInput.vue';

</script>

<template>
  <h1>Demonstração da Vinculação</h1>
  <br />
  <AloMundo />
  <br />
  <AloMundo2 />
  <br />
  <AloMundo3 />
  <br />
  <Contador />
  <br />
  <NomeInput />
</template>

<style scoped>
header {
  line-height: 1.5;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style>
