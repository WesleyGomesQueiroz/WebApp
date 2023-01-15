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
        [Route("GetAll")]
        public List<Alunos> GetAll()
        {
            Alunos aluno = new Alunos();

            return aluno.ListaAlunos();
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public Alunos GetById(int id)
        {
            Alunos aluno = new Alunos();

            return aluno.ListaAlunos().Where(x => x.id == id).FirstOrDefault();
        }

        [HttpPost]
        [Route("Create")]
        public List<Alunos> Create(Alunos aluno)
        {
            Alunos _aluno = new Alunos();

            _aluno.Inserir(aluno);

            return _aluno.ListaAlunos();
        }
    }
}
