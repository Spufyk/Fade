namespace Mid;

public class Questao{

    public string Pergunta;
    public string Resposta1;
    public string Resposta2;
    public string Resposta3;
    public string Resposta4;
    public string Resposta5;

    public int RespostaCerta;
    public int NivelResposta;

    private Label labelPergunta;

    private Button ButtonResposta1;
    private Button ButtonResposta2;
    private Button ButtonResposta3;
    private Button ButtonResposta4;
    private Button ButtonResposta5;

    public Questao(){
        
    }

    public Questao(Label labelPergunta, Button button1, Button button2, Button button3, Button button4, Button button5){
        this.labelPergunta = labelPergunta;
        ButtonResposta1 = button1;
        ButtonResposta2 = button2;
        ButtonResposta3 = button3;
        ButtonResposta4 = button4;
        ButtonResposta5 = button5;
    }

    public void ConfiguraEstruturaDesenho (Label labelPergunta, Button button1, Button button2, Button button3, Button button4, Button button5){
        this.labelPergunta = labelPergunta;
        ButtonResposta1 = button1;
        ButtonResposta2 = button2;
        ButtonResposta3 = button3;
        ButtonResposta4 = button4;
        ButtonResposta5 = button5;
    }

    public void Desenhar(){
        labelPergunta.Text = Pergunta;
        ButtonResposta1.Text = Resposta1;
        ButtonResposta2.Text = Resposta2;
        ButtonResposta3.Text = Resposta3;
        ButtonResposta4.Text = Resposta4;
        ButtonResposta5.Text = Resposta5;
    }

    private Button QualButton(int r){
        if(r == 1){
            return ButtonResposta1;
        }
        else if(r == 2){
            return ButtonResposta2;
        }
        else if (r == 3){
            return ButtonResposta3;
        }
        else if (r == 4){
            return ButtonResposta4;
        }
        else if (r == 5 ){
            return ButtonResposta5;
        }
        else{
            return null;
        }
    }

    public bool VerificaResposta(int rr){
        if(RespostaCerta == rr){
            var button = QualButton(rr);
            button.BackgroundColor = Colors.Green; //"#a1c9ae";
            return true;
        }
        else{
            var buttonCorreto = QualButton(RespostaCerta);
            var buttonIncorreto = QualButton(rr);
            buttonCorreto.BackgroundColor = Colors.Green; //"#a1c9ae";
            buttonIncorreto.BackgroundColor = Colors.Red; //#e88e8e;

            return false;
        }
    }
}