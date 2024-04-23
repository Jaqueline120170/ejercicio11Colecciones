namespace ejercicio11Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> parentesis = new Stack<char>();

            char tecla = ')';
            foreach(char teclas in parentesis)
            {
               if(teclas == tecla)
                {
                    parentesis.Push(tecla);
                }
            }
        }
    }
}
