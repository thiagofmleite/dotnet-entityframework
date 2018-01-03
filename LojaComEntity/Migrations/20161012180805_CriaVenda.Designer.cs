using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using LojaComEntity;

namespace LojaComEntity.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    [Migration("20161012180805_CriaVenda")]
    partial class CriaVenda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LojaComEntity.Entidades.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("LojaComEntity.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("LojaComEntity.Entidades.ProdutoVenda", b =>
                {
                    b.Property<int>("VendaId");

                    b.Property<int>("ProdutoId");

                    b.HasKey("VendaId", "ProdutoId");
                });

            modelBuilder.Entity("LojaComEntity.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("LojaComEntity.Entidades.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("LojaComEntity.Entidades.Produto", b =>
                {
                    b.HasOne("LojaComEntity.Entidades.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("LojaComEntity.Entidades.ProdutoVenda", b =>
                {
                    b.HasOne("LojaComEntity.Entidades.Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.HasOne("LojaComEntity.Entidades.Venda")
                        .WithMany()
                        .HasForeignKey("VendaId");
                });

            modelBuilder.Entity("LojaComEntity.Entidades.Venda", b =>
                {
                    b.HasOne("LojaComEntity.Entidades.Usuario")
                        .WithMany()
                        .HasForeignKey("ClienteId");
                });
        }
    }
}
