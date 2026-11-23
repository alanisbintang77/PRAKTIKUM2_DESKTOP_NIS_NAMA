using System.ComponentModel.Design;
using MySql.Data.MySqlClient;

namespace PRAKTIKUM2_DESKTOP_NIS_NAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
               
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
          try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString)) 
                {
                    connection.Open();
                    string query = "insret into 'tb_bahan_baku' ('kode bahan','nama bahan','kategori','stok','satuan','harga satuan','batas minimum','terakhir update')";
                    using (MySqlConnection connection = new MySqlConnection(query, Connection))
                    {
                        
                    }
                }
            }
        }
    }
}
