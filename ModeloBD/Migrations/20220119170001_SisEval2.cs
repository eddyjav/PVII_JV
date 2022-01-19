using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloBD.Migrations
{
    public partial class SisEval2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bonos",
                columns: table => new
                {
                    BonoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonos", x => x.BonoID);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salario = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.CargoId);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "desempenoEm",
                columns: table => new
                {
                    DesempenoEmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_desempenoEm", x => x.DesempenoEmId);
                });

            migrationBuilder.CreateTable(
                name: "DesempenoSc",
                columns: table => new
                {
                    DesempenoScId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesempenoSc", x => x.DesempenoScId);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Importe = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.FacturaId);
                });

            migrationBuilder.CreateTable(
                name: "Horario_Dets",
                columns: table => new
                {
                    Horario_DetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Minuto = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario_Dets", x => x.Horario_DetId);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    PermisoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.PermisoId);
                });

            migrationBuilder.CreateTable(
                name: "Sucursals",
                columns: table => new
                {
                    SucursalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursals", x => x.SucursalId);
                });

            migrationBuilder.CreateTable(
                name: "Control_Asistencias",
                columns: table => new
                {
                    Control_AsistenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalidaAlmuerzo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntradaAlmuerzo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Permiso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Horario_DetalleHorario_DetId = table.Column<int>(type: "int", nullable: true),
                    DetalleId = table.Column<int>(type: "int", nullable: false),
                    PermisoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Control_Asistencias", x => x.Control_AsistenciaId);
                    table.ForeignKey(
                        name: "FK_Control_Asistencias_Horario_Dets_Horario_DetalleHorario_DetId",
                        column: x => x.Horario_DetalleHorario_DetId,
                        principalTable: "Horario_Dets",
                        principalColumn: "Horario_DetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Control_Asistencias_Permisos_PermisoId",
                        column: x => x.PermisoId,
                        principalTable: "Permisos",
                        principalColumn: "PermisoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartamentosDepartamentoId = table.Column<int>(type: "int", nullable: true),
                    DepartamendoId = table.Column<int>(type: "int", nullable: false),
                    SucursalId = table.Column<int>(type: "int", nullable: false),
                    AsistenciasControl_AsistenciaId = table.Column<int>(type: "int", nullable: true),
                    AsistenciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_Empleados_Control_Asistencias_AsistenciasControl_AsistenciaId",
                        column: x => x.AsistenciasControl_AsistenciaId,
                        principalTable: "Control_Asistencias",
                        principalColumn: "Control_AsistenciaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleados_Departamentos_DepartamentosDepartamentoId",
                        column: x => x.DepartamentosDepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleados_Sucursals_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursals",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sueldos",
                columns: table => new
                {
                    SueldoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SueldoBase = table.Column<float>(type: "real", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false),
                    FacturasId = table.Column<int>(type: "int", nullable: false),
                    BonoId = table.Column<int>(type: "int", nullable: false),
                    DesempenoScId = table.Column<int>(type: "int", nullable: false),
                    DesempenoEmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sueldos", x => x.SueldoId);
                    table.ForeignKey(
                        name: "FK_Sueldos_Bonos_BonoId",
                        column: x => x.BonoId,
                        principalTable: "Bonos",
                        principalColumn: "BonoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sueldos_Cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargos",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sueldos_desempenoEm_DesempenoEmId",
                        column: x => x.DesempenoEmId,
                        principalTable: "desempenoEm",
                        principalColumn: "DesempenoEmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sueldos_DesempenoSc_DesempenoScId",
                        column: x => x.DesempenoScId,
                        principalTable: "DesempenoSc",
                        principalColumn: "DesempenoScId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sueldos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sueldos_Facturas_FacturasId",
                        column: x => x.FacturasId,
                        principalTable: "Facturas",
                        principalColumn: "FacturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Control_Asistencias_Horario_DetalleHorario_DetId",
                table: "Control_Asistencias",
                column: "Horario_DetalleHorario_DetId");

            migrationBuilder.CreateIndex(
                name: "IX_Control_Asistencias_PermisoId",
                table: "Control_Asistencias",
                column: "PermisoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_AsistenciasControl_AsistenciaId",
                table: "Empleados",
                column: "AsistenciasControl_AsistenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DepartamentosDepartamentoId",
                table: "Empleados",
                column: "DepartamentosDepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SucursalId",
                table: "Empleados",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Sueldos_BonoId",
                table: "Sueldos",
                column: "BonoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sueldos_CargoId",
                table: "Sueldos",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sueldos_DesempenoEmId",
                table: "Sueldos",
                column: "DesempenoEmId");

            migrationBuilder.CreateIndex(
                name: "IX_Sueldos_DesempenoScId",
                table: "Sueldos",
                column: "DesempenoScId");

            migrationBuilder.CreateIndex(
                name: "IX_Sueldos_EmpleadoId",
                table: "Sueldos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sueldos_FacturasId",
                table: "Sueldos",
                column: "FacturasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sueldos");

            migrationBuilder.DropTable(
                name: "Bonos");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "desempenoEm");

            migrationBuilder.DropTable(
                name: "DesempenoSc");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Control_Asistencias");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Sucursals");

            migrationBuilder.DropTable(
                name: "Horario_Dets");

            migrationBuilder.DropTable(
                name: "Permisos");
        }
    }
}
