using Microsoft.EntityFrameworkCore;
using PadariaDoceAroma.Models;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;

namespace PadariaDoceAroma.DataBase
{
    // Classe para gerenciar as entidades

    public class PadariaContext : DbContext
    {
        public DbSet<Item> Itens { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        // Configuracao da FK
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Item)
                .WithMany()
                .HasForeignKey(p => p.FkItemId);

           
        }

        public PadariaContext(DbContextOptions op) : base(op)
        {
        }
    }
}
