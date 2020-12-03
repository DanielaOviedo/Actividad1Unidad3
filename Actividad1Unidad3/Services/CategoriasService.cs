using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actividad1Unidad3.Models;
using Actividad1Unidad3.Repositories;

namespace Actividad1Unidad3.Services
{
    public class CategoriasService
    {
        public List<Categorias> Categorias { get; set; }

        public CategoriasService()
        {
            using (fruteriashopContext context = new fruteriashopContext())
            {
                Repository<Categorias> repos = new Repository<Categorias>(context);
                Categorias = repos.GetAll().Where(x => x.Eliminado == false).OrderBy(x => x.Nombre).ToList();
            }
        }
    }
}
