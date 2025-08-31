//Menu de opções com switch-case

Console.WriteLine("\nBoas vindas ao PetCare!\n");
Console.WriteLine("Para começar, você precisa cadastrar o novo pet:");
string opcao = "";
List<Pet> cadastrados = new List<Pet>();

while (opcao != "sair")
{
    Console.WriteLine("\nDigite 1 para cachorros");
    Console.WriteLine("Digite 2 para gatos");
    Console.WriteLine("Digite 3 para répteis");
    Console.WriteLine("Digite 4 para pássaros");
    Console.WriteLine("Digite 5 para consultar os filhotes");
    Console.WriteLine("Digite 6 para consultar os pets com mais de um ano de idade");
    Console.Write("Escolha uma opção ou digite 'sair' para encerrar: ");

    opcao = Console.ReadLine()!;

    if (opcao == "sair")
    {
        Thread.Sleep(700);
        Console.WriteLine("Tchau tchau ;)");
        break;
    }

    if (int.TryParse(opcao, out int opcaoInt))
    {
        switch (opcaoInt)
        {
            case 1:
                Cachorro novoCachorro = new Cachorro();
                novoCachorro.Cadastrar();
                Thread.Sleep(600);
                Console.WriteLine("\nCadastro feito com sucesso!\n\nInformações registradas:\nNome: " + novoCachorro.Nome + "\nIdade: " + novoCachorro.Idade + "\nSexo: " + novoCachorro.Sexo + "\nÚltimas vacinas: " + novoCachorro.Vacinas + "\nPeso: " + novoCachorro.Peso + "\nTamanho: " + novoCachorro.Tamanho + "\nRaça: " + novoCachorro.Raca + "\nComprimento do pelo: " + novoCachorro.ComprimentoPelo);
                cadastrados.Add(novoCachorro);
                break;
            case 2:
                Gato gato = new Gato();
                gato.Cadastrar();
                Thread.Sleep(600);
                Console.WriteLine("\nCadastro feito com sucesso!\n\nInformações registradas:\nNome: " + gato.Nome + "\nIdade: " + gato.Idade + "\nSexo: " + gato.Sexo + "\nÚltimas vacinas: " + gato.Vacinas + "\nPeso: " + gato.Peso + "\nTamanho: " + gato.Tamanho + "\nRaça: " + gato.Raca + "\nComprimento do pelo: " + gato.ComprimentoPelo);
                cadastrados.Add(gato);
                break;
            case 3:
                Reptil reptil = new Reptil();
                reptil.Cadastrar();
                Thread.Sleep(600);
                Console.WriteLine("\nCadastro feito com sucesso!\n\nInformações registradas:\nNome: " + reptil.Nome + "\nIdade: " + reptil.Idade + "\nSexo: " + reptil.Sexo + "\nÚltimas vacinas: " + reptil.Vacinas + "\nPeso: " + reptil.Peso + "\nEspécie: " + reptil.Especie + "\nTamanho: " + reptil.Tamanho + "\nTipo de pele: " + reptil.TipoPele + "\nHabitat: " + reptil.Habitat + "\nAlimentação: " + reptil.Alimentacao);
                cadastrados.Add(reptil);
                break;
            case 4:
                Passaro passaro = new Passaro();
                passaro.Cadastrar();
                Thread.Sleep(600);
                Console.WriteLine("\nCadastro feito com sucesso!\n\nInformações registradas:\nNome: " + passaro.Nome + "\nIdade: " + passaro.Idade + "\nSexo: " + passaro.Sexo + "\nÚltimas vacinas: " + passaro.Vacinas + "\nPeso: " + passaro.Peso + "\nEspécie: " + passaro.Especie + "\nTamanho: " + passaro.Tamanho + "\nHabitat: " + passaro.Habitat + "\nAlimentação: " + passaro.Alimentacao);
                cadastrados.Add(passaro);
                break;
            case 5:
                Pet petsCadastrados = new Pet();
                petsCadastrados.ExibeFilhotes(cadastrados);
                break;
            case 6:
                Pet todosPets = new Pet();
                todosPets.ConsultaPets(cadastrados);
                break;
        }
    }
}



