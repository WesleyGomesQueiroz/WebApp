using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

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
            var json = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Database", "Base.json"));

            return JsonConvert.DeserializeObject<List<Alunos>>(json);
        }
    }
}
