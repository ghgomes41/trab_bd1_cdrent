namespace trabBD1cdloc
{
    partial class AlugaCD
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
            this.dgvCDs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCDs
            // 
            this.dgvCDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCDs.Location = new System.Drawing.Point(12, 12);
            this.dgvCDs.Name = "dgvCDs";
            this.dgvCDs.Size = new System.Drawing.Size(474, 300);
            this.dgvCDs.TabIndex = 0;
            // 
            // AlugaCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 330);
            this.Controls.Add(this.dgvCDs);
            this.Name = "AlugaCD";
            this.Text = "AlugaCD";
            this.Load += new System.EventHandler(this.AlugaCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCDs;
    }
}