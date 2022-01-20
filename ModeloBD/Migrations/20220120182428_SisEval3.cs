using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloBD.Migrations
{
    public partial class SisEval3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Control_Asistencias_Horario_Dets_Horario_DetalleHorario_DetId",
                table: "Control_Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Control_Asistencias_Permisos_PermisoId",
                table: "Control_Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Control_Asistencias_AsistenciasControl_AsistenciaId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Departamentos_DepartamentosDepartamentoId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Sucursals_SucursalId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Sueldos_Bonos_BonoId",
                table: "Sueldos");

            migrationBuilder.DropForeignKey(
                name: "FK_Sueldos_Cargos_CargoId",
                table: "Sueldos");

            migrationBuilder.DropForeignKey(
                name: "FK_Sueldos_desempenoEm_DesempenoEmId",
                table: "Sueldos");

            migrationBuilder.DropForeignKey(
                name: "FK_Sueldos_DesempenoSc_DesempenoScId",
                table: "Sueldos");

            migrationBuilder.DropForeignKey(
                name: "FK_Sueldos_Empleados_EmpleadoId",
                table: "Sueldos");

            migrationBuilder.DropForeignKey(
                name: "FK_Sueldos_Facturas_FacturasId",
                table: "Sueldos");

            migrationBuilder.DropIndex(
                name: "IX_Sueldos_BonoId",
                table: "Sueldos");

            migrationBuilder.DropIndex(
                name: "IX_Sueldos_CargoId",
                table: "Sueldos");

            migrationBuilder.DropIndex(
                name: "IX_Sueldos_DesempenoEmId",
                table: "Sueldos");

            migrationBuilder.DropIndex(
                name: "IX_Sueldos_DesempenoScId",
                table: "Sueldos");

            migrationBuilder.DropIndex(
                name: "IX_Sueldos_EmpleadoId",
                table: "Sueldos");

            migrationBuilder.DropIndex(
                name: "IX_Sueldos_FacturasId",
                table: "Sueldos");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_AsistenciasControl_AsistenciaId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_DepartamentosDepartamentoId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Control_Asistencias_Horario_DetalleHorario_DetId",
                table: "Control_Asistencias");

            migrationBuilder.DropIndex(
                name: "IX_Control_Asistencias_PermisoId",
                table: "Control_Asistencias");

            migrationBuilder.DropColumn(
                name: "BonoId",
                table: "Sueldos");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "Sueldos");

            migrationBuilder.DropColumn(
                name: "DesempenoEmId",
                table: "Sueldos");

            migrationBuilder.DropColumn(
                name: "DesempenoScId",
                table: "Sueldos");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Sueldos");

            migrationBuilder.DropColumn(
                name: "AsistenciasControl_AsistenciaId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "DepartamentosDepartamentoId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "DetalleId",
                table: "Control_Asistencias");

            migrationBuilder.DropColumn(
                name: "Horario_DetalleHorario_DetId",
                table: "Control_Asistencias");

            migrationBuilder.DropColumn(
                name: "PermisoId",
                table: "Control_Asistencias");

            migrationBuilder.RenameColumn(
                name: "SucursalId",
                table: "Empleados",
                newName: "SueldoId");

            migrationBuilder.RenameColumn(
                name: "AsistenciaId",
                table: "Empleados",
                newName: "DesempenoScId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_SucursalId",
                table: "Empleados",
                newName: "IX_Empleados_SueldoId");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Sucursals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Control_AsistenciaId",
                table: "Permisos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Control_AsistenciaId",
                table: "Horario_Dets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SueldoId",
                table: "Facturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Control_AsistenciaId",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DesempenoEmId",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SueldoId",
                table: "Cargos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SueldoId",
                table: "Bonos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sucursals_EmpleadoId",
                table: "Sucursals",
                column: "EmpleadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_Control_AsistenciaId",
                table: "Permisos",
                column: "Control_AsistenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_Dets_Control_AsistenciaId",
                table: "Horario_Dets",
                column: "Control_AsistenciaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_SueldoId",
                table: "Facturas",
                column: "SueldoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Control_AsistenciaId",
                table: "Empleados",
                column: "Control_AsistenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DepartamendoId",
                table: "Empleados",
                column: "DepartamendoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DesempenoEmId",
                table: "Empleados",
                column: "DesempenoEmId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DesempenoScId",
                table: "Empleados",
                column: "DesempenoScId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_SueldoId",
                table: "Cargos",
                column: "SueldoId");

            migrationBuilder.CreateIndex(
                name: "IX_Bonos_SueldoId",
                table: "Bonos",
                column: "SueldoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bonos_Sueldos_SueldoId",
                table: "Bonos",
                column: "SueldoId",
                principalTable: "Sueldos",
                principalColumn: "SueldoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cargos_Sueldos_SueldoId",
                table: "Cargos",
                column: "SueldoId",
                principalTable: "Sueldos",
                principalColumn: "SueldoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Control_Asistencias_Control_AsistenciaId",
                table: "Empleados",
                column: "Control_AsistenciaId",
                principalTable: "Control_Asistencias",
                principalColumn: "Control_AsistenciaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Departamentos_DepartamendoId",
                table: "Empleados",
                column: "DepartamendoId",
                principalTable: "Departamentos",
                principalColumn: "DepartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_desempenoEm_DesempenoEmId",
                table: "Empleados",
                column: "DesempenoEmId",
                principalTable: "desempenoEm",
                principalColumn: "DesempenoEmId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_DesempenoSc_DesempenoScId",
                table: "Empleados",
                column: "DesempenoScId",
                principalTable: "DesempenoSc",
                principalColumn: "DesempenoScId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Sueldos_SueldoId",
                table: "Empleados",
                column: "SueldoId",
                principalTable: "Sueldos",
                principalColumn: "SueldoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Sueldos_SueldoId",
                table: "Facturas",
                column: "SueldoId",
                principalTable: "Sueldos",
                principalColumn: "SueldoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_Dets_Control_Asistencias_Control_AsistenciaId",
                table: "Horario_Dets",
                column: "Control_AsistenciaId",
                principalTable: "Control_Asistencias",
                principalColumn: "Control_AsistenciaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permisos_Control_Asistencias_Control_AsistenciaId",
                table: "Permisos",
                column: "Control_AsistenciaId",
                principalTable: "Control_Asistencias",
                principalColumn: "Control_AsistenciaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sucursals_Empleados_EmpleadoId",
                table: "Sucursals",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "EmpleadoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonos_Sueldos_SueldoId",
                table: "Bonos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cargos_Sueldos_SueldoId",
                table: "Cargos");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Control_Asistencias_Control_AsistenciaId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Departamentos_DepartamendoId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_desempenoEm_DesempenoEmId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_DesempenoSc_DesempenoScId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Sueldos_SueldoId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Sueldos_SueldoId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Horario_Dets_Control_Asistencias_Control_AsistenciaId",
                table: "Horario_Dets");

            migrationBuilder.DropForeignKey(
                name: "FK_Permisos_Control_Asistencias_Control_AsistenciaId",
                table: "Permisos");

            migrationBuilder.DropForeignKey(
                name: "FK_Sucursals_Empleados_EmpleadoId",
                table: "Sucursals");

            migrationBuilder.DropIndex(
                name: "IX_Sucursals_EmpleadoId",
                table: "Sucursals");

            migrationBuilder.DropIndex(
                name: "IX_Permisos_Control_AsistenciaId",
                table: "Permisos");

            migrationBuilder.DropIndex(
                name: "IX_Horario_Dets_Control_AsistenciaId",
                table: "Horario_Dets");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_SueldoId",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_Control_AsistenciaId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_DepartamendoId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_DesempenoEmId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_DesempenoScId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Cargos_SueldoId",
                table: "Cargos");

            migrationBuilder.DropIndex(
                name: "IX_Bonos_SueldoId",
                table: "Bonos");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Sucursals");

            migrationBuilder.DropColumn(
                name: "Control_AsistenciaId",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "Control_AsistenciaId",
                table: "Horario_Dets");

            migrationBuilder.DropColumn(
                name: "SueldoId",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "Control_AsistenciaId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "DesempenoEmId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "SueldoId",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "SueldoId",
                table: "Bonos");

            migrationBuilder.RenameColumn(
                name: "SueldoId",
                table: "Empleados",
                newName: "SucursalId");

            migrationBuilder.RenameColumn(
                name: "DesempenoScId",
                table: "Empleados",
                newName: "AsistenciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_SueldoId",
                table: "Empleados",
                newName: "IX_Empleados_SucursalId");

            migrationBuilder.AddColumn<int>(
                name: "BonoId",
                table: "Sueldos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "Sueldos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DesempenoEmId",
                table: "Sueldos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DesempenoScId",
                table: "Sueldos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Sueldos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AsistenciasControl_AsistenciaId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartamentosDepartamentoId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetalleId",
                table: "Control_Asistencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Horario_DetalleHorario_DetId",
                table: "Control_Asistencias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PermisoId",
                table: "Control_Asistencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_AsistenciasControl_AsistenciaId",
                table: "Empleados",
                column: "AsistenciasControl_AsistenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DepartamentosDepartamentoId",
                table: "Empleados",
                column: "DepartamentosDepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Control_Asistencias_Horario_DetalleHorario_DetId",
                table: "Control_Asistencias",
                column: "Horario_DetalleHorario_DetId");

            migrationBuilder.CreateIndex(
                name: "IX_Control_Asistencias_PermisoId",
                table: "Control_Asistencias",
                column: "PermisoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Control_Asistencias_Horario_Dets_Horario_DetalleHorario_DetId",
                table: "Control_Asistencias",
                column: "Horario_DetalleHorario_DetId",
                principalTable: "Horario_Dets",
                principalColumn: "Horario_DetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Control_Asistencias_Permisos_PermisoId",
                table: "Control_Asistencias",
                column: "PermisoId",
                principalTable: "Permisos",
                principalColumn: "PermisoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Control_Asistencias_AsistenciasControl_AsistenciaId",
                table: "Empleados",
                column: "AsistenciasControl_AsistenciaId",
                principalTable: "Control_Asistencias",
                principalColumn: "Control_AsistenciaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Departamentos_DepartamentosDepartamentoId",
                table: "Empleados",
                column: "DepartamentosDepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "DepartamentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Sucursals_SucursalId",
                table: "Empleados",
                column: "SucursalId",
                principalTable: "Sucursals",
                principalColumn: "SucursalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sueldos_Bonos_BonoId",
                table: "Sueldos",
                column: "BonoId",
                principalTable: "Bonos",
                principalColumn: "BonoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sueldos_Cargos_CargoId",
                table: "Sueldos",
                column: "CargoId",
                principalTable: "Cargos",
                principalColumn: "CargoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sueldos_desempenoEm_DesempenoEmId",
                table: "Sueldos",
                column: "DesempenoEmId",
                principalTable: "desempenoEm",
                principalColumn: "DesempenoEmId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sueldos_DesempenoSc_DesempenoScId",
                table: "Sueldos",
                column: "DesempenoScId",
                principalTable: "DesempenoSc",
                principalColumn: "DesempenoScId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sueldos_Empleados_EmpleadoId",
                table: "Sueldos",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "EmpleadoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sueldos_Facturas_FacturasId",
                table: "Sueldos",
                column: "FacturasId",
                principalTable: "Facturas",
                principalColumn: "FacturaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
