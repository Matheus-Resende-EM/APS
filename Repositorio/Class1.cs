using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class Class1
    {

        public void AdicioneImagem()
        {

        }
        public class AcessoFB
        {
            private static readonly AcessoFB instanciaFireBird = new AcessoFB();
            public AcessoFB() { }

            public static AcessoFB GetInstancia()
            {
                return instanciaFireBird;
            }

            public FbConnection GetConexao()
            {
                string conn = @"DataSource=localhost; Port=3053; Database=C:\APS\APS.FDB; username= SYSDBA; password = masterkey";
                return new FbConnection(conn);
            }
        }
    }
}