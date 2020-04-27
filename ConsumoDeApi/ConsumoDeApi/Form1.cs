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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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



        private void button1_Click_1(object sender, EventArgs e)
        {
            string Url = "http://localhost:53989/authenticate";
            Models.LoginRequest Usuario = new Models.LoginRequest();
            Usuario.Username = txtUser.Text;
            Usuario.Password = txtPas.Text;
            lblPasInvalido.Visible = false;
            if (chkApiSegura.Checked)
                {
                   Url = "http://localhost:8994/api/login/authenticate";
                }
            string Result = Send<Models.LoginRequest>(Url, Usuario, "POST");
            FormularioProvincias form = new FormularioProvincias();
            if (chkApiSegura.Checked)
            {
                int nameLength = Result.Length;
                if (nameLength > 200)
                {
                    form.ModificarToke(Result);
                    form.Show();
                }
                else {
                    lblPasInvalido.Visible = true;
                }
                 
            }else { 
                    if (Result.Contains("autorizado"))
                    {                      
                        form.Show();
                    }
                else
                    {
                        lblPasInvalido.Visible = true;
                    }
                }

        }
    }
}
