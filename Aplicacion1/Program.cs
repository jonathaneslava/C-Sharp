
using System.Diagnostics.Tracing;

Console.WriteLine("Console Write Line sirve para escribir datos en la salida de la consola"); 
Console.WriteLine(70);
Console.WriteLine(10 + 20);
Console.WriteLine("=====================================");

/*Tipo de datos
Sirve para reservar memoria correctamente y determinar el comportamiento logico de las variables
La variable es un espacio de memoria donde se guarda un dato
Su utilidad sirve para manipular informacion*/

//Tipos de datos, declaracion de variables e inicializacion
Console.WriteLine("TIPO DE DATOS");
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
Console.WriteLine("=====================================");

//Concatenar valores en salida de datos
Console.WriteLine("CONCATENAR");
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
Console.WriteLine("=====================================");

//Definir una constante, se usa const + tipo de dato y nombre de la variable
Console.WriteLine("DEFINIR UNA CONSTANTE");
const double dato_constante = 3.1416;
Console.WriteLine("Dato constante: " + dato_constante);
Console.WriteLine("=====================================");

//Casting convertir un tipo de dato a otro implicito o explicito
Console.WriteLine("CASTING");
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
Console.WriteLine("=====================================");

//Operadores
Console.WriteLine("OPERADORES ARITMETICOS");
int num1 = 90, num2 = 70, num3 = 10;

//Operador Suma
int suma_total = num1 + num2;
Console.WriteLine("Suma numero 1 mas numero 2: " + suma_total);

//Operador Resta
int diferencia = num1 - num2;
Console.WriteLine("Diferencia de numero 1 menos numero 2: " + diferencia);

//Operador Muliplicacion
int producto = num3 * num2;
Console.WriteLine("Multiplica de numero 3 por numero 2: " + producto);

//Operador Division
int resultado = num1 / num3;
Console.WriteLine("Division de numero 1 entre numero 3: " + resultado);

//Residuo
var modulo = num2 % num3;
Console.WriteLine("El residuo de dividir el numero 2 entre numero 3: " + modulo);
Console.WriteLine("=====================================");

//Entrada de datos
Console.WriteLine("ENTRADA DE DATOS...");
Console.WriteLine("INTRODUZCA SUS DATOS...");
Console.WriteLine("Introduzca su nombre...");
string nombre_usuario = Console.ReadLine(); //Console ReadLine guarda en la variable el dato recibido por el usuario
Console.WriteLine("Introduzca su edad...");
int edad_usuario = Convert.ToInt32(Console.ReadLine()); //Se realiza un casting debido a que ReadLine solo lee string
Console.WriteLine("Introduzca su salario...");
double salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("=====================================");
Console.WriteLine("Nombre colocado: " + nombre_usuario);
Console.WriteLine("Edad colocada: " + edad_usuario);
Console.WriteLine("Salario colocado: " + salario);
Console.WriteLine("=====================================");

//Operadores de incremento y decremento, aumenta o disminuye el valor de una variable
//Incrementa
Console.WriteLine("OPERADORES DE INCREMENTO Y DECREMENTO");
int valor_incrementa = 5;
Console.WriteLine("Valor inicial: " + valor_incrementa);
valor_incrementa ++; //Primero usa la variable y despues la incrementa
Console.WriteLine("Valor incrementado: " + valor_incrementa);
++valor_incrementa; //Primero incrementa la variable y despues la usa
Console.WriteLine("Valor incrementado: " + valor_incrementa);
//Decremento
int valor_decremento = 5;
Console.WriteLine("Valor inicial: " + valor_decremento);
valor_decremento--; //Primero usa la variable y despues la decrementa
Console.WriteLine("Valor incrementado: " + valor_decremento);
--valor_decremento; //Primero decrementa la variable y despues la usa
Console.WriteLine("Valor incrementado: " + valor_decremento);
Console.WriteLine("=====================================");

//Incrementa y Decrementa una cantidad en especifico
int incremento = 3;
Console.WriteLine("Valor inicial: " + incremento);
incremento += 3; //Incrementa en el numero despues del igual, en este caso el 3 al numero inicial
Console.WriteLine("Valor Incrementado: " + incremento);
int decremento = 9;
Console.WriteLine("Valor inicial: " + decremento);
decremento -= 3; //Decrementa en el numero despues del igual, en este caso el 3 al numero inicial
Console.WriteLine("Valor Decrementado: " + decremento);
Console.WriteLine("=====================================");

//Quita el path del repositorio, la ubicacion de donde esta el proyecto
Console.ReadKey();

