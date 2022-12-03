using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Collections;

namespace ProyectoRentaDeBarcos
{
    public partial class sesionInterfaz : Form
    {
        
        private ConexionMySQL conexionMysql;
        public sesionInterfaz()
        {
            conexionMysql = new ConexionMySQL();
            InitializeComponent();
            this.Icon = Properties.Resources.yacht_logo1669771022;
        }

        private void sesionInterfaz_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string query = $"select id_usuario from usuarios WHERE usuarios.nombre='{tb_usuario.Text}' AND usuarios.password='{tb_password.Text}';";
            MySqlCommand mCommand = new MySqlCommand(query, conexionMysql.GetConnection());
            MySqlDataReader mReader;
            mReader = mCommand.ExecuteReader();
            int id = 0;

            while (mReader.Read())
            {
                id = mReader.GetInt32(0);
            }
            mReader.Close();

            if (id == 1)
            {
               InterfazV2 fm = new InterfazV2();
                fm.Show();
            } else if (id == 0)
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
