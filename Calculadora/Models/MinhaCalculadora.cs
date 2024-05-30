using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class MinhaCalculadora
    {
        private List<string> listaHistorico;
        public MinhaCalculadora()
        {
            listaHistorico = new List<string>();
        }
        public int somar(int v1, int v2)
        {
            int res = v1 + v2;
            listaHistorico.Insert(0,"Resultado: " +  res);
            return res;
        }
        public int subtrair(int v1, int v2)
        {
            int res = v1 - v2;
            listaHistorico.Insert(0,"Resultado: " +  res);
            return res;
        }
        public int multiplicar(int v1, int v2)
        {
            int res = v1 * v2;
            listaHistorico.Insert(0,"Resultado: " +  res);
            return res;
        }
        public int dividir(int v1, int v2)
        {
            int res = v1 / v2;
            listaHistorico.Insert(0,"Resultado: " +  res);
            return res;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count-3);
            return listaHistorico;
        }
    }
}