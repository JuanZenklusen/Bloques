/* Bloque para calcular promedio de notas de un alumno segun cantidad de examenes que tiene*/

string alumno = "Nombre Alumno";
int cantidadDeNotas = 0;
double promedio = 0;
double nota = 0;
double sumaDeNotas = 0;

Console.WriteLine("Ingrese la cantidad de examenes que va a tener {0}: ", alumno);
cantidadDeNotas = int.Parse(Console.ReadLine());
        
for ( int i = 1 ; i <= cantidadDeNotas ; i++) {
          Console.WriteLine("Ingrese nota del examen {0} ", i);
          nota = double.Parse(Console.ReadLine());
          sumaDeNotas = sumaDeNotas + nota;
        }
        
promedio = sumaDeNotas / cantidadDeNotas;
Console.WriteLine("El promedio final es: {0}", promedio);
