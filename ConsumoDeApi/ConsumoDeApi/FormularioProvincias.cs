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

using System.Web.Script.Serialization;
using System.Net;
using System.IO;

namespace ConsumoDeApi
{
    public partial class FormularioProvincias : Form
    {
        public FormularioProvincias()
        {
            InitializeComponent();
        }
        public void ModificarToke(string texto)
        {
            lblToken.Text = "TOKEN " + texto; //control label
            lblToken.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Url = "http://localhost:53989/api/Provincia";
            Models.ProvinciaRequest ProvinciaaBuscar = new Models.ProvinciaRequest();    
            lblDescriocionProvincia.Visible = false;
            ProvinciaaBuscar.ProvinciaABuscar = txtProvincia.Text;
            string Result = Send(Url, ProvinciaaBuscar, "POST");
            lblDescriocionProvincia.Visible = true;
            lblDescriocionProvincia.Text = Result;

        }

        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string Result = "";
            try
            {


                JavaScriptSerializer js = new JavaScriptSerializer();

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                WebRequest request = WebRequest.Create(url);
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 100000;

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    Result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                Result = e.Message;
            }

            return Result;
        }

        private void FormularioProvincias_Load(object sender, EventArgs e)
        {

        }
    }
}
