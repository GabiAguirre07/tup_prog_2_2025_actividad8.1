using Actividad_En_El_Aula8._1.Models;

namespace Actividad_En_El_Aula8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbxVer.SelectedIndexChanged += lbxVer_SelectedValueChanged;
            openFileDialog1 = new OpenFileDialog();
        }

        List<Cuenta> cuentas = new List<Cuenta>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AgregarOActualizarCuenta(Cuenta nueva)
        {
            cuentas.Sort();
            int idx = cuentas.BinarySearch(nueva);
            if (idx >= 0)
            {
                cuentas[idx].Nombre = nueva.Nombre;
                cuentas[idx].Importe += nueva.Importe;
            }
            else
            {
                cuentas.Add(nueva);
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int DNI = Convert.ToInt32(tbDNI.Text);
                string Nombre = tbNombre.Text;
                double Importe = Convert.ToDouble(tbImporte.Text);
                if (Importe > 0)
                {
                    Cuenta nueva = new Cuenta(DNI, Nombre, Importe);
                    AgregarOActualizarCuenta(nueva);
                    btnActualizar.PerformClick();
                    tbDNI.Clear();
                    tbImporte.Clear();
                    tbNombre.Clear();
                }
                else
                {
                    MessageBox.Show("El importe no puede ser negativo o cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbImporte.Clear();
                }
            }
            catch (DNINoValidoException exc)
            {
                MessageBox.Show("Formato de DNI inválido(8 a 9 dígitos)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDNI.Clear();
            }
            catch (NombreNoValidoException exc)
            {
                MessageBox.Show("Formato de Nombre Inválido(Debe contener mayúscula,máximo 10 caracteres)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombre.Clear();
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lbxVer.Items.Clear();
            cuentas.Sort();
            foreach (Cuenta cuenta in cuentas)
            {
                lbxVer.Items.Add(cuenta);
            }
        }
        private void lbxVer_SelectedValueChanged(object sender, EventArgs e)
        {
            Cuenta seleccionado = lbxVer.SelectedItem as Cuenta;
            if (seleccionado != null)
            {
                tbDNI.Text = seleccionado.DNI.ToString();
                tbImporte.Text = seleccionado.Importe.ToString();
                tbNombre.Text = seleccionado.Nombre;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cuenta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos.txt|*.txt|Todos los archivos|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                string nombre = openFileDialog1.FileName;
                try
                {
                    fs = new FileStream(nombre, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    while (sr.EndOfStream == false)
                    {
                        string cadena = sr.ReadLine();
                        string Dni = cadena.Substring(0, 9).Trim();
                        string Nombre = cadena.Substring(9, 10).Trim();
                        string Importe = cadena.Substring(19, 9).Trim();
                        Cuenta nueva = new Cuenta(Convert.ToInt32(Dni), Nombre, Convert.ToDouble(Importe));
                        AgregarOActualizarCuenta(nueva);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (fs != null) fs.Close();
                    if (sr != null) sr.Close();
                }
                btnActualizar.PerformClick();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos.txt|*.txt|Todos los archivos|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombrear = saveFileDialog1.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(nombrear, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    foreach (Cuenta cuenta in cuentas)
                    {
                        string nombre = cuenta.Nombre;
                        if (cuenta.Nombre.Length > 10)
                        {
                            nombre = cuenta.Nombre.Substring(0, 10);
                        }
                        string linea = $"{cuenta.DNI,+9}{nombre,-10}{cuenta.Importe,+9:f2}";
                        sw.WriteLine(linea);
                    }
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
                
            }
        }
    }
}
