namespace TAX_Calculator1
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
            groupBox1 = new GroupBox();
            radioButtonOui = new RadioButton();
            radioButtonNon = new RadioButton();
            numericUpDownEnfants = new NumericUpDown();
            textSalaire = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelImpot = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonCalculer = new Button();
            buttonEffacer = new Button();
            buttonQuitter = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnfants).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonOui);
            groupBox1.Controls.Add(radioButtonNon);
            groupBox1.Location = new Point(52, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 62);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Etes-vous marie(e)";
            // 
            // radioButtonOui
            // 
            radioButtonOui.AutoSize = true;
            radioButtonOui.Checked = true;
            radioButtonOui.Location = new Point(6, 22);
            radioButtonOui.Name = "radioButtonOui";
            radioButtonOui.Size = new Size(44, 19);
            radioButtonOui.TabIndex = 1;
            radioButtonOui.TabStop = true;
            radioButtonOui.Text = "Oui";
            radioButtonOui.UseVisualStyleBackColor = true;
            // 
            // radioButtonNon
            // 
            radioButtonNon.AutoSize = true;
            radioButtonNon.Location = new Point(106, 22);
            radioButtonNon.Name = "radioButtonNon";
            radioButtonNon.Size = new Size(48, 19);
            radioButtonNon.TabIndex = 2;
            radioButtonNon.Text = "Non";
            radioButtonNon.UseVisualStyleBackColor = true;
            // 
            // numericUpDownEnfants
            // 
            numericUpDownEnfants.Location = new Point(186, 107);
            numericUpDownEnfants.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownEnfants.Name = "numericUpDownEnfants";
            numericUpDownEnfants.Size = new Size(120, 23);
            numericUpDownEnfants.TabIndex = 3;
            // 
            // textSalaire
            // 
            textSalaire.Location = new Point(186, 138);
            textSalaire.Name = "textSalaire";
            textSalaire.Size = new Size(100, 23);
            textSalaire.TabIndex = 4;
            textSalaire.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 115);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre d'enfants";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 146);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 6;
            label2.Text = "Salaire annuel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 183);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 7;
            label3.Text = "Impot a payer";
            // 
            // labelImpot
            // 
            labelImpot.AutoSize = true;
            labelImpot.BorderStyle = BorderStyle.Fixed3D;
            labelImpot.Location = new Point(186, 183);
            labelImpot.Name = "labelImpot";
            labelImpot.Size = new Size(40, 17);
            labelImpot.TabIndex = 8;
            labelImpot.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 146);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "euros";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 183);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 10;
            label6.Text = "euros";
            // 
            // buttonCalculer
            // 
            buttonCalculer.Location = new Point(52, 230);
            buttonCalculer.Name = "buttonCalculer";
            buttonCalculer.Size = new Size(75, 23);
            buttonCalculer.TabIndex = 11;
            buttonCalculer.Text = "Calculer";
            buttonCalculer.UseVisualStyleBackColor = true;
            buttonCalculer.Click += buttonCalculer_Click;
            // 
            // buttonEffacer
            // 
            buttonEffacer.Location = new Point(158, 230);
            buttonEffacer.Name = "buttonEffacer";
            buttonEffacer.Size = new Size(75, 23);
            buttonEffacer.TabIndex = 12;
            buttonEffacer.Text = "Effacer";
            buttonEffacer.UseVisualStyleBackColor = true;
            buttonEffacer.Click += buttonEffacer_Click;
            // 
            // buttonQuitter
            // 
            buttonQuitter.Location = new Point(268, 230);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(75, 23);
            buttonQuitter.TabIndex = 13;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 283);
            Controls.Add(buttonQuitter);
            Controls.Add(buttonEffacer);
            Controls.Add(buttonCalculer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(labelImpot);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSalaire);
            Controls.Add(numericUpDownEnfants);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnfants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButtonOui;
        private RadioButton radioButtonNon;
        private NumericUpDown numericUpDownEnfants;
        private TextBox textSalaire;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelImpot;
        private Label label5;
        private Label label6;
        private Button buttonCalculer;
        private Button buttonEffacer;
        private Button buttonQuitter;
    }
}