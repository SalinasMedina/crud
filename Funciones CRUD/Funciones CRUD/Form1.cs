using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Funciones_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.IfuncionesClient cliente = new ServiceReference1.IfuncionesClient())
            {
                try
                {
                {
                    cliente.guardar(Int32.Parse(textBox1.Text), textBox2.Text, Int32.Parse(textBox3.Text), float.Parse(textBox4.Text), textBox5.Text);
                }
                listBox1.Items.Add(textBox1.Text + ' ' + textBox2.Text + ' ' + Int32.Parse(textBox3.Text) + ' ' + float.Parse(textBox4.Text) + ' ' + textBox5.Text + ' ');
                textBox1.Text = "  ";
                textBox2.Text = "  ";
                textBox3.Text = "  ";
                textBox4.Text = "  ";
                textBox5.Text = "  ";
                }
                catch
                {
                    MessageBox.Show("No hay datos para registrar");
                }

            }
            
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            try
            {
                    listBox1.Items.Clear();
                    string[] lista;
                    using (ServiceReference1.IfuncionesClient cliente = new ServiceReference1.IfuncionesClient())
                    {
                        lista = cliente.leer();
                        {
                            for (int i = 0; i < lista.Count<string>(); i = i + 5)
                            {
                                listBox1.Items.Add(lista[i].ToString() + " " + lista[i + 1].ToString() + "  " + lista[i + 2].ToString() + "  " + lista[i + 3].ToString() + "  " + lista[i + 4].ToString() + "  ");
                            }
                        }
                    }
                }
            catch
            {
                MessageBox.Show("No se ha registrado ningun producto");
            }
        }
        

        private void btn_Update_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.IfuncionesClient cliente = new ServiceReference1.IfuncionesClient())
            {
                try
                {
                    {
                        if (cliente.modificar(Int32.Parse(textBox1.Text), textBox2.Text, Int32.Parse(textBox3.Text), float.Parse(textBox4.Text), textBox5.Text))
                        {
                            MessageBox.Show("Elemento modificado");
                        }
                            
                        else
                        {
                            MessageBox.Show("No se pudo modificar");
                        }
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                catch
                {
                    MessageBox.Show("Seleccione los datos a modificar");
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.IfuncionesClient cliente = new ServiceReference1.IfuncionesClient())
            {
                try
                {
                    if (cliente.eliminar(Int32.Parse(textBox1.Text)))
                    {
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No existe");
                    }
                }
                catch
                {
                    MessageBox.Show("No hay datos que eliminar");
                }
            }

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string[] vector = new string[5];
            using (ServiceReference1.IfuncionesClient cliente = new ServiceReference1.IfuncionesClient())
            {
                try
                {
                    vector = cliente.buscar(Convert.ToInt32(textBox1.Text));
                    if (vector[0] == null)
                    {
                        MessageBox.Show("No se encuentra");
                    }
                    else
                    {
                        textBox2.Text = vector[1];
                        textBox3.Text = vector[2];
                        textBox4.Text = vector[3];
                        textBox5.Text = vector[4];
                    }
                }
                catch
                {
                    MessageBox.Show("No se ha especificado una clave");
                }
            }
        }
    }
}
