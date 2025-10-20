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
        private FileHandler fileHandler;
        private int selectedHeroId = -1;

        public Form1()
        {
            InitializeComponent();
            fileHandler = new FileHandler();
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            {
                LoadSuperheroes();
            }

            /// <summary>
            /// Loads all superheroes into the DataGridView
            /// </summary>
            private void LoadSuperheroes()
            {
                try
                    {
                        var heroes = fileHandler.ReadSuperheroes();
                        dgvSuperheroes.DataSource = null;
                        dgvSuperheroes.DataSource = heroes;

                        // Clear 
                        selectedHeroId = -1;
                    }
            catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading superheroes: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        
        

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
                {
                    // Validate inputs
                    if (!ValidateInputs())
                        return;
                
                    // Parse input values
                    int heroId = int.Parse(txtHeroID.Text);
                    string name = txtName.Text.Trim();
                    int age = int.Parse(txtAge.Text);
                    string superpower = txtSuperpower.Text.Trim();
                    int examScore = int.Parse(txtExamScore.Text);
                
                    // Create new superhero
                    Superhero newHero = new Superhero(heroId, name, age, superpower, examScore);
                
                    // Add to file
                    fileHandler.AddSuperhero(newHero);
                
                    MessageBox.Show("Superhero added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    // Refresh display and clear inputs
                    LoadSuperheroes();
                    ClearInputs();
                
                    // Git commit message suggestion
                    MessageBox.Show("Remember to commit: git add . && git commit -m \"Added new superhero\"",
                        "Git Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding superhero: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

