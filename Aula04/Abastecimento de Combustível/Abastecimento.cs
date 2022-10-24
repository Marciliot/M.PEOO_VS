using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abastecimento_de_Combustível
{
    class Abastecimento
    {
     
        private double valorLitro;
        private double valorPago;
        private double KmRodados;
        public void SetValorLitor(double valorlitor)
        {
            if (valorlitor > 0) this.valorLitro = valorLitro;
        }
        public void SetValorPago(double valorPago)
        {
            if (valorPago > 0) this.valorPago = valorPago;
        }
        public void SetKmRodados(double KmRodados)
        {
            if (KmRodados > 0) this.KmRodados = KmRodados;
        }
        public double MediaKmLitro()
        {
            double numLitros = valorPago / valorLitro;
            return KmRodados / numLitros;
        }
        public double MediaReais()
        {
            return KmRodados / KmRodados;
        }
    }
}
}
