﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestaoTarefasIPG.Migrations
{
    [DbContext(typeof(GestaoTarefasIPGDbContext))]
    partial class GestaoTarefasIPGDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestaoTarefasIPG.Models.Cargo", b =>
                {
                    b.Property<int>("CargoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(248)")
                        .HasMaxLength(248);

                    b.HasKey("CargoID");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("GestaoTarefasIPG.Models.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EscolaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartamentoId");

                    b.HasIndex("EscolaId");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("GestaoTarefasIPG.Models.Escola", b =>
                {
                    b.Property<int>("EscolaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("EscolaID");

                    b.ToTable("Escola");
                });

            modelBuilder.Entity("GestaoTarefasIPG.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EscolaId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(248)")
                        .HasMaxLength(248);

                    b.Property<string>("telemovel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuncionarioID");

                    b.HasIndex("EscolaId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("GestaoTarefasIPG.Models.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("ServicoId");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("GestaoTarefasIPG.Models.Departamento", b =>
                {
                    b.HasOne("GestaoTarefasIPG.Models.Escola", "Escola")
                        .WithMany("Departamentos")
                        .HasForeignKey("EscolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestaoTarefasIPG.Models.Funcionario", b =>
                {
                    b.HasOne("GestaoTarefasIPG.Models.Escola", "Escola")
                        .WithMany("Funcionarios")
                        .HasForeignKey("EscolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
