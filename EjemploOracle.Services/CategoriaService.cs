using EjemploOracle.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace EjemploOracle.Services
{
    public class CategoriaService : ICategoriaService
    {
        private ModelContext _context;

        public CategoriaService(ModelContext context)
        {
            _context = context;
        }


        public async Task<List<Categorium>> GetAllCategorias()
        {
            return await _context.Categoria.ToListAsync();

        }

        public async Task<Categorium> GetCategoriaById(decimal id)
        {
            return await _context.Categoria.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> CreateCategoria(Categorium newCategoria)
        {

            await _context.Categoria.AddAsync(newCategoria);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateCategoria(Categorium categoria)
        {
            Categorium categoriaToEdit = await _context.Categoria.FirstOrDefaultAsync(x => x.Id == categoria.Id);

            if (categoriaToEdit != null)
            {
                categoriaToEdit.Nombre = categoria.Nombre;
                return await _context.SaveChangesAsync();
            }

            return 0;
        }

        public async Task<int> DeleteCategoria(decimal id)
        {
            Categorium categoriaToRemove = await _context.Categoria.FirstOrDefaultAsync(x => x.Id == id);

            if (categoriaToRemove != null)
            {
                _context.Categoria.Remove(categoriaToRemove);
                return await _context.SaveChangesAsync();
            }

            return 0;
        }
    }
}
