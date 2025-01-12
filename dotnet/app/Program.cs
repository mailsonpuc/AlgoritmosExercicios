using System.Text.Json;
using app.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;



Console.Clear();

// ex001 fala = new ex001();
// fala.Frase = "Ola Mundo";
// fala.Falar();

// ex002 nome = new ex002();
// nome.Nome();

// ex003 soma = new ex003();
// soma.SomaDoisNumeros();


// ex004 frase = new ex004();
// frase.Valor();

// ex005 n = new ex005();
// n.SucessoEantecessor();

// ex006 ex6 = new ex006();
// ex6.DobroTriploEraiz();

// ex007 ex7 = new ex007();
// ex7.NotaDoAluno();

// ex008 ex8 = new ex008();
// ex8.Medida();


// ex009 ex9 = new ex009();
// ex9.Tabuada();


// ex010 ex10 = new ex010();
// ex10.RealToDolar();

// ex011 ex11 = new ex011();
// ex11.PintaParede();

// ex012 ex12 = new ex012();
// ex12.Promocao();

// ex013 ex13 = new ex013();
// ex13.AumentoSalario();

// ex014 ex14 = new ex014();
// ex14.CelciosParaF();

// ex015 ex15 = new ex015();
// ex15.AluguelDeCarro();

// ex016 ex16 = new ex016();
// ex16.ConvertFloatToInte();

// ex017 ex17 = new ex017();
// ex17.Hipotenusa();


// ex018 ex18 = new ex018();
// ex18.CalculadoraTrigonometrica();

// ex019 ex19 = new ex019();
// ex19.EscolherAluno();

//  ex020 ex20 = new ex020();
//  ex20.OrdemDeapresentacao();

// ex021 ex21 = new ex021();
// ex21.TocaMusica();

// ex022 ex22 = new ex022();
// ex22.NomeDePessoa();

// ex023 ex23 = new ex023();
// ex23.UnidadeDezenaCentena();

// ex024 ex24 = new ex024();
// Console.WriteLine(ex24.VerificarPalavra());

// ex025 ex25 = new ex025();
// ex25.TemSilvaNoNome();

// ex026 ex26 = new ex026();
// ex26.FraseLettraA();

// ex027 ex27 = new ex027();
// ex27.PrimeiroEultimoNome();

// ex028 ex28 = new ex028();
// ex28.JogoAdivinha();

// ex029 ex29 = new ex029();
// ex29.MultaDeVelocidade();

// ex030 ex30 = new ex030();
// ex30.ParOuImpar();

// ex031 ex31 = new ex031();
// ex31.PrecoDeViagem();

// ex032 ex32 = new ex032();
// ex32.anoBissexto();

// ex033 ex33 = new ex033();
// ex33.MaiorEmenorValor();

// ex034 ex34 = new ex034();
// ex34.AumentoSalario();

// ex035 ex35 = new ex035();
// ex35.Triangulo();

// ex036 ex36 = new ex036();
// ex36.AprovandoEmprestimos();


// ex037 ex37 = new ex037();
// ex37.ConversoBaseNumerica();

// ex038 ex38 = new ex038();
// ex38.ComparandoNumeros();

// ex039 ex39 = new ex039();
// ex39.AlistamentoMilitar();

// ex040 ex40 = new ex040();
// ex40.MediaDeNota();

// ex042 ex42 = new ex042();
// ex42.Triangulo();

// ex043 ex43 = new ex043();
// ex43.CalcularImc();

// ex044 ex44 = new ex044();
// ex44.GerenciadoDePagamento();

// ex045 ex45 = new ex045();
// ex45.PedraPapalEtesoura();

// ex046 ex46 = new ex046();
// ex46.Contagem();

// ex047 ex47 = new ex047();
// ex47.ComtagemDePares();

// ex048 ex48 = new ex048();
// ex48.SomaDeMultiplosDe3();

// ex049 ex49 = new ex049();
// ex49.TabuadaV2();

// ex050 ex50 = new ex050();
// ex50.SomaDosPares();

// ex051 ex51 = new ex051();
// ex51.AritmeticaPA();

// ex052 ex52 = new ex052();
// ex52.NumeroPrimo();

// ex053 ex53 = new ex053();
// ex53.Polindromo();

// ex054 ex54 = new ex054();
// ex54.GrupoDeMaioridade();

// ex055 ex55 = new ex055();
// ex55.MaieEmenorDaSequencia();

// ex056 ex56 = new ex056();
// ex56.AnalisadorCompleto();

// ex057 ex57 = new ex057();
// ex57.ValidacaoDeDados();

// ex058 ex58 = new ex058();
// ex58.JogoDeAdivinhacao();

// ex059 ex59 = new ex059();
// ex59.Menu();
// ex060 ex60 = new ex060();
// ex60.CalculoFatorial();

// ex061 ex61 = new ex061();
// ex61.ProgrecaoAritmetica();

// ex062 ex62 = new ex062();
// ex62.GeradorDePA2();

// ex063 ex63 = new ex063();
// ex63.SequenciaDeFibonacci();

// ex064 ex64  = new ex064();
// ex64.TratandoVariosValores();

// ex065 ex65 = new ex065();
// ex65.maiorEmeno2();

// ex066 ex66 = new ex066();
// ex66.VariosNumerosComFlag();

// ex067 ex67 = new ex067();
// ex67.TabuadaDeQualqueValor();

// ex068 ex68 = new ex068();
// ex68.JogoDoParOuImopar();

// ex069 ex69 = new ex069();
// ex69.AnaliseDeDadosDeGrupo();

// ex070 ex70 = new ex070();
// ex70.EstatisticaEmProduto();

// ex071 ex71 = new ex071();
// ex71.SimuladorDeCaixaEletronico();
// ex072 ex72 = new ex072();
// ex72.NumeroPorExtenso();

// ex073 ex73 = new ex073();
// ex73.listaComTimesDeFutebol();

// ex074 ex74 = new ex074();
// ex74.MairEmenorValorEmLista();

// ex075 ex75 = new ex075();
// ex75.AnaliseDeDadosEmLista();

// ex076 ex76 = new ex076();
// ex76.listadePrecoComTupla();

// ex077 ex77 = new ex077();
// ex77.ContandoVogais();

// ex078 ex78 = new ex078();
// ex78.MaiorEmenorValoresNaLista();

// ex079 ex79 = new ex079();
// ex79.ValoresUnicosEmUmaLista();

// ex080 ex80 = new ex080();
// ex80.ListaOrdenadaSemRepeticao();

// ex081 ex81 = new ex081();
// ex81.ExtraindoDadosDeUmaLista();

// ex082 ex82 = new ex082();
// ex82.DividindoValoresEmVariasListas();

// ex083 ex83 = new ex083();
// ex83.ValidandoExpresaoNumerica();

// ex084 ex84 = new ex084();
// ex84.ListaCompletaEanaliseDeDados();

// ex085 ex85 = new ex085();
// ex85.ListaComParesEimpares();

// ex086 ex86 = new ex086();
// ex86.MatrizEmCsharp();

// ex087 ex87 = new ex087();
// ex87.MaisSobreMatrizes();

// ex088 ex88 = new ex088();
// ex88.JogarNaMegaSena();

// ex089 ex89 = new ex089();
// ex89.BoletimComLista();

// ex090 ex90 = new ex090();
// ex90.DicionarioEmCshsarp();

// ex091 ex91 = new ex091();
// ex91.JogandoDadosEmCsharp();

// ex092 ex92 = new ex092();
// ex92.CadastroDeTrabalhadorEmCsharp();

ex093 ex93 = new ex093();
ex93.TestaAPi();