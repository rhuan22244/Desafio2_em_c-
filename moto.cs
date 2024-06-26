public class Moto : Veiculo
{
    public override void Acelerar()
    {
        Console.WriteLine("Moto acelerando");
        velocidade += 15;
    }

    public override void Frear()
    {
        Console.WriteLine("Moto freando");
        velocidade = velocidade - 15;
    }
}