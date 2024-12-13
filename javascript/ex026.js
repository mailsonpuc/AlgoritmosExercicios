let frase = "Arara Azul".toLowerCase().trim();

console.log(`A letra A aparece ${frase.split('a').length - 1} vezes na frase`);
console.log(`A letra A aparece na posição ${frase.indexOf('a') + 1}`);
console.log(`A ultima letra A aparece na posição ${frase.lastIndexOf('a') + 1}`);

