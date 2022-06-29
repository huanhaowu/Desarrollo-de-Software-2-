namespace CRUD
{
    public partial class Form1 : Form
    {
        //Aqui lo que se hace es un listado con los diferentes elementos que pertenecen a mis clases 
        List<Ciudadano> Listado = new List<Ciudadano>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Metodo para borarr todo
            Clear();
        }

        private void Clear()
        {
            btnCrear.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            tbNumeroCedula.Clear();
            tbNombre.Clear();
            tb1apellido.Clear();
            tb2apellido.Clear();
            tbLugarNacimiento.Clear();
            tbNacionalidad.Clear();
            tbOcupacion.Clear();
            tbSangre.Clear();
            tbOcupacion.Clear();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Se "apagan" los botonos de cancelar y guardar, ya que no se ha decidido
            //crear un nuevo usuario o registrar un nuevo ciudadano
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCrear.Enabled = false;
            tbNombre.Focus();
        }

        //OJO
        void ObtenerCiudadano()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Listado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            
        }

        private void Guardar()
        {
            var usuario = new Ciudadano
            {
                Nombre = tbNombre.Text,
                Primerapellido = tb1apellido.Text,
                Segundoapellido = tb2apellido.Text,
                LugarNacimiento = tbLugarNacimiento.Text,
                Nacionalidad = tbNacionalidad.Text,
                Sangre = tbSangre.Text,
                Ocupacion = tbOcupacion.Text,
                EstadoCivil = cbEstadoCivil.Text,
                Fechanacimiento = dtpNacimiento.Value,
                CreatedDate = DateTime.Now,
            };
            //Aqui se añade el objeto que acabamos de "crear", al listado que pertencer a nuestra clase de ciudadano
            Listado.Add(usuario);
            Clear();
            
            //Se procede a añadir el usuario creado al data grid para que se pueda visualizar
            ObtenerCiudadano();

            //Seguido de esto, confirmamos el registro al usuario
            MessageBox.Show("Se ha registrado exitosamente", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            

        }

        public class Ciudadano
        {
            public string NumeroCedula { get; set; }
            public string Nombre { get; set; }
            public string Primerapellido { get; set; }
            public string Segundoapellido { get; set; }
            public string LugarNacimiento { get; set; }
            public string Nacionalidad { get; set; }
            public string Sangre { get; set; }
            public string Ocupacion { get; set; }
            public string Sexo { get; set; }
            public string EstadoCivil { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime Fechanacimiento { get; set; }

        }
    }

    }
}