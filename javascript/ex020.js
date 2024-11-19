console.clear()


const n1 = 'mailson';
const n2 = 'julia';
const n3 = 'fernanda';
const n4 = 'barbara';

const lista = [n1, n2, n3, n4];

for (let i = lista.length - 1; i > 0; i--) {
    const j = Math.floor(Math.random() * (i + 1));
    [lista[i], lista[j]] = [lista[j], lista[i]];
}

console.log(`a ordem de apresentação sera [ ${lista} ]`);

