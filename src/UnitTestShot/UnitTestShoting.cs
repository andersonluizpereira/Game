using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestShot.Model;
using ListarUsuario = UnitTestShot.Model.Dao;

namespace UnitTestShot
{
    [TestClass]
    public class UnitTestShoting
    {

        [TestMethod]
        public void TestMethodInicial()
        {
            var jogo = new Jogo();
            jogo.IniciarJogo();
            jogo.CarregarConfiguracao();
            jogo.VerificarPontuacao();
            jogo.VerificarPersonagens();
            jogo.VerificarPontuacao();


        }

    }
}
