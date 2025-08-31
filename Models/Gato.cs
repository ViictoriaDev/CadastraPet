public class Gato : Pet
{
    public string Raca { get; set; } = default!;
    public string ComprimentoPelo { get; set; } = default!;

    public override void Cadastrar()
    {
        base.Cadastrar();
        Console.Write("Raça: ");
        Raca = Console.ReadLine()!;
        Console.Write("Comprimento do pelo (pequeno, médio ou grande): ");
        ComprimentoPelo = Console.ReadLine()!;
    }
}