using Microsoft.EntityFrameworkCore;
using PadariaDoceAroma.Models;
using System.Collections.Generic;

namespace PadariaDoceAroma.DataBase
{
    // Classe para gerenciar as entidades

    public class ProdutosContext : DbContext
    {
        public DbSet<Item> Itens { get; set; }

        public ProdutosContext(DbContextOptions op) : base(op)
        {
        }
    }
}
