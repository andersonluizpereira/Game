using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestShot.Model
{
   public class Dao : Dados
    {
      

        public Dao()
        {
            this.PreencherLista();
        }


        public List<Usuario> OrdernarPontuacao(List<Usuario> usrs)
        {
            return usrs.OrderByDescending(p=>p.Pontos).ToList();
        }

        public static int PegarUltimoId()
        {
           return Dados.usuarios.Max(p => p.Id)+1;
        }

        public static void VerificarPersonagensLista()
        {
            Dados.usuarios.Remove(Dados.usuarios.FirstOrDefault(p=>p.Nome== @ConfigurationManager.AppSettings["usuarioaremover"].ToString()));
        }

        public IEnumerable<List<Usuario>> ArmasMaisUtilizadas()
        {
            return usuarios.GroupBy(p => p.Arma).Select(l => l.ToList());
            
        }


    }
}
