public class Cachorro : Pet
{
    public string Raca { get; set; } = default!;
    public string ComprimentoPelo { get; set; } = default!;

    public override void Cadastrar()
    {
        Console.Write("Raça: ");
        Raca = Console.ReadLine()!;
        Console.Write("Comprimento do pelo (curto, médio, grande): ");
        ComprimentoPelo = Console.ReadLine()!;
    }
}