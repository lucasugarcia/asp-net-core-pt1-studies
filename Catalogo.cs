using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Catalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Teste 1", 12.87m));
            livros.Add(new Livro("002", "Teste 2", 13.87m));
            livros.Add(new Livro("003", "Teste 3", 14.87m));

            return livros;
        }
    }
}
