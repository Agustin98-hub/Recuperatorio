namespace ApellidoNombre
{
    partial class Actividades
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
            this.txtFechaActi = new System.Windows.Forms.TextBox();
            this.txtFechaActi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txtFechaActi
            // 
            this.txtFechaActi.Location = new System.Drawing.Point(39, 67);
            this.txtFechaActi.Name = "txtFechaActi";
            this.txtFechaActi.Size = new System.Drawing.Size(118, 20);
            this.txtFechaActi.TabIndex = 0;
            // 
            // txtFechaActi2
            // 
            this.txtFechaActi2.Location = new System.Drawing.Point(280, 67);
            this.txtFechaActi2.Name = "txtFechaActi2";
            this.txtFechaActi2.Size = new System.Drawing.Size(118, 20);
            this.txtFechaActi2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(39, 149);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(386, 256);
            this.treeView1.TabIndex = 4;
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaActi2);
            this.Controls.Add(this.txtFechaActi);
            this.Name = "Actividades";
            this.Text = "Actividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFechaActi;
        private System.Windows.Forms.TextBox txtFechaActi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
    }
}