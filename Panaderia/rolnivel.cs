using System;
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
    public partial class rolnivel : Form
    {
        public rolnivel()
        {
            InitializeComponent();
        }

        private void rolnivel_Load(object sender, EventArgs e)
        {
            cargarrol();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label28.Text == "0")
            {
                if (txt_nombre.Text == "" || txt_estado.Text == "" || id_nivel.Text == "") { MessageBox.Show("Debe llenar todos los campos", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection("server=" + label21.Text + " ; database=" + label15.Text + " ; user id = sa; password='Valley';"))
                        {
                            using (SqlCommand cmd = new SqlCommand("prorol", cn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@rnom", SqlDbType.VarChar).Value = txt_nombre.Text;
                                cmd.Parameters.Add("@rnivel", SqlDbType.Int).Value = int.Parse(id_nivel.Text);
                                cmd.Parameters.Add("@restado", SqlDbType.Int).Value = int.Parse(txt_estado.Text);
                                cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = 1;
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = 1;
                                cn.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Se ha agregado un nuevo Rol", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                                cargarrol();
                            }
                        }
                    }
                    catch { MessageBox.Show("Un error ha sucedido", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else {
                if (txt_nombre.Text == "" || txt_estado.Text == "" || id_nivel.Text == "") { MessageBox.Show("Debe llenar todos los campos", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection("server=" + label21.Text + " ; database=" + label15.Text + " ; user id = sa; password='Valley';"))
                        {
                            using (SqlCommand cmd = new SqlCommand("prorol", cn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@rnom", SqlDbType.VarChar).Value = txt_nombre.Text;
                                cmd.Parameters.Add("@rnivel", SqlDbType.Int).Value = int.Parse(id_nivel.Text);
                                cmd.Parameters.Add("@restado", SqlDbType.Int).Value = int.Parse(txt_estado.Text);
                                cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = 2;
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(label28.Text);
                                cn.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Se actualizado el Rol", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                                cargarrol();
                            }
                        }
                    }
                    catch { MessageBox.Show("Un error ha sucedido", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }

            }

           
        }
        private void limpiar()
        {
            txt_ncod.Text= "";
            txt_nombre.Text = "";
            txt_nnombre.Text = "";
            id_nivel.Text = "";
            txt_estado.Text = "1";
            txt_nestado.Text = "1";
            label28.Text = "0";
            button19.Text = "Agregar";
            button2.Text = "Agregar";
            txt_nestado.Enabled = false;
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (label28.Text == "0")
            {
                if (txt_ncod.Text == "" || txt_nnombre.Text == "" || txt_nestado.Text == "") { MessageBox.Show("Debe llenar todos los campos", "Nivel", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection("server=" + label21.Text + " ; database=" + label15.Text + " ; user id = sa; password='Valley';"))
                        {
                            using (SqlCommand cmd = new SqlCommand("pronivel", cn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@nid", SqlDbType.Int).Value = int.Parse(txt_ncod.Text);
                                cmd.Parameters.Add("@nnom", SqlDbType.VarChar).Value = txt_nnombre.Text;
                                cmd.Parameters.Add("@nestado", SqlDbType.Int).Value = int.Parse(txt_nestado.Text);
                                cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = 1;
                                cn.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Se ha agregado un nuevo Nivel", "Nivel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cargarnivel();
                                limpiar();
                            }
                        }
                    }
                    catch { MessageBox.Show("Un error ha sucedido", "Nivel", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else
            {
                    if (txt_nnombre.Text == "" || txt_nestado.Text == "") { MessageBox.Show("Debe llenar todos los campos", "Nivel", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else
                    {
                        try
                        {
                            using (SqlConnection cn = new SqlConnection("server=" + label21.Text + " ; database=" + label15.Text + " ; user id = sa; password='Valley';"))
                            {
                                using (SqlCommand cmd = new SqlCommand("pronivel", cn))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add("@nid", SqlDbType.Int).Value = int.Parse(label28.Text);
                                    cmd.Parameters.Add("@nnom", SqlDbType.VarChar).Value = txt_nnombre.Text;
                                    cmd.Parameters.Add("@nestado", SqlDbType.Int).Value = int.Parse(txt_nestado.Text);
                                    cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = 2;
                                    cn.Open();
                                    cmd.ExecuteNonQuery();
                                    cargarnivel();
                                    MessageBox.Show("Se ha actualizado el Nivel", "Nivel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpiar();
                                }
                            }
                        }
                        catch { MessageBox.Show("Un error ha sucedido", "Nivel", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void posicion(int pos)
        {
            try
            {
                if (dataGridView2.Rows.Count <= 0) { pictureBox14.Size = new Size(0, 10); pictureBox12.Size = new Size(0, 10); }
                else
                {
                    //texto2.Text = "" + dataGridView1.CurrentRow.Cells[2].Value;
                    string estado = "";
                    int total = 0;
                    for (int i = 0; i < dataGridView2.Rows.Count; i++) { estado = "" + dataGridView2.Rows[i].Cells[pos].Value.ToString(); if (estado == "1") { total += 1; } }
                    double tt = (total * 100) / int.Parse(dataGridView2.Rows.Count.ToString());
                    double ttt = tt * 1.5;
                    int t4 = int.Parse(Math.Round(ttt, MidpointRounding.AwayFromZero).ToString());
                    pictureBox14.Size = new Size(t4, 10);
                    pictureBox12.Size = new Size(150 - t4, 10);
                }
            }
            catch { }

            try {
                if (dataGridView1.RowCount <= 0) { pictureBox9.Size = new Size(0, 10); pictureBox10.Size = new Size(0, 10); }
                else
                {
                    //texto2.Text = "" + dataGridView1.CurrentRow.Cells[2].Value;
                    string estado = "";
                    int total = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++) { estado = "" + dataGridView1.Rows[i].Cells[pos].Value.ToString(); if (estado == "1") { total += 1; } }
                    double tt = (total * 100) / int.Parse(dataGridView1.Rows.Count.ToString());
                    double ttt = tt * 1.5;
                    int t4 = int.Parse(Math.Round(ttt, MidpointRounding.AwayFromZero).ToString());
                    pictureBox9.Size = new Size(t4, 10);
                    pictureBox10.Size = new Size(150 - t4, 10);
                }
            } catch { }
           


        }
        private void cargarrol()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("server=" + label21.Text + " ; database=" + label15.Text + " ; user id = sa; password='Valley';"))
                {
                    using (SqlCommand cmd = new SqlCommand("prorol", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@rnom", SqlDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@rnivel", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@restado", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = 3;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = 1;
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0];
                        label23.Text = dataGridView2.Rows.Count.ToString();
                        posicion(3);
                    }
                }
            }
            catch { MessageBox.Show("Ha sucedido un error", "Rol", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cargarnivel()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("server=" + label21.Text + " ; database=" + label15.Text + " ; user id = sa; password='Valley';"))
                {
                    using (SqlCommand cmd = new SqlCommand("pronivel", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@nnom", SqlDbType.VarChar).Value ="1";
                        cmd.Parameters.Add("@nestado", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = 3;
                        cmd.Parameters.Add("@nid", SqlDbType.Int).Value = 1;
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        label17.Text = dataGridView1.Rows.Count.ToString();
                        posicion(2);
                    }
                }
            }
            catch { MessageBox.Show("Ha sucedido un error", "Nivel", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            label4.Text = "Rol";
            rol.Visible = true;
            nivel.Visible = false;
            cargarrol();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            limpiar();
            cargarnivel();
            nivel.Text = "Rol";
            rol.Visible = false;
            nivel.Visible = true;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.RowCount > 0) {
                button19.Text = "Actualizar";
                txt_nombre.Text = "" + dataGridView2.CurrentRow.Cells[1].Value;
                id_nivel.Text = "" + dataGridView2.CurrentRow.Cells[2].Value;
                txt_estado.Text = "" + dataGridView2.CurrentRow.Cells[3].Value;
                txt_estado.Enabled = true;
                label28.Text = "" + dataGridView2.CurrentRow.Cells[0].Value;
            }
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0) {
                button2.Text = "Actualizar";
                txt_nnombre.Text = "" + dataGridView1.CurrentRow.Cells[1].Value;
                txt_nestado.Text = "" + dataGridView1.CurrentRow.Cells[2].Value;
                txt_nestado.Enabled = true;
                label28.Text = "" + dataGridView1.CurrentRow.Cells[0].Value;
            }
           
        }
    
    }
}
