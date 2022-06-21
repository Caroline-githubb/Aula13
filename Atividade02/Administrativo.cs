using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02
{
    internal class Administrativo : Escola
    {
        private Aluno aluno;
        // 2.1. Adicionar chave/valor
        public void addAluno()
        { 
            Aluno.Add("RJ", "Rio de Janeiro");
            Aluno.Add("SP", "São Paulo");
            Aluno.Add("MG", "Minas Gerais");
        }




        // 2.2. Remover chave/valor
        public void RemoverAluno()
        {
           this.aluno = new Aluno();
            

            
        }
            



        // 2.3. Listar
            public void listAlunos()
        {
            foreach (KeyValuePair<int, string> local in UF)
            {
                Console.WriteLine($"{local.Key} {local.Value}");
            }
        }
    }
}
