using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_SetaDigital.Model;
using System.Globalization;

namespace WebAPI_SetaDigital.Controllers
{    
    public class CRUD
    {
        //Novos métodos///////////////////////////////////////////////////
        public List<Contagem> contagemClientesUFs(string pais)
        {
            Console.WriteLine("Contagem de clientes por UFs");
            return Banco.Instance.contagemClientesUFs(pais);
        }
        public List<Contagem> contagemClientesCidades(string pais, string estado)
        {
            Console.WriteLine("Contagem de clientes por Cidades");
            return Banco.Instance.contagemClientesCidades(pais,estado);
        }
        public List<Contagem> contagemClientesBairros(string pais, string estado, string cidade)
        {
            Console.WriteLine("Contagem de clientes por Bairros");
            return Banco.Instance.contagemClientesBairros(pais,estado,cidade);
        }
        public List<Contagem> gastoEstados(string pais)
        {
            Console.WriteLine("Contagem gasto dos clientes por Estados");
            return Banco.Instance.gastoEstados(pais);
        }
        public List<Contagem> gastoCidades(string pais, string estado)
        {
            Console.WriteLine("Contagem gasto dos clientes por Cidades");
            return Banco.Instance.gastoCidades(pais,estado);
        }
        public List<Contagem> gastoBairros(string pais, string estado, string cidade)
        {
            Console.WriteLine("Contagem gasto dos clientes por Bairros");
            return Banco.Instance.gastoBairros(pais,estado,cidade);
        }
        public List<ContagemMarca> listMarcasUFs (string pais, int qtd){
            Console.WriteLine("Lista de marcas mais vendidas por estado");
            return Banco.Instance.listMarcasUFs(pais, qtd);
        }
        public List<ContagemMarca> listMarcasCidades (string pais, string estado, int qtd){
            Console.WriteLine("Lista de marcas mais vendidas por cidade");
            return Banco.Instance.listMarcasCidades(pais, estado, qtd);
        }
        public List<ContagemMarca> listMarcasBairros (string pais, string estado, string cidade, int qtd){
            Console.WriteLine("Lista de marcas mais vendidas por bairro");
            return Banco.Instance.listMarcasBairros(pais, estado, cidade, qtd);
        }
        public List<ContagemMarca> listMarcasCidadeSomente (string pais, string estado, string cidade, int qtd){
            Console.WriteLine("Lista de marcas mais vendidas em uma cidade somente");
            return Banco.Instance.listMarcasCidadeSomente(pais, estado, cidade, qtd);
        }
        public List<ContagemMarca> listTopMarcasUFs (string pais, int qtd){
            Console.WriteLine("Lista das top marcas mais vendidas da loja por estado");
            return Banco.Instance.listTopMarcasUFs(pais, qtd);
        }
        public List<ContagemMarca> listTopMarcasCidades (string pais, string estado, int qtd){
            Console.WriteLine("Lista das top marcas mais vendidas da loja por cidade");
            return Banco.Instance.listTopMarcasCidades(pais, estado, qtd);
        }
        public List<ContagemMarca> listTopMarcasBairros (string pais, string estado, string cidade, int qtd){
            Console.WriteLine("Lista das top marcas mais vendidas da loja por bairro");
            return Banco.Instance.listTopMarcasBairros(pais, estado, cidade, qtd);
        }
        //Fim dos novos métodos///////////////////////////////////////////

        
        public Pessoa BuscarPessoa(string codigo)
        {
            Console.WriteLine("Buscando a pessoa com o codigo> " + codigo);
            return Banco.Instance.BuscarPessoa(codigo);
        }

        //todo (4) Criar um metodo de "controlardor" para inserir a nova pessoa Obs: Ele deve retornar o Código da pessoa que acabou de ser inserida.
        public string CadastrarPessoa(Pessoa pessoa)
        {
            Console.WriteLine("Inserindo a pessoa com o codigo> ");
            return Banco.Instance.CadastrarPessoa(pessoa);
        }

        public string CadastrarPreVenda(Venda prevenda)
        {
            Console.WriteLine("Inserindo a prevenda> ");
            return Banco.Instance.CadastrarPreVenda(prevenda);
        }

        public string CadastrarMovimentoPreVenda(Movimento movimento)
        {
            Console.WriteLine("Inserindo o movimento da prevenda> ");
            return Banco.Instance.CadastrarMovimentoPreVenda(movimento);
        }

        public decimal BuscarInfoProduto(string codigo, string opcao)
        {
            Console.WriteLine("Buscando o preco do Produto> {0}", codigo);
            return Banco.Instance.BuscarInfoProduto(codigo, opcao);
        }
        public void AlterarPessoa(Pessoa pessoa)
        {
            Console.WriteLine("Alterando pessoa");
            Banco.Instance.AlterarPessoa(pessoa);
        }
    }
}