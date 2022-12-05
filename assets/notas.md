# cw - System.Console.WriteLine();

# format code
shift alt f  

# operadores y expresiones de c#
https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/

# Tipos de colecciones  
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
Simples
manipulan todo como tipos de object
- ArrayList, BitArray, Queue, Stack, SortedList, Hashtable, StringCollection, StringDictionary

Especiales
manipulan todo como tipos de datos primitivos
- StringCollection, bitVector, ListDictionary

Genericos
usan generics para crear implementaciones optimizadas de coleccion segun e tipo de dato configurado
- List<T>, Dictionary<T>, Queue<T>, Stack<T>, LinkedList<T>, SortedList<T>, SortedDictionary<T>, SortedSet<T>, HashSet<T>

Concurrent

# Ver todas accediendo a su tipo
System.Collections.Generic

metodos de las listas 
- remover
otra_coleccion.Clear();
- remover
otra_coleccion.Clear();

// escuela.ListaCursos.Remove(otra_coleccion[0]);  //por index especifico
// escuela.ListaCursos.Remove(tmp);  //por objeto especifico

# removeAll  se le pasa un predicadom
otra_coleccion.RemoveAll(delegate (Curso obj) { return obj.Nombre == "301"; });

# hashcode
Es un codigo unico de los objetos

# metodos
Por conversion los metodos inician en mayusculas

# Predicados 
Son metodos  que deben devolver un boolean.
Son funciones como parametros dentro de otra funcion

# Comentarios ---->    ///
Se colocan los 3 slash /// para poner una descripcion de lo que hace el metodo
/// <summary>
/// Esta clase imprime
/// </summary>
/// <param name="escuela"></param>
