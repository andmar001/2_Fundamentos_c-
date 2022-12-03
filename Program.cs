using Etapa1.Entidades;

Escuela escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,pais:"Colombia", ciudad: "Bogotá");

Console.WriteLine(escuela);

Curso curso1 = new Curso() {
     Nombre = "101"
     };

Curso curso2 = new Curso() {
    Nombre = "201"
    };

Curso curso3 = new Curso() {
    Nombre = "301"
    };

Console.WriteLine(escuela);
Console.WriteLine("===============");
Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
Console.WriteLine($"{ curso2.Nombre }, {curso2.UniqueId}");
Console.WriteLine(curso3);
