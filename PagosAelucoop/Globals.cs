using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagosAelucoop
{
    public static class Globals
    {
        public static string lastSQL = "";

        public static String Username = "";
        public static String Password = "";
        public static int IdUsername = -1;
        public static int IdUserEntidad = -1;

        public static String ExportarPath = Application.StartupPath + "\\Exportar\\";

        public static String TablaUsuario = "AELU_USUARIO";
        public static String TablaPago = "AELU_PAGO";
        public static String TablaEntidad = "AELU_ENTIDAD";
        public static String TablaProcesado = "AELU_PROCESADO";
        //public static String TablaTipoDoc = "AELU_TIPO_DOCUMENTO";
    }
}
