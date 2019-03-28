using System;
using System.Collections.Generic;
using System.Linq;

namespace lab1.Controllers
{
    public class ProdutoRepositorio
    {
        private static readonly List<Produto> produtos = new List<Produto>();
        private bool teste;

        public Produto Get(Guid id)
        {
            var produto  = produtos.SingleOrDefault(c => c.Id == id);
              if (produto == null)
            {
                 throw new NonExistsObjectException("Produto não encontrado!");
            } 
            return produtos.SingleOrDefault(c => c.Id == id);
        }

        public IList<Produto> GetAll()
        {
            
            return produtos;
        }

        public void Add(Produto produto)
        {
            produtos.Add(produto);
        }

        public void Update(Guid id, Produto produto)
        {
            var index = produtos.FindIndex(c => c.Id == id);

            if (index < 0)
            {
                 throw new NonExistsObjectException("Objeto não encontrado, não pode ser atualizado");
            } 

            produtos[index] = produto;
        }

        public void Remove(Guid id)
        {
            var oldProduto = produtos.SingleOrDefault(c => c.Id == id);

            if (oldProduto == null)
            {
                throw new NonExistsObjectException("Objeto não encontrado, não pode ser removido");
            }

            produtos.Remove(oldProduto);
        }
    }
}