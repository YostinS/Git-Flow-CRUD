/* Yostin S. Sanchez Rosario
  Matricula: 2024-1722 */
namespace CRUD_Ferreteria
{
    class Product
    {
        public string nombre;
        public string descripcion;
        public int cantidad;
        public double precio;
        public Product(string nombre, string descripcion, int cantidad, double precio)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
        }
        public static void AddProduct()
        {
            Console.WriteLine("Ingrese el nombre del producto:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la descripcion del producto:");
            string descripcion = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad del producto:");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del producto:");
            double precio = double.Parse(Console.ReadLine());

            Product newProduct = new Product(nombre, descripcion, cantidad, precio);
            Console.WriteLine("Producto agregado exitosamente.");
        }
    }
    class Program
    {
        private static void home_screen()
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("                        Bienvenido a la Ferreteria  ");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("| 1. Ingresar nuevo producto | 2. Ver productos | 3. Actualizar producto |");
                Console.WriteLine("|   4. Eliminar producto     | 5. Leer manual   |        6. Salir        |");
                Console.WriteLine("Seleccione una opcion (1-6): ");
                Console.WriteLine("--------------------------------------------------------------------------");

                int answer;
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    switch (answer)
                    {
                        case 1:
                            Product.AddProduct();
                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                        case 5:
                            manual();
                            break;
                        case 6:

                            exit = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Por favor ingresa un numero.");
                }

            }
        }
        private static void manual()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("                             Manual de Usuario:");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Debe de responder solo con numeros enteros en el menu principal.");
            Console.WriteLine("1. Ingresar nuevo producto: Permite agregar un nuevo producto a la base de datos.");
            Console.WriteLine("2. Ver productos: Muestra una lista de todos los productos disponibles.");
            Console.WriteLine("3. Actualizar producto: Permite modificar la información de un producto existente.");
            Console.WriteLine("4. Eliminar producto: Permite eliminar un producto de la base de datos.");
            Console.WriteLine("5. Leer manual: Muestra este manual de usuario.");
            Console.WriteLine("6. Salir: Cierra la aplicación.");
            Console.WriteLine("--------------------------------------------------------------------------");
        }
        static void Main(string[] args)
        {
            home_screen();


            Console.ReadKey();
        }


    }
}
