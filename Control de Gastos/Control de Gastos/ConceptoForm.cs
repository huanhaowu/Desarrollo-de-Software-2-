using Control_de_Gastos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Gastos
{
    public partial class ConceptoForm : Form
    {

        public bool Adding { get; set} = true;

        public ConceptoForm()
        {
            InitializeComponent();

            GetRecords();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gbPanel.Enabled = true;
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            //Aquí estamos llamando a una función que nos va a generar un nuevo ID
            //GenerateNewID();
        }

        //Entonces aquí creamos dicha función para generar un nuevo ID
        private void GenerateNewID() 
        {
            //Aquí creamos otra función que nos ayudara a limpiar todas las casillas
            ClearFields();
            //var ID= 1; 
            //txtID.Text = ID.ToString();

        }

        private void ClearFields()
        {

            txtID.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            chkIsEnabled.Checked = false; 
        }

        //------------------------------------------------------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creamos un metodo para guardar las diferentes informaciones que ingrese el usuario 
            SaveRecord();
        }

        private void SaveRecord()
        {
            //Existen diferentes formas para guardar la información, lo podemos hacer a través de una archivo de texto plano
            //O lo podemos hacer a través de un archivo Json que es un tipo de archivo para guardar informaciones. 

            var json = string.Empty;

            //En esta se crea un listado con todos los conceptos  
            var conceptlist = new List<Concepto>();

            var pathfile = $"{AppDomain.CurrentDomain.BaseDirectory}\\conceptos.json";

            if (File.Exists(pathfile)) 
            { 
                //1h.09min
                json = File.ReadAllText(pathfile, Encoding.UTF8);
                conceptlist = JsonConvert.DeserializeObject<List<Concepto>>(json);

            }

            var concepto = new Concepto();
            if (Adding)
            {
                concepto = new Concepto
                {
                    Id = int.Parse(txtID.Text),
                    Name = txtNombre.Text,
                    Description = txtDescripcion.Text,
                    IsEnabled = chkIsEnabled.Checked,
                    CreatedDate = DateTime.Now,

                };
            }
            else //Actualizando los registros 
            {
                var Id = int.Parse(txtID.Text);

                concepto = conceptlist.FirstOrDefault(x => x.Id == Id);
                if (conceptlist != null)
                {
                    conceptlist.Remove(concepto);

                    concepto.Name = txtNombre.Text;
                    concepto.Description = txtDescripcion.Text;
                    concepto.IsEnabled = chkIsEnabled.Checked;
                    concepto.ModifiedDate = DateTime.Now;
                }

            }

            conceptlist.Add(concepto);

            json = JsonConvert.SerializeObject(conceptlist);

            var sw = new StreamWriter(pathfile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            MessageBox.Show("Registro Almacenado", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gbPanel.Enabled = false;
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            ClearFields();

            GetRecords();
        }

        private void GetRecords()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\conceptos.json";

            var conceptlist = new List<Concepto>(json);

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptlist = JsonConvert.DeserializeObject<List<Concepto>>(json);
            }

            txtID.Text = (conceptlist.Count + 1).ToString(); 
            dgvPanel.DataSource = conceptlist;   

        }
    }
}
