
Console.WriteLine("Console Write Line sirve para escribir datos en la salida de la consola"); 
Console.WriteLine(70);
Console.WriteLine(10 + 20);

//Tipo de datos
//Sirve para reservar memoria correctamente y determinar el comportamiento logico de las variables
//La variable es un espacio de memoria donde se guarda un dato
//Su utilidad sirve para manipular informacion

//Tipos de datos, declaracion de variables e inicializacion
int edad = 2; //Almacena valores enteros
double pi = 3.14; //Almacenar valires de tipo decimal
bool activo  = true; //Almacena tipo de dato booleano
char letra = 'a'; //Almacena tipo de dato unico
float precio = 1.50f; //Almacena valores decimales de 32 byts
string abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Cadenas de texto
decimal descuento = 10.50m;
DateTime fecha = DateTime.Now;
//Para ver el contenido de la variable en la consola se usa WriteLine

Console.WriteLine(edad);
Console.WriteLine(activo);
Console.WriteLine(pi);
Console.WriteLine(letra);
Console.WriteLine(precio);
Console.WriteLine(abecedario);
Console.WriteLine(descuento);
Console.WriteLine(fecha);


//Quita el path del repositorio, la ubicacion de donde esta el proyecto
Console.ReadKey();

