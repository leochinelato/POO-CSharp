using GerBiblioteca;

Livro livro1 = new("H.P e a Pedra Filosofal", "J.K. Rowling", "Fantasia", 400);
Livro livro2 = new("O senhor dos aneis", "J.R.R. Tolkien", "Fantasia", 1000);

Cliente cliente1 = new("Leonardo", "k1d0b2n3");
Cliente cliente2 = new("Luana", "1vds3093");

Biblioteca biblioteca = new();

biblioteca.AdicionarLivro(livro1);
biblioteca.AdicionarLivro(livro2);

biblioteca.CadastrarCliente(cliente1);
biblioteca.CadastrarCliente(cliente2);

biblioteca.RealizarEmprestimo(cliente1, livro1);
biblioteca.RealizarEmprestimo(cliente2, livro2);

biblioteca.RegistrarDevolucao(cliente1, livro1);

Console.WriteLine("Detalhe dos livros:");
livro1.ExibirDetalhes();

Console.WriteLine("Detalhe dos clientes:");
cliente1.ExibirDetalhes();
cliente2.ExibirDetalhes();