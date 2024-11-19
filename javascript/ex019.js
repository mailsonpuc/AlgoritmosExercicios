console.clear();

const n1 =  'ana';
const n2 = 'bia'
const n3 = 'july'
const n4 = 'mailson'

const lista = [n1, n2, n3, n4]

const escolhido = parseInt(Math.random() * lista.length);

console.log(`O aluno escolhido foi: ${lista[escolhido]}`)