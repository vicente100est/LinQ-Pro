string[] niveles = { "Basico", "Intermedio", "Avanzado" };

var nc = niveles.Count();

int max = 6;

var ns = niveles.Where(n => n.Length > max).OrderBy(no => no);

foreach (var n in ns)
    Console.WriteLine(n);

//Expreciones de consualta

var qn = from nivel in niveles
         where nivel.Length > max
         orderby nivel ascending
         select nivel;

Console.WriteLine(qn);