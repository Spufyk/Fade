using Mid;

public abstract class IAjuda{
    protected Button Resposta01;
    protected Button Resposta02;
    protected Button Resposta03;
    protected Button Resposta04;
    protected Button Resposta05;
    protected Frame labelAjuda;

    public void ConfiguraEstruturaDesenho(Button Resposta01, Button Resposta02, Button Resposta03, Button Resposta04, Button Resposta05){
        this.Resposta01 = Resposta01;
        this.Resposta02 = Resposta02;
        this.Resposta03 = Resposta03;
        this.Resposta04 = Resposta04;
        this.Resposta05 = Resposta05;
    }

    public void ConfiguraEstruturaDesenho(Frame AjudaFrame){
        this.labelAjuda = labelAjuda;
    }

    public abstract void RealizaAjuda(Questao questao);
}