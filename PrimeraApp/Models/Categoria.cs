using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PrimeraApp.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
    public class CategoriaDBContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
    }
}
