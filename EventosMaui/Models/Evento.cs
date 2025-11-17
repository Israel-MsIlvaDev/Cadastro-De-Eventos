using System;

namespace EventosMaui.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public int NumeroParticipantes { get; set; }
        public double CustoPorParticipante { get; set; }

        public DateTime DataInicio { get; set; } = DateTime.Today;
        public DateTime DataTermino { get; set; } = DateTime.Today;

        public int DuracaoEmDias
        {
            get
            {
                if (DataTermino < DataInicio)
                {
                    return 0;
                }

                int dias = (int)(DataTermino - DataInicio).TotalDays;

                return dias + 1;
            }
        }
        public double CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}