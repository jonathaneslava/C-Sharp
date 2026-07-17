
Console.WriteLine("Console Write Line sirve para escribir datos en la salida de la consola"); 
Console.WriteLine(70);
Console.WriteLine(10 + 20);

/*Tipo de datos
Sirve para reservar memoria correctamente y determinar el comportamiento logico de las variables
La variable es un espacio de memoria donde se guarda un dato
Su utilidad sirve para manipular informacion*/

//Tipos de datos, declaracion de variables e inicializacion
int num = 2; //Almacena valores enteros
double pi = 3.14; //Almacenar valires de tipo decimal
bool activo  = true; //Almacena tipo de dato booleano
char letra = 'a'; //Almacena tipo de dato unico
float precio = 1.50f; //Almacena valores decimales de 32 byts
string abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Cadenas de texto
decimal descuento = 10.50m;
DateTime fecha = DateTime.Now;
//Para ver el contenido de la variable en la consola se usa WriteLine

Console.WriteLine("Tipo de dato Int: " + num);
Console.WriteLine("Tipo de dato Boleano: " + activo);
Console.WriteLine("Tipo de dato Double: " + pi);
Console.WriteLine("Tipo de dato Char: " + letra);
Console.WriteLine("Tipo de dato Float: " + precio);
Console.WriteLine("Tipo de dato String: " + abecedario);
Console.WriteLine("Tipo de dato Decimal: " + descuento);
Console.WriteLine("Tipo de dato Date Time: " + fecha);

//Concatenar valores en salida de datos
string nombre = "Jose";
int edad = 25;

Console.WriteLine("Nombre: " + nombre + " Edad: " + edad ); //Se concatena el texto con el valor de mi variable

//Salto de linea se coloca con "\n"
Console.WriteLine("Nombre: " + nombre + "\n" + 
                  "Edad: " + edad);

//Salto de linea dentro del texto "\n"
Console.WriteLine("Nombre:\n" + nombre);

//Si se quita el Line de WriteLine se coloca la siguiente salida en una misma linea
Console.Write("Nombre: " + nombre);
Console.WriteLine("Edad: " + edad);

//El signo $ usando WriteLine sirve para insertar variables dentro de las comillas o el texto
Console.WriteLine($"Nombre de usuario :{nombre}, edad en 5 años {edad + 5}");

//Constante: Valor fijo que no cambia durante la ejecucion del programa
var distinto_tipo = 10.5; //var le dice al sistema que esa variable puede aceptar tipos de datos variados
Console.WriteLine($"Muestra primer valor: {distinto_tipo}");
distinto_tipo = 200;
Console.WriteLine($"Muestra el segundo valor: {distinto_tipo}");

//Definir una constante, se usa const + tipo de dato y nombre de la variable
const double dato_constante = 3.1416;
Console.WriteLine("Dato constante: " + dato_constante);

//Casting convertir un tipo de dato a otro implicito o explicito

//Implicito, asigna la variable total lo que esta en la variable valor aunque no sea el mismo tipo
int valor = 200;
double total = valor;
Console.WriteLine("Casting Implicito int a double " + total);

//Explicito, se coloca int delante de la variable costo para que acepte el tipo de dato correctamente
double costo = 500.23;
int descuenta = (int)costo;
Console.WriteLine("Casting Explicito double a int: " + descuenta);

//Implicito, muestra el valor de codigo de la letra A en Asci
char letra_prueba = 'A';
int codigoAsci = letra_prueba;
Console.WriteLine("Codigo Asci de A: " + codigoAsci);


string palabra = "12345";
int numero_prueba = Convert.ToInt32(palabra);
Console.WriteLine("Convierte string a entero: " + numero_prueba);

string textoDecimal = "15.60";
double valor_decimal = double.Parse(textoDecimal);
Console.WriteLine("Convierte string a double: " + valor_decimal);

//Quita el path del repositorio, la ubicacion de donde esta el proyecto
Console.ReadKey();

