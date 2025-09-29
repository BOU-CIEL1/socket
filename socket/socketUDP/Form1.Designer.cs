namespace socketUDP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxRecp = new System.Windows.Forms.TextBox();
            this.textBoxIPeR = new System.Windows.Forms.TextBox();
            this.textBoxDest = new System.Windows.Forms.TextBox();
            this.textBoxIPeD = new System.Windows.Forms.TextBox();
            this.textBoxEnvoi = new System.Windows.Forms.TextBox();
            this.textBoxRecpBig = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.Location = new System.Drawing.Point(325, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Créer Socket et Bind(IPeR)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fermer Close()";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Envoyer SendTo(IPeD)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Recevoir ReceiveFrom()\r\nBloquant Timeout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recp.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dest.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "IPeR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "IPeD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Envoi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Recp.";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(325, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "CLS";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBoxRecp
            // 
            this.textBoxRecp.Location = new System.Drawing.Point(45, 34);
            this.textBoxRecp.Name = "textBoxRecp";
            this.textBoxRecp.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecp.TabIndex = 11;
            this.textBoxRecp.Text = "127.0.0.1";
            // 
            // textBoxIPeR
            // 
            this.textBoxIPeR.Location = new System.Drawing.Point(164, 34);
            this.textBoxIPeR.Name = "textBoxIPeR";
            this.textBoxIPeR.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPeR.TabIndex = 12;
            this.textBoxIPeR.Text = "3031";
            // 
            // textBoxDest
            // 
            this.textBoxDest.Location = new System.Drawing.Point(45, 69);
            this.textBoxDest.Name = "textBoxDest";
            this.textBoxDest.Size = new System.Drawing.Size(100, 20);
            this.textBoxDest.TabIndex = 13;
            this.textBoxDest.Text = "127.0.0.1";
            // 
            // textBoxIPeD
            // 
            this.textBoxIPeD.Location = new System.Drawing.Point(164, 69);
            this.textBoxIPeD.Name = "textBoxIPeD";
            this.textBoxIPeD.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPeD.TabIndex = 14;
            this.textBoxIPeD.Text = "3032";
            // 
            // textBoxEnvoi
            // 
            this.textBoxEnvoi.Location = new System.Drawing.Point(45, 104);
            this.textBoxEnvoi.Multiline = true;
            this.textBoxEnvoi.Name = "textBoxEnvoi";
            this.textBoxEnvoi.Size = new System.Drawing.Size(264, 68);
            this.textBoxEnvoi.TabIndex = 15;
            // 
            // textBoxRecpBig
            // 
            this.textBoxRecpBig.Location = new System.Drawing.Point(45, 190);
            this.textBoxRecpBig.Multiline = true;
            this.textBoxRecpBig.Name = "textBoxRecpBig";
            this.textBoxRecpBig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecpBig.Size = new System.Drawing.Size(264, 188);
            this.textBoxRecpBig.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 387);
            this.Controls.Add(this.textBoxRecpBig);
            this.Controls.Add(this.textBoxEnvoi);
            this.Controls.Add(this.textBoxIPeD);
            this.Controls.Add(this.textBoxDest);
            this.Controls.Add(this.textBoxIPeR);
            this.Controls.Add(this.textBoxRecp);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Communication par socket UDP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxRecp;
        private System.Windows.Forms.TextBox textBoxIPeR;
        private System.Windows.Forms.TextBox textBoxDest;
        private System.Windows.Forms.TextBox textBoxIPeD;
        private System.Windows.Forms.TextBox textBoxEnvoi;
        private System.Windows.Forms.TextBox textBoxRecpBig;
    }
}

