namespace Feladatok
{
    partial class Visszaszamlalas
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
            numIdo = new NumericUpDown();
            bznIndit = new Button();
            btnStop = new Button();
            progressIdo = new ProgressBar();
            lblIdo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numIdo).BeginInit();
            SuspendLayout();
            // 
            // numIdo
            // 
            numIdo.Location = new Point(20, 31);
            numIdo.Name = "numIdo";
            numIdo.Size = new Size(222, 27);
            numIdo.TabIndex = 0;
            numIdo.ValueChanged += numIdo_ValueChanged;
            // 
            // bznIndit
            // 
            bznIndit.Location = new Point(22, 86);
            bznIndit.Name = "bznIndit";
            bznIndit.Size = new Size(94, 29);
            bznIndit.TabIndex = 1;
            bznIndit.TabStop = false;
            bznIndit.Text = "Indít";
            bznIndit.UseVisualStyleBackColor = true;
            bznIndit.Click += bznIndit_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(148, 84);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 2;
            btnStop.Text = " Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // progressIdo
            // 
            progressIdo.Location = new Point(23, 152);
            progressIdo.Name = "progressIdo";
            progressIdo.Size = new Size(219, 29);
            progressIdo.TabIndex = 3;
            // 
            // lblIdo
            // 
            lblIdo.AutoSize = true;
            lblIdo.Location = new Point(24, 210);
            lblIdo.Name = "lblIdo";
            lblIdo.Size = new Size(172, 20);
            lblIdo.TabIndex = 4;
            lblIdo.Text = "10 másodperc van hátra!";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Visszaszamlalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 309);
            Controls.Add(lblIdo);
            Controls.Add(progressIdo);
            Controls.Add(btnStop);
            Controls.Add(bznIndit);
            Controls.Add(numIdo);
            Name = "Visszaszamlalas";
            Text = "Visszaszamlalas";
            Load += Visszaszamlalas_Load;
            ((System.ComponentModel.ISupportInitialize)numIdo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numIdo;
        private Button bznIndit;
        private Button btnStop;
        private ProgressBar progressIdo;
        private Label lblIdo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}