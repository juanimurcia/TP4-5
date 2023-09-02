using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1 : Form
    {
        private Image imagenSeleccionada;
        private string rutaImagenSeleccionada;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|ArchivosImagenes | *.png";
            openFileDialog1.Title = "Seleccionar una imagen.";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;

                TBFoto.Text = rutaArchivo;

                try
                {
                    // Cargar la imagen en un objeto Image
                    imagenSeleccionada = new System.Drawing.Bitmap(rutaArchivo);

                    // Almacena la ruta de la imagen
                    rutaImagenSeleccionada = rutaArchivo;

                    // Mostrar la imagen en el PictureBox (opcional)
                    pictureBox1.Image = imagenSeleccionada;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar la imagen" + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TBNombre.Leave += TextBox_Leave;
            TBApellido.Leave += TextBox_Leave;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = CapitalizeFirstLetter(textBox.Text);
            }
        }

        private string CapitalizeFirstLetter(String input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return char.ToUpper(input[0]) + input.Substring(1).ToLower();
            }
            return input;
        }

        private void TBSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un número, una coma, una tecla de movimiento o la tecla de borrar
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Left && e.KeyChar != (char)Keys.Right)
            {
                // El carácter no es válido, cancelar la pulsación y mostrar un mensaje de advertencia
                e.Handled = true;
                MessageBox.Show("Solo se permiten números, comas y teclas de movimiento.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que la tecla presionada sea una letra, espacio o tecla de movimiento o eliminar
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.Left && e.KeyChar != (char)Keys.Right)
            {
                e.Handled = true; // Ignora la tecla presionada
                MessageBox.Show("Unicamente puede ingresar letras o espacios.");
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que la tecla presionada sea una letra, espacio o tecla de movimiento o eliminar
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.Left && e.KeyChar != (char)Keys.Right)
            {
                e.Handled = true; // Ignora la tecla presionada
                MessageBox.Show("Unicamente puede ingresar letras o espacios.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = TBNombre.Text;
            string apellido = TBApellido.Text;
            DateTime fechaNacimiento = dateTimePicker1.Value;
            string genero = radioButton1.Checked ? "Hombre" : "Mujer";

            if (decimal.TryParse(TBSaldo.Text, out decimal saldo))
            {
                int filaActual = dataGridView1.Rows.Add(nombre, apellido, fechaNacimiento, genero, "Eliminar", saldo, imagenSeleccionada, rutaImagenSeleccionada);

                dataGridView1.Rows[filaActual].Height = 200;

                LimpiarCampos();

                imagenSeleccionada = null;
                rutaImagenSeleccionada = null;

                if (saldo < 50)
                {
                    dataGridView1.Rows[filaActual].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para el saldo.");
            }
        }

        private void LimpiarCampos()
        {
            TBNombre.Clear();
            TBApellido.Clear();
            TBSaldo.Clear();
            TBFoto.Clear();
            radioButton1.Checked = true; // Establece el valor predeterminado
            dateTimePicker1.Value = DateTime.Today; // Establece la fecha predeterminada
            pictureBox1.Image = null;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en una celda de la columna "Eliminar" y si la fila no es la cabecera
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                // Obtiene los datos de la fila
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string nombre = row.Cells["Nombre"].Value.ToString();
                string apellido = row.Cells["Apellido"].Value.ToString();

                // Muestra un mensaje con los datos de la fila y pregunta si desea eliminar
                DialogResult resultado = MessageBox.Show("¿Desea eliminar los datos de " + nombre + " " + apellido + "?", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Verifica si se presionó "Sí" (Aceptar) en el MessageBox
                if (resultado == DialogResult.Yes)
                {
                    // Elimina la fila correspondiente del DataGridView
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Asegúrate de que haya al menos una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la descripción del sexo desde la celda de la fila seleccionada
                string descripcionSexo = dataGridView1.SelectedRows[0].Cells["Sexo"].Value.ToString();

                // Configurar el RadioButton según la descripción del sexo
                if (descripcionSexo == radioButton1.Text)
                {
                    radioButton1.Checked = true;
                }
                else if (descripcionSexo == radioButton3.Text)
                {
                    radioButton3.Checked = true;
                }
            }
        }

        
    }
}
