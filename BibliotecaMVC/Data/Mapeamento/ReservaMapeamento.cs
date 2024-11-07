using BibliotecaMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaMVC.Data.Mapeamento
{
    public class ReservaMapeamento : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.ToTable("Reserva");

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Quando).HasColumnType("DATE");
            builder.Property(t => t.Devolucao).HasColumnType("DATE");
            builder.Property(t => t.Pessoa).HasColumnType("VARCHAR(50)");
            builder.Property(t => t.Livro).HasColumnType("VARCHAR(60)");
        }
    }
}
