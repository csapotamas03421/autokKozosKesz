namespace autokKözös
{
    partial class Form1
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
            this.dGAutok = new System.Windows.Forms.DataGridView();
            this.dGWkoltsegek = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGAutok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWkoltsegek)).BeginInit();
            this.SuspendLayout();
            // 
            // dGAutok
            // 
            this.dGAutok.AllowUserToAddRows = false;
            this.dGAutok.AllowUserToDeleteRows = false;
            this.dGAutok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGAutok.Location = new System.Drawing.Point(12, 12);
            this.dGAutok.Name = "dGAutok";
            this.dGAutok.ReadOnly = true;
            this.dGAutok.RowHeadersVisible = false;
            this.dGAutok.Size = new System.Drawing.Size(703, 265);
            this.dGAutok.TabIndex = 0;
            this.dGAutok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGAutok_CellClick);
            // 
            // dGWkoltsegek
            // 
            this.dGWkoltsegek.AllowUserToAddRows = false;
            this.dGWkoltsegek.AllowUserToDeleteRows = false;
            this.dGWkoltsegek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWkoltsegek.Location = new System.Drawing.Point(12, 336);
            this.dGWkoltsegek.Name = "dGWkoltsegek";
            this.dGWkoltsegek.ReadOnly = true;
            this.dGWkoltsegek.Size = new System.Drawing.Size(617, 165);
            this.dGWkoltsegek.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 558);
            this.Controls.Add(this.dGWkoltsegek);
            this.Controls.Add(this.dGAutok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGAutok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWkoltsegek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGAutok;
        private System.Windows.Forms.DataGridView dGWkoltsegek;
    }
}

