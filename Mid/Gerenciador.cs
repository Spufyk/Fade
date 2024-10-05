using Mid;

namespace Mid;

public class Gerenciador
{

    List<Questao> listaTodasQuestoes = new List<Questao>();
    List<Questao> listaTodasQuestaoRespondidas = new List<Questao>();
    Questao questaoAtual;

    public int Pontuacao { get; private set; }
    Label labelPontuacao;
    Label labelNivel;
    int NivelResposta = 1;

    void Initialize()
    {
        Pontuacao = 0;
        NivelResposta = 1;
        ProximaQuestao();
    }

    public Questao GetQuestaoAtual()
    {
        return questaoAtual;
    }

    public Gerenciador(Label labelPergunta, Button Resposta01, Button Resposta02, Button Resposta03, Button Resposta04, Button Resposta05, Label labelNivel, Label labelPontuacao)
    {
        CriarQuestoes(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        this.labelNivel = labelNivel;
        this.labelPontuacao = labelPontuacao;
    }

    void CriarQuestoes(Label labelPergunta, Button Resposta01, Button Resposta02, Button Resposta03, Button Resposta04, Button Resposta05)
    {

        var q1 = new Questao();

        q1.NivelResposta = 1;
        q1.Pergunta = "Quanto é 2 + 2";
        q1.Resposta1 = "Bolsonabo";
        q1.Resposta2 = "13";
        q1.Resposta3 = "4";
        q1.Resposta4 = "6";
        q1.Resposta5 = "0";

        q1.RespostaCerta = 3;
        q1.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q1);

        var q2 = new Questao();
        q2.NivelResposta = 1;

        q2.Pergunta = "Qual a capital da França?";
        q2.Resposta1 = "Berlim";
        q2.Resposta2 = "Paris";
        q2.Resposta3 = "Madrid";
        q2.Resposta4 = "Lisboa";
        q2.Resposta5 = "Roma";

        q2.RespostaCerta = 2;
        q2.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q2);

        var q3 = new Questao();
        q3.NivelResposta = 1;
        q3.Pergunta = "Qual é a cor do céu em um dia limpo?";
        q3.Resposta1 = "Verde";
        q3.Resposta2 = "Azul";
        q3.Resposta3 = "Amarelo";
        q3.Resposta4 = "Vermelho";
        q3.Resposta5 = "Preto";

        q3.RespostaCerta = 2;
        q3.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q3);

        var q4 = new Questao();
        q4.NivelResposta = 1;
        q4.Pergunta = "Qual é o maior planeta do sistema solar?";
        q4.Resposta1 = "Terra";
        q4.Resposta2 = "Marte";
        q4.Resposta3 = "Júpiter";
        q4.Resposta4 = "Saturno";
        q4.Resposta5 = "Netuno";

        q4.RespostaCerta = 3;
        q4.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q4);

        var q5 = new Questao();
        q5.NivelResposta = 1;
        q5.Pergunta = "Quem escreveu 'Dom Casmurro'?";
        q5.Resposta1 = "Machado de Assis";
        q5.Resposta2 = "José de Alencar";
        q5.Resposta3 = "Jorge Amado";
        q5.Resposta4 = "Clarice Lispector";
        q5.Resposta5 = "Graciliano Ramos";

        q5.RespostaCerta = 1;
        q5.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q5);

        var q6 = new Questao();
        q6.NivelResposta = 1;
        q6.Pergunta = "Quantos continentes existem?";
        q6.Resposta1 = "5";
        q6.Resposta2 = "6";
        q6.Resposta3 = "7";
        q6.Resposta4 = "4";
        q6.Resposta5 = "8";

        q6.RespostaCerta = 3;
        q6.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q6);

        var q7 = new Questao();
        q7.NivelResposta = 1;
        q7.Pergunta = "Qual é a fórmula da água?";
        q7.Resposta1 = "H2O";
        q7.Resposta2 = "O2";
        q7.Resposta3 = "CO2";
        q7.Resposta4 = "NaCl";
        q7.Resposta5 = "C6H12O6";

        q7.RespostaCerta = 1;
        q7.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q7);

        var q8 = new Questao();
        q8.NivelResposta = 1;
        q8.Pergunta = "Qual é a língua mais falada do mundo?";
        q8.Resposta1 = "Inglês";
        q8.Resposta2 = "Mandarim";
        q8.Resposta3 = "Espanhol";
        q8.Resposta4 = "Francês";
        q8.Resposta5 = "Árabe";

        q8.RespostaCerta = 2;
        q8.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q8);

        var q9 = new Questao();
        q9.NivelResposta = 1;
        q9.Pergunta = "Quem pintou a Mona Lisa?";
        q9.Resposta1 = "Vincent van Gogh";
        q9.Resposta2 = "Leonardo da Vinci";
        q9.Resposta3 = "Pablo Picasso";
        q9.Resposta4 = "Claude Monet";
        q9.Resposta5 = "Michelangelo";

        q9.RespostaCerta = 2;
        q9.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q9);

        var q10 = new Questao();
        q10.NivelResposta = 1;
        q10.Pergunta = "Qual é o maior oceano do mundo?";
        q10.Resposta1 = "Oceano Atlântico";
        q10.Resposta2 = "Oceano Índico";
        q10.Resposta3 = "Oceano Pacífico";
        q10.Resposta4 = "Oceano Ártico";
        q10.Resposta5 = "Oceano Antártico";

        q10.RespostaCerta = 3;
        q10.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q10);

        var q11 = new Questao();
        q11.NivelResposta = 2;
        q11.Pergunta = "Qual é o elemento químico com símbolo O?";
        q11.Resposta1 = "Oxigênio";
        q11.Resposta2 = "Ouro";
        q11.Resposta3 = "Prata";
        q11.Resposta4 = "Cálcio";
        q11.Resposta5 = "Nitrogênio";

        q11.RespostaCerta = 1;
        q11.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q11);

        // 12
        var q12 = new Questao();
        q12.NivelResposta = 2;
        q12.Pergunta = "Qual animal é conhecido como o 'rei da selva'?";
        q12.Resposta1 = "Elefante";
        q12.Resposta2 = "Tigre";
        q12.Resposta3 = "Leão";
        q12.Resposta4 = "Urso";
        q12.Resposta5 = "Gorila";

        q12.RespostaCerta = 3;
        q12.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q12);

        // 13
        var q13 = new Questao();
        q13.NivelResposta = 2;
        q13.Pergunta = "Qual é a moeda do Japão?";
        q13.Resposta1 = "Yuan";
        q13.Resposta2 = "Won";
        q13.Resposta3 = "Yen";
        q13.Resposta4 = "Dólar";
        q13.Resposta5 = "Euro";

        q13.RespostaCerta = 3;
        q13.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q13);

        // 14
        var q14 = new Questao();
        q14.NivelResposta = 2;
        q14.Pergunta = "Qual é o nome do famoso relógio de Londres?";
        q14.Resposta1 = "Big Ben";
        q14.Resposta2 = "Tower Bridge";
        q14.Resposta3 = "London Eye";
        q14.Resposta4 = "Buckingham Palace";
        q14.Resposta5 = "Westminster Abbey";

        q14.RespostaCerta = 1;
        q14.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q14);

        // 15
        var q15 = new Questao();
        q15.NivelResposta = 2;
        q15.Pergunta = "Quem é o autor de 'A Moreninha'?";
        q15.Resposta1 = "Joaquim Manuel de Macedo";
        q15.Resposta2 = "Machado de Assis";
        q15.Resposta3 = "José de Alencar";
        q15.Resposta4 = "Aluísio Azevedo";
        q15.Resposta5 = "Eça de Queirós";

        q15.RespostaCerta = 1;
        q15.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q15);

        // 16
        var q16 = new Questao();
        q16.NivelResposta = 2;
        q16.Pergunta = "Qual planeta é conhecido como o 'planeta vermelho'?";
        q16.Resposta1 = "Marte";
        q16.Resposta2 = "Vênus";
        q16.Resposta3 = "Júpiter";
        q16.Resposta4 = "Saturno";
        q16.Resposta5 = "Mercúrio";

        q16.RespostaCerta = 1;
        q16.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q16);

        // 17
        var q17 = new Questao();
        q17.NivelResposta = 2;
        q17.Pergunta = "Qual é o maior mamífero do mundo?";
        q17.Resposta1 = "Elefante";
        q17.Resposta2 = "Baleia Azul";
        q17.Resposta3 = "Girafa";
        q17.Resposta4 = "Tubarão-Baleia";
        q17.Resposta5 = "Orca";

        q17.RespostaCerta = 2;
        q17.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q17);

        // 18
        var q18 = new Questao();
        q18.NivelResposta = 2;
        q18.Pergunta = "Qual é a capital da Itália?";
        q18.Resposta1 = "Roma";
        q18.Resposta2 = "Milão";
        q18.Resposta3 = "Nápoles";
        q18.Resposta4 = "Florença";
        q18.Resposta5 = "Veneza";

        q18.RespostaCerta = 1;
        q18.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q18);

        // 19
        var q19 = new Questao();
        q19.NivelResposta = 2;
        q19.Pergunta = "Quem descobriu a penicilina?";
        q19.Resposta1 = "Louis Pasteur";
        q19.Resposta2 = "Alexander Fleming";
        q19.Resposta3 = "Marie Curie";
        q19.Resposta4 = "Isaac Newton";
        q19.Resposta5 = "Charles Darwin";

        q19.RespostaCerta = 2;
        q19.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q19);

        // 20
        var q20 = new Questao();
        q20.NivelResposta = 2;
        q20.Pergunta = "Qual é o país famoso por seus cangurus?";
        q20.Resposta1 = "Austrália";
        q20.Resposta2 = "Canadá";
        q20.Resposta3 = "África do Sul";
        q20.Resposta4 = "Brasil";
        q20.Resposta5 = "Nova Zelândia";

        q20.RespostaCerta = 1;
        q20.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q20);

        // 21
        var q21 = new Questao();
        q21.NivelResposta = 3;
        q21.Pergunta = "Qual a fórmula química da água?";
        q21.Resposta1 = "H2";
        q21.Resposta2 = "O2";
        q21.Resposta3 = "H2O";
        q21.Resposta4 = "CO2";
        q21.Resposta5 = "H2O2";
        q21.RespostaCerta = 3;
        q21.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q21);

        var q22 = new Questao();
        q22.NivelResposta = 3;
        q22.Pergunta = "Qual é a capital da Austrália?";
        q22.Resposta1 = "Sydney";
        q22.Resposta2 = "Melbourne";
        q22.Resposta3 = "Canberra";
        q22.Resposta4 = "Brisbane";
        q22.Resposta5 = "Adelaide";
        q22.RespostaCerta = 3;
        q22.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q22);

        var q23 = new Questao();
        q23.NivelResposta = 3;
        q23.Pergunta = "Quem escreveu a obra 'Dom Quixote'?";
        q23.Resposta1 = "William Shakespeare";
        q23.Resposta2 = "Gabriel García Márquez";
        q23.Resposta3 = "Miguel de Cervantes";
        q23.Resposta4 = "Jorge Luis Borges";
        q23.Resposta5 = "Fernando Pessoa";
        q23.RespostaCerta = 3;
        q23.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q23);

        var q24 = new Questao();
        q24.NivelResposta = 3;
        q24.Pergunta = "Em qual ano ocorreu a Revolução Francesa?";
        q24.Resposta1 = "1789";
        q24.Resposta2 = "1776";
        q24.Resposta3 = "1812";
        q24.Resposta4 = "1804";
        q24.Resposta5 = "1756";
        q24.RespostaCerta = 1;
        q24.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q24);

        var q25 = new Questao();
        q25.NivelResposta = 3;
        q25.Pergunta = "Quantos elementos químicos existem na tabela periódica?";
        q25.Resposta1 = "100";
        q25.Resposta2 = "109";
        q25.Resposta3 = "118";
        q25.Resposta4 = "125";
        q25.Resposta5 = "132";
        q25.RespostaCerta = 3;
        q25.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q25);

        var q26 = new Questao();
        q26.NivelResposta = 3;
        q26.Pergunta = "Quem foi o primeiro presidente do Brasil?";
        q26.Resposta1 = "Dom Pedro II";
        q26.Resposta2 = "Marechal Floriano Peixoto";
        q26.Resposta3 = "Getúlio Vargas";
        q26.Resposta4 = "Deodoro da Fonseca";
        q26.Resposta5 = "João Goulart";
        q26.RespostaCerta = 4;
        q26.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q26);

        var q27 = new Questao();
        q27.NivelResposta = 3;
        q27.Pergunta = "Qual é o maior planeta do Sistema Solar?";
        q27.Resposta1 = "Marte";
        q27.Resposta2 = "Saturno";
        q27.Resposta3 = "Júpiter";
        q27.Resposta4 = "Vênus";
        q27.Resposta5 = "Netuno";
        q27.RespostaCerta = 3;
        q27.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q27);

        var q28 = new Questao();
        q28.NivelResposta = 3;
        q28.Pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
        q28.Resposta1 = "1965";
        q28.Resposta2 = "1969";
        q28.Resposta3 = "1972";
        q28.Resposta4 = "1959";
        q28.Resposta5 = "1975";
        q28.RespostaCerta = 2;
        q28.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q28);

        var q29 = new Questao();
        q29.NivelResposta = 3;
        q29.Pergunta = "Quantos ossos tem o corpo humano adulto?";
        q29.Resposta1 = "200";
        q29.Resposta2 = "206";
        q29.Resposta3 = "208";
        q29.Resposta4 = "210";
        q29.Resposta5 = "212";
        q29.RespostaCerta = 2;
        q29.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q29);

        var q30 = new Questao();
        q30.NivelResposta = 3;
        q30.Pergunta = "Quem foi o primeiro homem a circunavegar o globo terrestre?";
        q30.Resposta1 = "Cristóvão Colombo";
        q30.Resposta2 = "Vasco da Gama";
        q30.Resposta3 = "Fernando de Magalhães";
        q30.Resposta4 = "Américo Vespúcio";
        q30.Resposta5 = "James Cook";
        q30.RespostaCerta = 3;
        q30.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q30);

        // 31
        var q31 = new Questao();
        q31.NivelResposta = 4;
        q31.Pergunta = "Quem desenvolveu a teoria da relatividade?";
        q31.Resposta1 = "Isaac Newton";
        q31.Resposta2 = "Albert Einstein";
        q31.Resposta3 = "Nikola Tesla";
        q31.Resposta4 = "Galileu Galilei";
        q31.Resposta5 = "Stephen Hawking";
        q31.RespostaCerta = 2;
        q31.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q31);

        var q32 = new Questao();
        q32.NivelResposta = 4;
        q32.Pergunta = "Qual foi a principal causa da Primeira Guerra Mundial?";
        q32.Resposta1 = "Assassinato do arquiduque Francisco Ferdinando";
        q32.Resposta2 = "Invasão da Polônia";
        q32.Resposta3 = "Revolução Francesa";
        q32.Resposta4 = "Guerra Fria";
        q32.Resposta5 = "Conflito entre EUA e União Soviética";
        q32.RespostaCerta = 1;
        q32.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q32);

        var q33 = new Questao();
        q33.NivelResposta = 4;
        q33.Pergunta = "Em que obra é mencionado o conceito de 'Estado de Natureza' de Hobbes?";
        q33.Resposta1 = "O Leviatã";
        q33.Resposta2 = "A República";
        q33.Resposta3 = "O Príncipe";
        q33.Resposta4 = "A Política";
        q33.Resposta5 = "O Contrato Social";
        q33.RespostaCerta = 1;
        q33.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q33);

        var q34 = new Questao();
        q34.NivelResposta = 4;
        q34.Pergunta = "Qual elemento tem o maior ponto de fusão?";
        q34.Resposta1 = "Carbono";
        q34.Resposta2 = "Osmium";
        q34.Resposta3 = "Tungstênio";
        q34.Resposta4 = "Irídio";
        q34.Resposta5 = "Platina";
        q34.RespostaCerta = 3;
        q34.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q34);

        var q35 = new Questao();
        q35.NivelResposta = 4;
        q35.Pergunta = "Quem escreveu 'A Divina Comédia'?";
        q35.Resposta1 = "Dante Alighieri";
        q35.Resposta2 = "Giovanni Boccaccio";
        q35.Resposta3 = "Virgílio";
        q35.Resposta4 = "Homero";
        q35.Resposta5 = "Victor Hugo";
        q35.RespostaCerta = 1;
        q35.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q35);

        var q36 = new Questao();
        q36.NivelResposta = 4;
        q36.Pergunta = "Quem foi o líder revolucionário da independência da Índia?";
        q36.Resposta1 = "Jawaharlal Nehru";
        q36.Resposta2 = "Mahatma Gandhi";
        q36.Resposta3 = "Nelson Mandela";
        q36.Resposta4 = "Winston Churchill";
        q36.Resposta5 = "Bhagat Singh";
        q36.RespostaCerta = 2;
        q36.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q36);

        var q37 = new Questao();
        q37.NivelResposta = 4;
        q37.Pergunta = "Em que ano aconteceu a Revolução Russa?";
        q37.Resposta1 = "1914";
        q37.Resposta2 = "1917";
        q37.Resposta3 = "1923";
        q37.Resposta4 = "1919";
        q37.Resposta5 = "1936";
        q37.RespostaCerta = 2;
        q37.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q37);

        var q38 = new Questao();
        q38.NivelResposta = 4;
        q38.Pergunta = "Qual foi o primeiro satélite artificial lançado pela humanidade?";
        q38.Resposta1 = "Sputnik 1";
        q38.Resposta2 = "Explorer 1";
        q38.Resposta3 = "Apollo 11";
        q38.Resposta4 = "Vostok 1";
        q38.Resposta5 = "Luna 2";
        q38.RespostaCerta = 1;
        q38.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q38);

        var q39 = new Questao();
        q39.NivelResposta = 4;
        q39.Pergunta = "Qual é o nome do maior deserto quente do mundo?";
        q39.Resposta1 = "Deserto do Saara";
        q39.Resposta2 = "Deserto da Arábia";
        q39.Resposta3 = "Deserto de Gobi";
        q39.Resposta4 = "Deserto de Kalahari";
        q39.Resposta5 = "Deserto da Patagônia";
        q39.RespostaCerta = 1;
        q39.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q39);

        var q40 = new Questao();
        q40.NivelResposta = 4;
        q40.Pergunta = "Quem pintou o teto da Capela Sistina?";
        q40.Resposta1 = "Leonardo da Vinci";
        q40.Resposta2 = "Michelangelo";
        q40.Resposta3 = "Rafael Sanzio";
        q40.Resposta4 = "Donatello";
        q40.Resposta5 = "Tintoretto";
        q40.RespostaCerta = 2;
        q40.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q40);

        // 41
        var q41 = new Questao();
        q41.NivelResposta = 5;
        q41.Pergunta = "Qual é a equação de Schrödinger na forma mais conhecida?";
        q41.Resposta1 = "E = mc²";
        q41.Resposta2 = "ψ(x,t) = e^(i/hbar * (px - Et))";
        q41.Resposta3 = "F = ma";
        q41.Resposta4 = "ΔG = ΔH - TΔS";
        q41.Resposta5 = "V = IR";
        q41.RespostaCerta = 2;
        q41.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q41);

        var q42 = new Questao();
        q42.NivelResposta = 5;
        q42.Pergunta = "Qual é o Princípio da Incerteza de Heisenberg?";
        q42.Resposta1 = "ΔxΔp ≥ h/4π";
        q42.Resposta2 = "F = ma";
        q42.Resposta3 = "E = mc²";
        q42.Resposta4 = "V = IR";
        q42.Resposta5 = "PV = nRT";
        q42.RespostaCerta = 1;
        q42.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q42);

        var q43 = new Questao();
        q43.NivelResposta = 5;
        q43.Pergunta = "Quem foi o primeiro filósofo a sistematizar a lógica formal?";
        q43.Resposta1 = "Platão";
        q43.Resposta2 = "Descartes";
        q43.Resposta3 = "Aristóteles";
        q43.Resposta4 = "Immanuel Kant";
        q43.Resposta5 = "Friedrich Nietzsche";
        q43.RespostaCerta = 3;
        q43.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q43);

        var q44 = new Questao();
        q44.NivelResposta = 5;
        q44.Pergunta = "Em qual ano ocorreu a Revolução Francesa?";
        q44.Resposta1 = "1789";
        q44.Resposta2 = "1848";
        q44.Resposta3 = "1917";
        q44.Resposta4 = "1776";
        q44.Resposta5 = "1815";
        q44.RespostaCerta = 1;
        q44.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q44);

        var q45 = new Questao();
        q45.NivelResposta = 5;
        q45.Pergunta = "Qual é a diferença entre mitose e meiose?";
        q45.Resposta1 = "Mitose ocorre apenas em organismos unicelulares, meiose em multicelulares.";
        q45.Resposta2 = "Mitose resulta em células geneticamente idênticas, meiose em células com metade dos cromossomos.";
        q45.Resposta3 = "Mitose ocorre apenas em células somáticas, meiose apenas em células neuronais.";
        q45.Resposta4 = "Mitose cria espermatozóides, meiose gera neurônios.";
        q45.Resposta5 = "Mitose resulta em quatro células, meiose em duas.";
        q45.RespostaCerta = 2;
        q45.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q45);

        var q46 = new Questao();
        q46.NivelResposta = 5;
        q46.Pergunta = "O que descreve a teoria de cordas em física?";
        q46.Resposta1 = "Partículas subatômicas são na verdade minúsculas cordas vibrando.";
        q46.Resposta2 = "O universo é composto por átomos interligados como cordas.";
        q46.Resposta3 = "Cordas conectam galáxias e permitem a expansão do universo.";
        q46.Resposta4 = "Cordas são filamentos de energia que sustentam a gravidade.";
        q46.Resposta5 = "Cordas mantêm elétrons e nêutrons orbitando.";
        q46.RespostaCerta = 1;
        q46.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q46);

        var q47 = new Questao();
        q47.NivelResposta = 5;
        q47.Pergunta = "Qual é a função de onda associada a uma partícula no formalismo da mecânica quântica?";
        q47.Resposta1 = "A função densidade";
        q47.Resposta2 = "A equação de onda de Schrödinger";
        q47.Resposta3 = "A função de probabilidade";
        q47.Resposta4 = "A função psi";
        q47.Resposta5 = "A função de energia";
        q47.RespostaCerta = 4;
        q47.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q47);

        var q48 = new Questao();
        q48.NivelResposta = 5;
        q48.Pergunta = "O que o teorema da incompletude de Gödel demonstra?";
        q48.Resposta1 = "Que a matemática está completa.";
        q48.Resposta2 = "Que qualquer sistema formal contém proposições indecidíveis.";
        q48.Resposta3 = "Que todos os axiomas podem ser provados.";
        q48.Resposta4 = "Que a lógica formal não pode ser aplicada a sistemas naturais.";
        q48.Resposta5 = "Que números complexos não têm solução.";
        q48.RespostaCerta = 2;
        q48.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q48);

        var q49 = new Questao();
        q49.NivelResposta = 5;
        q49.Pergunta = "Qual é o principal fator para determinar o clima de uma região?";
        q49.Resposta1 = "A vegetação local";
        q49.Resposta2 = "A altitude";
        q49.Resposta3 = "A latitude";
        q49.Resposta4 = "A densidade populacional";
        q49.Resposta5 = "A composição do solo";
        q49.RespostaCerta = 3;
        q49.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q49);

        var q50 = new Questao();
        q50.NivelResposta = 5;
        q50.Pergunta = "O que significa o termo 'Singularidade' em física?";
        q50.Resposta1 = "Um ponto no espaço-tempo onde as leis da física se quebram.";
        q50.Resposta2 = "Um ponto em um átomo onde a energia é máxima.";
        q50.Resposta3 = "Uma configuração de partículas idênticas.";
        q50.Resposta4 = "Um evento único no ciclo de vida de uma estrela.";
        q50.Resposta5 = "O ponto mais próximo de um buraco negro.";
        q50.RespostaCerta = 1;
        q50.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q50);

        // 51
        var q51 = new Questao();
        q51.NivelResposta = 6;
        q51.Pergunta = "Qual é a interpretação de Copenhague na mecânica quântica?";
        q51.Resposta1 = "Todas as partículas têm uma trajetória definida.";
        q51.Resposta2 = "A função de onda colapsa em um estado determinado quando observada.";
        q51.Resposta3 = "Partículas podem existir em múltiplos estados simultaneamente, sem colapso.";
        q51.Resposta4 = "O tempo é absoluto e invariante.";
        q51.Resposta5 = "Os elétrons estão presos em órbitas fixas ao redor do núcleo.";
        q51.RespostaCerta = 2;
        q51.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q51);

        var q52 = new Questao();
        q52.NivelResposta = 6;
        q52.Pergunta = "Qual foi a principal contribuição de Kurt Gödel à lógica matemática?";
        q52.Resposta1 = "A invenção da lógica proposicional.";
        q52.Resposta2 = "A criação do cálculo diferencial.";
        q52.Resposta3 = "A formulação do Teorema da Incompletude.";
        q52.Resposta4 = "A descoberta dos números transcendentais.";
        q52.Resposta5 = "O desenvolvimento da álgebra booleana.";
        q52.RespostaCerta = 3;
        q52.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q52);

        var q53 = new Questao();
        q53.NivelResposta = 6;
        q53.Pergunta = "Qual é o conceito de 'dualidade onda-partícula' em física?";
        q53.Resposta1 = "Partículas se comportam apenas como ondas.";
        q53.Resposta2 = "As ondas podem ser observadas apenas em estado estacionário.";
        q53.Resposta3 = "Todas as partículas podem se comportar como ondas e vice-versa.";
        q53.Resposta4 = "Ondas e partículas são estados mutuamente exclusivos.";
        q53.Resposta5 = "O comportamento de partículas depende da velocidade da luz.";
        q53.RespostaCerta = 3;
        q53.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q53);

        var q54 = new Questao();
        q54.NivelResposta = 6;
        q54.Pergunta = "Em que contexto se aplica a Transformada de Fourier?";
        q54.Resposta1 = "Na análise de circuitos elétricos.";
        q54.Resposta2 = "Na decomposição de funções periódicas em frequências.";
        q54.Resposta3 = "Na criação de campos gravitacionais.";
        q54.Resposta4 = "Na geometria diferencial.";
        q54.Resposta5 = "Na álgebra de Lie.";
        q54.RespostaCerta = 2;
        q54.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q54);

        var q55 = new Questao();
        q55.NivelResposta = 6;
        q55.Pergunta = "O que estabelece o teorema de Noether?";
        q55.Resposta1 = "Que a simetria em um sistema físico está associada a uma lei de conservação.";
        q55.Resposta2 = "Que energia e massa são equivalentes.";
        q55.Resposta3 = "Que todas as partículas têm antipartículas correspondentes.";
        q55.Resposta4 = "Que a entropia do universo está sempre aumentando.";
        q55.Resposta5 = "Que a velocidade da luz é constante em todos os referenciais.";
        q55.RespostaCerta = 1;
        q55.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q55);

        var q56 = new Questao();
        q56.NivelResposta = 6;
        q56.Pergunta = "Como a equação de Navier-Stokes descreve o comportamento dos fluidos?";
        q56.Resposta1 = "Por meio da equação de Bernoulli.";
        q56.Resposta2 = "Através da relação entre pressão, temperatura e velocidade.";
        q56.Resposta3 = "Pelo movimento de fluidos viscosos em diferentes densidades.";
        q56.Resposta4 = "Usando as leis de Newton para descrever o movimento de partículas em líquidos.";
        q56.Resposta5 = "Ao integrar a densidade de probabilidade de partículas.";
        q56.RespostaCerta = 3;
        q56.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q56);

        var q57 = new Questao();
        q57.NivelResposta = 6;
        q57.Pergunta = "Qual é o princípio subjacente à teoria dos jogos?";
        q57.Resposta1 = "Maximizar o valor esperado em jogos de sorte.";
        q57.Resposta2 = "Modelar a tomada de decisões em contextos de interação estratégica.";
        q57.Resposta3 = "Encontrar soluções para problemas combinatórios.";
        q57.Resposta4 = "Prever o comportamento de sistemas caóticos.";
        q57.Resposta5 = "Minimizar a entropia em sistemas não-lineares.";
        q57.RespostaCerta = 2;
        q57.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q57);

        var q58 = new Questao();
        q58.NivelResposta = 6;
        q58.Pergunta = "Qual é a hipótese de Riemann?";
        q58.Resposta1 = "Todos os números naturais são primos.";
        q58.Resposta2 = "Todos os zeros não triviais da função zeta de Riemann têm parte real igual a 1/2.";
        q58.Resposta3 = "A função exponencial é inversa à função logarítmica.";
        q58.Resposta4 = "A função zeta de Riemann não tem zeros fora da linha crítica.";
        q58.Resposta5 = "A soma dos números primos é um número complexo.";
        q58.RespostaCerta = 2;
        q58.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q58);

        var q59 = new Questao();
        q59.NivelResposta = 6;
        q59.Pergunta = "O que diz o teorema da informação de Shannon?";
        q59.Resposta1 = "O conhecimento completo do sistema implica em entropia zero.";
        q59.Resposta2 = "A entropia de uma mensagem é maximizada em sistemas caóticos.";
        q59.Resposta3 = "A quantidade de informação contida em uma mensagem pode ser medida em bits.";
        q59.Resposta4 = "Toda transmissão de dados sofre perda de informações.";
        q59.Resposta5 = "A informação não pode ser destruída, apenas transformada.";
        q59.RespostaCerta = 3;
        q59.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q59);

        var q60 = new Questao();
        q60.NivelResposta = 6;
        q60.Pergunta = "Qual é o significado de 'buracos negros evaporam' na teoria de Hawking?";
        q60.Resposta1 = "A matéria é lentamente puxada para fora de um buraco negro.";
        q60.Resposta2 = "Buracos negros perdem massa através da radiação de Hawking.";
        q60.Resposta3 = "A energia em um buraco negro é dissipada por ondas gravitacionais.";
        q60.Resposta4 = "Buracos negros colapsam após atingirem um limite crítico.";
        q60.Resposta5 = "O horizonte de eventos encolhe quando o buraco negro interage com matéria escura.";
        q60.RespostaCerta = 2;
        q60.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q60);

        // 61
        var q61 = new Questao();
        q61.NivelResposta = 7;
        q61.Pergunta = "O que é a conjectura de Poincaré?";
        q61.Resposta1 = "É a hipótese de que qualquer variedade tridimensional fechada e sem buracos é topologicamente equivalente a uma esfera.";
        q61.Resposta2 = "Afirma que qualquer função contínua sobre uma variedade bidimensional pode ser parametrizada por funções harmônicas.";
        q61.Resposta3 = "Teorema que diz que todo número primo pode ser expresso como a soma de dois números quadrados.";
        q61.Resposta4 = "Hipótese que propõe que todo sistema dinâmico tem pelo menos um ponto de equilíbrio.";
        q61.Resposta5 = "Teoria que demonstra a conexão entre física quântica e relatividade.";
        q61.RespostaCerta = 1;
        q61.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q61);

        var q62 = new Questao();
        q62.NivelResposta = 7;
        q62.Pergunta = "Qual é o paradoxo de Fermi relacionado à astrobiologia?";
        q62.Resposta1 = "Que a vida na Terra é a única no universo conhecido.";
        q62.Resposta2 = "Que embora a probabilidade de vida extraterrestre seja alta, ainda não encontramos evidências de sua existência.";
        q62.Resposta3 = "Que a vida alienígena só pode existir em dimensões paralelas.";
        q62.Resposta4 = "Que seres extraterrestres evoluiriam de forma idêntica aos seres humanos.";
        q62.Resposta5 = "Que a evolução biológica não poderia ocorrer fora da Terra.";
        q62.RespostaCerta = 2;
        q62.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q62);

        var q63 = new Questao();
        q63.NivelResposta = 7;
        q63.Pergunta = "O que significa a 'conjectura de Hodge' na geometria algébrica?";
        q63.Resposta1 = "Toda curva algébrica pode ser representada como a interseção de hipersuperfícies.";
        q63.Resposta2 = "O espaço tangente de uma variedade complexa pode ser parametrizado por formas holomorfas.";
        q63.Resposta3 = "Certas classes de cohomologia de uma variedade projetiva complexa são combinações lineares de classes de subvariedades algébricas.";
        q63.Resposta4 = "Cada variedade suave tem um fibrado tangente trivial.";
        q63.Resposta5 = "Toda variedade de Kähler pode ser decomposta em uma soma de classes topológicas.";
        q63.RespostaCerta = 3;
        q63.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q63);

        var q64 = new Questao();
        q64.NivelResposta = 7;
        q64.Pergunta = "Qual é a principal ideia por trás da teoria de cordas?";
        q64.Resposta1 = "Todas as partículas subatômicas são formadas por um único tipo de partícula fundamental.";
        q64.Resposta2 = "O espaço-tempo é curvado pela presença de massa e energia.";
        q64.Resposta3 = "As partículas fundamentais não são pontos, mas cordas unidimensionais vibrantes.";
        q64.Resposta4 = "O universo tem uma geometria plana e infinita.";
        q64.Resposta5 = "Partículas são agrupadas em quarks, que são indivisíveis.";
        q64.RespostaCerta = 3;
        q64.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q64);

        var q65 = new Questao();
        q65.NivelResposta = 7;
        q65.Pergunta = "Qual é a interpretação da desigualdade de Bell na mecânica quântica?";
        q65.Resposta1 = "Ela demonstra que partículas entrelaçadas compartilham informações mais rápido que a luz.";
        q65.Resposta2 = "Prova que teorias de variáveis ocultas locais não podem reproduzir todas as previsões da mecânica quântica.";
        q65.Resposta3 = "Estabelece uma relação direta entre velocidade e posição de uma partícula quântica.";
        q65.Resposta4 = "Descreve a simetria entre diferentes estados de spin em partículas entrelaçadas.";
        q65.Resposta5 = "Confirma que todos os estados quânticos podem ser representados por números inteiros.";
        q65.RespostaCerta = 2;
        q65.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q65);

        var q66 = new Questao();
        q66.NivelResposta = 7;
        q66.Pergunta = "Qual é o objetivo da 'cosmologia inflacionária'?";
        q66.Resposta1 = "Descrever o comportamento do universo durante o Big Crunch.";
        q66.Resposta2 = "Explicar a rápida expansão inicial do universo após o Big Bang.";
        q66.Resposta3 = "Demonstrar a formação de buracos negros supermassivos.";
        q66.Resposta4 = "Provar a existência de universos paralelos.";
        q66.Resposta5 = "Definir o colapso gravitacional de estrelas massivas.";
        q66.RespostaCerta = 2;
        q66.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q66);

        var q67 = new Questao();
        q67.NivelResposta = 7;
        q67.Pergunta = "O que descreve a teoria das categorias na matemática?";
        q67.Resposta1 = "A estrutura algébrica de anéis e corpos.";
        q67.Resposta2 = "As relações entre diferentes tipos de estruturas matemáticas, usando morfismos e objetos.";
        q67.Resposta3 = "A decomposição de números inteiros em fatores primos.";
        q67.Resposta4 = "A estrutura topológica de espaços métrico-vetoriais.";
        q67.Resposta5 = "A solução de equações diferenciais não-lineares.";
        q67.RespostaCerta = 2;
        q67.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q67);

        var q68 = new Questao();
        q68.NivelResposta = 7;
        q68.Pergunta = "Qual é o conceito de 'energia escura' no contexto da cosmologia?";
        q68.Resposta1 = "Uma forma de energia responsável pela aceleração da expansão do universo.";
        q68.Resposta2 = "A energia residual das primeiras estrelas que se formaram.";
        q68.Resposta3 = "Uma forma de matéria que não emite luz, mas interage gravitacionalmente.";
        q68.Resposta4 = "A radiação que preenche o vácuo do universo após o Big Bang.";
        q68.Resposta5 = "A energia emitida por buracos negros supermassivos.";
        q68.RespostaCerta = 1;
        q68.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q68);

        var q69 = new Questao();
        q69.NivelResposta = 7;
        q69.Pergunta = "O que é a 'hipótese da simulação' em filosofia e ciência?";
        q69.Resposta1 = "A ideia de que o universo é apenas uma simulação computacional avançada.";
        q69.Resposta2 = "A teoria que propõe que todas as decisões humanas são predeterminadas.";
        q69.Resposta3 = "A noção de que o espaço-tempo é uma ilusão criada por ondas gravitacionais.";
        q69.Resposta4 = "A crença de que apenas sistemas caóticos podem ser simulados com precisão.";
        q69.Resposta5 = "A proposta de que o Big Bang foi o início de uma simulação universal.";
        q69.RespostaCerta = 1;
        q69.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q69);

        var q70 = new Questao();
        q70.NivelResposta = 7;
        q70.Pergunta = "Qual é o significado de 'entrelançamento quântico'?";
        q70.Resposta1 = "A superposição de partículas que se encontram no mesmo estado energético.";
        q70.Resposta2 = "A interação gravitacional de duas partículas em estados diferentes.";
        q70.Resposta3 = "Um fenômeno no qual partículas quânticas permanecem correlacionadas independentemente da distância entre elas.";
        q70.Resposta4 = "A transferência de informação entre partículas em diferentes universos paralelos.";
        q70.Resposta5 = "A criação de novas partículas a partir da colisão de prótons.";
        q70.RespostaCerta = 3;
        q70.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q70);

        // 71
        var q71 = new Questao();
        q71.NivelResposta = 8;
        q71.Pergunta = "Qual é o princípio da incerteza de Heisenberg na mecânica quântica?";
        q71.Resposta1 = "É impossível determinar simultaneamente a posição e o momento de uma partícula com precisão arbitrária.";
        q71.Resposta2 = "Partículas subatômicas se comportam de maneira determinística ao interagir com campos elétricos.";
        q71.Resposta3 = "A massa de uma partícula se torna indefinida quando está em um estado entrelaçado.";
        q71.Resposta4 = "O número de partículas criadas em um vácuo quântico é diretamente proporcional à energia do sistema.";
        q71.Resposta5 = "A posição de uma partícula pode ser medida exatamente, mas sua velocidade nunca pode ser conhecida.";
        q71.RespostaCerta = 1;
        q71.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q71);

        var q72 = new Questao();
        q72.NivelResposta = 8;
        q72.Pergunta = "O que é a 'hipótese de Riemann' na teoria dos números?";
        q72.Resposta1 = "Afirma que todos os números primos podem ser expressos como a soma de dois números quadrados.";
        q72.Resposta2 = "É a conjectura de que todos os zeros não triviais da função zeta de Riemann têm parte real igual a 1/2.";
        q72.Resposta3 = "Estabelece uma relação entre números primos e as raízes de equações diferenciais parciais.";
        q72.Resposta4 = "Postula que todo número composto pode ser fatorado como uma soma de três números primos.";
        q72.Resposta5 = "Demonstra que a função zeta de Riemann pode ser aproximada por uma série convergente.";
        q72.RespostaCerta = 2;
        q72.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q72);

        var q73 = new Questao();
        q73.NivelResposta = 8;
        q73.Pergunta = "O que estabelece a 'equação de Schrödinger' na mecânica quântica?";
        q73.Resposta1 = "Ela descreve a evolução temporal do estado quântico de um sistema físico.";
        q73.Resposta2 = "Define a relação entre massa e energia em sistemas relativísticos.";
        q73.Resposta3 = "Afirma que a energia total de um sistema quântico é igual à soma das energias das partículas constituintes.";
        q73.Resposta4 = "Descreve a interação entre partículas entrelaçadas a longas distâncias.";
        q73.Resposta5 = "Postula que o universo quântico pode ser descrito por uma função de onda determinística.";
        q73.RespostaCerta = 1;
        q73.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q73);

        var q74 = new Questao();
        q74.NivelResposta = 8;
        q74.Pergunta = "Qual é a implicação do 'teorema de Gödel' na lógica matemática?";
        q74.Resposta1 = "Afirma que todos os sistemas formais são completos e consistentes.";
        q74.Resposta2 = "Prova que, em sistemas formais suficientemente complexos, existem proposições que não podem ser provadas nem refutadas.";
        q74.Resposta3 = "Demonstra que toda proposição lógica pode ser provada usando regras de inferência dedutivas.";
        q74.Resposta4 = "Estabelece que toda teoria física pode ser descrita por um conjunto de axiomas matemáticos.";
        q74.Resposta5 = "Postula que qualquer função recursiva pode ser descrita por uma equação algébrica.";
        q74.RespostaCerta = 2;
        q74.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q74);

        var q75 = new Questao();
        q75.NivelResposta = 8;
        q75.Pergunta = "O que é a teoria da 'relatividade geral' de Einstein?";
        q75.Resposta1 = "Uma teoria que descreve a interação entre energia e a expansão do universo.";
        q75.Resposta2 = "Uma teoria que unifica a gravidade e o eletromagnetismo em uma única força.";
        q75.Resposta3 = "Uma teoria que relaciona a curvatura do espaço-tempo com a distribuição de massa e energia.";
        q75.Resposta4 = "Uma teoria que propõe que o tempo flui mais rapidamente em regiões de baixa densidade gravitacional.";
        q75.Resposta5 = "Uma teoria que postula que todas as leis físicas são invariantes sob transformações relativísticas.";
        q75.RespostaCerta = 3;
        q75.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q75);

        var q76 = new Questao();
        q76.NivelResposta = 8;
        q76.Pergunta = "Qual é o conceito por trás da 'interpretação de muitos mundos' da mecânica quântica?";
        q76.Resposta1 = "Que cada partícula quântica tem um estado único e bem definido em um universo paralelo.";
        q76.Resposta2 = "Que todas as possíveis histórias de uma partícula ocorrem simultaneamente, em diferentes universos.";
        q76.Resposta3 = "Que o universo quântico é indeterminado até ser observado por um agente consciente.";
        q76.Resposta4 = "Que os estados quânticos são irreversíveis e só podem ser observados uma vez.";
        q76.Resposta5 = "Que cada universo é composto por infinitas partículas entrelaçadas.";
        q76.RespostaCerta = 2;
        q76.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q76);

        var q77 = new Questao();
        q77.NivelResposta = 8;
        q77.Pergunta = "O que afirma o 'teorema de incompletude de Gödel'?";
        q77.Resposta1 = "Que em qualquer sistema formal consistente, há proposições verdadeiras que não podem ser provadas dentro do sistema.";
        q77.Resposta2 = "Que todas as proposições matemáticas podem ser provadas verdadeiras ou falsas dentro de um sistema formal.";
        q77.Resposta3 = "Que sistemas formais complexos podem provar sua própria consistência.";
        q77.Resposta4 = "Que todo sistema formal deve ser completo para ser consistente.";
        q77.Resposta5 = "Que axiomas são sempre suficientes para provar todas as proposições verdadeiras.";
        q77.RespostaCerta = 1;
        q77.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q77);

        var q78 = new Questao();
        q78.NivelResposta = 8;
        q78.Pergunta = "Qual é o conceito da 'dualidade onda-partícula' na física quântica?";
        q78.Resposta1 = "Partículas podem se comportar como ondas ou partículas, dependendo da forma como são medidas.";
        q78.Resposta2 = "Ondas eletromagnéticas podem ser quantizadas em pacotes de energia denominados partículas.";
        q78.Resposta3 = "Todas as partículas possuem uma contraparte ondulatória em um universo paralelo.";
        q78.Resposta4 = "A energia de uma partícula depende da velocidade com que sua onda associada se propaga.";
        q78.Resposta5 = "Ondas quânticas podem colapsar para estados de partículas sob certas condições.";
        q78.RespostaCerta = 1;
        q78.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q78);

        var q79 = new Questao();
        q79.NivelResposta = 8;
        q79.Pergunta = "O que é a 'entropia' no contexto da termodinâmica?";
        q79.Resposta1 = "A quantidade de energia potencial que um sistema pode liberar.";
        q79.Resposta2 = "Uma medida da desordem ou aleatoriedade em um sistema físico.";
        q79.Resposta3 = "A quantidade de energia que pode ser convertida em trabalho útil.";
        q79.Resposta4 = "A capacidade de um sistema retornar ao equilíbrio após uma perturbação.";
        q79.Resposta5 = "A quantidade de calor necessário para alterar a fase de uma substância.";
        q79.RespostaCerta = 2;
        q79.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q79);

        // 80
        var q80 = new Questao();
        q80.NivelResposta = 8;
        q80.Pergunta = "Qual é o principal ingrediente do guacamole?";
        q80.Resposta1 = "Tomate";
        q80.Resposta2 = "Cebola";
        q80.Resposta3 = "Abacate";
        q80.Resposta4 = "Pimentão";
        q80.Resposta5 = "Limão";
        q80.RespostaCerta = 3;
        listaTodasQuestoes.Add(q80);

        // 81
        var q81 = new Questao();
        q81.NivelResposta = 9;
        q81.Pergunta = "O que é a 'teoria M' na física teórica?";
        q81.Resposta1 = "Uma unificação de todas as teorias de supercordas em uma única teoria abrangente.";
        q81.Resposta2 = "Uma teoria que postula a existência de 11 dimensões no universo.";
        q81.Resposta3 = "Uma proposta que relaciona a gravidade quântica com a teoria das supercordas.";
        q81.Resposta4 = "Uma explicação da relação entre partículas e forças fundamentais em um único quadro.";
        q81.Resposta5 = "Uma teoria que descreve a evolução do universo a partir do Big Bang.";
        q81.RespostaCerta = 1;
        q81.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q81);

        var q82 = new Questao();
        q82.NivelResposta = 9;
        q82.Pergunta = "O que afirma o teorema de Poincaré sobre a topologia?";
        q82.Resposta1 = "Todo espaço topológico conexo e compacto é homeomórfico a uma esfera.";
        q82.Resposta2 = "Todo espaço compacto é homeomórfico a um espaço euclidiano de dimensão n.";
        q82.Resposta3 = "Um espaço simplesmente conexo de dimensão 3 é homeomórfico a uma esfera tridimensional.";
        q82.Resposta4 = "Todo espaço topológico de dimensão 4 pode ser reduzido a um espaço de dimensão 3.";
        q82.Resposta5 = "Um espaço conexo é sempre compacto.";
        q82.RespostaCerta = 3;
        q82.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q82);

        var q83 = new Questao();
        q83.NivelResposta = 9;
        q83.Pergunta = "Qual é o significado da 'dualidade onda-partícula' na mecânica quântica?";
        q83.Resposta1 = "As partículas subatômicas podem ser descritas como ondas ou partículas dependendo da observação.";
        q83.Resposta2 = "A relação entre a velocidade e a frequência de ondas é uma propriedade das partículas.";
        q83.Resposta3 = "Todas as partículas têm uma contrapartida ondulatória em universos paralelos.";
        q83.Resposta4 = "As partículas subatômicas são ondas em sua natureza, mas se comportam como partículas ao serem medidas.";
        q83.Resposta5 = "Os estados quânticos podem ser representados como superposições de ondas.";
        q83.RespostaCerta = 1;
        q83.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q83);

        var q84 = new Questao();
        q84.NivelResposta = 9;
        q84.Pergunta = "O que é a 'teoria do tudo' na física?";
        q84.Resposta1 = "Uma teoria que combina todas as forças fundamentais da natureza em uma única equação.";
        q84.Resposta2 = "Uma hipótese que sugere que todas as partículas são manifestações de cordas vibrantes.";
        q84.Resposta3 = "Uma proposta que tenta explicar a origem do universo a partir do vácuo quântico.";
        q84.Resposta4 = "Uma teoria que descreve o comportamento da matéria escura e da energia escura.";
        q84.Resposta5 = "Uma teoria que relaciona a gravidade e a mecânica quântica.";
        q84.RespostaCerta = 1;
        q84.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q84);

        var q85 = new Questao();
        q85.NivelResposta = 9;
        q85.Pergunta = "O que é 'entropia' no contexto da segunda lei da termodinâmica?";
        q85.Resposta1 = "A medida da quantidade de energia disponível em um sistema para realizar trabalho.";
        q85.Resposta2 = "Uma medida da desordem ou aleatoriedade em um sistema isolado que sempre aumenta.";
        q85.Resposta3 = "A quantidade de energia que um sistema pode dissipar ao longo do tempo.";
        q85.Resposta4 = "Uma medida da eficiência de uma máquina térmica.";
        q85.Resposta5 = "A relação entre a temperatura e a pressão em um sistema fechado.";
        q85.RespostaCerta = 2;
        q85.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q85);

        var q86 = new Questao();
        q86.NivelResposta = 9;
        q86.Pergunta = "Qual é a premissa fundamental da 'teoria da relatividade geral' de Einstein?";
        q86.Resposta1 = "A gravidade é uma curvatura do espaço-tempo causada pela presença de massa.";
        q86.Resposta2 = "O espaço e o tempo são conceitos independentes que não se influenciam.";
        q86.Resposta3 = "A gravidade é uma força que atua à distância entre duas massas.";
        q86.Resposta4 = "O tempo é constante em todos os sistemas de referência.";
        q86.Resposta5 = "A luz viaja a diferentes velocidades em diferentes meios.";
        q86.RespostaCerta = 1;
        q86.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q86);

        var q87 = new Questao();
        q87.NivelResposta = 9;
        q87.Pergunta = "O que significa 'colapso da função de onda' na mecânica quântica?";
        q87.Resposta1 = "É a transição de um estado quântico superposto para um estado definido após uma medição.";
        q87.Resposta2 = "O fenômeno onde partículas subatômicas se separam em estados divergentes.";
        q87.Resposta3 = "A mudança de energia de uma partícula durante uma interação.";
        q87.Resposta4 = "A transformação de um estado clássico em um estado quântico.";
        q87.Resposta5 = "É a perda de informação quântica em um sistema isolado.";
        q87.RespostaCerta = 1;
        q87.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q87);

        var q88 = new Questao();
        q88.NivelResposta = 9;
        q88.Pergunta = "O que é a 'física quântica' no contexto das interações fundamentais?";
        q88.Resposta1 = "Um ramo da física que descreve o comportamento de partículas em escalas subatômicas.";
        q88.Resposta2 = "Uma teoria que busca unificar a mecânica clássica e a relatividade.";
        q88.Resposta3 = "Um modelo que explica como a gravidade e a eletromagnetismo se interagem.";
        q88.Resposta4 = "Um conjunto de leis que regem o movimento de objetos macroscópicos.";
        q88.Resposta5 = "Uma teoria que investiga as propriedades dos buracos negros e sua relação com a gravidade.";
        q88.RespostaCerta = 1;
        q88.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q88);

        var q89 = new Questao();
        q89.NivelResposta = 9;
        q89.Pergunta = "Qual é o 'princípio de exclusão de Pauli' na mecânica quântica?";
        q89.Resposta1 = "Nenhuma partícula idêntica pode ocupar o mesmo estado quântico simultaneamente.";
        q89.Resposta2 = "Os elétrons em um átomo devem ter spins opostos.";
        q89.Resposta3 = "O movimento de partículas é restrito a níveis de energia discretos.";
        q89.Resposta4 = "As partículas têm uma natureza dual, comportando-se como partículas e ondas.";
        q89.Resposta5 = "Toda partícula tem uma antipartícula correspondente que anula sua existência.";
        q89.RespostaCerta = 1;
        q89.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q89);

        var q90 = new Questao();
        q90.NivelResposta = 9;
        q90.Pergunta = "O que é um 'buraco negro' em astrofísica?";
        q90.Resposta1 = "Uma região do espaço onde a gravidade é tão intensa que nada pode escapar dela, nem mesmo a luz.";
        q90.Resposta2 = "Um tipo de estrela que emite radiação em níveis extremos antes de colapsar.";
        q90.Resposta3 = "Um objeto astronômico que se formou a partir da fusão de estrelas de nêutrons.";
        q90.Resposta4 = "Uma massa estelar que expulsa materia negra";

        // 91
        var q91 = new Questao();
        q91.NivelResposta = 10;
        q91.Pergunta = "O que é a 'conjectura de Hodge' em geometria algébrica?";
        q91.Resposta1 = "Afirma que a classe de cohomologia de Hodge é isomórfica à classe de cohomologia de De Rham.";
        q91.Resposta2 = "Postula que todas as variedades algébricas podem ser descritas em termos de formas diferenciais.";
        q91.Resposta3 = "Sugere que a decomposição de classes de cohomologia pode ser feita em termos de classes de Hodge.";
        q91.Resposta4 = "Afirma que as classes de Hodge são invariantes sob transformações de birracionalidade.";
        q91.Resposta5 = "Estabelece uma relação entre a topologia de uma variedade e sua estrutura analítica.";
        q91.RespostaCerta = 1;
        q91.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q91);

        var q92 = new Questao();
        q92.NivelResposta = 10;
        q92.Pergunta = "Qual é a essência do 'teorema de Noether' na física teórica?";
        q92.Resposta1 = "Cada simetria contínua de um sistema físico corresponde a uma lei de conservação.";
        q92.Resposta2 = "As leis da física são invariantes sob transformações discretas de tempo e espaço.";
        q92.Resposta3 = "As simetrias de um sistema determinam sua estabilidade a longo prazo.";
        q92.Resposta4 = "A energia é sempre conservada em sistemas com simetria temporal.";
        q92.Resposta5 = "As leis de conservação são apenas válidas em sistemas isolados e homogêneos.";
        q92.RespostaCerta = 1;
        q92.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q92);

        var q93 = new Questao();
        q93.NivelResposta = 10;
        q93.Pergunta = "O que é o 'paradoxo de Banach-Tarski' na matemática?";
        q93.Resposta1 = "Um teorema que demonstra que é possível dividir uma esfera em partes finitas e reconstituí-la em duas esferas do mesmo tamanho.";
        q93.Resposta2 = "Uma conjectura que sugere a impossibilidade de dividir um conjunto infinito de maneira que preserve sua cardinalidade.";
        q93.Resposta3 = "A afirmação de que não existem conjuntos infinitos com propriedades semelhantes a conjuntos finitos.";
        q93.Resposta4 = "Uma proposição que postula que conjuntos infinitos podem ser manipulados como números finitos.";
        q93.Resposta5 = "Um teorema que explica a natureza dos conjuntos não mensuráveis.";
        q93.RespostaCerta = 1;
        q93.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q93);

        var q94 = new Questao();
        q94.NivelResposta = 10;
        q94.Pergunta = "Qual é a teoria da 'quantização da gravidade' em física teórica?";
        q94.Resposta1 = "Uma tentativa de descrever a gravidade utilizando princípios da mecânica quântica.";
        q94.Resposta2 = "A ideia de que todos os campos fundamentais devem ser quantizados em uma única estrutura.";
        q94.Resposta3 = "A aplicação de métodos estatísticos na descrição do comportamento gravitacional.";
        q94.Resposta4 = "Uma abordagem que considera a gravidade como uma força mediada por partículas bosônicas.";
        q94.Resposta5 = "Um conceito que propõe que a gravidade é uma propriedade emergente de sistemas quânticos.";
        q94.RespostaCerta = 1;
        q94.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q94);

        var q95 = new Questao();
        q95.NivelResposta = 10;
        q95.Pergunta = "O que é o 'princípio da incerteza' de Heisenberg?";
        q95.Resposta1 = "É impossível conhecer simultaneamente a posição e a velocidade de uma partícula com precisão arbitrária.";
        q95.Resposta2 = "A incerteza se refere apenas a medidas realizadas em partículas em estados excitados.";
        q95.Resposta3 = "As medições em sistemas quânticos alteram o estado do sistema de forma determinística.";
        q95.Resposta4 = "As incertezas podem ser minimizadas ao aumentar a precisão dos instrumentos de medição.";
        q95.Resposta5 = "Todas as medições têm um limite superior de precisão que pode ser ultrapassado.";
        q95.RespostaCerta = 1;
        q95.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q95);

        var q96 = new Questao();
        q96.NivelResposta = 10;
        q96.Pergunta = "Qual é o impacto do 'teorema de Gödel' na lógica e na matemática?";
        q96.Resposta1 = "Ele demonstra que em qualquer sistema formal consistente, existem proposições que não podem ser provadas ou refutadas.";
        q96.Resposta2 = "Ele garante que todos os axiomas da aritmética são completos e consistentes.";
        q96.Resposta3 = "Ele estabelece que todos os teoremas matemáticos podem ser provados com um número finito de passos.";
        q96.Resposta4 = "Ele assegura que a lógica clássica pode ser aplicada a todos os sistemas formais.";
        q96.Resposta5 = "Ele fornece um método para encontrar contradições em sistemas consistentes.";
        q96.RespostaCerta = 1;
        q96.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q96);

        var q97 = new Questao();
        q97.NivelResposta = 10;
        q97.Pergunta = "O que caracteriza a 'teoria da informação quântica'?";
        q97.Resposta1 = "A aplicação de princípios quânticos para processar e transmitir informações.";
        q97.Resposta2 = "Uma nova forma de descrever a informação utilizando lógica clássica.";
        q97.Resposta3 = "A ideia de que a informação é sempre preservada em sistemas físicos.";
        q97.Resposta4 = "A relação entre a quantidade de informação e a energia necessária para sua transmissão.";
        q97.Resposta5 = "A aplicação de teorias da computação clássica em sistemas quânticos.";
        q97.RespostaCerta = 1;
        q97.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q97);

        var q98 = new Questao();
        q98.NivelResposta = 10;
        q98.Pergunta = "O que é o 'multiverso' na cosmologia?";
        q98.Resposta1 = "A hipótese de que existem múltiplos universos, cada um com suas próprias leis físicas.";
        q98.Resposta2 = "Um conceito que sugere que o universo é um sistema fechado e não pode interagir com outros.";
        q98.Resposta3 = "A ideia de que nosso universo é o único e isolado no espaço-tempo.";
        q98.Resposta4 = "Uma teoria que descreve como os buracos negros se conectam a outros universos.";
        q98.Resposta5 = "A proposição de que todos os universos têm as mesmas propriedades físicas.";
        q98.RespostaCerta = 1;
        q98.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q98);

        var q99 = new Questao();
        q99.NivelResposta = 10;
        q99.Pergunta = "O que é a 'conjectura de Poincaré' em topologia?";
        q99.Resposta1 = "Afirma que uma variedade tridimensional que é simplesmente conexa é homeomórfica a uma esfera tridimensional.";
        q99.Resposta2 = "Postula que todas as superfícies fechadas são homeomórficas a um disco.";
        q99.Resposta3 = "Sugere que todos os espaços euclidianos são homeomórficos entre si.";
        q99.Resposta4 = "Estabelece que os sólidos de revolução têm propriedades topológicas equivalentes.";
        q99.Resposta5 = "Alega que a homotopia de um espaço topológico pode ser reduzida a um ponto.";
        q99.RespostaCerta = 1;
        q99.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q99);

        var q100 = new Questao();
        q100.NivelResposta = 10;
        q100.Pergunta = "O que é a 'teoria da relatividade geral' de Einstein e suas implicações?";
        q100.Resposta1 = "Descreve a gravidade como uma curvatura do espaço-tempo causada pela massa e energia.";
        q100.Resposta2 = "Afirmou que a gravidade é uma força fundamental que atua à distância entre massas.";
        q100.Resposta3 = "Postula que o espaço e o tempo são entidades independentes que não se influenciam.";
        q100.Resposta4 = "Sugere que a gravidade é uma propriedade emergente da interação eletromagnética.";
        q100.Resposta5 = "Estabelece que a luz se propaga em linha reta em campos gravitacionais variáveis.";
        q100.RespostaCerta = 1;
        q100.ConfiguraEstruturaDesenho(labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
        listaTodasQuestoes.Add(q100);
    }

    public void ProximaQuestao()
    {

        var listaQuestoes = listaTodasQuestoes.Where(d => d.NivelResposta == NivelResposta).ToList();
        var numRandom = Random.Shared.Next(0, listaTodasQuestoes.Count);
        var NovaQuestao = listaTodasQuestoes[numRandom];

        while (listaTodasQuestaoRespondidas.Contains(NovaQuestao))
        {
            numRandom = Random.Shared.Next(0, listaTodasQuestoes.Count - 1);
            NovaQuestao = listaTodasQuestoes[numRandom];
        }

        listaTodasQuestaoRespondidas.Add(NovaQuestao);
        questaoAtual = listaTodasQuestoes[numRandom];
        questaoAtual.Desenhar();
    }

    public async void VerificaCorreta(int rr)
    {
        if (questaoAtual.VerificaResposta(rr))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelResposta);
            NivelResposta++;
            ProximaQuestao();
            labelPontuacao.Text = "Nível: " + NivelResposta.ToString();
            labelNivel.Text = "Pontuação: " + Pontuacao.ToString();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Game Over", "Você perdeu", "Ok");
            Initialize();
        }
    }

    void AdicionaPontuacao(int n)
    {
        if (n == 1)
        {
            Pontuacao = 1000;
        }
        if (n == 2)
        {
            Pontuacao = 2000;
        }
        if (n == 3)
        {
            Pontuacao = 5000;
        }
        if (n == 4)
        {
            Pontuacao = 10000;
        }
        if (n == 5)
        {
            Pontuacao = 20000;
        }
        if (n == 6)
        {
            Pontuacao = 50000;
        }
        if (n == 7)
        {
            Pontuacao = 100000;
        }
        if (n == 8)
        {
            Pontuacao = 200000;
        }
        if (n == 9)
        {
            Pontuacao = 500000;
        }
        if (n == 10)
        {
            Pontuacao = 1000000;
        }
    }
}