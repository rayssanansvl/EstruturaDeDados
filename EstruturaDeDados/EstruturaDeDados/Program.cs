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

        // Trabalhando com dicionário (dictionary)

        // Criando um dicionário de dados
        Dictionary<int, string> carros = new Dictionary<int, string>();
        // Adicionar dados a um dicionário
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        Console.WriteLine(); // Pula linha em branco
        Console.WriteLine("=============================================");
        Console.WriteLine(); // Pula linha em branco

        Console.WriteLine("Meu dicionário de carros:");
        // Imprimir um dicionario de dados
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }

        Console.WriteLine(); // Pula linha em branco
        Console.WriteLine("=============================================");
        Console.WriteLine(); // Pula linha em branco

        // Trabalhando com fila
        // Criar um fila (Queue)
        Queue<string> filaBanco = new Queue<string>();

        // Adicionar elementos em uma fila
        filaBanco.Enqueue("André");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("Bia");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }
        // retirar o primeiro elemento de uma fila
        filaBanco.Dequeue();

        Console.WriteLine(); // Pula linha em branco
        Console.WriteLine("=============================================");
        Console.WriteLine(); // Pula linha em branco
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // Verificar se existe um elemento na fila

        bool achou = filaBanco.Contains("Bia");

        if (achou)
        {
            Console.WriteLine("A pessoa está na fila!");
        }
        else
        {
            Console.WriteLine("A pessoa não está na fila!");
        }

        Console.WriteLine(); // Pula linha em branco
        Console.WriteLine("=============================================");
        Console.WriteLine(); // Pula linha em branco

        // Trabalhando com pilha (Stack)
        // Criando uma pilha
        Stack<string> livros = new Stack<string>();

        // Adicionar elementos em uma pilha
        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de Neve e os Sete Anões");
        livros.Push("Princesa e o Sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine(); // Pula linha em branco
        Console.WriteLine("=============================================");
        Console.WriteLine(); // Pula linha em branco

        // Remove o primeiro elemento da pilha
        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine(); // Pula linha em branco
        Console.WriteLine("=============================================");
        Console.WriteLine(); // Pula linha em branco
    }



}