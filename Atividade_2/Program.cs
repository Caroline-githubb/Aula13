namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola();
            escola.CadastrarAluno();
            escola.RemoverAluno();
            escola.ListarMatriculas();
        }
    }
}