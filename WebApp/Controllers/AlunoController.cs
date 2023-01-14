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

            return aluno.listaAlunos();
        }


    }
}
