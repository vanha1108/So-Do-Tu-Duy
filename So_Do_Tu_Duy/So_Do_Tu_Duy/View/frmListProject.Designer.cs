namespace So_Do_Tu_Duy.View
{
    partial class frmListProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenProject = new System.Windows.Forms.Button();
            this.dtgvListProject = new System.Windows.Forms.DataGridView();
            this.cIDPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListProject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách Project";
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.Location = new System.Drawing.Point(507, 337);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(148, 51);
            this.btnOpenProject.TabIndex = 2;
            this.btnOpenProject.Text = "Open Project";
            this.btnOpenProject.UseVisualStyleBackColor = true;
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // dtgvListProject
            // 
            this.dtgvListProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDPro,
            this.cNote});
            this.dtgvListProject.Location = new System.Drawing.Point(21, 59);
            this.dtgvListProject.Name = "dtgvListProject";
            this.dtgvListProject.RowHeadersWidth = 51;
            this.dtgvListProject.RowTemplate.Height = 24;
            this.dtgvListProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListProject.Size = new System.Drawing.Size(634, 254);
            this.dtgvListProject.TabIndex = 3;
            // 
            // cIDPro
            // 
            this.cIDPro.HeaderText = "ID Project";
            this.cIDPro.MinimumWidth = 6;
            this.cIDPro.Name = "cIDPro";
            // 
            // cNote
            // 
            this.cNote.HeaderText = "Note";
            this.cNote.MinimumWidth = 6;
            this.cNote.Name = "cNote";
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(353, 337);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(148, 51);
            this.btnDeleteProject.TabIndex = 4;
            this.btnDeleteProject.Text = "Delete Project";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // frmListProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 412);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.dtgvListProject);
            this.Controls.Add(this.btnOpenProject);
            this.Controls.Add(this.label1);
            this.Name = "frmListProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Project";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNote;
        public System.Windows.Forms.DataGridView dtgvListProject;
        public System.Windows.Forms.Button btnOpenProject;
        public System.Windows.Forms.Button btnDeleteProject;
    }
}