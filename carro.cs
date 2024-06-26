public class Carro : Veiculo
{
    public override void Acelerar()
    {
        velocidade = velocidade + 10;
    }

    public override void Frear()
    {
        velocidade = velocidade - 5;
    }
}