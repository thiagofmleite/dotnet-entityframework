using LojaComEntity.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();

            //UsuarioDao usuarioDao = new UsuarioDao();
            //Usuario usuario = usuarioDao.BuscaPorId(1);

            //Venda v = new Venda
            //{
            //    Cliente = usuario,

            //};



            //Produto p1 = contexto.Produtos.FirstOrDefault(p => p.Id == 1);
            //Produto p2 = contexto.Produtos.FirstOrDefault(p => p.Id == 2);

            //ProdutoVenda pv1 = new ProdutoVenda
            //{
            //    Venda = v,
            //    Produto = p1
            //};

            //ProdutoVenda pv2 = new ProdutoVenda
            //{
            //    Venda = v,
            //    Produto = p2
            //};

            //contexto.Vendas.Add(v);
            //contexto.ProdutosVenda.Add(pv1);
            //contexto.ProdutosVenda.Add(pv2);
            //contexto.SaveChanges();


            //Venda venda = contexto.Vendas
            //    .Include(v => v.ProdutosVenda)
            //    .ThenInclude(pv => pv.Produto)
            //    .FirstOrDefault(v => v.Id == 1);

            //foreach (var pv in venda.ProdutosVenda)
            //{
            //    Console.WriteLine(pv.Produto.Nome);
            //}

            //Console.ReadKey();

            //PessoaFisica pf = new PessoaFisica
            //{
            //    Nome = "Guilherme",
            //    CPF = "000.000.000-00",
            //    Senha = "123"
            //};

            //PessoaJuridica pj = new PessoaJuridica
            //{
            //    Nome = "Alura",
            //    CNPJ = "000",
            //    Senha = "123"
            //};

            //contexto.PessoasFisicas.Add(pf);
            //contexto.PessoasJuridicas.Add(pj);
            //contexto.SaveChanges();
            //contexto.Dispose();
        }
    }
}
