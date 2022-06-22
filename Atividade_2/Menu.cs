namespace Atividade_2
{
    public class Menu
    {

        public Dictionary<string, Escola> Opcoes = new Dictionary<string, Escola>();
        private Escola escola;

        public Menu()
        {
            this.escola = new Escola();
        }

        private int MostrarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("MENU DE OPÇÕES:"); 
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar Aluno");
            Console.WriteLine("2 - Remover Aluno");
            Console.WriteLine("3 - Listar Alunos");
            Console.WriteLine("0 - Terminar");
            Console.WriteLine("Sua opção: ");

            return int.Parse(Console.ReadLine() + "");
        }

        public void Iniciar()
        {
            int opcao; 
            do
            {   
                opcao = this.MostrarMenu();             
                try
                {
                    switch (opcao)
                    {
                        case 0:
                            break;
                        case 1:
                            escola.CadastrarAluno();
                            break;
                        case 2:
                            escola.RemoverAluno();
                            break;
                        case 3:
                            escola.ListarMatriculas();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (opcao != 0);
        }


    }
}
