public class Reptil : Pet
{
    public string Especie { get; set; } = default!;
    public string TipoPele { get; set; } = default!;
    public string Habitat { get; set; } = default!;
    public string Alimentacao { get; set; } = default!;

    public override void Cadastrar()
    {
        base.Cadastrar();
        Console.Write("Espécie: ");
        Especie = Console.ReadLine()!;
        Console.Write("Tipo de pele: ");
        TipoPele = Console.ReadLine()!;
        Console.Write("Habitat (ambiente quente, frio, temp. ambiente, gaiola, ar livre): ");
        Habitat = Console.ReadLine()!;
        Console.Write("Alimentação (o que come no dia-a-dia): ");
        Alimentacao = Console.ReadLine()!;
    }
}