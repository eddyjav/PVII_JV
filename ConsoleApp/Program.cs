using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Creacion de Departamentos
            Departamento Ventas = new Departamento()
            {
                Nombre = "Ventas"
            };

            //Creacion de Sucursales
            Sucursal Sucursal1 = new Sucursal() 
            {
                Nombre = "Sucursal Sur",
                Direccion = "Av. Villaflora"
            };

            Sucursal Sucursal2 = new Sucursal()
            {
                Nombre = "Sucursal Norte",
                Direccion = "Av. Galo Plaza"
            };

            //creacion de empleado
            Empleado Juan = new Empleado() { 
                Nombres="Juan", 
                Apellidos="Perez",
                Cedula=1234567890,
                Direccion="UIO",
                Telefono=12346, 
                Email="jp@gmail.com",
                Departamentos = Ventas,
                Sucursales = Sucursal1 
            };

            Empleado Andres = new Empleado()
            {
                Nombres = "Andres",
                Apellidos = "Simba",
                Cedula = 1234567891,
                Direccion = "GYE",
                Telefono = 12347,
                Email = "as@gmail.com",
                Departamentos= Ventas,
                Sucursales= Sucursal2
            };

            //Ventas.ListaEmDep = new List<Empleado>() { Juan, Andres};


            Repositorio db = new Repositorio();
            db.Departamentos.Add(Ventas);
            db.Sucursals.Add(Sucursal1);
            db.Sucursals.Add(Sucursal2);
            db.Empleados.Add(Juan);
            db.Empleados.Add(Andres);
            db.SaveChanges();
        }
    }
}
