using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio05
{
    public class Equipo
    {
        private string nombre;
        private int partidosganados;
        private int partidosempatados;
        private int partidosperdidos;
        private int golesfavor;
        private int golescontra;

        public Equipo(string nombre, int partidosganados, int partidosempatados, int partidosperdidos, int golesfavor, int golescontra)
        {
            if (partidosempatados + partidosganados + partidosperdidos != 3 || golescontra < 0 || golesfavor < 0)
                throw new Exception("Revise el equipo");

            this.nombre= nombre;
            this.partidosganados= partidosganados;
            this.partidosempatados = partidosempatados;
            this.partidosperdidos = partidosperdidos;
            this.golesfavor = golesfavor;
            this.golescontra = golescontra;

        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetPartidosGanados()
        {
            return partidosganados;
        }

        public int GetPartidosEmpatados()
        {
            return partidosempatados;
        }

        public int GetPartidosPerdidos()
        {
            return partidosperdidos;
        }

        public int GetGolesFavor()
        {
            return golesfavor;
        }

        public int GetGolesContra()
        {
            return golescontra;
        }
    }
}
