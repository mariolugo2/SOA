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

    public partial class CRUD : Form
    {


        public CRUD()
        {

            InitializeComponent();

         localhost.Service ser = new localhost.Service();
         DataSet dt = new DataSet();
         dt = ser.Obtener_Todo();
         dataGridView1.DataSource = dt.Tables[0];
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
          


        }


        private void insertar_Click(object sender, EventArgs e)
        {

            insertar frm_insertar = new insertar();
            frm_insertar.ShowDialog();
            actualizar_tabla();
        }

        public void actualizar_tabla()
        {
            localhost.Service ser = new localhost.Service();
            DataSet dt = new DataSet();
            dt = ser.Obtener_Todo();
            dataGridView1.DataSource = dt.Tables[0];
        }


        private void button3_Click(object sender, EventArgs e)
        {

            String selecion = dataGridView1.CurrentCell.Value.ToString();
       
            int i;

            if (selecion == "")
            {
                MessageBox.Show("No se puede");

            }
            else
            {

                if (!int.TryParse(selecion, out i))
                {

                    MessageBox.Show("SOLO NUMERO ENTEROS");
                }
                else
                {

                    localhost.Service ser = new localhost.Service();

                    //LLAMAR METODO DEL SERVICE
                    ser.Borra_Registro(selecion);

                    MessageBox.Show("HECHO");

                    CRUD frm_principal = new CRUD();

                    actualizar_tabla();




                }


            }
        }

        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());

        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            actulizar frm_actualizar = new actulizar();
            frm_actualizar.ShowDialog();
            actualizar_tabla();


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            insertar frm_insertar = new insertar();
            frm_insertar.ShowDialog();
            actualizar_tabla();
        }

        private void actulizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actulizar frm_actualizar = new actulizar();
            frm_actualizar.ShowDialog();
            actualizar_tabla();

        }



        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String selecion = dataGridView1.CurrentCell.Value.ToString();
            int i;
          
              if (selecion == "")
              {
                  MessageBox.Show("No se puede");

              }
              else
              {

                  if (!int.TryParse(selecion, out i))
                  {

                      MessageBox.Show("SOLO NUMERO ENTEROS");
                  }
                  else
                  {

                      localhost.Service ser = new localhost.Service();

                      //LLAMAR METODO DEL SERVICE
                      ser.Borra_Registro(selecion);

                      MessageBox.Show("HECHO");

                      CRUD frm_principal = new CRUD();

                      actualizar_tabla();




                  }
            

              }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int v1 = 0;
            int v2 = 0;
           
            int selecc = Convert.ToInt32(v2);
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {

                v1 = Convert.ToInt32(Row.Cells["matricula"].Value);

                if (selecc == v1)
                {

                    MessageBox.Show("Hecho");
                    this.Show();

                }


            }
        }

        




    }
}
