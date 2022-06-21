using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Escola : Aluno
    {
        public Dictionary<int, Aluno> Matriculados = new Dictionary<int, Aluno>();

        public void CadastrarAluno()
        {
            Console.Write("Quantos Alunos deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Aluno alunoMatriculado = new Aluno();
                Console.WriteLine("Digite os dados do aluno" + " " + (i + 1));
                Console.Write("Digite a matricula: ");
                alunoMatriculado.Matricula = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome: ");
                alunoMatriculado.Nome = Console.ReadLine();
                Console.Write("Digite o sobrenome: ");
                alunoMatriculado.Sobrenome = Console.ReadLine();
                Console.Write("Digite o telefone: ");
                alunoMatriculado.Telefone = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("---------------------------------");


                Matriculados.Add(i, alunoMatriculado);
            }

        }
        public void RemoverAluno()
        {
            Console.WriteLine("Qual Aluno deseja remover? ");
            foreach (KeyValuePair<int, Aluno> local in Matriculados)
            {
                Console.WriteLine($"Digite {local.Key} para remover {local.Value.Nome}");
            }
            int alunoRemovido = int.Parse(Console.ReadLine());
            Matriculados.Remove(alunoRemovido);
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
    }
}

