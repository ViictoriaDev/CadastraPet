public class Pet
{
    public string Nome { get; set; } = default!;
    public int Idade { get; set; }
    public string Sexo { get; set; } = default!;
    public string Vacinas { get; set; } = default!;
    public double Peso { get; set; }
    public string Tamanho { get; set; } = default!;

    public virtual void Cadastrar() //virtual para permitir que as classes filhas sobrescrevam o método
    {
        Console.WriteLine("Complete as informações do seu bichinho:");
        Console.Write("Nome: ");
        Nome = Console.ReadLine()!;
        Console.Write("Idade: ");
        Idade = int.Parse(Console.ReadLine()!);
        Console.Write("Sexo: ");
        Sexo = Console.ReadLine()!;
        Console.Write("Últimas 3 vacinas que tomou e as datas: ");
        Vacinas = Console.ReadLine()!;
        Console.Write("Peso em kg (digite somente o número e vírgula - exemplo 1,200): ");
        Peso = double.Parse(Console.ReadLine()!);
        Console.Write("Tamanho (pequeno, médio ou grande): ");
        Tamanho = Console.ReadLine()!;

    }

    public void ExibeFilhotes(List<Pet> cadastrados)
    {
        if (cadastrados.Count == 0)
        {
            Console.WriteLine("\nNão há nenhum pet cadastrado!");
        }
        //Implementando LINQ
        var filhotes = cadastrados
        .Where(p => p.Idade == 1)
        .Select(p => p.Nome);

        foreach (var nomeIdade in filhotes)
        {
            Console.WriteLine(nomeIdade);
        }
    }

    public void ConsultaPets(List<Pet> cadastrados)
    {
        foreach (var pets in cadastrados)
        {
            Console.WriteLine(pets.Nome, pets.Idade, pets.Sexo);
        }
    }
}