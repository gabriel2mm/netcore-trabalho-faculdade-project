﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stock.Infrastructure.Context;

namespace Stock.Infrastructure.Migrations
{
    [DbContext(typeof(EfContext))]
    partial class EfContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Stock.Domain.Models.BranchOffice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Filial");
                });

            modelBuilder.Entity("Stock.Domain.Models.Campaign", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageBanner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ShowcaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ShowcaseId");

                    b.ToTable("Campanha");
                });

            modelBuilder.Entity("Stock.Domain.Models.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnName("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Emission")
                        .HasColumnName("Emissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnName("NumeroIdentificacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InvoiceType")
                        .HasColumnName("Tipo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Transition")
                        .HasColumnName("Transacao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("NotaFiscal");
                });

            modelBuilder.Entity("Stock.Domain.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CEP")
                        .HasColumnName("CEP")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("City")
                        .HasColumnName("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complement")
                        .HasColumnName("Complemento")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("District")
                        .HasColumnName("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("Number")
                        .HasColumnName("Numero")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnName("UF")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Street")
                        .HasColumnName("Endereço")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Local");
                });

            modelBuilder.Entity("Stock.Domain.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnName("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderCode")
                        .HasColumnName("codPedido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("PaymentId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Stock.Domain.Models.OrdersShowcases", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ShowcaseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderId", "ShowcaseId");

                    b.HasIndex("ShowcaseId");

                    b.ToTable("PedidosVitrine");
                });

            modelBuilder.Entity("Stock.Domain.Models.PaymentModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BilletNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CCV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Card")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DueDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Payment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plots")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("Stock.Domain.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Input")
                        .HasColumnName("Entrada")
                        .HasColumnType("datetime2");

                    b.Property<string>("Measure")
                        .IsRequired()
                        .HasColumnName("Medida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Output")
                        .HasColumnName("Saida")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnName("Preço")
                        .HasColumnType("float");

                    b.Property<string>("ProductCode")
                        .HasColumnName("CodProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnName("Unidade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Stock.Domain.Models.ProductManagement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnName("Quantidade")
                        .HasColumnType("int");

                    b.Property<double>("AverageCost")
                        .HasColumnName("CustoMedio")
                        .HasColumnType("float");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductsControlWareHouseIDs")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TotalCost")
                        .HasColumnName("Custo total")
                        .HasColumnType("float");

                    b.Property<Guid?>("WareHouseProductControlId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("WareHouseProductControlId");

                    b.ToTable("ProdutoControle");
                });

            modelBuilder.Entity("Stock.Domain.Models.ProductProvider", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProviderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId", "ProviderId");

                    b.HasIndex("ProviderId");

                    b.ToTable("ProdutoFornecedor");
                });

            modelBuilder.Entity("Stock.Domain.Models.ProductTransition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("InvoiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnName("Quantidade")
                        .HasColumnType("int");

                    b.Property<DateTime>("Transition")
                        .HasColumnName("DataDaTransicao")
                        .HasColumnType("datetime2");

                    b.Property<int>("TransitionType")
                        .HasColumnName("TipoTransacao")
                        .HasColumnType("int");

                    b.Property<double>("UnitCost")
                        .HasColumnName("CustoUnitario")
                        .HasColumnType("float");

                    b.Property<Guid>("WarehouseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("TransacaoProduto");
                });

            modelBuilder.Entity("Stock.Domain.Models.Provider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("Stock.Domain.Models.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductManagementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductManagementId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Stock.Domain.Models.Showcase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .HasColumnName("cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnName("descrição")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnName("imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProductManagementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantidade")
                        .HasColumnName("quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductManagementId");

                    b.ToTable("Vitrine");
                });

            modelBuilder.Entity("Stock.Domain.Models.Warehouse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BranchOfficeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LocationWareHouseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ThirdParty")
                        .HasColumnName("DeTerceiros")
                        .HasColumnType("bit");

                    b.Property<Guid?>("WareHousesID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WarehouseCode")
                        .IsRequired()
                        .HasColumnName("DepositoCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchOfficeId");

                    b.HasIndex("LocationWareHouseId");

                    b.ToTable("Deposito");
                });

            modelBuilder.Entity("Stock.Domain.Models.Campaign", b =>
                {
                    b.HasOne("Stock.Domain.Models.Showcase", "Showcase")
                        .WithMany()
                        .HasForeignKey("ShowcaseId");
                });

            modelBuilder.Entity("Stock.Domain.Models.Order", b =>
                {
                    b.HasOne("Stock.Domain.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Stock.Domain.Models.PaymentModel", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Stock.Domain.Models.OrdersShowcases", b =>
                {
                    b.HasOne("Stock.Domain.Models.Order", "Order")
                        .WithMany("OrdersShowcases")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Stock.Domain.Models.Showcase", "ShowCase")
                        .WithMany("OrderShowcases")
                        .HasForeignKey("ShowcaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Stock.Domain.Models.ProductManagement", b =>
                {
                    b.HasOne("Stock.Domain.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("Stock.Domain.Models.Warehouse", "Warehouse")
                        .WithMany("ProductManagements")
                        .HasForeignKey("WareHouseProductControlId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Stock.Domain.Models.ProductProvider", b =>
                {
                    b.HasOne("Stock.Domain.Models.Provider", "Provider")
                        .WithMany("Products")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Stock.Domain.Models.Product", "Product")
                        .WithMany("Providers")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Stock.Domain.Models.ProductTransition", b =>
                {
                    b.HasOne("Stock.Domain.Models.Invoice", "Invoice")
                        .WithMany("ProductTransitions")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Stock.Domain.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Stock.Domain.Models.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Stock.Domain.Models.Reservation", b =>
                {
                    b.HasOne("Stock.Domain.Models.ProductManagement", "ProductManagement")
                        .WithMany()
                        .HasForeignKey("ProductManagementId");
                });

            modelBuilder.Entity("Stock.Domain.Models.Showcase", b =>
                {
                    b.HasOne("Stock.Domain.Models.ProductManagement", "ProductManagement")
                        .WithMany()
                        .HasForeignKey("ProductManagementId");
                });

            modelBuilder.Entity("Stock.Domain.Models.Warehouse", b =>
                {
                    b.HasOne("Stock.Domain.Models.BranchOffice", "BranchOffice")
                        .WithMany("Warehouses")
                        .HasForeignKey("BranchOfficeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Stock.Domain.Models.Location", "Location")
                        .WithMany("Warehouses")
                        .HasForeignKey("LocationWareHouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}