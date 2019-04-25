namespace HybridizationTool
{
    partial class HybridizationToolWindow
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
            this.lblPathBlast = new System.Windows.Forms.Label();
            this.txtBlastPath = new System.Windows.Forms.TextBox();
            this.lblPathDb = new System.Windows.Forms.Label();
            this.txtDbPath = new System.Windows.Forms.TextBox();
            this.btnBlastPath = new System.Windows.Forms.Button();
            this.btnDbPath = new System.Windows.Forms.Button();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.btnAddFasta = new System.Windows.Forms.Button();
            this.lblViennaPath = new System.Windows.Forms.Label();
            this.btnViennaPath = new System.Windows.Forms.Button();
            this.txtViennaPath = new System.Windows.Forms.TextBox();
            this.btnRemoveFasta = new System.Windows.Forms.Button();
            this.btnTestPart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPathBlast
            // 
            this.lblPathBlast.AutoSize = true;
            this.lblPathBlast.Location = new System.Drawing.Point(14, 16);
            this.lblPathBlast.Name = "lblPathBlast";
            this.lblPathBlast.Size = new System.Drawing.Size(78, 13);
            this.lblPathBlast.TabIndex = 0;
            this.lblPathBlast.Text = "Path to blastn: ";
            // 
            // txtBlastPath
            // 
            this.txtBlastPath.Location = new System.Drawing.Point(154, 12);
            this.txtBlastPath.Name = "txtBlastPath";
            this.txtBlastPath.ReadOnly = true;
            this.txtBlastPath.Size = new System.Drawing.Size(284, 20);
            this.txtBlastPath.TabIndex = 1;
            // 
            // lblPathDb
            // 
            this.lblPathDb.AutoSize = true;
            this.lblPathDb.Location = new System.Drawing.Point(14, 69);
            this.lblPathDb.Name = "lblPathDb";
            this.lblPathDb.Size = new System.Drawing.Size(139, 13);
            this.lblPathDb.TabIndex = 2;
            this.lblPathDb.Text = "Path to organism database: ";
            // 
            // txtDbPath
            // 
            this.txtDbPath.Location = new System.Drawing.Point(154, 66);
            this.txtDbPath.Name = "txtDbPath";
            this.txtDbPath.ReadOnly = true;
            this.txtDbPath.Size = new System.Drawing.Size(284, 20);
            this.txtDbPath.TabIndex = 3;
            // 
            // btnBlastPath
            // 
            this.btnBlastPath.Location = new System.Drawing.Point(444, 11);
            this.btnBlastPath.Name = "btnBlastPath";
            this.btnBlastPath.Size = new System.Drawing.Size(32, 23);
            this.btnBlastPath.TabIndex = 4;
            this.btnBlastPath.Text = "...";
            this.btnBlastPath.UseVisualStyleBackColor = true;
            this.btnBlastPath.Click += new System.EventHandler(this.btnBlastPath_Click);
            // 
            // btnDbPath
            // 
            this.btnDbPath.Location = new System.Drawing.Point(444, 64);
            this.btnDbPath.Name = "btnDbPath";
            this.btnDbPath.Size = new System.Drawing.Size(32, 23);
            this.btnDbPath.TabIndex = 5;
            this.btnDbPath.Text = "...";
            this.btnDbPath.UseVisualStyleBackColor = true;
            this.btnDbPath.Click += new System.EventHandler(this.btnDbPath_Click);
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(17, 134);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(459, 345);
            this.dgvParts.TabIndex = 6;
            // 
            // btnAddFasta
            // 
            this.btnAddFasta.Location = new System.Drawing.Point(17, 105);
            this.btnAddFasta.Name = "btnAddFasta";
            this.btnAddFasta.Size = new System.Drawing.Size(75, 23);
            this.btnAddFasta.TabIndex = 7;
            this.btnAddFasta.Text = "Add FASTA";
            this.btnAddFasta.UseVisualStyleBackColor = true;
            this.btnAddFasta.Click += new System.EventHandler(this.btnAddFasta_Click);
            // 
            // lblViennaPath
            // 
            this.lblViennaPath.AutoSize = true;
            this.lblViennaPath.Location = new System.Drawing.Point(14, 43);
            this.lblViennaPath.Name = "lblViennaPath";
            this.lblViennaPath.Size = new System.Drawing.Size(90, 13);
            this.lblViennaPath.TabIndex = 9;
            this.lblViennaPath.Text = "Path to RNAfold: ";
            // 
            // btnViennaPath
            // 
            this.btnViennaPath.Location = new System.Drawing.Point(444, 39);
            this.btnViennaPath.Name = "btnViennaPath";
            this.btnViennaPath.Size = new System.Drawing.Size(32, 23);
            this.btnViennaPath.TabIndex = 11;
            this.btnViennaPath.Text = "...";
            this.btnViennaPath.UseVisualStyleBackColor = true;
            this.btnViennaPath.Click += new System.EventHandler(this.btnViennaPath_Click);
            // 
            // txtViennaPath
            // 
            this.txtViennaPath.Location = new System.Drawing.Point(154, 40);
            this.txtViennaPath.Name = "txtViennaPath";
            this.txtViennaPath.ReadOnly = true;
            this.txtViennaPath.Size = new System.Drawing.Size(284, 20);
            this.txtViennaPath.TabIndex = 10;
            // 
            // btnRemoveFasta
            // 
            this.btnRemoveFasta.Location = new System.Drawing.Point(98, 105);
            this.btnRemoveFasta.Name = "btnRemoveFasta";
            this.btnRemoveFasta.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFasta.TabIndex = 12;
            this.btnRemoveFasta.Text = "Remove";
            this.btnRemoveFasta.UseVisualStyleBackColor = true;
            // 
            // btnTestPart
            // 
            this.btnTestPart.Location = new System.Drawing.Point(513, 451);
            this.btnTestPart.Name = "btnTestPart";
            this.btnTestPart.Size = new System.Drawing.Size(75, 23);
            this.btnTestPart.TabIndex = 13;
            this.btnTestPart.Text = "Test Part";
            this.btnTestPart.UseVisualStyleBackColor = true;
            this.btnTestPart.Click += new System.EventHandler(this.btnTestPart_Click);
            // 
            // HybridizationToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 490);
            this.Controls.Add(this.btnTestPart);
            this.Controls.Add(this.btnRemoveFasta);
            this.Controls.Add(this.btnViennaPath);
            this.Controls.Add(this.txtViennaPath);
            this.Controls.Add(this.lblViennaPath);
            this.Controls.Add(this.btnAddFasta);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.btnDbPath);
            this.Controls.Add(this.btnBlastPath);
            this.Controls.Add(this.txtDbPath);
            this.Controls.Add(this.lblPathDb);
            this.Controls.Add(this.txtBlastPath);
            this.Controls.Add(this.lblPathBlast);
            this.Name = "HybridizationToolWindow";
            this.Text = "Hybridization Tool";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPathBlast;
        private System.Windows.Forms.TextBox txtBlastPath;
        private System.Windows.Forms.Label lblPathDb;
        private System.Windows.Forms.TextBox txtDbPath;
        private System.Windows.Forms.Button btnBlastPath;
        private System.Windows.Forms.Button btnDbPath;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Button btnAddFasta;
        private System.Windows.Forms.Label lblViennaPath;
        private System.Windows.Forms.Button btnViennaPath;
        private System.Windows.Forms.TextBox txtViennaPath;
        private System.Windows.Forms.Button btnRemoveFasta;
        private System.Windows.Forms.Button btnTestPart;
    }
}

