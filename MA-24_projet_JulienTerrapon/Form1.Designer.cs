namespace MA_24_projet_JulienTerrapon
{
    partial class form
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
            this.components = new System.ComponentModel.Container();
<<<<<<< HEAD
            this.cmdStart = new System.Windows.Forms.Button();
            this.timerChrono = new System.Windows.Forms.Timer(this.components);
            this.lblChrono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTemps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(24, 61);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
=======
            this.timerChrono = new System.Windows.Forms.Timer(this.components);
            this.lblChrono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTemps = new System.Windows.Forms.Label();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
>>>>>>> Messages toutes les 5 secondes CORRIGE + RESTART RESET
            // timerChrono
            // 
            this.timerChrono.Interval = 1;
            this.timerChrono.Tick += new System.EventHandler(this.timerChrono_Tick);
            // 
            // lblChrono
            // 
            this.lblChrono.AutoSize = true;
            this.lblChrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblChrono.Location = new System.Drawing.Point(216, 61);
            this.lblChrono.Name = "lblChrono";
            this.lblChrono.Size = new System.Drawing.Size(0, 25);
=======
            this.lblChrono.Location = new System.Drawing.Point(141, 11);
            this.lblChrono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChrono.Name = "lblChrono";
            this.lblChrono.Size = new System.Drawing.Size(0, 31);
>>>>>>> Messages toutes les 5 secondes CORRIGE + RESTART RESET
            this.lblChrono.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(122, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chrono:";
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(24, 90);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStop.TabIndex = 3;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(24, 119);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(75, 23);
            this.cmdReset.TabIndex = 4;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            // 
=======
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chrono:";
            // 
>>>>>>> Messages toutes les 5 secondes CORRIGE + RESTART RESET
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTemps
            // 
            this.lblTemps.AutoSize = true;
            this.lblTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblTemps.Location = new System.Drawing.Point(124, 100);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(0, 25);
            this.lblTemps.TabIndex = 5;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTemps);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChrono);
            this.Controls.Add(this.cmdStart);
=======
            this.lblTemps.Location = new System.Drawing.Point(19, 59);
            this.lblTemps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(0, 31);
            this.lblTemps.TabIndex = 5;
            // 
            // cmdReset
            // 
            this.cmdReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReset.Location = new System.Drawing.Point(25, 108);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(108, 50);
            this.cmdReset.TabIndex = 6;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdRestart
            // 
            this.cmdRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRestart.Location = new System.Drawing.Point(147, 108);
            this.cmdRestart.Name = "cmdRestart";
            this.cmdRestart.Size = new System.Drawing.Size(107, 50);
            this.cmdRestart.TabIndex = 7;
            this.cmdRestart.Text = "Restart";
            this.cmdRestart.UseVisualStyleBackColor = true;
            this.cmdRestart.Click += new System.EventHandler(this.cmdRestart_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 170);
            this.Controls.Add(this.cmdRestart);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.lblTemps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChrono);
            this.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> Messages toutes les 5 secondes CORRIGE + RESTART RESET
            this.Name = "form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
<<<<<<< HEAD

        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Timer timerChrono;
        private System.Windows.Forms.Label lblChrono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTemps;
=======
        private System.Windows.Forms.Timer timerChrono;
        private System.Windows.Forms.Label lblChrono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdRestart;
>>>>>>> Messages toutes les 5 secondes CORRIGE + RESTART RESET
    }
}

