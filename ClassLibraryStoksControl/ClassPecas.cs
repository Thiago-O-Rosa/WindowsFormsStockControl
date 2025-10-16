using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryStoksControl
{
    internal class ClassPecas
    {
        private string Tipos { get; set; }
        private string Marcas { get; set; }
        private string Modelos { get; set; }
        private int NumeroSeries { get; set; }
        private int Quantidades { get; set; }
        private string Responsaveis { get; set; }
        private int DataHoraRet { get; set; }
        private int DataHoraDev { get; set; }

        //Construtor
        public ClassPecas(string _tipo, string _marca, string _modelo, int _numeroSerie, int _quantidade, string _responsavel, int _dataHoraRet, int _dataHoraDev)
        {
            this.Tipos = _tipo;
            this.Marcas = _marca;
            this.Modelos = _modelo;
            this.NumeroSeries = _numeroSerie;
            this.Quantidades = _quantidade;
            this.Responsaveis = _responsavel;
            this.DataHoraRet = _dataHoraRet;
            this.DataHoraDev = _dataHoraDev;
        }


        public string Lista(string _tipos, string _marcas, string _modelos, int _numeroseries, int _quantidades, string _responsaveis, int _dataHoraRet, int _dataHoraDev)
        {
            return "";
        }
    }
}
