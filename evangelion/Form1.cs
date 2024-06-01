using evangelion.Eu.carpetaimportante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace evangelion
{
    public partial class Form1 : Form
    {
        private string[] afiliacionEva  = {
            "Piloto",
            "Capitana de la Sección táctica de NERV",
            "anonimo"

        };
        private evangelionpersonajes personaje;
        
        public Form1()
        {
            InitializeComponent();
            personaje = new evangelionpersonajes("localhost", "root", "Soynoob9182");
        }

        private void buttonCargaData_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personaje.LeerPersonajes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // llenamos el combo box con las afiliaciones
            comboBox1afiliacion.Items.AddRange(afiliacionEva);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                

        }


       
        //en este apartado buscamos al usuario por medio de su ID
        private void buscarPorId()
        {
            int idPersonajeABuscar = int.Parse(IDTEXT.Text);

            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeABuscar);

            if (personajeEncontrado.Rows.Count > 0)
            {
                // El personaje fue encontrado
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string afiliacion = personajeEncontrado.Rows[0]["afiliacion"].ToString();
                string estadomental = personajeEncontrado.Rows[0]["estado_mental"].ToString();
                int edad = int.Parse(personajeEncontrado.Rows[0]["edad_del_personaje"].ToString());
                int eva = int.Parse(personajeEncontrado.Rows[0]["eva_unidad"].ToString());
                bool check = bool.Parse(personajeEncontrado.Rows[0]["es_angel"].ToString());
                DateTime fechacreacion = DateTime.Parse(personajeEncontrado.Rows[0]["fecha_creacion"].ToString());
                textBoxnombre.Text = nombre;
                textBox1afiliacion.Text = afiliacion;
                comboBox1afiliacion.Text = afiliacion;
                textBoxestadomental.Text = estadomental;
                numericUpDown1edad.Value = edad;
                numericUpDowneva.Value = eva;
                checkBox1.Checked = check;
                dateTimePicker1.Value = fechacreacion;

            }
            else
            {
                MessageBox.Show("no ingresaste algun id existente, ingresa uno que exista");
                IDTEXT.Focus();
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscarPorId();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDTEXT.Text))
            {
                MessageBox.Show("no ingresaste nada en el campo, Por favor, ingresa un valor en el campo de texto.");
                IDTEXT.Focus(); 
            }
            else
            {
                buscarPorId();
            }
        }

        private void textBoxestadomental_TextChanged(object sender, EventArgs e)
        {

        }




        //boton de prueba de conexion
        private void buttontes_Click(object sender, EventArgs e)
        {

            if (personaje.ProbarConexion())
            {
                MessageBox.Show("Conexion exitosa");
            }
            else
            {
                MessageBox.Show("Error en la conexi�n");
            }

        }


        //boton actualizar
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDTEXT.Text))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            if (int.TryParse(IDTEXT.Text, out int id))
            {
                string nombre = textBoxnombre.Text;
                string afiliacion = textBox1afiliacion.Text;
                string estadomental = textBoxestadomental.Text;
                int edad = (int)numericUpDown1edad.Value;
                int eva = (int)numericUpDowneva.Value;
                bool check = checkBox1.Checked;
                DateTime fechacreacion = dateTimePicker1.Value;
                personaje.ActualizarPersonaje(id, nombre, afiliacion,  estadomental, edad, eva,check, fechacreacion);
                MessageBox.Show("Personaje actualizado con éxito.");
                dataGridView1.DataSource = personaje.LeerPersonajes();
            }
            
          

        }


        //boton para cargar
        private void button2cargar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personaje.LeerPersonajes();

        }

        
        //boton para eliminar
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDTEXT.Text))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            if (int.TryParse(IDTEXT.Text, out int id))
            {
                personaje.EliminarPersonaje(id);
                MessageBox.Show("Personaje eliminado con éxito.");
                dataGridView1.DataSource = personaje.LeerPersonajes();
            }
           

        }


        //apartado del boton de agregar ;)
        private void button1_Click(object sender, EventArgs e)
        {
            
            string nombre = textBoxnombre.Text;
            string afiliacion = textBox1afiliacion.Text;
            string estadomental = textBoxestadomental.Text;
            int edad = (int)numericUpDown1edad.Value;
            int eva = (int)numericUpDowneva.Value;
            bool check = checkBox1.Checked;
            DateTime fechacreacion = dateTimePicker1.Value;
            int respuesta = personaje.CrearPersonaje(nombre, afiliacion, estadomental,  edad, eva,check, fechacreacion);
            if (respuesta > 0)
            {
                MessageBox.Show("Personaje creado correctamente");
                dataGridView1.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Error al crear el personaje");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDowneva_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1afiliacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
