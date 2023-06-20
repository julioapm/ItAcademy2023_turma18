(function (x: number, y:number) {
    console.log(x + y);
})(1,2);

function somar(x: number): (y: number) => number {
    return function (y: number) {
        return x + y;
    };
}

const somar2 = somar(2);
console.log(somar2(3));

function somarComArrow(x: number) {
    return (y: number) => x + y;
}

console.log(somarComArrow(2)(3));
