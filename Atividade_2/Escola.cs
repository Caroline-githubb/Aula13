using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    public class Escola
    {
        public Dictionary<int, Aluno> Matriculados = new Dictionary<int, Aluno>();

        public void CadastrarAluno()
        {
            Console.Write("Informe o código do novo aluno: ");
            int codigo = int.Parse(Console.ReadLine() ?? string.Empty);
            if(this.Matriculados.ContainsKey(codigo)) //caso não tenha a operação que o usuário digitar, aparecerá a mensagem
            {
                throw new Exception("O código informado já existe!");
            }
            Console.WriteLine("Digite os dados do Aluno que deseja cadastrar:");
            Aluno aluno = new Aluno();
            aluno = LerAluno();
            Matriculados.Add(codigo, aluno);
        }
        public void RemoverAluno()
        {
            Console.WriteLine("Qual Aluno deseja remover? ");
            foreach (KeyValuePair<int, Aluno> local in Matriculados)
            {
                Console.WriteLine($"Digite {local.Key} para remover {local.Value.Nome}");
            }
            int alunoRemovido = int.Parse(Console.ReadLine() ?? string.Empty);
            Matriculados.Remove(alunoRemovido);
            Console.WriteLine("Aluno removido com sucesso!");
            Console.WriteLine("---------------------------------");
        }
        public void ListarMatriculas()
        {
            Console.WriteLine("Lista atualizada: ");
            foreach (KeyValuePair<int, Aluno> local in Matriculados)
            {
                Console.WriteLine($"{local.Key} - {local.Value.Nome}");
            }
        }

        public Aluno LerAluno()
        {
            Aluno alunoMatriculado = new Aluno();
            Console.Write("Digite a matricula: ");
            alunoMatriculado.Matricula = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Digite o nome: ");
            alunoMatriculado.Nome = Console.ReadLine() ?? string.Empty;
            Console.Write("Digite o sobrenome: ");
            alunoMatriculado.Sobrenome = Console.ReadLine() ?? string.Empty;
            Console.Write("Digite o telefone: ");
            alunoMatriculado.Telefone = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("---------------------------------");
            return alunoMatriculado;
        }
    }
}

