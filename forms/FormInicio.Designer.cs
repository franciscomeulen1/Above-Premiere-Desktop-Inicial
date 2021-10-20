
namespace AbovePremiere.forms
{
    partial class FormInicio
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
            this.textArchivo = new System.Windows.Forms.TextBox();
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.labelNuevoNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelCambiarFormato = new System.Windows.Forms.Label();
            this.radioButtonMp4 = new System.Windows.Forms.RadioButton();
            this.radioButtonAvi = new System.Windows.Forms.RadioButton();
            this.radioButtonMpeg = new System.Windows.Forms.RadioButton();
            this.radioButtonFlv = new System.Windows.Forms.RadioButton();
            this.buttonConvertir = new System.Windows.Forms.Button();
            this.buttonExtraerAudio = new System.Windows.Forms.Button();
            this.buttonRemoverAudio = new System.Windows.Forms.Button();
            this.labelCambiarResolucion = new System.Windows.Forms.Label();
            this.radioButton1080 = new System.Windows.Forms.RadioButton();
            this.radioButton720 = new System.Windows.Forms.RadioButton();
            this.radioButton480 = new System.Windows.Forms.RadioButton();
            this.radioButton360 = new System.Windows.Forms.RadioButton();
            this.radioButton240 = new System.Windows.Forms.RadioButton();
            this.radioButton144 = new System.Windows.Forms.RadioButton();
            this.buttonCambiarResol = new System.Windows.Forms.Button();
            this.labelExtraerImagenes = new System.Windows.Forms.Label();
            this.labelElijaSegundos = new System.Windows.Forms.Label();
            this.textSegundos = new System.Windows.Forms.TextBox();
            this.buttonExtraerImagenes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textArchivo
            // 
            this.textArchivo.Enabled = false;
            this.textArchivo.Location = new System.Drawing.Point(57, 28);
            this.textArchivo.Name = "textArchivo";
            this.textArchivo.Size = new System.Drawing.Size(189, 20);
            this.textArchivo.TabIndex = 0;
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExaminar.Location = new System.Drawing.Point(270, 20);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(90, 32);
            this.buttonExaminar.TabIndex = 1;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = true;
            this.buttonExaminar.Click += new System.EventHandler(this.buttonExaminar_Click);
            // 
            // labelNuevoNombre
            // 
            this.labelNuevoNombre.AutoSize = true;
            this.labelNuevoNombre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoNombre.Location = new System.Drawing.Point(54, 83);
            this.labelNuevoNombre.Name = "labelNuevoNombre";
            this.labelNuevoNombre.Size = new System.Drawing.Size(121, 18);
            this.labelNuevoNombre.TabIndex = 2;
            this.labelNuevoNombre.Text = "Nuevo nombre:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(181, 84);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(114, 20);
            this.textNombre.TabIndex = 3;
            // 
            // labelCambiarFormato
            // 
            this.labelCambiarFormato.AutoSize = true;
            this.labelCambiarFormato.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambiarFormato.Location = new System.Drawing.Point(54, 132);
            this.labelCambiarFormato.Name = "labelCambiarFormato";
            this.labelCambiarFormato.Size = new System.Drawing.Size(125, 14);
            this.labelCambiarFormato.TabIndex = 4;
            this.labelCambiarFormato.Text = "Cambiar formato a:";
            // 
            // radioButtonMp4
            // 
            this.radioButtonMp4.AutoSize = true;
            this.radioButtonMp4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMp4.Location = new System.Drawing.Point(193, 132);
            this.radioButtonMp4.Name = "radioButtonMp4";
            this.radioButtonMp4.Size = new System.Drawing.Size(50, 17);
            this.radioButtonMp4.TabIndex = 5;
            this.radioButtonMp4.TabStop = true;
            this.radioButtonMp4.Text = "mp4";
            this.radioButtonMp4.UseVisualStyleBackColor = true;
            // 
            // radioButtonAvi
            // 
            this.radioButtonAvi.AutoSize = true;
            this.radioButtonAvi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAvi.Location = new System.Drawing.Point(252, 132);
            this.radioButtonAvi.Name = "radioButtonAvi";
            this.radioButtonAvi.Size = new System.Drawing.Size(42, 17);
            this.radioButtonAvi.TabIndex = 6;
            this.radioButtonAvi.TabStop = true;
            this.radioButtonAvi.Text = "avi";
            this.radioButtonAvi.UseVisualStyleBackColor = true;
            // 
            // radioButtonMpeg
            // 
            this.radioButtonMpeg.AutoSize = true;
            this.radioButtonMpeg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMpeg.Location = new System.Drawing.Point(304, 132);
            this.radioButtonMpeg.Name = "radioButtonMpeg";
            this.radioButtonMpeg.Size = new System.Drawing.Size(57, 17);
            this.radioButtonMpeg.TabIndex = 7;
            this.radioButtonMpeg.TabStop = true;
            this.radioButtonMpeg.Text = "mpeg";
            this.radioButtonMpeg.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlv
            // 
            this.radioButtonFlv.AutoSize = true;
            this.radioButtonFlv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFlv.Location = new System.Drawing.Point(371, 132);
            this.radioButtonFlv.Name = "radioButtonFlv";
            this.radioButtonFlv.Size = new System.Drawing.Size(39, 17);
            this.radioButtonFlv.TabIndex = 8;
            this.radioButtonFlv.TabStop = true;
            this.radioButtonFlv.Text = "flv";
            this.radioButtonFlv.UseVisualStyleBackColor = true;
            // 
            // buttonConvertir
            // 
            this.buttonConvertir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvertir.Location = new System.Drawing.Point(416, 126);
            this.buttonConvertir.Name = "buttonConvertir";
            this.buttonConvertir.Size = new System.Drawing.Size(93, 26);
            this.buttonConvertir.TabIndex = 9;
            this.buttonConvertir.Text = "Convertir";
            this.buttonConvertir.UseVisualStyleBackColor = true;
            this.buttonConvertir.Click += new System.EventHandler(this.buttonConvertir_Click);
            // 
            // buttonExtraerAudio
            // 
            this.buttonExtraerAudio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtraerAudio.Location = new System.Drawing.Point(57, 176);
            this.buttonExtraerAudio.Name = "buttonExtraerAudio";
            this.buttonExtraerAudio.Size = new System.Drawing.Size(226, 30);
            this.buttonExtraerAudio.TabIndex = 10;
            this.buttonExtraerAudio.Text = "Extraer audio en formato .mp3";
            this.buttonExtraerAudio.UseVisualStyleBackColor = true;
            this.buttonExtraerAudio.Click += new System.EventHandler(this.buttonExtraerAudio_Click);
            // 
            // buttonRemoverAudio
            // 
            this.buttonRemoverAudio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoverAudio.Location = new System.Drawing.Point(57, 224);
            this.buttonRemoverAudio.Name = "buttonRemoverAudio";
            this.buttonRemoverAudio.Size = new System.Drawing.Size(122, 27);
            this.buttonRemoverAudio.TabIndex = 11;
            this.buttonRemoverAudio.Text = "Remover audio";
            this.buttonRemoverAudio.UseVisualStyleBackColor = true;
            this.buttonRemoverAudio.Click += new System.EventHandler(this.buttonRemoverAudio_Click);
            // 
            // labelCambiarResolucion
            // 
            this.labelCambiarResolucion.AutoSize = true;
            this.labelCambiarResolucion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambiarResolucion.Location = new System.Drawing.Point(57, 273);
            this.labelCambiarResolucion.Name = "labelCambiarResolucion";
            this.labelCambiarResolucion.Size = new System.Drawing.Size(137, 14);
            this.labelCambiarResolucion.TabIndex = 12;
            this.labelCambiarResolucion.Text = "Cambiar resolución a:";
            // 
            // radioButton1080
            // 
            this.radioButton1080.AutoSize = true;
            this.radioButton1080.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1080.Location = new System.Drawing.Point(209, 273);
            this.radioButton1080.Name = "radioButton1080";
            this.radioButton1080.Size = new System.Drawing.Size(53, 17);
            this.radioButton1080.TabIndex = 13;
            this.radioButton1080.TabStop = true;
            this.radioButton1080.Text = "1080";
            this.radioButton1080.UseVisualStyleBackColor = true;
            // 
            // radioButton720
            // 
            this.radioButton720.AutoSize = true;
            this.radioButton720.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton720.Location = new System.Drawing.Point(270, 273);
            this.radioButton720.Name = "radioButton720";
            this.radioButton720.Size = new System.Drawing.Size(46, 17);
            this.radioButton720.TabIndex = 14;
            this.radioButton720.TabStop = true;
            this.radioButton720.Text = "720";
            this.radioButton720.UseVisualStyleBackColor = true;
            // 
            // radioButton480
            // 
            this.radioButton480.AutoSize = true;
            this.radioButton480.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton480.Location = new System.Drawing.Point(325, 273);
            this.radioButton480.Name = "radioButton480";
            this.radioButton480.Size = new System.Drawing.Size(46, 17);
            this.radioButton480.TabIndex = 15;
            this.radioButton480.TabStop = true;
            this.radioButton480.Text = "480";
            this.radioButton480.UseVisualStyleBackColor = true;
            // 
            // radioButton360
            // 
            this.radioButton360.AutoSize = true;
            this.radioButton360.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton360.Location = new System.Drawing.Point(378, 273);
            this.radioButton360.Name = "radioButton360";
            this.radioButton360.Size = new System.Drawing.Size(46, 17);
            this.radioButton360.TabIndex = 16;
            this.radioButton360.TabStop = true;
            this.radioButton360.Text = "360";
            this.radioButton360.UseVisualStyleBackColor = true;
            // 
            // radioButton240
            // 
            this.radioButton240.AutoSize = true;
            this.radioButton240.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton240.Location = new System.Drawing.Point(431, 273);
            this.radioButton240.Name = "radioButton240";
            this.radioButton240.Size = new System.Drawing.Size(46, 17);
            this.radioButton240.TabIndex = 17;
            this.radioButton240.TabStop = true;
            this.radioButton240.Text = "240";
            this.radioButton240.UseVisualStyleBackColor = true;
            // 
            // radioButton144
            // 
            this.radioButton144.AutoSize = true;
            this.radioButton144.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton144.Location = new System.Drawing.Point(484, 273);
            this.radioButton144.Name = "radioButton144";
            this.radioButton144.Size = new System.Drawing.Size(46, 17);
            this.radioButton144.TabIndex = 18;
            this.radioButton144.TabStop = true;
            this.radioButton144.Text = "144";
            this.radioButton144.UseVisualStyleBackColor = true;
            // 
            // buttonCambiarResol
            // 
            this.buttonCambiarResol.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarResol.Location = new System.Drawing.Point(536, 267);
            this.buttonCambiarResol.Name = "buttonCambiarResol";
            this.buttonCambiarResol.Size = new System.Drawing.Size(75, 28);
            this.buttonCambiarResol.TabIndex = 19;
            this.buttonCambiarResol.Text = "Cambiar";
            this.buttonCambiarResol.UseVisualStyleBackColor = true;
            this.buttonCambiarResol.Click += new System.EventHandler(this.buttonCambiarResol_Click);
            // 
            // labelExtraerImagenes
            // 
            this.labelExtraerImagenes.AutoSize = true;
            this.labelExtraerImagenes.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtraerImagenes.Location = new System.Drawing.Point(57, 314);
            this.labelExtraerImagenes.Name = "labelExtraerImagenes";
            this.labelExtraerImagenes.Size = new System.Drawing.Size(171, 14);
            this.labelExtraerImagenes.TabIndex = 20;
            this.labelExtraerImagenes.Text = "Extraer imágenes del video";
            // 
            // labelElijaSegundos
            // 
            this.labelElijaSegundos.AutoSize = true;
            this.labelElijaSegundos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElijaSegundos.Location = new System.Drawing.Point(57, 338);
            this.labelElijaSegundos.Name = "labelElijaSegundos";
            this.labelElijaSegundos.Size = new System.Drawing.Size(183, 14);
            this.labelElijaSegundos.TabIndex = 21;
            this.labelElijaSegundos.Text = "Elija cada cuantos segundos:";
            // 
            // textSegundos
            // 
            this.textSegundos.Location = new System.Drawing.Point(246, 336);
            this.textSegundos.Name = "textSegundos";
            this.textSegundos.Size = new System.Drawing.Size(37, 20);
            this.textSegundos.TabIndex = 22;
            // 
            // buttonExtraerImagenes
            // 
            this.buttonExtraerImagenes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtraerImagenes.Location = new System.Drawing.Point(294, 330);
            this.buttonExtraerImagenes.Name = "buttonExtraerImagenes";
            this.buttonExtraerImagenes.Size = new System.Drawing.Size(145, 31);
            this.buttonExtraerImagenes.TabIndex = 23;
            this.buttonExtraerImagenes.Text = "Extraer Imágenes";
            this.buttonExtraerImagenes.UseVisualStyleBackColor = true;
            this.buttonExtraerImagenes.Click += new System.EventHandler(this.buttonExtraerImagenes_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 399);
            this.Controls.Add(this.buttonExtraerImagenes);
            this.Controls.Add(this.textSegundos);
            this.Controls.Add(this.labelElijaSegundos);
            this.Controls.Add(this.labelExtraerImagenes);
            this.Controls.Add(this.buttonCambiarResol);
            this.Controls.Add(this.radioButton144);
            this.Controls.Add(this.radioButton240);
            this.Controls.Add(this.radioButton360);
            this.Controls.Add(this.radioButton480);
            this.Controls.Add(this.radioButton720);
            this.Controls.Add(this.radioButton1080);
            this.Controls.Add(this.labelCambiarResolucion);
            this.Controls.Add(this.buttonRemoverAudio);
            this.Controls.Add(this.buttonExtraerAudio);
            this.Controls.Add(this.buttonConvertir);
            this.Controls.Add(this.radioButtonFlv);
            this.Controls.Add(this.radioButtonMpeg);
            this.Controls.Add(this.radioButtonAvi);
            this.Controls.Add(this.radioButtonMp4);
            this.Controls.Add(this.labelCambiarFormato);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelNuevoNombre);
            this.Controls.Add(this.buttonExaminar);
            this.Controls.Add(this.textArchivo);
            this.Name = "FormInicio";
            this.Text = "Above Premiere";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cerrarForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textArchivo;
        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.Label labelNuevoNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelCambiarFormato;
        private System.Windows.Forms.RadioButton radioButtonMp4;
        private System.Windows.Forms.RadioButton radioButtonAvi;
        private System.Windows.Forms.RadioButton radioButtonMpeg;
        private System.Windows.Forms.RadioButton radioButtonFlv;
        private System.Windows.Forms.Button buttonConvertir;
        private System.Windows.Forms.Button buttonExtraerAudio;
        private System.Windows.Forms.Button buttonRemoverAudio;
        private System.Windows.Forms.Label labelCambiarResolucion;
        private System.Windows.Forms.RadioButton radioButton1080;
        private System.Windows.Forms.RadioButton radioButton720;
        private System.Windows.Forms.RadioButton radioButton480;
        private System.Windows.Forms.RadioButton radioButton360;
        private System.Windows.Forms.RadioButton radioButton240;
        private System.Windows.Forms.RadioButton radioButton144;
        private System.Windows.Forms.Button buttonCambiarResol;
        private System.Windows.Forms.Label labelExtraerImagenes;
        private System.Windows.Forms.Label labelElijaSegundos;
        private System.Windows.Forms.TextBox textSegundos;
        private System.Windows.Forms.Button buttonExtraerImagenes;
    }
}