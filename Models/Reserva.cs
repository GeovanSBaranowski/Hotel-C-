using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new();
        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(Suite == null)
            {
                throw new InvalidOperationException("Nenhuma suite cadastrada!");
            }
            if (hospedes.Count > Suite.Capacidade)
            {
                throw new ArgumentException("Numero de Hospedes ultrapassa a capacidade da suite!");
            }
            
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
        
        public decimal CalcularDiaria()
        {
            if (Suite == null)
            {
                throw new InvalidOperationException("Nenhuma suite cadastrada!");
            }
            
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10M;
            }

            return valor;
        }
    }
}