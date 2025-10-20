namespace PRG282Project_PTA_19PM
{
        partial class Form1
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            private void InitializeComponent()
            {
                this.dgvSuperheroes = new System.Windows.Forms.DataGridView();
                this.txtHeroID = new System.Windows.Forms.TextBox();
                this.txtName = new System.Windows.Forms.TextBox();
                this.txtAge = new System.Windows.Forms.TextBox();
                this.txtSuperpower = new System.Windows.Forms.TextBox();
                this.txtExamScore = new System.Windows.Forms.TextBox();
                this.lblHeroID = new System.Windows.Forms.Label();
                this.lblName = new System.Windows.Forms.Label();
                this.lblAge = new System.Windows.Forms.Label();
                this.lblSuperpower = new System.Windows.Forms.Label();
                this.lblExamScore = new System.Windows.Forms.Label();
                this.btnAdd = new System.Windows.Forms.Button();
                this.btnUpdate = new System.Windows.Forms.Button();
                this.btnDelete = new System.Windows.Forms.Button();
                this.btnGenerateReport = new System.Windows.Forms.Button();
                this.btnClear = new System.Windows.Forms.Button();
                this.lblTitle = new System.Windows.Forms.Label();
                this.grpInputs = new System.Windows.Forms.GroupBox();
                this.grpActions = new System.Windows.Forms.GroupBox();
                ((System.ComponentModel.ISupportInitialize)(this.dgvSuperheroes)).BeginInit();
                this.grpInputs.SuspendLayout();
                this.grpActions.SuspendLayout();
                this.SuspendLayout();
                // 
                // dgvSuperheroes
                // 
                this.dgvSuperheroes.AllowUserToAddRows = false;
                this.dgvSuperheroes.AllowUserToDeleteRows = false;
                this.dgvSuperheroes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                this.dgvSuperheroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dgvSuperheroes.Location = new System.Drawing.Point(12, 350);
                this.dgvSuperheroes.Name = "dgvSuperheroes";
                this.dgvSuperheroes.ReadOnly = true;
                this.dgvSuperheroes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                this.dgvSuperheroes.Size = new System.Drawing.Size(976, 288);
                this.dgvSuperheroes.TabIndex = 0;
                this.dgvSuperheroes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuperheroes_CellClick);
                // 
                // txtHeroID
                // 
                this.txtHeroID.Location = new System.Drawing.Point(120, 30);
                this.txtHeroID.Name = "txtHeroID";
                this.txtHeroID.Size = new System.Drawing.Size(200, 20);
                this.txtHeroID.TabIndex = 1;
                // 
                // txtName
                // 
                this.txtName.Location = new System.Drawing.Point(120, 65);
                this.txtName.Name = "txtName";
                this.txtName.Size = new System.Drawing.Size(200, 20);
                this.txtName.TabIndex = 2;
                // 
                // txtAge
                // 
                this.txtAge.Location = new System.Drawing.Point(120, 100);
                this.txtAge.Name = "txtAge";
                this.txtAge.Size = new System.Drawing.Size(200, 20);
                this.txtAge.TabIndex = 3;
                // 
                // txtSuperpower
                // 
                this.txtSuperpower.Location = new System.Drawing.Point(120, 135);
                this.txtSuperpower.Name = "txtSuperpower";
                this.txtSuperpower.Size = new System.Drawing.Size(200, 20);
                this.txtSuperpower.TabIndex = 4;
                // 
                // txtExamScore
                // 
                this.txtExamScore.Location = new System.Drawing.Point(120, 170);
                this.txtExamScore.Name = "txtExamScore";
                this.txtExamScore.Size = new System.Drawing.Size(200, 20);
                this.txtExamScore.TabIndex = 5;
                // 
                // lblHeroID
                // 
                this.lblHeroID.AutoSize = true;
                this.lblHeroID.Location = new System.Drawing.Point(20, 33);
                this.lblHeroID.Name = "lblHeroID";
                this.lblHeroID.Size = new System.Drawing.Size(48, 13);
                this.lblHeroID.TabIndex = 6;
                this.lblHeroID.Text = "Hero ID:";
                // 
                // lblName
                // 
                this.lblName.AutoSize = true;
                this.lblName.Location = new System.Drawing.Point(20, 68);
                this.lblName.Name = "lblName";
                this.lblName.Size = new System.Drawing.Size(38, 13);
                this.lblName.TabIndex = 7;
                this.lblName.Text = "Name:";
                // 
                // lblAge
                // 
                this.lblAge.AutoSize = true;
                this.lblAge.Location = new System.Drawing.Point(20, 103);
                this.lblAge.Name = "lblAge";
                this.lblAge.Size = new System.Drawing.Size(29, 13);
                this.lblAge.TabIndex = 8;
                this.lblAge.Text = "Age:";
                // 
                // lblSuperpower
                // 
                this.lblSuperpower.AutoSize = true;
                this.lblSuperpower.Location = new System.Drawing.Point(20, 138);
                this.lblSuperpower.Name = "lblSuperpower";
                this.lblSuperpower.Size = new System.Drawing.Size(67, 13);
                this.lblSuperpower.TabIndex = 9;
                this.lblSuperpower.Text = "Superpower:";
                // 
                // lblExamScore
                // 
                this.lblExamScore.AutoSize = true;
                this.lblExamScore.Location = new System.Drawing.Point(20, 173);
                this.lblExamScore.Name = "lblExamScore";
                this.lblExamScore.Size = new System.Drawing.Size(94, 13);
                this.lblExamScore.TabIndex = 10;
                this.lblExamScore.Text = "Exam Score (0-100):";
                // 
                // btnAdd
                // 
                this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
                this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                this.btnAdd.ForeColor = System.Drawing.Color.White;
                this.btnAdd.Location = new System.Drawing.Point(20, 30);
                this.btnAdd.Name = "btnAdd";
                this.btnAdd.Size = new System.Drawing.Size(120, 40);
                this.btnAdd.TabIndex = 11;
                this.btnAdd.Text = "Add Hero";
                this.btnAdd.UseVisualStyleBackColor = false;
                this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
                // 
                // btnUpdate
                // 
                this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
                this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                this.btnUpdate.ForeColor = System.Drawing.Color.White;
                this.btnUpdate.Location = new System.Drawing.Point(160, 30);
                this.btnUpdate.Name = "btnUpdate";
                this.btnUpdate.Size = new System.Drawing.Size(120, 40);
                this.btnUpdate.TabIndex = 12;
                this.btnUpdate.Text = "Update Hero";
                this.btnUpdate.UseVisualStyleBackColor = false;
                this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
                // 
                // btnDelete
                // 
                this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
                this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                this.btnDelete.ForeColor = System.Drawing.Color.White;
                this.btnDelete.Location = new System.Drawing.Point(300, 30);
                this.btnDelete.Name = "btnDelete";
                this.btnDelete.Size = new System.Drawing.Size(120, 40);
                this.btnDelete.TabIndex = 13;
                this.btnDelete.Text = "Delete Hero";
                this.btnDelete.UseVisualStyleBackColor = false;
                this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
                // 
                // btnGenerateReport
                // 
                this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
                this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
                this.btnGenerateReport.Location = new System.Drawing.Point(440, 30);
                this.btnGenerateReport.Name = "btnGenerateReport";
                this.btnGenerateReport.Size = new System.Drawing.Size(150, 40);
                this.btnGenerateReport.TabIndex = 14;
                this.btnGenerateReport.Text = "Generate Report";
                this.btnGenerateReport.UseVisualStyleBackColor = false;
                this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
                // 
                // btnClear
                // 
                this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
                this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                this.btnClear.ForeColor = System.Drawing.Color.White;
                this.btnClear.Location = new System.Drawing.Point(610, 30);
                this.btnClear.Name = "btnClear";
                this.btnClear.Size = new System.Drawing.Size(120, 40);
                this.btnClear.TabIndex = 15;
                this.btnClear.Text = "Clear Fields";
                this.btnClear.UseVisualStyleBackColor = false;
                this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
                // 
                // lblTitle
                // 
                this.lblTitle.AutoSize = true;
                this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
                this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
                this.lblTitle.Location = new System.Drawing.Point(250, 15);
                this.lblTitle.Name = "lblTitle";
                this.lblTitle.Size = new System.Drawing.Size(500, 29);
                this.lblTitle.TabIndex = 16;
                this.lblTitle.Text = "One Kick Heroes Academy - Database HQ";
                // 
                // grpInputs
                // 
                this.grpInputs.Controls.Add(this.lblHeroID);
                this.grpInputs.Controls.Add(this.txtHeroID);
                this.grpInputs.Controls.Add(this.lblName);
                this.grpInputs.Controls.Add(this.txtName);
                this.grpInputs.Controls.Add(this.lblAge);
                this.grpInputs.Controls.Add(this.txtAge);
                this.grpInputs.Controls.Add(this.lblSuperpower);
                this.grpInputs.Controls.Add(this.txtSuperpower);
                this.grpInputs.Controls.Add(this.lblExamScore);
                this.grpInputs.Controls.Add(this.txtExamScore);
                this.grpInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
                this.grpInputs.Location = new System.Drawing.Point(12, 60);
                this.grpInputs.Name = "grpInputs";
                this.grpInputs.Size = new System.Drawing.Size(350, 220);
                this.grpInputs.TabIndex = 17;
                this.grpInputs.TabStop = false;
                this.grpInputs.Text = "Hero Information";
                // 
                // grpActions
                // 
                this.grpActions.Controls.Add(this.btnAdd);
                this.grpActions.Controls.Add(this.btnUpdate);
                this.grpActions.Controls.Add(this.btnDelete);
                this.grpActions.Controls.Add(this.btnGenerateReport);
                this.grpActions.Controls.Add(this.btnClear);
                this.grpActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
                this.grpActions.Location = new System.Drawing.Point(380, 60);
                this.grpActions.Name = "grpActions";
                this.grpActions.Size = new System.Drawing.Size(750, 90);
                this.grpActions.TabIndex = 18;
                this.grpActions.TabStop = false;
                this.grpActions.Text = "Actions";
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(1000, 650);
                this.Controls.Add(this.grpActions);
                this.Controls.Add(this.grpInputs);
                this.Controls.Add(this.lblTitle);
                this.Controls.Add(this.dgvSuperheroes);
                this.Name = "Form1";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Superhero Database System - PRG2782";
                this.Load += new System.EventHandler(this.Form1_Load);
                ((System.ComponentModel.ISupportInitialize)(this.dgvSuperheroes)).EndInit();
                this.grpInputs.ResumeLayout(false);
                this.grpInputs.PerformLayout();
                this.grpActions.ResumeLayout(false);
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            #endregion

            private System.Windows.Forms.DataGridView dgvSuperheroes;
            private System.Windows.Forms.TextBox txtHeroID;
            private System.Windows.Forms.TextBox txtName;
            private System.Windows.Forms.TextBox txtAge;
            private System.Windows.Forms.TextBox txtSuperpower;
            private System.Windows.Forms.TextBox txtExamScore;
            private System.Windows.Forms.Label lblHeroID;
            private System.Windows.Forms.Label lblName;
            private System.Windows.Forms.Label lblAge;
            private System.Windows.Forms.Label lblSuperpower;
            private System.Windows.Forms.Label lblExamScore;
            private System.Windows.Forms.Button btnAdd;
            private System.Windows.Forms.Button btnUpdate;
            private System.Windows.Forms.Button btnDelete;
            private System.Windows.Forms.Button btnGenerateReport;
            private System.Windows.Forms.Button btnClear;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.GroupBox grpInputs;
            private System.Windows.Forms.GroupBox grpActions;
        }
    }

