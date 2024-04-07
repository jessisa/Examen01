// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(String[] args)

    {
        bool menu = true;

        while (menu)
        {

            menu = MainMenu();
        }

    }

    static bool MainMenu()
    {
        
       
        Console.WriteLine("======================");
        Console.WriteLine("         MENU         ");
        Console.WriteLine("======================");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1) Tipo de número");
        Console.WriteLine("2) Imprimir mensaje");
        Console.WriteLine("3) Suma de números");
        Console.WriteLine("4) Imprimir números");
        Console.WriteLine("5) Area de circulo");
        Console.WriteLine("6) Elementos de arreglo");
        Console.WriteLine("7) Nombre de Personas");
        Console.WriteLine("8) Salir");
        Console.Write("\r\nElija una opcion: ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear();

                int num;
                string res;
                Console.WriteLine("Ingrese número a identificar el tipo:");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(calculartipo(num));
               
                return true;
            case "2":
                Console.Clear();
                int num1;
                Console.WriteLine("Ingrese número de la semana:");
                num1 = Convert.ToInt32(Console.ReadLine());
                semana(num1);
                return true;
            case "3":
                Console.Clear();
                suma();
                return true;
            case "4":
                Console.Clear();
                int num2 = 0;
                Console.WriteLine("Ingrese número final a imprimir:");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Los números son:");
                imprimir(num2);
                return true;
            case "5":
                Console.Clear();
                int rad;
                Console.WriteLine("Ingrese radio:");
                rad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El área del circulo es:" + calculararea(rad));
                return true;
            case "6":
                Console.Clear();
                int c = 0;
                Console.WriteLine("Indique cantidad de palabras a ingresar:");
                c = Convert.ToInt32(Console.ReadLine());
                arreglo(c);
                return true;
            case "7":
                Console.Clear();
                int c1 = 0;
                Console.WriteLine("Indique cantidad de Personas a ingresar:");
                c1 = Convert.ToInt32(Console.ReadLine());
                persona(c1);
                return true;
            case "8": return false;
            default:

                return true;

        }

        string calculartipo(int num)
        {
            string resul = "";

            if (num > 0)
            { resul = "Es positivo"; }
            if (num < 0)
            { resul = "Es negativo"; }
            if (num == 0)
            { resul = "Es cero"; }

            return resul;
        }

        void semana(int num)
        {

            switch (num)
            {
                case 1:
                    Console.WriteLine("El dia es lunes");
                    break;
                case 2:
                    Console.WriteLine("El dia es martes");
                    break;
                case 3:
                    Console.WriteLine("El dia es miercoles");
                    break;
                case 4:
                    Console.WriteLine("El dia es jueves");
                    break;
                case 5:
                    Console.WriteLine("El dia es viernes");
                    break;
                case 6:
                    Console.WriteLine("El dia es sabado");
                    break;
                case 7:
                    Console.WriteLine("El dia es domingo");
                    break;
                default:
                    Console.WriteLine("No es un dia de la semana");
                    break;
            }
        }
        void suma()
        {
            int suma = 0;

            for (int i = 1; i <= 100; i++)
            {
                suma = suma + i;

            }
            Console.WriteLine("La suma es:" + suma);
        }
        void imprimir(int num)
        {
            int suma = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);

            }

        }
        double calculararea(int num)
        {
            double area = 0;

            area = Math.PI * (Math.Pow(num, 2));

            return area;
        }
        void arreglo(int cant)
        {
            string[] palabra = new string[cant];

            string nombre = string.Empty;



            for (int i = 0; i < palabra.Length; i++)
            {
                Console.WriteLine("Ingrese palabra " + (i + 1) + " :");
                nombre = Console.ReadLine();
                palabra[i] = nombre;
            }


            Console.WriteLine("La lista de palabras es:");
            for (int i = 0; i < palabra.Length; i++)
            {
                Console.WriteLine(palabra[i]);
            }


        }
        void persona(int can)
        {
            List<string> persona = new List<string>();
            string nombre = string.Empty;
            bool salir = false;
            int cont = 0;
            do
            {
                Console.WriteLine("Ingrese Nombre de la Persona " + cont + 1 + " :");
                nombre = Console.ReadLine();
                persona.Add(nombre);
                cont++;
                if (can == cont)
                    salir = true;
            } while (!salir);
            Console.WriteLine("La lista de personas es:");
            foreach (var item in persona)
            {
                Console.WriteLine(item);
            }

        }

       



    }



}

