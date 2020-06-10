namespace So_Do_Tu_Duy
{
    partial class frmMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRelationship = new System.Windows.Forms.Button();
            this.btnTopic = new System.Windows.Forms.Button();
            this.btnSubTopic = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mindMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outlinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptbDraw = new System.Windows.Forms.PictureBox();
            this.btnCloseMap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnRelationship);
            this.panel1.Controls.Add(this.btnTopic);
            this.panel1.Controls.Add(this.btnSubTopic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 90);
            this.panel1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(980, 24);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(155, 49);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnRelationship
            // 
            this.btnRelationship.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRelationship.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelationship.Image = ((System.Drawing.Image)(resources.GetObject("btnRelationship.Image")));
            this.btnRelationship.Location = new System.Drawing.Point(422, 24);
            this.btnRelationship.Name = "btnRelationship";
            this.btnRelationship.Size = new System.Drawing.Size(155, 49);
            this.btnRelationship.TabIndex = 0;
            this.btnRelationship.Text = "Relationship";
            this.btnRelationship.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelationship.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelationship.UseVisualStyleBackColor = false;
            this.btnRelationship.Click += new System.EventHandler(this.btnRelationship_Click);
            // 
            // btnTopic
            // 
            this.btnTopic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTopic.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopic.Image = ((System.Drawing.Image)(resources.GetObject("btnTopic.Image")));
            this.btnTopic.Location = new System.Drawing.Point(92, 24);
            this.btnTopic.Name = "btnTopic";
            this.btnTopic.Size = new System.Drawing.Size(155, 49);
            this.btnTopic.TabIndex = 0;
            this.btnTopic.Text = "Topic";
            this.btnTopic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTopic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTopic.UseVisualStyleBackColor = false;
            this.btnTopic.Click += new System.EventHandler(this.btnTopic_Click);
            // 
            // btnSubTopic
            // 
            this.btnSubTopic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubTopic.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubTopic.Image = ((System.Drawing.Image)(resources.GetObject("btnSubTopic.Image")));
            this.btnSubTopic.Location = new System.Drawing.Point(256, 24);
            this.btnSubTopic.Name = "btnSubTopic";
            this.btnSubTopic.Size = new System.Drawing.Size(155, 49);
            this.btnSubTopic.TabIndex = 0;
            this.btnSubTopic.Text = "SubTopic";
            this.btnSubTopic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubTopic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubTopic.UseVisualStyleBackColor = false;
            this.btnSubTopic.Click += new System.EventHandler(this.btnSubTopic_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mindMapToolStripMenuItem,
            this.outlinerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mindMapToolStripMenuItem
            // 
            this.mindMapToolStripMenuItem.Name = "mindMapToolStripMenuItem";
            this.mindMapToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.mindMapToolStripMenuItem.Text = "Mind Map";
            this.mindMapToolStripMenuItem.Click += new System.EventHandler(this.mindMapToolStripMenuItem_Click);
            // 
            // outlinerToolStripMenuItem
            // 
            this.outlinerToolStripMenuItem.Name = "outlinerToolStripMenuItem";
            this.outlinerToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.outlinerToolStripMenuItem.Text = "Outliner";
            this.outlinerToolStripMenuItem.Click += new System.EventHandler(this.outlinerToolStripMenuItem_Click);
            // 
            // ptbDraw
            // 
            this.ptbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbDraw.Location = new System.Drawing.Point(0, 130);
            this.ptbDraw.Name = "ptbDraw";
            this.ptbDraw.Size = new System.Drawing.Size(1182, 673);
            this.ptbDraw.TabIndex = 2;
            this.ptbDraw.TabStop = false;
            this.ptbDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbDraw_MouseClick);
            this.ptbDraw.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ptbDraw_MouseDoubleClick);
            // 
            // btnCloseMap
            // 
            this.btnCloseMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseMap.BackgroundImage")));
            this.btnCloseMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseMap.Location = new System.Drawing.Point(1126, 0);
            this.btnCloseMap.Name = "btnCloseMap";
            this.btnCloseMap.Size = new System.Drawing.Size(56, 40);
            this.btnCloseMap.TabIndex = 3;
            this.btnCloseMap.UseVisualStyleBackColor = true;
            this.btnCloseMap.Click += new System.EventHandler(this.btnCloseMap_Click);
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 803);
            this.Controls.Add(this.btnCloseMap);
            this.Controls.Add(this.ptbDraw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMap_FormClosing);
            this.Load += new System.EventHandler(this.frmMap_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptbDraw;
        private System.Windows.Forms.Button btnCloseMap;
        private System.Windows.Forms.Button btnRelationship;
        private System.Windows.Forms.Button btnSubTopic;
        private System.Windows.Forms.Button btnTopic;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ToolStripMenuItem mindMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outlinerToolStripMenuItem;
    }
}