using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        [HttpGet]
        [Route("Listar")]
        public List<Alunos> Listar()
        {
            Alunos aluno = new Alunos();

            return aluno.ListaAlunos();
        }

        [HttpGet]
        [Route("PegarPorId/{id}")]
        public Alunos PegarPorId(int id)
        {
            Alunos aluno = new Alunos();

            return aluno.ListaAlunos().Where(x => x.id == id).FirstOrDefault();
        }

        [HttpPost]
        [Route("Inserir")]
        public List<Alunos> Inserir(Alunos aluno)
        {
            Alunos _aluno = new Alunos();

            _aluno.Inserir(aluno);

            return _aluno.ListaAlunos();
        }

        [HttpPut]
        [Route("Atualizar/{id}")]
        public Alunos Atualizar(int id, Alunos aluno)
        {
            Alunos _aluno = new Alunos();

            return _aluno.Atualizar(id, aluno);
        }

        [HttpDelete]
        [Route("Deletar/{id}")]
        public bool Deletar(int id)
        {
            Alunos _aluno = new Alunos();

            return _aluno.Deletar(id);
        }
    }
}
