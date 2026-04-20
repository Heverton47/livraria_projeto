using System;

public class livro
{
    public string titulo;
    public string autor;
    public string genero;
    public double preco;

    public livro(string titulo, string autor, string genero, double preco)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.genero = genero;
        this.preco = preco;
    }
}

class Program
{
    public static void MostrarMenu(){
        Console.WriteLine("\n===== LIVRARIA =====\n");
        Console.WriteLine("1 - Cadastrar livro");
        Console.WriteLine("2 - Listar livros");
        Console.WriteLine("3 - Buscar livro");
        Console.WriteLine("4 - Carrinho de compras");        
        Console.WriteLine("5 - Sair");
    }

    public static void CadastrarLivro(int senha){
        if (senha == 1234)
        {
            Console.WriteLine("Acesso concedido. Por favor, informe os dados do livro:");

            Console.Write("Titulo: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Qual o Genero?:\n1 - Romance\n2 - Ficcao Cientifica\n3 - Fantasia\n4 - Biografia\n");
            int escolhaGenero = int.Parse(Console.ReadLine());
            string genero = "";
            switch (escolhaGenero)
            {
                case 1:
                    genero = "Romance";
                    break;
                case 2:
                    genero = "Ficcao Cientifica";
                    break;
                case 3:
                    genero = "Fantasia";
                    break;
                case 4:
                    genero = "Biografia";
                    break;
            }

            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            while (preco < 10.00){
                Console.WriteLine("Valor minimo de R$ 10,00 - Digite um novo valor valido\n");
                Console.Write("Preco: ");
                preco = double.Parse(Console.ReadLine());
            }
            livro novoLivro = new livro(titulo, autor, genero, preco);
            Console.WriteLine("Livro cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Senha incorreta. Acesso negado.");
        }
    }

    static void Main()
    {
        livro l1 = new livro("O Senhor dos Aneis", "J.R.R. Tolkien", "Fantasia", 39.90);
        livro l2 = new livro("Harry Potter e a Pedra Filosofal", "J.K. Rowling", "Fantasia", 29.90);

        livro l3 = new livro("Duna", "Frank Herbert", "Ficcao Cientifica", 68.00);
        livro l4 = new livro("O Guia do Mochileiro das Galaxias", "Douglas Adams", "Ficcao Cientifica", 24.90);

        livro l5 = new livro("Romeu e Julieta", "William Shakespeare", "Romance", 19.90);
        livro l6 = new livro("A culpa e das estrelas", "John Green", "Romance", 19.90);
        
        livro l7 = new livro("Anne Frank: A Historia de uma Vida", "Anne Frank", "Biografia", 24.90);
        livro l8 = new livro("Eu Sou Malala", "Malala Yousafzai", "Biografia", 29.90);

        bool sair = true;
        while (sair)        {
            MostrarMenu();
            Console.Write("Escolha uma opcao: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Bem-vindo ao cadastro de livros!");
                    Console.WriteLine("Poderia me informar sua senha de acesso? (Digite '1234' para acessar o cadastro)");
                    int senha = int.Parse(Console.ReadLine());
                    CadastrarLivro(senha);
                    // AINDA VAI FALTAR ADICIONAR A MECÂNICA DA LISTA DE LIVROS DENTRO DO CADASTRO, MAS DE RESTO ESTÁ FUNCIONANDO
                    break;
                case 2:
                    // Lógica para listar livros
                    break;
                case 3:
                    // Lógica para buscar livro
                    break;
                case 4:
                    // Lógica para carrinho de compras
                    break;
                case 5:
                    sair = false;
                    Console.WriteLine("Ate logo!");
                    break;
                default:
                    Console.WriteLine("Opcao invalida. Tente novamente.");
                    break;
            }
        }
    }
}