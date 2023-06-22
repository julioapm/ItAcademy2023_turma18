export function area(r: number) {
    return Math.PI * r**2;
}

export function circunferencia(r: number) {
    return 2 * Math.PI * r;
}

function potenciaDois(n: number): number {
    if (n === 0) return 1;
    return 2 * potenciaDois(n-1);
}

export {potenciaDois};