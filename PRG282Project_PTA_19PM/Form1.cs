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

    //Variable declaration
        private FileHandler fileHandler;
        private int selectedHeroId = -1;

        public Form1()
        {
            InitializeComponent();
            fileHandler = new FileHandler();
            
        }

       //Method to load superhero data when form loads up
        private void Form1_Load(object sender, EventArgs e)
        {
            {
                LoadSuperheroes();
            }

            //Method to load superheros data into data grid view
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

        
        //Button method to add a new superhero to textfile 
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
                
                    
                    MessageBox.Show("Added new superhero",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding superhero: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }       
        
        //Button Method to Update a superheroes data from the textfile
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
        
                     
                     MessageBox.Show("Updated superhero record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
         catch (Exception ex)
                 {
                     MessageBox.Show($"Error updating superhero: {ex.Message}",
                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }           
         }

        //Button Method to delete superhero from texfile
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
        
                         
                         MessageBox.Show("Deleted superhero record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                 }
         catch (Exception ex)
                 {
                     MessageBox.Show($"Error deleting superhero: {ex.Message}",
                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
         }

       //Button method to generate and show summary report 
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
        
                     
                     MessageBox.Show("Generated summary report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
          catch (Exception ex)
                 {
                     MessageBox.Show($"Error generating report: {ex.Message}",
                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }          
          }

        
         
         // DataGridView cell click method to populate input fields
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
       
    
        //Button method to clear all input fields
         private void btnClear_Click(object sender, EventArgs e)
         {
             ClearInputs();
         }

         
         // Method to validates all input fields
         private bool ValidateInputs()
         {
             // Check for empty fields
             if (string.IsNullOrWhiteSpace(txtHeroID.Text))
                 {
                     MessageBox.Show("Hero ID is required!", "Validation Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     txtHeroID.Focus();
                     return false;
                 }
    
             if (string.IsNullOrWhiteSpace(txtName.Text))
                 {
                     MessageBox.Show("Name is required!", "Validation Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     txtName.Focus();
                     return false;
                 }
    
             if (string.IsNullOrWhiteSpace(txtAge.Text))
                 {
                     MessageBox.Show("Age is required!", "Validation Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     txtAge.Focus();
                     return false;
                 }
    
             if (string.IsNullOrWhiteSpace(txtSuperpower.Text))
                 {
                     MessageBox.Show("Superpower is required!", "Validation Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     txtSuperpower.Focus();
                     return false;
                 }
    
             if (string.IsNullOrWhiteSpace(txtExamScore.Text))
                 {
                     MessageBox.Show("Exam Score is required!", "Validation Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     txtExamScore.Focus();
                     return false;
                 }
    
             // Validate numeric fields
             if (!int.TryParse(txtHeroID.Text, out int heroId))
                 {
                     MessageBox.Show("Hero ID must be a valid number!", "Validation Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     txtHeroID.Focus();
                     return false;
                 }
    
             if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
                 {
                     MessageBox.Show("Age must be a positive number!", "Validation Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     txtAge.Focus();
                     return false;
                 }
    
             if (!int.TryParse(txtExamScore.Text, out int score) || score < 0 || score > 100)
                 {
                     MessageBox.Show("Exam Score must be between 0 and 100!", "Validation Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     txtExamScore.Focus();
                     return false;
                 }
    
             return true;
         }
    
         
         //Method to clears all input fields 
         private void ClearInputs()
         {
             txtHeroID.Clear();
             txtName.Clear();
             txtAge.Clear();
             txtSuperpower.Clear();
             txtExamScore.Clear();
             selectedHeroId = -1;
             txtHeroID.Focus();
         }
    
       }
   }
    
    
    
    

