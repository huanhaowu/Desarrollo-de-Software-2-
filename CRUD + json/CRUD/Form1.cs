using Newtonsoft.Json;
using System.Text;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public bool Adding { get; set; } = true;
        public Form1()
        {
            InitializeComponent();
        }

        //Cancelar - Borrar todas las celdas
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            BtnCancelar.Enabled = false;
            BtnCrear.Enabled = true;
            BtnGuardar.Enabled = false;
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtLugarNacimiento.Clear();
            txtNacionalidad.Clear();
            txtOcupacion.Clear();
            txtSangre.Clear();
            cbEstadoCivil.SelectedIndex = 0;
        }

        //Guardar - se desabilitan todas las casillas y se guarda la información
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var json = string.Empty;
            var conceptList = new List<concept>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";

            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<concept>>(json);
            }

            var conceptExist = conceptList.Count(x => x.Nombre.ToString().ToLower().Trim() == txtNombre.Text.ToLower().Trim());
            if (conceptExist > 0)
            {
                MessageBox.Show("El cocepto Existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            var concept = new concept();
            if (Adding) //Adding Record
            {
                concept = new concept
                {
                    Nombre = txtNombre.Text,
                    PrimerApellido = txtApellido1.Text,
                    SegundoApellido = txtApellido2.Text,
                    LugarNacimiento = txtLugarNacimiento.Text,
                    Sangre = txtSangre.Text,
                    Nacionalidad = txtNacionalidad.Text,
                    Ocupacion = txtOcupacion.Text,
                    CreatedTime = DateTime.Now
                };
            }

            conceptList.Add(concept);

            json = JsonConvert.SerializeObject(conceptList);

            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();

            MessageBox.Show("Registro Almacenado", "INTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gbPanel.Enabled = false;
            BtnCrear.Enabled = true;
            BtnGuardar.Enabled = false;
            BtnCancelar.Enabled = false;

            Clear();

            GetRecords();
        }

        private void GetRecords()
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";
            var conceptList = new List<concept>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<concept>>(json);
            }

            txtNombre.Text = (conceptList.Count + 1).ToString();
            gbPanel.DataSource = conceptList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetRecords();
        }
    }
}