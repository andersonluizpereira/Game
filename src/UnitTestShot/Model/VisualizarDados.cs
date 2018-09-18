using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListarUsuario = UnitTestShot.Model.Dao;

namespace UnitTestShot.Model
{
   public class VisualizarDados : Dao
    {
        public VisualizarDados()
        {
            VisualizarPontuacao();
            Debug.WriteLine("\n");
        }

        public void VisualizarPontuacao()
        {
            foreach (var lista in OrdernarPontuacao(Dados.usuarios))
            {
                Debug.WriteLine(DateTime.Now +" Nome : " + lista.Nome + " Pontuação :" + lista.Pontos + " Armas preferidas " + lista.Arma);
            }
        }
        
    }
}
