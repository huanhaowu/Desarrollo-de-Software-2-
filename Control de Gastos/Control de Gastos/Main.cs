using Control_de_Gastos.Models;

namespace Control_de_Gastos
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnConcepto_Click(object sender, EventArgs e)
        {
            //Aqu� declaramos una variable (con su nombre) y le asignamos el form que creamos, para despu�s llamar a dicha variable 
            //y presentarla
            this.Hide();

            var oForm = new ConceptoForm();
            oForm.Show();
        }

        private void btnCategor�a_Click(object sender, EventArgs e)
        {
            //Tengo que replicar lo mismo que se realizo con el concepto, para las categor�as 
            this.Hide();

            var oForm = new Categor�aForm();
            oForm.Show();
        }

        private void btnAgregarConcepto_Click(object sender, EventArgs e)
        {
            this.Hide();

            var oForm = new /*ConceptoForm*/();
            oForm.Show();
        }

        private void txtConcepto_Click(object sender, EventArgs e)
        {
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\conceptos.json";
            var conceptlist = new List<Concepto>();

            if (File.Exists(pathFile))
            {
                var json = File.ReadAllText(pathFile, encoding.UTF8);
                conceptlist = JsonConvert.DeserializeObject<List<Concepto>>(json);
            }

            txtConcepto.DataSource = conceptlist.Where(x => x.IsEnabled).ToList();
            txtConcepto.DisplayMember = "Name";
            txtConcepto.ValueMember = "Id";
        }
    }
}