using Empleados;
using System;
using System.Collections.Generic;

var random = new Random();

List<EmpleadosModel> empleadosLst = new List<EmpleadosModel>()
{
    new EmpleadosModel
    {
        Nombre = "Vicente",
        Apellido = "Estrada",
        Departamento = Departamento.Desarrollo,
        Edad = 23,
        IdExterno = 201112007
    },

    new EmpleadosModel
    {
        Nombre = "Tesifonte",
        Apellido = "Lazcano",
        Departamento = Departamento.Desarrollo,
        Edad = random.Next(18,64),
        IdExterno = random.Next(1,999999999)
    },

    new EmpleadosModel
    {
        Nombre = "Fernando",
        Apellido = "Legazpi",
        Departamento = Departamento.Desarrollo,
        Edad = random.Next(18,64),
        IdExterno = random.Next(1,999999999)
    },

    new EmpleadosModel
    {
        Nombre = "Lucy",
        Apellido = "Escobar",
        Departamento = Departamento.RH,
        Edad = random.Next(18,64),
        IdExterno = random.Next(1,999999999)
    }
};

List<EmpleadosModel> empleadosNuevos = new List<EmpleadosModel>
{
    new EmpleadosModel
    {
        Nombre = "Fabricio",
        Apellido = "Cordero",
        Departamento = Departamento.Desarrollo,
        Edad = random.Next(18,64),
        IdExterno = random.Next(1,999999999)
    },
    new EmpleadosModel
    {
        Nombre = "Julia",
        Apellido = "Lombardo",
        Departamento = Departamento.Admin,
        Edad = 30,
        IdExterno = random.Next(1,999999999)
    }
};

static void ImprimeEmpleado(EmpleadosModel e)
{
    string fila = string.Format("{0,-40} {1,-10} {2,-20} {3,-10} {4}",
        e.Id, e.Nombre, e.Apellido, e.Edad, e.Departamento);
    Console.WriteLine(fila);
}

static void ImprimeEmpleados(IEnumerable<EmpleadosModel> lista, string titulo = "/** --- **/")
{
    Console.WriteLine(titulo);
    var encabezado = string.Format("{0,-40} {1,-10} {2,-20} {3,-10} {4}",
        "ID", "NOMBRE", "APELLIDO", "EDAD", "DEPARTAMENTO");
    Console.WriteLine(encabezado);
    foreach (var lst in lista)
        ImprimeEmpleado(lst);
}
