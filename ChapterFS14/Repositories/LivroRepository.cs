using ChapterFS14.Contexts;
using ChapterFS14.Models;
using Microsoft.EntityFrameworkCore;

namespace ChapterFS14.Repositories
{
  
    public class LivroRepository
    {
        private Sqlcontext _context;
        public LivroRepository(Sqlcontext context)
        {
            _context = context;
        }
        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }

    }
}
