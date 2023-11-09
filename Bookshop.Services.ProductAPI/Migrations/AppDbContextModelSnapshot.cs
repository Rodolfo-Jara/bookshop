﻿// <auto-generated />
using Bookshop.Services.ProductAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookshop.Services.ProductAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bookshop.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoriaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLocalPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Autor = "León Tolstói ",
                            CategoriaName = "Clásicos",
                            ImageUrl = "https://th.bing.com/th/id/OIP.5s7sgEWKFdXkyfeb9AAFRgAAAA?pid=ImgDet&rs=1/602*402",
                            Name = "Guerra y paz (1864)",
                            Precio = 99.0
                        },
                        new
                        {
                            ProductId = 2,
                            Autor = "Julio Verne y Peter Holeinone ",
                            CategoriaName = "Aventura",
                            ImageUrl = "https://th.bing.com/th/id/R.a4f0e9791c5e8cd4420a166c458236c6?rik=wZALMIra17zTYA&riu=http%3a%2f%2f2.bp.blogspot.com%2f-0j8TFs-A-5s%2fUPaCPHWTtyI%2fAAAAAAAAAmo%2f473HjvPPjkk%2fs1600%2fLA-VUELTA-AL-MUNDO-EN-80-D%c3%8d.jpg&ehk=o7YW8POWHmb1qbAIwjxB4q%2bS4mldeJdS3DLqix4cpW8%3d&risl=&pid=ImgRaw&r=0/602*402",
                            Name = "La vuelta al mundo en ochenta días (1872)",
                            Precio = 99.900000000000006
                        },
                        new
                        {
                            ProductId = 3,
                            Autor = "J. R. R. Tolkien",
                            CategoriaName = "Fantasía",
                            ImageUrl = "https://archive.is/zxd7Q/3899704ff0b9fac95ed4a3513aab081f999c1565.jpg",
                            Name = "El señor de los anillos (1954)",
                            Precio = 89.900000000000006
                        },
                        new
                        {
                            ProductId = 4,
                            Autor = "Indro Montanelli y Roberto Gervaso",
                            CategoriaName = "Historia ",
                            ImageUrl = "https://infolibros.org/wp-content/uploads/2020/07/Historia-de-la-Edad-Media.jpg",
                            Name = "Breve historia del mundo (1936)",
                            Precio = 90.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
