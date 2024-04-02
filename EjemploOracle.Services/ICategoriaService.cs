using EjemploOracle.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemploOracle.Services
{
    public interface ICategoriaService
    {
        Task<List<Categorium>> GetAllCategorias();
        Task<Categorium> GetCategoriaById(decimal id);
        Task<int> CreateCategoria(Categorium newCategoria);
        Task<int> UpdateCategoria(Categorium categoria);
        Task<int> DeleteCategoria(decimal id);
    }
}
