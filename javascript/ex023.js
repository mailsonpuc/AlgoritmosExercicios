console.clear();

const num = 1997;
u = num / 1 % 10
d = num / 10 % 10
c = num / 100 % 10
m = num / 1000 % 10


console.log(`Analizando o numero ${num}`);
console.log(`Unidade ${Math.floor(u)}`);
console.log(`Dezena ${Math.floor(d)}`);
console.log(`Centena ${Math.floor(c)}`);
console.log(`Milhar ${Math.floor(m)}`);