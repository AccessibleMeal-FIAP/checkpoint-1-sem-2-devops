// <auto-generated />
using System;
using LifeShare.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LifeShare.Migrations
{
    [DbContext(typeof(ClienteContext))]
    partial class ClienteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LifeShare.Models.Cliente", b =>
            {
                b.Property<int>("ClienteId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id")
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("DataEntrada")
                    .HasColumnName("Dt_Entrada")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("DataSaida")
                    .HasColumnName("Dt_Saida")
                    .HasColumnType("datetime2");

                b.Property<string>("Nome")
                    .IsRequired()
                    .HasColumnType("nvarchar(80)")
                    .HasMaxLength(80);

                b.Property<string>("Placa")
                    .IsRequired()
                    .HasColumnType("nvarchar(8)")
                    .HasMaxLength(8); ;

                b.Property<int>("CorCarro")
                    .HasColumnType("int");

                b.HasKey("ClienteId");

                b.ToTable("Tb_Cliente");
            });
#pragma warning restore 612, 618
        }
    }
}
