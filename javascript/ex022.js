console.clear();

const nome = "maria da silva cardoso";
const nomeCompleto = nome.replaceAll(' ','');
const primeiroNome = nome.split(' ');


console.log(`Analizando seu nome..........`);

console.log(`Seu nome em maiuscula é: ${nome.toUpperCase()}`)
console.log(`Seu nome em minuscula é: ${nome.toLowerCase()}`)
console.log(`Seu nome tem ao todo ${nome.length} letras`)
console.log(`Seu nome tem ao todo tem ${nomeCompleto.length} letras`)

console.log(`Seu primeiro nome tem ${primeiroNome[0].length} letras`)
