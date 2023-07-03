import { ref, watchEffect, toValue, type MaybeRefOrGetter } from "vue";

export function useFetch<T>(url: MaybeRefOrGetter<string>) {
    const dados = ref<T>();
    const erro = ref<Error>();
    watchEffect(async () => {
        dados.value = undefined;
        erro.value = undefined;
        const urlValor = toValue(url);
        try {
            await timeout();
            const resposta = await fetch(urlValor);
            if (resposta.ok) {
                dados.value = await resposta.json() as T;
            } else {
                erro.value = new Error(`GET status: ${resposta.status}`);
            }
        } catch (error) {
            erro.value = error as Error;
        }
    });
    return {dados, erro};
}

function timeout() {
    return new Promise<void>((resolve, reject) => {
        setTimeout(() => {
            if (Math.random() > 0.3) {
                resolve();
            } else {
                reject(new Error('Falhou'));
            }
        }, 2000);
    });
}