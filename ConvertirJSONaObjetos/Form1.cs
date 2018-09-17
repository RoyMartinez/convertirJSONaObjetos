using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace ConvertirJSONaObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string obtenerjson()
        {
            string json;
            json = File.ReadAllText(@"c:\Roy\persona.json");
            return json;
        }

        #region datatable
        public void datatable()
        {
            DataTable m = JSONdatatable(obtenerjson());
            dgvJSON.DataSource = m;

        }
        private DataTable JSONdatatable(String JSON)
        {
            //var t = JsonConvert.DeserializeObject<DataTable>(JSON);
            //DataTable t = JsonConvert.DeserializeObject<DataTable>(JSON, new ConvertirJSONaObjetos.DataTableConverter());
            DataTable t=(DataTable)JsonConvert.DeserializeObject(JSON, (typeof(DataTable)));
            return t;
        }
        #endregion datatable
        #region clase
        public void Clase()
        {
            colores m = JSONclase(obtenerjson());
            MessageBox.Show(m.NombreColor);
        }
        private colores JSONclase(String JSON )
        {
            colores t = JsonConvert.DeserializeObject<colores>(JSON);
            return t;
        }
        #endregion clase

        private void btnMOSTRAR_Click(object sender, EventArgs e)
        {
            //Clase();
            datatable();
        }

    }
}
