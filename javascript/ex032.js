
const ano = 2005;
const dataAtual = new Date();

if (ano == 0) {
    ano = dataAtual.getFullYear();
}
 
if (ano % 4==0 && ano % 100 !=0 || ano % 400 ==0) {
    console.log(`O ano ${ano} é BISSEXTO`);
}
else{
    console.log(`O ${ano} não é BISSEXTO`)
}