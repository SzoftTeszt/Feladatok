namespace Feladatok
{
    partial class Regisztracio
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtNev = new TextBox();
            txtEmail = new TextBox();
            lblEredmeny = new Label();
            mtxtTelefon = new MaskedTextBox();
            label3 = new Label();
            dtpSzuletes = new DateTimePicker();
            label4 = new Label();
            btnMentes = new Button();
            errorProvider1 = new ErrorProvider(components);
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Név";
            // 
            // txtNev
            // 
            txtNev.Location = new Point(93, 20);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(125, 27);
            txtNev.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 60);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 1;
            // 
            // lblEredmeny
            // 
            lblEredmeny.AutoSize = true;
            lblEredmeny.Location = new Point(35, 247);
            lblEredmeny.Name = "lblEredmeny";
            lblEredmeny.Size = new Size(50, 20);
            lblEredmeny.TabIndex = 0;
            lblEredmeny.Text = "label1";
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(93, 103);
            mtxtTelefon.Mask = "(36) 00-000-00-00";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(125, 27);
            mtxtTelefon.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 63);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // dtpSzuletes
            // 
            dtpSzuletes.Format = DateTimePickerFormat.Short;
            dtpSzuletes.Location = new Point(93, 152);
            dtpSzuletes.Name = "dtpSzuletes";
            dtpSzuletes.Size = new Size(125, 27);
            dtpSzuletes.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 157);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 0;
            label4.Text = "Szül.Idő";
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(35, 198);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(94, 29);
            btnMentes.TabIndex = 4;
            btnMentes.Text = "Mentés";
            btnMentes.UseVisualStyleBackColor = true;
            btnMentes.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 107);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 0;
            label6.Text = "Telefon";
            // 
            // Regisztracio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 330);
            Controls.Add(btnMentes);
            Controls.Add(dtpSzuletes);
            Controls.Add(mtxtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(lblEredmeny);
            Controls.Add(txtNev);
            Controls.Add(label1);
            Name = "Regisztracio";
            Text = "Regisztracio";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNev;
        private TextBox txtEmail;
        private Label lblEredmeny;
        private MaskedTextBox mtxtTelefon;
        private Label label3;
        private DateTimePicker dtpSzuletes;
        private Label label4;
        private Button btnMentes;
        private ErrorProvider errorProvider1;
        private Label label6;
    }
}