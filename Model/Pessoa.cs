using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_SetaDigital.Model
{
    public class Pessoa
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }

        //todo (2) Criar as variaveis de acordo com o cadastro de pessoa fisica do SETA;
        public string Cpf {get; set;}
        public string Cep {get; set;}
        public string Tipo {get; set;}
        public string Endereco {get; set;}
        public string Bairro {get; set;}
        public string Cidade {get; set;}
        public string Uf {get; set;}
        public string Estadocivil {get; set;}
        public string Status {get; set;}
        public string Sexo {get; set;}
        public string Cadastro {get; set;}
        public string Cliente {get; set;}
    }
}
