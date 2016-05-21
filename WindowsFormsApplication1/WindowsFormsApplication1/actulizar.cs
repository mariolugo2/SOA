using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class actulizar : Form
    {
        public actulizar()
        {
            InitializeComponent();
            localhost.Service ser = new localhost.Service();
            MessageBox.Show("Actulizar Datos Estudiante Ingrese Matricula");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selecion_combo_plantel = comboBox_plantel.SelectedIndex;
            int selecion_combo_carrera = comboBox_carrera.SelectedIndex;
            
            int i;
            if (!int.TryParse(matricula.Text, out i))
            {
                MessageBox.Show("Error , Matricula Incorrecta");
                matricula.Focus();
            }
            else if (nombre.Text == "")
            {
                MessageBox.Show("No debe haber campos vacios");
                nombre.Focus();
            }
            else if (p_apellido.Text == "")
            {
                MessageBox.Show("No debe haber campos vacios");
                p_apellido.Focus();
            }
            else if (s_apellido.Text == "")
            {
                MessageBox.Show("No debe haber campos vacios");
                s_apellido.Focus();
            }
            else if (semestre.Text == "")
            {
                MessageBox.Show("No debe haber campos vacios");
                semestre.Focus();
            }
            else if (direccion.Text == "")
            {
                MessageBox.Show("No debe haber campos vacios");
                direccion.Focus();
            }
            else if (correo.Text == "")
            {
                MessageBox.Show("No debe haber campos vacios");
                correo.Focus();
            }
            else if (correo.Text == "@example.com")
            {
                MessageBox.Show("Por favor ingrese su correo");
                correo.Focus();
            }
            else if (telefono.Text == "")
            {
                MessageBox.Show("No debe haber campos vacios");
                telefono.Focus();
            }
            else if (selecion_combo_plantel == -1)
            {
                MessageBox.Show("Debe selecionar uno de la lista");
                comboBox_plantel.Focus();
            }
            else if (selecion_combo_carrera == -1)
            {
                MessageBox.Show("Debe selecionar uno de la lista");
                comboBox_carrera.Focus();
            }
            else
            {
                localhost.Service ser = new localhost.Service();
                String Fecha = dateTimePicker1.Value.Year.ToString()+"-"+dateTimePicker1.Value.Month.ToString()+"-"+dateTimePicker1.Value.Day.ToString();
                String selecion_plantel = comboBox_plantel.SelectedItem.ToString();
                String selecion_carrera = comboBox_carrera.SelectedItem.ToString();

                //LLAMAR METODO DEL SERVICE
                ser.Actualizar(matricula.Text,nombre.Text, p_apellido.Text,s_apellido.Text,Fecha,selecion_plantel,selecion_carrera,semestre.Text,direccion.Text,correo.Text,telefono.Text);

                //PONER TEXTBOX VACIOS
               // matricula.Text = "";
                //nombre.Text = "";
                //p_apellido.Text = "";
               // s_apellido.Text = "";


                MessageBox.Show("HECHO");

                this.Close();
                CRUD frm_principal = new CRUD();
                frm_principal.Refresh();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CRUD frm_principal = new CRUD();
            frm_principal.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            localhost.Service ser = new localhost.Service();

            //LLAMAR METODO DEL SERVICE
           

        }
    }
}
