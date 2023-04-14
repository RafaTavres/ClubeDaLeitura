using ClubeDaLeitura.ConsoleApp.Repositorios;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declaração de Repositorios e Telas
            string opcao ="";                           
            AmigoRepository amigoRepository = new AmigoRepository();    
            CaixaRepository caixaRepository = new CaixaRepository();
            RevistaRepositoty revistaRepositoty = new RevistaRepositoty();
            EmprestimoRepository emprestimoRepository = new EmprestimoRepository();
            revistaRepositoty.repositorioCaixa = caixaRepository;

            TelaAmigos telaAmigos = new TelaAmigos();
            telaAmigos.repositorioAmigo = amigoRepository;

            TelaCaixa telaCaixa = new TelaCaixa();
            telaCaixa.repositorioCaixa = caixaRepository;

            TelaRevistas telaRevistas = new TelaRevistas();
            telaRevistas.repositorioDeCaixas = caixaRepository;
            telaRevistas.telaCaixa = telaCaixa;
            telaRevistas.repositorioDeRevista = revistaRepositoty;

            TelaEmprestimo telaEmprestimo = new TelaEmprestimo();
            telaEmprestimo.repositorioAmigo = amigoRepository;
            telaEmprestimo.repositorioRevista = revistaRepositoty;
            telaEmprestimo.repositorioEmprestimo = emprestimoRepository;
            telaEmprestimo.telaAmigos = telaAmigos;
            telaEmprestimo.telaRevista = telaRevistas;
            #endregion

            do
            {          
                Console.Clear();
                Console.WriteLine("1- Menu Amigo | 2- Menu Revista | 3- Menu Caixa | 4- Menu Emprestimo | S- Sair");
                opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    telaAmigos.MenuAmigo(opcao);
                }
                if (opcao == "2")
                {
                    telaRevistas.MenuRevista(opcao);
                }
                if (opcao == "3")
                {
                    telaCaixa.MenuCaixa(opcao);
                }
                if (opcao == "4")
                {
                    telaEmprestimo.MenuEmprestimo(opcao);
                }

            } 
            while (opcao.ToUpper() != "S");
        
        }
    }
}