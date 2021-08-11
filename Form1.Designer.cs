
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
            this.reset = new System.Windows.Forms.Button();
            this.txtMichi = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namePlayer = new System.Windows.Forms.TextBox();
            this.IA = new System.Windows.Forms.Timer(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Foto_gato = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto_gato)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(76, 100);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(50, 50);
            this.a1.TabIndex = 0;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.playerClick);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(132, 100);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(50, 50);
            this.a2.TabIndex = 1;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.playerClick);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(188, 100);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(50, 50);
            this.a3.TabIndex = 2;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.playerClick);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(188, 156);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(50, 50);
            this.b3.TabIndex = 5;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.playerClick);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(132, 156);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(50, 50);
            this.b2.TabIndex = 4;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.playerClick);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(76, 156);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(50, 50);
            this.b1.TabIndex = 3;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.playerClick);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(188, 212);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(50, 50);
            this.c3.TabIndex = 8;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.playerClick);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(132, 212);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(50, 50);
            this.c2.TabIndex = 7;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.playerClick);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(76, 212);
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
            this.playGame.Location = new System.Drawing.Point(65, 243);
            this.playGame.Name = "playGame";
            this.playGame.Size = new System.Drawing.Size(106, 32);
            this.playGame.TabIndex = 9;
            this.playGame.Text = "Juguemos";
            this.playGame.UseVisualStyleBackColor = false;
            this.playGame.Click += new System.EventHandler(this.iniciarJuego);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Transparent;
            this.reset.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(76, 286);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(104, 32);
            this.reset.TabIndex = 10;
            this.reset.Text = "¡Otra vez!";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reiniciarJuego);
            // 
            // txtMichi
            // 
            this.txtMichi.BackColor = System.Drawing.Color.Transparent;
            this.txtMichi.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMichi.Location = new System.Drawing.Point(175, 23);
            this.txtMichi.Name = "txtMichi";
            this.txtMichi.Size = new System.Drawing.Size(127, 20);
            this.txtMichi.TabIndex = 11;
            this.txtMichi.Text = "Michi Puntos: 0";
            // 
            // txtPlayer
            // 
            this.txtPlayer.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayer.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer.Location = new System.Drawing.Point(13, 23);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(156, 20);
            this.txtPlayer.TabIndex = 12;
            this.txtPlayer.Text = "Jugador Puntos: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Juguemos Gato";
            // 
            // namePlayer
            // 
            this.namePlayer.Location = new System.Drawing.Point(96, 122);
            this.namePlayer.Name = "namePlayer";
            this.namePlayer.Size = new System.Drawing.Size(100, 20);
            this.namePlayer.TabIndex = 14;
            this.namePlayer.TextChanged += new System.EventHandler(this.namePlayer_TextChanged);
            // 
            // IA
            // 
            this.IA.Interval = 1000;
            this.IA.Tick += new System.EventHandler(this.IAmoves);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Red;
            this.radioButton1.Location = new System.Drawing.Point(43, 179);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 24);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "X";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton2.Location = new System.Drawing.Point(149, 179);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(40, 24);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "O";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Foto_gato);
            this.panel1.Controls.Add(this.txtPlayer);
            this.panel1.Controls.Add(this.txtMichi);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.c3);
            this.panel1.Controls.Add(this.c2);
            this.panel1.Controls.Add(this.c1);
            this.panel1.Controls.Add(this.b3);
            this.panel1.Controls.Add(this.b2);
            this.panel1.Controls.Add(this.b1);
            this.panel1.Controls.Add(this.a3);
            this.panel1.Controls.Add(this.a2);
            this.panel1.Controls.Add(this.a1);
            this.panel1.Location = new System.Drawing.Point(262, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 344);
            this.panel1.TabIndex = 19;
            // 
            // Foto_gato
            // 
            this.Foto_gato.Image = global::JuguemosGato.Properties.Resources.restart;
            this.Foto_gato.Location = new System.Drawing.Point(199, 283);
            this.Foto_gato.Name = "Foto_gato";
            this.Foto_gato.Size = new System.Drawing.Size(39, 35);
            this.Foto_gato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto_gato.TabIndex = 18;
            this.Foto_gato.TabStop = false;
            this.Foto_gato.Click += new System.EventHandler(this.Foto_gato_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.namePlayer);
            this.panel2.Controls.Add(this.playGame);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 301);
            this.panel2.TabIndex = 20;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jueguemos Gato con Michi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Foto_gato)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label txtMichi;
        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namePlayer;
        private System.Windows.Forms.Timer IA;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Foto_gato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

