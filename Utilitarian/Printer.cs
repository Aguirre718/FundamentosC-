using static System.Console;

namespace Core_Escuela.Utilitarian
{
    // Las clases estáticas no permiten crear instancias, pero permite utilizar sus métodos
    public static class Printer
    {
        public static void DrawLine(int size = 10)
        {
            WriteLine("".PadLeft(size, '*'));
        }

        public static void Title(string title)
        {
            // Imprime dejando espacio a los lados
            WriteLine($"   {title}   ");
        }
    }
}
