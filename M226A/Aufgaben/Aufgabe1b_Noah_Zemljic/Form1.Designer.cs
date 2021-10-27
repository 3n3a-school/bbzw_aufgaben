
namespace Block_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSeiteA = new System.Windows.Forms.TextBox();
            this.tbxSeiteB = new System.Windows.Forms.TextBox();
            this.btnBerechneDynamisch = new System.Windows.Forms.Button();
            this.btnBerechneStatisch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxFlaeche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "b:";
            // 
            // tbxSeiteA
            // 
            this.tbxSeiteA.Location = new System.Drawing.Point(55, 34);
            this.tbxSeiteA.Name = "tbxSeiteA";
            this.tbxSeiteA.Size = new System.Drawing.Size(67, 23);
            this.tbxSeiteA.TabIndex = 2;
            // 
            // tbxSeiteB
            // 
            this.tbxSeiteB.Location = new System.Drawing.Point(56, 66);
            this.tbxSeiteB.Name = "tbxSeiteB";
            this.tbxSeiteB.Size = new System.Drawing.Size(65, 23);
            this.tbxSeiteB.TabIndex = 3;
            // 
            // btnBerechneDynamisch
            // 
            this.btnBerechneDynamisch.Location = new System.Drawing.Point(211, 26);
            this.btnBerechneDynamisch.Name = "btnBerechneDynamisch";
            this.btnBerechneDynamisch.Size = new System.Drawing.Size(140, 30);
            this.btnBerechneDynamisch.TabIndex = 4;
            this.btnBerechneDynamisch.Text = "berechne m.Objekt";
            this.btnBerechneDynamisch.UseVisualStyleBackColor = true;
            this.btnBerechneDynamisch.Click += new System.EventHandler(this.btnBerechneDynamisch_Click);
            // 
            // btnBerechneStatisch
            // 
            this.btnBerechneStatisch.Location = new System.Drawing.Point(211, 62);
            this.btnBerechneStatisch.Name = "btnBerechneStatisch";
            this.btnBerechneStatisch.Size = new System.Drawing.Size(139, 26);
            this.btnBerechneStatisch.TabIndex = 5;
            this.btnBerechneStatisch.Text = "berechne statisch";
            this.btnBerechneStatisch.UseVisualStyleBackColor = true;
            this.btnBerechneStatisch.Click += new System.EventHandler(this.btnBerechneStatisch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fläche:";
            // 
            // tbxFlaeche
            // 
            this.tbxFlaeche.Location = new System.Drawing.Point(470, 16);
            this.tbxFlaeche.Name = "tbxFlaeche";
            this.tbxFlaeche.Size = new System.Drawing.Size(52, 23);
            this.tbxFlaeche.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxFlaeche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBerechneStatisch);
            this.Controls.Add(this.btnBerechneDynamisch);
            this.Controls.Add(this.tbxSeiteB);
            this.Controls.Add(this.tbxSeiteA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSeiteA;
        private System.Windows.Forms.TextBox tbxSeiteB;
        private System.Windows.Forms.Button btnBerechneDynamisch;
        private System.Windows.Forms.Button btnBerechneStatisch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxFlaeche;
    }
}

