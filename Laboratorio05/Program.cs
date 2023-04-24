namespace Laboratorio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jarod Bolaños");

            Equipo equipo1 = new Equipo("equipo 1", 3, 0, 0, 1, 0);
            Equipo equipo2 = new Equipo("equipo 2", 1, 1, 1, 1, 1);

            Partido partido = new Partido(equipo1, equipo2);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(partido.EquipoGanador().GetNombre());
            }


        }
    }
}