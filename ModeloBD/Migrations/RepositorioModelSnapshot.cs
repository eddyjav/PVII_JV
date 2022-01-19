﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloBD;

namespace ModeloBD.Migrations
{
    [DbContext(typeof(Repositorio))]
    partial class RepositorioModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Entidades.Bono", b =>
                {
                    b.Property<int>("BonoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("BonoID");

                    b.ToTable("Bonos");
                });

            modelBuilder.Entity("Modelo.Entidades.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Salario")
                        .HasColumnType("real");

                    b.HasKey("CargoId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("Modelo.Entidades.Control_Asistencia", b =>
                {
                    b.Property<int>("Control_AsistenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DetalleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EntradaAlmuerzo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Horario_DetalleHorario_DetId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ingreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Permiso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PermisoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Salida")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SalidaAlmuerzo")
                        .HasColumnType("datetime2");

                    b.HasKey("Control_AsistenciaId");

                    b.HasIndex("Horario_DetalleHorario_DetId");

                    b.HasIndex("PermisoId");

                    b.ToTable("Control_Asistencias");
                });

            modelBuilder.Entity("Modelo.Entidades.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("Modelo.Entidades.DesempenoEm", b =>
                {
                    b.Property<int>("DesempenoEmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesempenoEmId");

                    b.ToTable("desempenoEm");
                });

            modelBuilder.Entity("Modelo.Entidades.DesempenoSc", b =>
                {
                    b.Property<int>("DesempenoScId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesempenoScId");

                    b.ToTable("DesempenoSc");
                });

            modelBuilder.Entity("Modelo.Entidades.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AsistenciaId")
                        .HasColumnType("int");

                    b.Property<int?>("AsistenciasControl_AsistenciaId")
                        .HasColumnType("int");

                    b.Property<int>("Cedula")
                        .HasColumnType("int");

                    b.Property<int>("DepartamendoId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartamentosDepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("AsistenciasControl_AsistenciaId");

                    b.HasIndex("DepartamentosDepartamentoId");

                    b.HasIndex("SucursalId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Modelo.Entidades.Factura", b =>
                {
                    b.Property<int>("FacturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Anio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Dia")
                        .HasColumnType("datetime2");

                    b.Property<float>("Importe")
                        .HasColumnType("real");

                    b.Property<DateTime>("Mes")
                        .HasColumnType("datetime2");

                    b.HasKey("FacturaId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Modelo.Entidades.Horario_Det", b =>
                {
                    b.Property<int>("Horario_DetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Anio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Dia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Mes")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Minuto")
                        .HasColumnType("datetime2");

                    b.HasKey("Horario_DetId");

                    b.ToTable("Horario_Dets");
                });

            modelBuilder.Entity("Modelo.Entidades.Permiso", b =>
                {
                    b.Property<int>("PermisoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermisoId");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("Modelo.Entidades.Sucursal", b =>
                {
                    b.Property<int>("SucursalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SucursalId");

                    b.ToTable("Sucursals");
                });

            modelBuilder.Entity("Modelo.Entidades.Sueldo", b =>
                {
                    b.Property<int>("SueldoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BonoId")
                        .HasColumnType("int");

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<int>("DesempenoEmId")
                        .HasColumnType("int");

                    b.Property<int>("DesempenoScId")
                        .HasColumnType("int");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<int>("FacturasId")
                        .HasColumnType("int");

                    b.Property<float>("SueldoBase")
                        .HasColumnType("real");

                    b.HasKey("SueldoId");

                    b.HasIndex("BonoId");

                    b.HasIndex("CargoId");

                    b.HasIndex("DesempenoEmId");

                    b.HasIndex("DesempenoScId");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("FacturasId");

                    b.ToTable("Sueldos");
                });

            modelBuilder.Entity("Modelo.Entidades.Control_Asistencia", b =>
                {
                    b.HasOne("Modelo.Entidades.Horario_Det", "Horario_Detalle")
                        .WithMany()
                        .HasForeignKey("Horario_DetalleHorario_DetId");

                    b.HasOne("Modelo.Entidades.Permiso", "Permisos")
                        .WithMany()
                        .HasForeignKey("PermisoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Horario_Detalle");

                    b.Navigation("Permisos");
                });

            modelBuilder.Entity("Modelo.Entidades.Empleado", b =>
                {
                    b.HasOne("Modelo.Entidades.Control_Asistencia", "Asistencias")
                        .WithMany()
                        .HasForeignKey("AsistenciasControl_AsistenciaId");

                    b.HasOne("Modelo.Entidades.Departamento", "Departamentos")
                        .WithMany()
                        .HasForeignKey("DepartamentosDepartamentoId");

                    b.HasOne("Modelo.Entidades.Sucursal", "Sucursales")
                        .WithMany()
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asistencias");

                    b.Navigation("Departamentos");

                    b.Navigation("Sucursales");
                });

            modelBuilder.Entity("Modelo.Entidades.Sueldo", b =>
                {
                    b.HasOne("Modelo.Entidades.Bono", "Bonos")
                        .WithMany()
                        .HasForeignKey("BonoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Cargo", "CargoS")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.DesempenoEm", "DesempenoEms")
                        .WithMany()
                        .HasForeignKey("DesempenoEmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.DesempenoSc", "desempenoScs")
                        .WithMany()
                        .HasForeignKey("DesempenoScId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Empleado", "Empleados")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Factura", "Facturas")
                        .WithMany()
                        .HasForeignKey("FacturasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bonos");

                    b.Navigation("CargoS");

                    b.Navigation("DesempenoEms");

                    b.Navigation("desempenoScs");

                    b.Navigation("Empleados");

                    b.Navigation("Facturas");
                });
#pragma warning restore 612, 618
        }
    }
}