using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WebApp.Models
{
    public class Alunos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string telefone { get; set; }
        public int ra { get; set; }

        public List<Alunos> ListaAlunos()
        {
            var json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Database", "Base.json"));

            return JsonConvert.DeserializeObject<List<Alunos>>(json);
        }

        public bool RescreverArquivo(List<Alunos> listagemAlunos)
        {
            var json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Database", "Base.json"));
            File.WriteAllText(json, JsonConvert.SerializeObject(listagemAlunos, Formatting.Indented));
            return true;
        }

        public Alunos Inserir(Alunos aluno)
        {
            var listaAlunos = this.ListaAlunos();

            var maxId = listaAlunos.Max(p => p.id);
            aluno.id = maxId + 1;
            listaAlunos.Add(aluno);

            RescreverArquivo(listaAlunos);
            return aluno;
        }

        public Alunos Atualizar(int id, Alunos aluno)
        {
            var listaAlunos = this.ListaAlunos();

            var itemIndex = listaAlunos.FindIndex(p => p.id == aluno.id);

            if (itemIndex >= 0)
            {
                aluno.id = id;
                listaAlunos[itemIndex] = aluno;
            }
            else
            {
                return null;
            }

            RescreverArquivo(listaAlunos);
            return aluno;
        }

        public bool Deletar(int id)
        {
            var listaAlunos = this.ListaAlunos();

            var itemIndex = listaAlunos.FindIndex(p => p.id == id);

            if (itemIndex >= 0)
            {
                listaAlunos.RemoveAt(itemIndex);
            }
            else
            {
                return false;
            }

            RescreverArquivo(listaAlunos);
            return true;
        }
    }
}
