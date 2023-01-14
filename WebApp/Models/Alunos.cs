using System.Collections.Generic;

namespace WebApp.Models
{
    public class Alunos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string telefone { get; set; }
        public int ra { get; set; }

        public List<Alunos> listaAlunos()
        {
            Alunos aluno = new Alunos();
            aluno.id = 1;
            aluno.nome = "Wesley";
            aluno.sobrenome = "Gomes Queiroz";
            aluno.telefone = "11 958657154";
            aluno.ra = 00001;
            
            Alunos aluno1 = new Alunos();
            aluno1.id = 2;
            aluno1.nome = "Daisy";
            aluno1.sobrenome = "Galvão";
            aluno1.telefone = "11 958657154";
            aluno1.ra = 00002;

            List<Alunos> listaAlunos = new List<Alunos>();

            listaAlunos.Add(aluno);
            listaAlunos.Add(aluno1);

            return listaAlunos;
        }
    }
}
