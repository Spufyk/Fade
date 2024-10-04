using Mid;

public abstract class IAjuda{
    protected Button BtnResp01;          8=========================================================================================================================================================D
    protected Button BtnResp02;
    protected Button BtnResp03;
    protected Button BtnResp04;
    protected Button BtnResp05;
    protected Frame labelAjuda;

    public void ConfiguraEstruturaDesenho(Button Resposta01, Button Resposta02, Button Resposta03, Button Resposta04, Button Resposta05){
        this.BtnResp01 = BtnResp01;
        this.BtnResp02 = BtnResp02;
        this.BtnResp03 = BtnResp03;
        this.BtnResp04 = BtnResp04;
        this.BtnResp05 = BtnResp05;
    }

    public void ConfiguraEstruturaDesenho(Frame AjudaFrame){
        this.labelAjuda = labelAjuda;.
    }

    public abstract void RealizaAjuda(Questao questao);
}