using LojaComEntity.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public class CategoriaDao
    {
        public EntidadesContext contexto { get; set; }

        public CategoriaDao()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public Categoria BuscaPorId(int id)
        {
            return contexto.Categorias.Include(c => c.Produtos).FirstOrDefault(c => c.Id == id);
        }

        public void Remove(Categoria categoria)
        {
            contexto.Categorias.Remove(categoria);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
    }
}
