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

        
        /// <summary>
        /// Add new superhero button click event
        /// </summary> 
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
        
        /// <summary>
    m   /// Update superhero button click event
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
                 {
                     if (selectedHeroId == -1)
                     {
                         MessageBox.Show("Please select a superhero from the grid first!",
                             "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return;
                     }

                     // Validate inputs
                     if (!ValidateInputs())
                         return;
        
                     // Parse input values
                     int heroId = int.Parse(txtHeroID.Text);
                     string name = txtName.Text.Trim();
                     int age = int.Parse(txtAge.Text);
                     string superpower = txtSuperpower.Text.Trim();
                     int examScore = int.Parse(txtExamScore.Text);
        
                     // Create updated superhero
                     Superhero updatedHero = new Superhero(heroId, name, age, superpower, examScore);
        
                     // Update in file
                     fileHandler.UpdateSuperhero(selectedHeroId, updatedHero);
        
                     MessageBox.Show("Superhero updated successfully!", "Success",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
        
                     // Refresh display and clear inputs
                     LoadSuperheroes();
                     ClearInputs();
        
                     // Git commit message suggestion
                     MessageBox.Show("Remember to commit: git add . && git commit -m \"Updated superhero record\"",
                         "Git Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
         catch (Exception ex)
                 {
                     MessageBox.Show($"Error updating superhero: {ex.Message}",
                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }           
        }

         /// <summary>
         /// Delete superhero button click event
         /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
                 {
                     if (selectedHeroId == -1)
                     {
                         MessageBox.Show("Please select a superhero from the grid first!",
                             "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return;
                     }
        
                     // Confirm deletion
                     DialogResult result = MessageBox.Show(
                         $"Are you sure you want to delete Hero ID {selectedHeroId}?",
                         "Confirm Delete",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
        
                     if (result == DialogResult.Yes)
                     {
                         // Delete from file
                         fileHandler.DeleteSuperhero(selectedHeroId);
        
                         MessageBox.Show("Superhero deleted successfully!", "Success",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        
                         // Refresh display and clear inputs
                         LoadSuperheroes();
                         ClearInputs();
        
                         // Git commit message suggestion
                         MessageBox.Show("Remember to commit: git add . && git commit -m \"Deleted superhero record\"",
                             "Git Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                 }
         catch (Exception ex)
                 {
                     MessageBox.Show($"Error deleting superhero: {ex.Message}",
                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
        }

        /// <summary>
        /// Generate summary report button click event
        /// </summary>
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
                 {
                     string summary = fileHandler.GenerateSummary();
        
                     // Display summary in a message box
                     MessageBox.Show(summary, "Summary Report",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
        
                     MessageBox.Show("Summary saved to summary.txt", "Success",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
        
                     // Git commit message suggestion
                     MessageBox.Show("Remember to commit: git add . && git commit -m \"Generated summary report\"",
                         "Git Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
         catch (Exception ex)
                 {
                     MessageBox.Show($"Error generating report: {ex.Message}",
                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }          
        }

        
         /// <summary>
         /// Clear all input fields
         /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
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


