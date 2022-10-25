using Class;
using System.Security.Cryptography;

List<Empleados> empleadosLst = new List<Empleados>()
{
    new Empleados
    {
        Nombre = "Vicente",
        Apellido = "Estrada",
        Departamento = Departamento.Desarrollo
    },
    new Empleados
    {
        Nombre = "Juan",
        Apellido = "Correa",
        Departamento = Departamento.Desarrollo
    },
    new Empleados
    {
        Nombre = "Michelle",
        Apellido = "Galindo",
        Departamento = Departamento.Desarrollo
    },
    new Empleados
    {
        Nombre = "Lucy",
        Apellido = "Escobar",
        Departamento = Departamento.RH
    },
    new Empleados
    {
        Nombre = "Mariana",
        Apellido = "Morales",
        Departamento = Departamento.Soporte
    },
    new Empleados
    {
        Nombre = "Erik",
        Apellido = "Veracruzano",
        Departamento = Departamento.Soporte
    },
    new Empleados
    {
        Nombre = "Jose",
        Apellido = "Camerino",
        Departamento = Departamento.Soporte
    },
    new Empleados
    {
        Nombre = "Armando",
        Apellido = "Casas",
        Departamento = Departamento.Soporte
    },
};

var emp = empleadosLst.Where(u => (u.Departamento == Departamento.Desarrollo ||
        u.Departamento == Departamento.Soporte) && u.Apellido.ToUpper().StartsWith("C"))
    .OrderByDescending(u => u.Nombre)
    .Select(u => new
    {
        u.Nombre,
        u.Apellido,
        dep = u.Departamento
    });

var header = string.Format("{0, -20} {1, -20} {2}",
    "Nombre", "Apellido", "Departamento");

Console.WriteLine(header);
foreach (var f in emp)
{
    string fila = string.Format("{0, -20} {1, -20} {2}",
        f.Nombre, f.Apellido, f.dep);
    Console.WriteLine(fila);
}

var qe = from e in empleadosLst
         where (e.Departamento == Departamento.Soporte
            || e.Departamento == Departamento.Soporte)
            && e.Apellido.ToLower().StartsWith("c")
         orderby e.Nombre descending
         select new
         {
             e.Nombre,
             e.Apellido,
             dep = e.Departamento
         };

Console.WriteLine();

foreach (var f in qe)
{
    string fila = string.Format("{0, -20} {1, -20} {2}",
        f.Nombre, f.Apellido, f.dep);
    Console.WriteLine(fila);
}