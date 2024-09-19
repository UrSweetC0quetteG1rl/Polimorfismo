
using Polimorfismo.Clases;

DocenteContratoFijo docente1 = new DocenteContratoFijo("Jose Luis", "Hernandez", "880002568", 68000, true);
DocenteContratoFijo docente2 = new DocenteContratoFijo("Wandy", "Familia", "99952147", 35000, false);

DocentePorHora docentePorHora1 = new DocentePorHora("Petronila", "Germosen", "21453677", 42);

EmpleadoAdministrativo administrativo1 = new EmpleadoAdministrativo("Robert", "Pimentel", "2224553365", 75000, true);
EmpleadoAdministrativo administrativo2 = new EmpleadoAdministrativo("Ashley", "Binet", "2214788855", 82000, false);

Console.WriteLine(docente1);
Console.WriteLine(docente2);
Console.WriteLine(administrativo1);
Console.WriteLine(administrativo2);
Console.WriteLine(docentePorHora1);

Console.ReadKey();
