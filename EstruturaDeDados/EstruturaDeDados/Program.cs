internal class Program
{
    private static void Main(string[] args)
    {
        // Trabalhando com lista (list)
        //Criando uma lista

        List<string> frutas = new List<string>();

        // Adicionar itens na lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        // Imprimir os itens da lista 
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine();
        //Console.WriteLine("Minha lista de frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}

        frutas.ForEach(Console.WriteLine);
        Console.WriteLine(); // Pula linha em branco

        // Imprimir elemento na posição específica
        Console.WriteLine("Fruta no índice 2:" + frutas[2]);

        // Inserir um elemento no índice específico
        frutas.Insert(1, "Maracujá");

        // Imprimindo a lista novamente
        Console.WriteLine(); // Pula linha em branco

        //Console.WriteLine("Minha lista de frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine();
        // Alterar um elemento no índice específico
        frutas[4] = "Pêra";
        // Imprimindo a lista novamente
        //Console.WriteLine(); // Pula linha em branco
        //Console.WriteLine("Minha lista de frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}

        frutas.ForEach(Console.WriteLine);
        Console.WriteLine();
        // Remover elementos da lista no índice específico
        frutas.RemoveAt(3);

        // Remover elementos pelo valor do conteúdo
        frutas.Remove("Morango");

        // Imprimindo a lista novamente
        //Console.WriteLine(); // Pula linha em branco
        //Console.WriteLine("Minha lista de frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine();
        // Apagar todos os elementos da lista
        frutas.Clear();
    }
}