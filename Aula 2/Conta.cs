class Conta{
    public string numero;
    public string titular;
    public decimal saldo;

    //construtor
    public Conta(string num, string tit, decimal sal){
        this.numero = num;
        this.titular = tit;
        this.saldo = sal;
    }
    //métodos
    public string mostrarDados(){
        string texto="";

        texto += "Conta " + this.numero;
        texto += " do correnteista " + this.titular;
        texto += " com saldo de " + this.saldo.ToString();

        return texto;
    }


}