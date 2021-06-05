﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Panaderia
{
    public partial class sesion : Form
    {
        public sesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("server=" + servertxt.Text+ " ; database=" + dbtxt.Text+ " ; user id = sa; password='Valley';"))
                    
                {
                    using (SqlCommand cmd = new SqlCommand("ConsultarUsuario", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = usertxt.Text;
                        cmd.Parameters.Add("@passwords", SqlDbType.VarChar).Value = passwordtxt.Text;
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        //SELECIONO USUARIO Y COMPAARO
                        string name =  "" + dataGridView1.Rows[0].Cells[2].Value;
                        string pass = "" + dataGridView1.Rows[0].Cells[3].Value;
                        if (name == usertxt.Text & pass == passwordtxt.Text)
                        {
                            label7.Text=  "" + dataGridView1.Rows[0].Cells[0].Value;
                            label6.Text= "" + dataGridView1.Rows[0].Cells[2].Value;
                            pictureBox47.ImageLocation =  dataGridView1.Rows[0].Cells[4].Value.ToString();
                            label13.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                            label9.Text = servertxt.Text;
                            label8.Text = dbtxt.Text;
                            MessageBox.Show("Inicio correcto");
                            Properties.Settings.Default.Save();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No nos hemos podido conectar");
                        }
                      
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }

        private void sesion_Load(object sender, EventArgs e)
        {

        }

        private void passwordtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button15_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
