namespace Laboratorio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jarod Bolaños");

            Equipo equipo1 = new Equipo("equipo 1", 3, 0, 0, 1, 0);
            Equipo equipo2 = new Equipo("equipo 2", 1, 1, 1, 1, 1);

            Console.WriteLine(equipo1.GetNombre() + " - " + equipo1.GetPartidosGanados() +
                "-" + equipo1.GetPartidosPerdidos() + "-" + equipo1.GetPartidosEmpatados() +
                "-" + equipo1.GetGolesFavor() + "-" + equipo1.GetGolesContra());


            Console.WriteLine(equipo2.GetNombre() + " - " + equipo2.GetPartidosGanados() +
                   "-" + equipo2.GetPartidosPerdidos() + "-" + equipo2.GetPartidosEmpatados() +
                   "-" + equipo2.GetGolesFavor() + "-" + equipo2.GetGolesContra());


        }
    }
}