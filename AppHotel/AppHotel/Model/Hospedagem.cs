using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Model
{
    public class Hospedagem
    {
        int quantidade_adultos;
        Suite Quarto;

        public Suite QuartoEscolhido
        {
            get => Quarto;
            set
            {
                if (value == null)
                    throw new Exception("Erro! Informe o quarto escolhido.");

                Quarto = value;
            }
        }
        public int QuantAdultos
        {
            get => quantidade_adultos;
            set
            {
                if (value == 0)
                    throw new Exception("Erro! Informe a quantidade de adultos.");

                quantidade_adultos = value;
            }
        }

        public int QuantCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }
        public double ValorTotal
        {
            get => ((QuantAdultos * QuartoEscolhido.DiariaAdulto) +
                     (QuantCriancas * QuartoEscolhido.DiariaCrianca)
                   ) * Estadia;
        }
    }
}
