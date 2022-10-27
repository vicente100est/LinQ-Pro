using Class;

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
List<Empleados> empleadosNuevos = new List<Empleados>
{
    new Empleados
    {
        Nombre = "Fabricio",
        Apellido = "Cordero",
        Departamento = Departamento.Desarrollo
    },
    new Empleados
    {
        Nombre = "Julia",
        Apellido = "Lombardo",
        Departamento = Departamento.Admin
    }
};
empleadosLst.AddRange(empleadosNuevos); //Agrega nuevos datos a la lista

//var subQ = empleadosLst.Where(e => e.Nombre.Length == empleadosLst
//    .OrderBy(eb => eb.Apellido.Length)
//    .Select(eb => eb.Apellido.Length)
//    .FirstOrDefault());

//Expresiones de consulta
//var subQ = from e in empleadosLst
//           where e.Nombre.Length == (from eb in empleadosLst
//                                     orderby eb.Apellido.Length
//                                     select eb.Apellido.Length).First()
//           select e;

//Mas corta
var subQ = from e in empleadosLst
           where e.Nombre.Length ==
           empleadosLst.OrderBy(eb => eb.Apellido.Length).First().Apellido.Length
           select e;

var encabezado = string.Format("{0, -2} {1}",
    "Nomabre", "Apellido");

Console.WriteLine(encabezado);

foreach (var f in subQ)
{
    string fila = string.Format("{0, -2} {1}",
        f.Nombre, f.Apellido);
    Console.WriteLine(fila);
}