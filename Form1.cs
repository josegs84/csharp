using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Aqui pondremos el código válido para que podamos utilizar el InputBox en nuestros ejercicios
        /// </summary>
        /// <param name="texto">El texto introducido se obtendrá a través del formulario emergente InputBox, invocado en los ejercicios</param>
        /// <returns></returns>
        private static string InputBox(string texto)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = texto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }
        /* 
         * Ejercicio 501: Realiza un programa en Visual C# que lea 10 números por teclado, y después los muestre. Utiliza para ello un vector. 
         */
        const int k501 = 10;
        int[] vector501 = new int[k501];
        /// <summary>
        /// Función que captura los numeros solicitados y los muestra en pantalla
        /// </summary>
        /// <param name="vector501">El vector tiene una cardinalidad de 10.</param>
        /// <returns></returns>
        string leerymostrar501(int[] vector501)
        {
            string textoinic = "El vector tiene los numeros ";
            string texto = "";
            for (int i = 0; i < k501; i++)
            {
                vector501[i] = int.Parse(InputBox("Introduzca el número " + i));
                if (vector501[i] == vector501[k501 - 1])
                    texto = texto + vector501[i] + ".";
                else
                    texto = texto + vector501[i] + ", ";
            }
            textoinic = textoinic + texto;
            return textoinic;
        }

        private void btn501leerymostrar_Click(object sender, EventArgs e)
        {
            string salida = leerymostrar501(vector501);
            MessageBox.Show(salida);
        }
        /*
         * Ejercicio 502: Realizar un programa que lea los elementos de un array o vector de 10 enteros y visualice su media. La media se calculará mediante una función.
         */
        const int k502 = 10;
        int[] vector502 = new int[k502];
        /// <summary>
        /// Función que realizará la lectura de los números para incluirlos en el vector.
        /// </summary>
        /// <param name="vector502">Vector con cardinalidad 10.</param>
        void leer502(int[] vector502)
        {
            for (int i = 0; i < k502; i++)
            {
                vector502[i] = int.Parse(InputBox("Introduzca el numero de la posición " + i));
            }
        }
        /// <summary>
        /// Función que calculará la media de los números del vector.
        /// </summary>
        /// <param name="vector502">Vector con cardinalidad 10.</param>
        /// <returns></returns>
        double media502(int[] vector502)
        {
            double media = 0;
            for (int i = 0; i < vector502.Length; i++)
            {
                media = media + vector502[i];
            }
            media = media / vector502.Length;
            return media;
        }

        private void btn502leerymedia_Click(object sender, EventArgs e)
        {
            double salida;
            leer502(vector502);
            salida = media502(vector502);
            MessageBox.Show("La media de los numeros introducidos es " + salida);
        }
        /*
         * Ejercicio 503: Realizar un programa que lea los elementos de un vector de 10 enteros y nos visualice posteriormente el menor de ellos. Utilizar programación modular.
         */
        const int k503 = 10;
        int[] vector503 = new int[k503];
        /// <summary>
        /// Función que introduce los números dentro del vector.
        /// </summary>
        /// <param name="vector503">Vector de cardinalidad 10.</param>
        void leer503(int[] vector503)
        {
            for (int i = 0; i < vector503.Length; i++)
            {
                vector503[i] = int.Parse(InputBox("Introduzca el numero de la posicion " + i));
            }
        }
        /// <summary>
        /// Función que lee el vector posición por posición y compara entre ellos cual es el menor de los números y lo devuelve.
        /// </summary>
        /// <param name="vector503">Vector de cardinalidad 10.</param>
        /// <returns></returns>
        int menor503(int[] vector503)
        {
            int menor = 0;
            for (int i = 0; i < vector503.Length; i++)
            {
                if (i == 0)
                {
                    menor = vector503[i];
                } else
                {
                    if (menor > vector503[i])
                        menor = vector503[i];
                }
            }
            return menor;
        }
        private void btn503Leerymenor_Click(object sender, EventArgs e)
        {
            string texto = "El número menor de la serie es ";
            int salida;
            leer503(vector503);
            salida = menor503(vector503);
            MessageBox.Show(texto + salida);
        }
        /*
         * Ejercicio 504: Escribir un programa con un botón que lea un vector de números positivos y negativos. En otro botón recorrerá el vector 
         * sustituyendo los números positivos por 0 y mostrará cuantos números negativos había. Hacerlo modularizando
         */
        const int k504 = 5;
        int[] vector504 = new int[k504];
        /// <summary>
        /// Función que solicita al usuario añadir números positivos y negativos y que los irá almacenando en el vector.
        /// </summary>
        /// <param name="vector504">Vector de cardinalidad 10.</param>
        string leer504(int[] vector504)
        {
            string resultado = "El vector inicial es \n";
            for (int i = 0; i < vector504.Length; i++)
            {
                // 
                vector504[i] = int.Parse(InputBox("Introduzca un número positivo o negativo pata la posicion " + i));
                if(vector504[i] == vector504[k504 - 1])
                {
                    resultado = resultado + vector504[i] + ".";
                } else
                {
                    resultado = resultado + vector504[i] + ", ";
                }
            }
            return resultado;
        }
        /// <summary>
        /// <para>Función que modifica los datos introducidos en el vector. Establecerá a 0 los números positivos y contará los números negativos.</para>
        /// <para>Para ello, se utiliza un contador que luego devolverá la cantidad de números negativos contados en el vector.</para>
        /// </summary>
        /// <param name="vector504">Vector de cardinalidad 10.</param>
        /// <returns></returns>
        int modifica504(int[] vector504)
        {
            int contador = 0;
            for (int i = 0; i < vector504.Length; i++)
            {
                // Este condicional, verifica si el número tratado es mayor o igual a 0 (número positivo). De ser así, lo convierte a 0. Si es negativo, lo añade al contador.
                if (vector504[i] >= 0)
                {
                    vector504[i] = 0;
                } else
                {
                    contador++;
                }
            }
            return contador;
        }
        /// <summary>
        /// Función que leerá el contenido del vector ya modificado y creará una cadena de texto que luego será mostrada.
        /// </summary>
        /// <param name="vector504">Vector de cardinalidad 10.</param>
        /// <returns></returns>
        string impresion504(int[] vector504)
        {
            string resultado = "El vector final es ";
            for (int i = 0; i < vector504.Length; i++)
            {
                // Este condicional, verifica si es el último número de la serie. En ese caso, pondrá un punto (.). Si no, añadirá una coma (,) y un espacio ( ).
                if (vector504[i] == vector504[k504 - 1])
                {
                    resultado = resultado + vector504[i] + ".";
                }
                else
                {
                    resultado = resultado + vector504[i] + ", ";
                }
            }
            return resultado;
        }

        private void btn504leer_Click(object sender, EventArgs e)
        {
            /*
             * En este ejercicio, todas las llamadas a las funciones se hacen una a una desde el botón aunque se pueden encadenar unas a otras
             * y así ahorrar algo de código, aunque lo harían algo mas complejo.
             */
            string texto1, texto2;
            int salida;
            // Se hace la llamada a la función leer504 para que se solicite al usuario introducir 5 valores positivos o negativos para almacenarlos en el vector.
            leer504(vector504);
            // La variable "salida" llama a la funcion modifica504 que será la encargada de modificar el vector introducido por el usuario y que recibirá el nº de negativos que tiene.
            salida = modifica504(vector504);
            // La variable "texto2" llama a la función impresion504 que recorrerá el vector y devolverá el contenido del mismo una vez ya modificado.
            texto1 = "Hay " + salida + " números negativos. \n";
            texto2 = impresion504(vector504);
            MessageBox.Show(texto1 + texto2);
        }
        /*
         * Programa 505: Realizar un programa que lea dos vectores de números. A continuación sumaremos, posición a posición, 
         * en otro vector los dos anteriores, y por último, lo imprimiremos por pantalla.
         */

        const int k505 = 5;
        int[] vector505a = new int[k505];
        int[] vector505b = new int[k505];
        int[] vector505final = new int[k505];
        /// <summary>
        /// Función que solicita al usuario incluir los números al vector A.
        /// </summary>
        /// <param name="vector505a">Vector con cardinalidad 5.</param>
        void leer505a(int[] vector505a)
        {
            for (int i = 0; i < k505; i++)
            {
                vector505a[i] = int.Parse(InputBox("Introduzca números del vector A, posición " + i));
            }
        }
        /// <summary>
        /// Funcion que solicita al usuario incluir los números del vector B.
        /// </summary>
        /// <param name="vector505b">Vector con cardinalidad 5.</param>
        void leer505b(int[] vector505b)
        {
            for (int j = 0; j < k505; j++)
            {
                vector505b[j] = int.Parse(InputBox("Introduzca números del vector B, posición " + j));
            }
        }
        /// <summary>
        /// Función que realiza la suma de ambos vectores, una vez hayamos capturado todos los datos.
        /// </summary>
        /// <param name="vector505a">Vector con cardinalidad 5.</param>
        /// <param name="vector505b">Vector con cardinalidad 5.</param>
        void sumar505(int[] vector505a, int[] vector505b)
        {
            for (int i = 0; i < k505; i++)
            {
                vector505final[i] = vector505a[i] + vector505b[i];
            }
        }
        /// <summary>
        /// Función que creará la cadena con el resultado de las sumas de los anteriores vectores. (Vector A y Vector B)
        /// </summary>
        /// <param name="vector505final">Vector con cardinalidad 5.</param>
        /// <returns>Devuelve una cadena de texto compuesta por la suma de los anteriores vectores.</returns>
        string imprime505(int[] vector505final)
        {
            string salida = "El resultado final será: \n", separador = "";
            for (int i = 0; i < k505; i++)
            {
                if(i == (k505 - 1))
                {
                    separador = ".";
                } else
                {
                    separador = ", ";
                }
                salida = salida + vector505final[i] + separador;
            }
            return salida;
        }
        // Botón que realizará la captura de los datos para vectores A y B y además, sumará los datos y los introducirá en un vector Final.
        private void btn505leer_Click(object sender, EventArgs e)
        {
            leer505a(vector505a);
            leer505b(vector505b);
            sumar505(vector505a, vector505b);
        }
        // Botón que llamará la función que creará la cadena que ha de mostrarse con el resultado de la suma de los vectores.
        private void btn505mostrar_Click(object sender, EventArgs e)
        {
            string salida = imprime505(vector505final);
            MessageBox.Show(salida);
        }
        /*
         *  Ejercicio 506: Realizar un programa que lea dos vectores de 10 elementos de tipo entero y posteriormente compruebe si son o no iguales. 
         *  Dos vectores serán iguales si TODOS sus elementos (posición a posición) son iguales. Utilizar programación modular.
         */
        const int k506 = 10;
        int[] vector506a = new int[k506];
        int[] vector506b = new int[k506];
        /// <summary>
        /// Función que solicita al usuario introducir los numeros en el vector A.
        /// </summary>
        /// <param name="vector506a">Vector de cardinalidad 10.</param>
        void leer506a(int[] vector506a)
        {
            for (int i = 0; i < k506; i++)
            {
                vector506a[i] = int.Parse(InputBox("Introduzca valores del vector A, posición " + i));
            }
        }
        /// <summary>
        /// Funcion que solicita al usuario introducir los numeros en el vector B.
        /// </summary>
        /// <param name="vector506b">Vector de cardinalidad 10.</param>
        void leer506b(int[] vector506b)
        {
            for (int i = 0; i < k506; i++)
            {
                vector506b[i] = int.Parse(InputBox("Introduzca valores del vector B, posición " + i));
            }
        }
        /// <summary>
        /// Función que verifica que ambos vectores cumplen la condición de ser iguales en cada uno de sus valores
        /// </summary>
        /// <param name="vector506a">Vector de cardinalidad 10.</param>
        /// <param name="vector506b">Vector de cardinalidad 10.</param>
        /// <returns>Devuelve true si ambos vectores son iguales. Devuelve false si ambos vectores no son iguales.</returns>
        bool verifica506(int[] vector506a, int[] vector506b)
        {
            bool iguales = false;
            for (int i = 0; i < k506; i++)
            {
                if (vector506a[i] == vector506b[i])
                    iguales = true;
                else
                    iguales = false;
            }
            return iguales;
        }
        private void btn506leeryverificar_Click(object sender, EventArgs e)
        {
            bool salida;
            leer506a(vector506a);
            leer506b(vector506b);
            salida = verifica506(vector506a, vector506b);
            if (!salida)
                MessageBox.Show("Los vectores no son iguales");
            else
                MessageBox.Show("Los vectores son iguales");
        }
        /*
         * Ejercicio 507: Realizar un programa que lea los 10 elementos de un vector de enteros, obligando al usuario a que cada elemento sea mayor que el anterior.
         */
        const int k507 = 10;
        int[] vector507 = new int[k507];
        /// <summary>
        /// <para>Función que realizará todo el trabajo.</para>
        /// <para>En primer lugar, captura el dato introducido por el usuario.</para>
        /// <para>En segundo lugar, valida si cumple los criterios. Si es el primero o si es mayor que el anterior, es correcto.</para>
        /// <para>De lo contrario, vuelve al paso anterior del bucle y comienza de nuevo, avisando del error al usuario.</para>
        /// <para>Finalmente, en el caso de ser el correcto. Incluye el dato en una cadena.</para>
        /// </summary>
        /// <param name="vector507">Vector de cardinalidad 10.</param>
        /// <returns>Devuelve una cadena con los números introducidos por el usuario.</returns>
        string leer507(int[] vector507)
        {
            int validar;
            string resultado = "El vector contiene los números ";
            string mensaje = "Introduzca un valor superior al anterior en la posición ";
            string aviso = "";
            for (int i = 0; i < k507; i++)
            {
                validar = int.Parse(InputBox(aviso + mensaje + i));

                if (i == 0 || vector507[i - 1] < validar)
                {
                    aviso = "";
                    vector507[i] = validar;
                    resultado = resultado + " " + vector507[i];
                }
                else
                {
                    aviso = "ERROR! INTRODUJO UN VALOR INFERIOR AL ÚLTIMO\n";
                    i--;
                }
            }
            return resultado;
        }

        private void btn507leer_Click(object sender, EventArgs e)
        {
            string salida = leer507(vector507);
            MessageBox.Show(salida);
        }
        /*
         * Ejercicio 508: Escribir un subprograma que lea un vector de números enteros positivos. Escribir otra función que acepte el vector de números
         * sustituyendo cada valor repetido por el –1 y devolviendo el número de valores modificados.
         */
        const int k508 = 10;
        int[] vector508a = new int[k508];
        int[] vector508b = new int[k508];
        /// <summary>
        /// Función que solicita al usuario la introducción de los números.
        /// </summary>
        /// <param name="vector508a">Vector de cardinalidad 10.</param>
        void leer508(int[] vector508a)
        {
            for (int i = 0; i < k508; i++)
            {
                vector508a[i] = int.Parse(InputBox("Introduzca el número de la posición " + i));
            }
        }
        /// <summary>
        /// <para>Función que realizará el paso de valores de un vector a otro y a su vez, validará si el número se encuentra ya repetido.</para>
        /// <para>Para ello, se apoyará en la utilización de un semáforo, que indicará, a la vez de la comparación de valores, si ya ha comprobado que ese numero está repetido o no.</para>
        /// <para>En caso de no tenerlo, validará una vez que un numero es repetido pero volverá a leerlo y en otra posición no estaría repetido, por lo que validaría el numero finalmente.</para>
        /// <para>Me doy cuenta que es posible hacerlo con un while y de ese modo, ahorraría al sistema tener que seguir dando vueltas al número, puesto que el programa ya sabría que el número está repetido.</para>
        /// </summary>
        /// <param name="vector508a">Vector de cardinalidad 10.</param>
        void repetidos508(int[] vector508a)
        {
            bool semaforo;
            for (int i = 0; i < k508; i++)
            {
                // Activamos el semáforo. Cada vez que de una vuelta, abrirá el semaforo para validar
                semaforo = true;
                // Si es el primero, no hay repetido, por lo que escribimos
                if (i == 0)
                {
                    vector508b[i] = vector508a[i];
                } else
                {
                    // Aquí va a comenzar a validar las posiciones anteriores para ver si el número está repetido o no
                    for (int j = 0; j < i; j++)
                    {
                        // Si está repetido, escribimos -1 y cerramos el semáforo para que entienda que ya está repetido
                        if (vector508a[i] == vector508a[j])
                        {
                            vector508b[i] = -1;
                            semaforo = false;
                        // Si no está repetido y el semáforo está abierto, establecemos el valor
                        } else if (semaforo == true)
                        {
                            vector508b[i] = vector508a[i];
                        }
                    }
                }              
            }
        }
        /// <summary>
        /// Función que hará la impresión del vector en una cadena
        /// </summary>
        /// <param name="vector508b"></param>
        /// <returns>Devuelve el texto ya estructurado a mostrar por pantalla</returns>
        string imprimir508(int[] vector508b)
        {
            string texto = "El vector final es \n";
            string separador = ", ";
            for (int i = 0; i < k508; i++)
            {
                if (i == (k508 - 1))
                {
                    separador = ".";
                }
                texto = texto + vector508b[i] + separador;
            }
            return texto;
        }

        private void btn508leer_Click(object sender, EventArgs e)
        {
            leer508(vector508a);
        }

        private void btn508sustituye_Click(object sender, EventArgs e)
        {
            string salida;
            repetidos508(vector508a);
            salida = imprimir508(vector508b);
            MessageBox.Show(salida);
        }
        /*
         * Ejercicio 509: Realizar un programa que lea un vector de 10 enteros y obtenga otro al revés.
         */
        const int k509 = 10;
        int[] vector509a = new int[k509];
        int[] vector509b = new int[k509];
        /// <summary>
        /// Solicitamos al usuario introducir los numeros para el vector
        /// </summary>
        /// <param name="vector509a">Vector de cardinalidad 10.</param>
        void leer509(int[] vector509a)
        {
            for (int i = 0; i < k509; i++)
            {
                vector509a[i] = int.Parse(InputBox("Introduzca el numero " + i + " de la serie"));
            }
        }
        /// <summary>
        /// Pasa los números al vector B, empezando éste por la posición final y el vector A comienza desde la posición inicial.
        /// </summary>
        /// <param name="vector509a">Vector de cardinalidad 10.</param>
        void pasar509(int[] vector509a){
            int contador = k509 - 1;
            for (int i = 0; i < k509; i++)
            {
                vector509b[contador] = vector509a[i];
                contador--;
            }
        }
        /// <summary>
        /// Escribe en una variable string los datos contenidos en el vector B
        /// </summary>
        /// <param name="vector509b">Vector de cardinalidad 10.</param>
        /// <returns>Devuelve la cadena de texto con el contenido del vector B</returns>
        string escribe509(int[] vector509b)
        {
            string texto = "La transformación del vector es \n";
            string separador = ", ";
            for (int i = 0; i < k509; i++)
            {
                if (i == k509 - 1)
                {
                    separador = ".";
                }
                texto = texto + vector509b[i] + separador;
            }
            return texto;
        }

        private void btn509leer_Click(object sender, EventArgs e)
        {
            leer509(vector509a);
            pasar509(vector509a);
            string texto = escribe509(vector509b);
            MessageBox.Show(texto);
        }
        /*
         * Ejercicio 510: Realizar un programa que lea un vector de 10 enteros y obtenga otro vector 
         * con todos los elementos del primer vector desplazados una posición a la derecha, salvo el 
         * último que se desplazará a la primera posición.
         */
        const int k510 = 10;
        int[] vector510a = new int[k510];
        int[] vector510b = new int[k510];
        /// <summary>
        /// Solicita al usuario que introduzca los números del Vector A
        /// </summary>
        /// <param name="vector510a">Vector de cardinalidad 10.</param>
        void leer510(int[] vector510a)
        {
            for (int i = 0; i < k510; i++)
            {
                vector510a[i] = int.Parse(InputBox("Introduzca el valor de la posición " + i + " de la serie"));
            }
        }
        /// <summary>
        /// <para>El vector B comienza desde 0 y el vector A desde 1</para>
        /// <para>Cuando el vector A llega al tope, vuelve al comienzo del mismo para seguir escribiendo sobre B</para>
        /// </summary>
        /// <param name="vector510a">Vector de cardinalidad 10.</param>
        void transfor510(int[] vector510a)
        {
            int contador = 0;
            for (int i = 0; i < k510; i++)
            {
                contador++;
                if(contador == k510)
                {
                    contador = 0;
                }
                vector510b[i] = vector510a[contador];
            }
        }
        /// <summary>
        /// Escribe el contenido del vector B en la cadena de texto
        /// </summary>
        /// <param name="vector510b">Vector de cardinalidad 10.</param>
        /// <returns>Devuelve la cadena de texto con el contenido del vector B</returns>
        string escribe510(int[] vector510b)
        {
            string texto = "La salida es \n";
            string separador = ", ";
            for (int i = 0; i < k510; i++)
            {
                if(i == k510 - 1)
                {
                    separador = ".";
                }
                texto = texto + vector510b[i] + separador;
            }
            return texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leer510(vector510a);
            transfor510(vector510a);
            string salida = escribe510(vector510b);
            MessageBox.Show(salida);
        }

        /*
         * Ejercicio 511: Mismo ejercicio que el 510 pero usando solo 1 vector.
         */
        
        void transforma511(int[] vector510a)
        {
            int temporal = vector510a[0];
            int contador = 0;
            for (int i = 0; i < k510; i++)
            {
                contador++;
                if (contador == k510)
                {
                    vector510a[i] = temporal;
                } else
                {
                    vector510a[i] = vector510a[contador];
                }
            }
        }

        string escribe511(int[] vector510a)
        {
            string texto = "La salida resultante es \n";
            string separador = ", ";
            for (int i = 0; i < k510; i++)
            {
                if (i == k510 - 1)
                {
                    separador = ".";
                }
                texto = texto + vector510a[i] + separador;
            }
            return texto;
        }

        private void btn511_Click(object sender, EventArgs e)
        {
            leer510(vector510a);
            transforma511(vector510a);
            string salida = escribe511(vector510a);
            MessageBox.Show(salida);
        }
        /*
         * Ejercicio 512: Realizar un programa que permita introducir las temperaturas de las 24 horas de un día en Alicante (las temperaturas se introducirán en un vector). 
         * Realizar un subprograma que permita obtener la temperatura máxima, mínima y la media.
         */

        const int k512 = 24;
        int[] vector512 = new int[k512];

        void leer512(int[] vector512)
        {
            for (int i = 0; i < k512; i++)
            {
                vector512[i] = int.Parse(InputBox("Introduzca la temperatura de las " + i + " horas en Alicante"));
            }
        }

        string maxima512(int[] vector512)
        {
            string texto = "La temperatura máxima de Alicante hoy es ";
            int maxima = vector512[0];
            for (int i = 0; i < k512; i++)
            {
                if (maxima < vector512[i])
                {
                    maxima = vector512[i];
                }
            }
            texto = texto + maxima;
            return texto;
        }

        string minima512(int[] vector512)
        {
            string texto = "La temperatura mínima de Alicante hoy es ";
            int minima = vector512[0];
            for (int i = 0; i < k512; i++)
            {
                if(minima > vector512[i])
                {
                    minima = vector512[i];
                }
            }
            texto = texto + minima;
            return texto;
        }

        string media512(int[] vector512)
        {
            string texto = "La temperatura media de Alicante hoy es ";
            int media = 0, suma = 0;
            for (int i = 0; i < k512; i++)
            {
                suma = suma + vector512[i];
            }
            media = suma / k512;
            texto = texto + media;
            return texto;
        }

        private void btn512_Click(object sender, EventArgs e)
        {
            leer512(vector512);
            string maxima = maxima512(vector512);
            string minima = minima512(vector512);
            string media = media512(vector512);
            MessageBox.Show(maxima + "\n" + minima + "\n" + media);
        }
    }
}
