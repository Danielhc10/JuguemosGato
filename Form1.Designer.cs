
namespace JuguemosGato
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.playGame = new System.Windows.Forms.Button();
            this.reinicio = new System.Windows.Forms.Button();
            this.txtMichi = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namePlayer = new System.Windows.Forms.TextBox();
            this.IA = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(77, 127);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(50, 50);
            this.a1.TabIndex = 0;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.playerClick);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(133, 127);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(50, 50);
            this.a2.TabIndex = 1;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.playerClick);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(189, 127);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(50, 50);
            this.a3.TabIndex = 2;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.playerClick);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(189, 183);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(50, 50);
            this.b3.TabIndex = 5;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.playerClick);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(133, 183);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(50, 50);
            this.b2.TabIndex = 4;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.playerClick);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(77, 183);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(50, 50);
            this.b1.TabIndex = 3;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.playerClick);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(189, 239);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(50, 50);
            this.c3.TabIndex = 8;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.playerClick);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(133, 239);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(50, 50);
            this.c2.TabIndex = 7;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.playerClick);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(77, 239);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(50, 50);
            this.c1.TabIndex = 6;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.playerClick);
            // 
            // playGame
            // 
            this.playGame.BackColor = System.Drawing.Color.Transparent;
            this.playGame.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGame.Location = new System.Drawing.Point(47, 371);
            this.playGame.Name = "playGame";
            this.playGame.Size = new System.Drawing.Size(106, 32);
            this.playGame.TabIndex = 9;
            this.playGame.Text = "Juguemos";
            this.playGame.UseVisualStyleBackColor = false;
            this.playGame.Click += new System.EventHandler(this.iniciarJuego);
            // 
            // reinicio
            // 
            this.reinicio.BackColor = System.Drawing.Color.Transparent;
            this.reinicio.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reinicio.Location = new System.Drawing.Point(175, 371);
            this.reinicio.Name = "reinicio";
            this.reinicio.Size = new System.Drawing.Size(104, 32);
            this.reinicio.TabIndex = 10;
            this.reinicio.Text = "¡Otra vez!";
            this.reinicio.UseVisualStyleBackColor = false;
            this.reinicio.Click += new System.EventHandler(this.reiniciarJuego);
            // 
            // txtMichi
            // 
            this.txtMichi.AutoSize = true;
            this.txtMichi.BackColor = System.Drawing.Color.Transparent;
            this.txtMichi.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMichi.Location = new System.Drawing.Point(171, 9);
            this.txtMichi.Name = "txtMichi";
            this.txtMichi.Size = new System.Drawing.Size(127, 20);
            this.txtMichi.TabIndex = 11;
            this.txtMichi.Text = "Michi wins - 0";
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayer.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer.Location = new System.Drawing.Point(12, 9);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(134, 20);
            this.txtPlayer.TabIndex = 12;
            this.txtPlayer.Text = "Player wins - 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Juguemos Gato";
            // 
            // namePlayer
            // 
            this.namePlayer.Location = new System.Drawing.Point(110, 323);
            this.namePlayer.Name = "namePlayer";
            this.namePlayer.Size = new System.Drawing.Size(100, 20);
            this.namePlayer.TabIndex = 14;
            // 
            // IA
            // 
            this.IA.Interval = 1000;
            this.IA.Tick += new System.EventHandler(this.IAmoves);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuguemosGato.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.namePlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.txtMichi);
            this.Controls.Add(this.reinicio);
            this.Controls.Add(this.playGame);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jueguemos Gato con Michi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button playGame;
        private System.Windows.Forms.Button reinicio;
        private System.Windows.Forms.Label txtMichi;
        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namePlayer;
        private System.Windows.Forms.Timer IA;
    }
}

