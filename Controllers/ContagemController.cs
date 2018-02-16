﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_SetaDigital.Model;
using Newtonsoft.Json;

namespace WebAPI_SetaDigital.Controllers {
    [Produces ("application/json")]
    public class ContagemController : Controller {
        //Novos métodos///////////////////////////////////////////////
        [HttpGet]
        [Route ("api/geoseta/{pais}")]
        public  JsonResult  ContagemClientesUF (string  pais) {
            //588655 senha da 
            Console.WriteLine("Pais = "+pais);
            CRUD crud = new CRUD();
            List<ContagemClientes> lista = crud.contagemClientesUFs(pais);
            return new JsonResult(lista);
        }

        [HttpGet]
        [Route ("api/geoseta/{pais}/{estado}")]
        public  JsonResult  ContagemClientesUF (string  pais, string estado) {
            //588655 senha da 
            Console.WriteLine("Pais = "+pais);
            Console.WriteLine("Estado = "+estado);
            CRUD crud = new CRUD();
            List<ContagemClientes> lista = crud.contagemClientesCidades(pais, estado);
            return new JsonResult(lista);
        }
        [HttpGet]
        [Route ("api/geoseta/{pais}/{estado}/{cidade}")]
        public  JsonResult  ContagemClientesUF (string  pais, string estado, string cidade) {
            //588655 senha da 
            Console.WriteLine("Pais = "+pais);
            Console.WriteLine("Estado = "+estado);
            Console.WriteLine("Cidade = "+cidade);
            CRUD crud = new CRUD();
            List<ContagemClientes> lista = crud.contagemClientesBairros(pais, estado, cidade);
            return new JsonResult(lista);
        }
        //Fim dos novos métodos///////////////////////////////////////
        [HttpGet ("{codigo}")]
        [Route ("api/geoseta/pessoas/buscar")]
        public JsonResult Get (string codigo) {
            Pessoa pessoa = new Pessoa ();
            CRUD crud = new CRUD ();
            pessoa = crud.BuscarPessoa (codigo);
            return new JsonResult (pessoa);
        }

        [HttpPost]
        [Route ("api/pessoas/cadastrar")]
        public void CadastrarPessoa ([FromBody] Pessoa pessoa) {
            CRUD crud = new CRUD ();
            Console.WriteLine ("Cadastrando a pessoa {0}", pessoa.Nome);
            Console.WriteLine ("CEP = " + pessoa.Cep);

            Console.WriteLine ("Endereco = {0}", pessoa.Endereco);

            Console.WriteLine ("Bairro = {0}", pessoa.Bairro);

            Console.WriteLine ("Cidade = {0}", pessoa.Cidade);

            Console.WriteLine ("UF = {0}", pessoa.Uf);

            Console.WriteLine ("CPF (000.000.000-00) = {0}", pessoa.Cpf);

            Console.WriteLine ("Estado civil = {0}", pessoa.Estadocivil);

            Console.WriteLine ("Status (A) = {0}", pessoa.Status);

            Console.WriteLine ("Sexo = {0}", pessoa.Sexo);

            string dia = DateTime.Now.Day.ToString ();
            string mes = DateTime.Now.Month.ToString ();
            string ano = DateTime.Now.Year.ToString ();

            pessoa.Cadastro = ano + "-" + mes + "-" + dia;
            Console.WriteLine ("Cadastro data = " + pessoa.Cadastro);
            pessoa.Cliente = "true";
            pessoa.Tipo = "1";
            crud.CadastrarPessoa (pessoa);
        }

        // POST api/values
        [HttpPost]
        [Route ("api/pessoas/desativar")]
        public void DesativarPessoa ([FromBody] dynamic alt) {
            CRUD crud = new CRUD ();
            Pessoa pessoa = crud.BuscarPessoa (alt.usuario);
            pessoa.Codigo = alt.codigo;
            pessoa.Status = alt.status;
            crud.AlterarPessoa (pessoa);
        }
    }

}