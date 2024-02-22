using Logica;
using Logica.Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudiantesWF
{
    public partial class FormEstudiantes : Form
    {
        private Estudiantes estudiantes; //Llamamos a la clase estudiantes.
        private Library librerias;
        public FormEstudiantes()
        {
            InitializeComponent();
            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxName);
            listTextBox.Add(textBoxSurname);
            listTextBox.Add(textBoxDNI);
            listTextBox.Add(textBoxMail);

            var listLabel = new List<Label>();
            listLabel.Add(labelName);
            listLabel.Add(labelSurname);
            listLabel.Add(labelDNI);
            listLabel.Add(labelMail);
            listLabel.Add(labelPaginas);
            Object[] objetos = { 
                pictureBoxImage,
                Properties.Resources.default_user,
                dataGridList,
                numericUpDown
            }; 



                              

            estudiantes = new Estudiantes(listTextBox, listLabel, objetos);
        } //Lista de objetos de tipo textbox

         
  
        private void textTitle_TextChanged(object sender, EventArgs e)
        {

        }
        private void PictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiantes.uploadImage.CargarImagen(pictureBoxImage); //EL NOMBRE DEL CONTROL DE LA IMAGEN EN EL DISEÑO
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            if(textBoxDNI.Text.Equals(" "))
            {
                labelDNI.ForeColor = Color.Red; //Le asignamos el color rojo la label.
            }
            else
            {
                labelDNI.ForeColor = Color.Green;
                labelDNI.Text = "DNI";
            }
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvents.numberKeyPress(e);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals(" "))
            {
                labelName.ForeColor = Color.Red; //Le asignamos el color rojo la label.
            }
            else
            {
                labelName.ForeColor = Color.Green;
                labelName.Text = "Nombre";
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvents.textKeyPress(e);
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSurname.Text.Equals(" "))
            {
                labelSurname.ForeColor = Color.Red; //Le asignamos el color rojo la label.
            }
            else
            {
                labelSurname.ForeColor = Color.Green;
                labelSurname.Text = "Apellido";
            }
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvents.textKeyPress(e);
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMail.Text.Equals(" "))
            {
                labelMail.ForeColor = Color.Red; //Le asignamos el color rojo la label.
            }
            else
            {
                labelMail.ForeColor = Color.Green;
                labelMail.Text = "EMAIL";
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            estudiantes.Registrar();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            estudiantes.SearchEstudiante(textBoxBusqueda.Text);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Primero");
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Anterior");
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Siguiente");
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Ultimo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            estudiantes.Registro_Paginas();
        }

        private void dataGridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridList.Rows.Count != 0)
            {
                estudiantes.GetEstudiante();
            }
        }

        private void dataGridList_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridList.Rows.Count != 0)
            {
                estudiantes.GetEstudiante();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            estudiantes.Eliminar();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            estudiantes.Restablecer();
        }
    }

}
