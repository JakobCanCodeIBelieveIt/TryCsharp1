namespace TryCsharp1
{
    partial class MainForm
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
            this.btnCheckGenome = new System.Windows.Forms.Button();
            this.btnSimulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckGenome
            // 
            this.btnCheckGenome.Location = new System.Drawing.Point(25, 12);
            this.btnCheckGenome.Name = "btnCheckGenome";
            this.btnCheckGenome.Size = new System.Drawing.Size(200, 100);
            this.btnCheckGenome.TabIndex = 0;
            this.btnCheckGenome.Text = "Проверка генома";
            this.btnCheckGenome.UseVisualStyleBackColor = true;
            this.btnCheckGenome.Click += new System.EventHandler(this.btnCheckGenome_Click);
            // 
            // btnSimulation
            // 
            this.btnSimulation.Location = new System.Drawing.Point(25, 130);
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.Size = new System.Drawing.Size(200, 100);
            this.btnSimulation.TabIndex = 1;
            this.btnSimulation.Text = "Симуляция";
            this.btnSimulation.UseVisualStyleBackColor = true;
            this.btnSimulation.Click += new System.EventHandler(this.btnSimulation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.btnSimulation);
            this.Controls.Add(this.btnCheckGenome);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckGenome;
        private System.Windows.Forms.Button btnSimulation;
    }
}