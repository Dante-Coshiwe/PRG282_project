using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PRG282Project_PTA_19PM.DataLayer;
using PRG282Project_PTA_19PM.BusinessProcessLayer;


namespace PRG282Project_PTA_19PM
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

       
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
           
        }

        
        

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }


        private void dgvSuperheroes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvSuperheroes.Rows[e.RowIndex];

                    txtHeroID.Text = row.Cells["HeroID"].Value.ToString();
                    txtName.Text = row.Cells["Name"].Value.ToString();
                    txtAge.Text = row.Cells["Age"].Value.ToString();
                    txtSuperpower.Text = row.Cells["Superpower"].Value.ToString();
                    txtExamScore.Text = row.Cells["ExamScore"].Value.ToString();

                    selectedHeroId = int.Parse(row.Cells["HeroID"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting superhero: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
