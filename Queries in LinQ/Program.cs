using Queries_in_LinQ;

List<Empleado> empleados = new List<Empleado>()
{
    new Empleado
    {
        Nombre = "Vicente",
        Apellido = "Estrada",
        Departamento = Departamento.Desarrollo
    },
    new Empleado
    {
        Nombre = "Fernando",
        Apellido = "Legaspi",
        Departamento = Departamento.Desarrollo
    },
    new Empleado
    {
        Nombre = "Lucy",
        Apellido = "Escobar",
        Departamento = Departamento.Admin
    },
    new Empleado
    {
        Nombre = "Irma",
        Apellido = "Estrada",
        Departamento = Departamento.Admin
    },
    new Empleado
    {
        Nombre = "Belen",
        Apellido = "Najarro",
        Departamento = Departamento.RH
    },
    new Empleado
    {
        Nombre = "Michelle",
        Apellido = "Galindo",
        Departamento = Departamento.Admin
    }
};

//Desarrolla un programa que tenga opciones de filtrado y ordenamiento, se necesita obtener los empleados del
//Departamento de desarrollo que contengan la letra F, y ordenados por id e imprimir en formato de tipo tabla

var emp = empleados.Where(u => u.Departamento == Departamento.Desarrollo && u.Nombre.ToUpper().Contains("F"))
    .OrderBy(n => n.Id); ;


//Y si se necesita objeto diferente a empleado como salida
var filter = empleados.Where(u => u.Departamento == Departamento.Desarrollo && u.Nombre.ToUpper().Contains("V"))
    .OrderBy(u => u.Id)
    .Select(u => new
    {
        u.Id,
        u.Nombre,
        InicialAp = u.Apellido.Substring(0, 1),
        Dpto = u.Departamento.ToString()
    }); ;

var header = string.Format("{0, -40} {1, -10} {2, -10} {3}",
    "ID", "Nombre", "Apellido", "Departamento");

Console.WriteLine(header);
foreach (var f in filter)
{
    string fila = string.Format("{0, -40} {1, -10} {2, -10} {3}",
        f.Id, f.Nombre, f.InicialAp, f.Dpto);
    Console.WriteLine(fila);
}