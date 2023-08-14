namespace ProgramaTareas
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
            this.btnEliminarCompletadas = new System.Windows.Forms.Button();
            this.btnModificarCompletadas = new System.Windows.Forms.Button();
            this.btnAgregarCompletadas = new System.Windows.Forms.Button();
            this.lbxCompletadas = new System.Windows.Forms.ListBox();
            this.txtPorRealizar = new System.Windows.Forms.TextBox();
            this.txtNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMS_Daltonico = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarPorRealizar = new System.Windows.Forms.Button();
            this.btnEliminarPorRealizar = new System.Windows.Forms.Button();
            this.btnAgregarPorRealizar = new System.Windows.Forms.Button();
            this.lbxA_Realizar = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarEnProgreso = new System.Windows.Forms.Button();
            this.btnAgregarEnProgreso = new System.Windows.Forms.Button();
            this.lbxEnProgreso = new System.Windows.Forms.ListBox();
            this.btnModificarEnProgreso = new System.Windows.Forms.Button();
            this.CMS_Daltonico.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarCompletadas
            // 
            this.btnEliminarCompletadas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarCompletadas.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCompletadas.ForeColor = System.Drawing.Color.Blue;
            this.btnEliminarCompletadas.Location = new System.Drawing.Point(709, 929);
            this.btnEliminarCompletadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarCompletadas.Name = "btnEliminarCompletadas";
            this.btnEliminarCompletadas.Size = new System.Drawing.Size(132, 44);
            this.btnEliminarCompletadas.TabIndex = 29;
            this.btnEliminarCompletadas.Text = "Eliminar";
            this.btnEliminarCompletadas.UseVisualStyleBackColor = false;
            this.btnEliminarCompletadas.Click += new System.EventHandler(this.btnEliminarCompletadas_Click);
            // 
            // btnModificarCompletadas
            // 
            this.btnModificarCompletadas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificarCompletadas.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCompletadas.ForeColor = System.Drawing.Color.Blue;
            this.btnModificarCompletadas.Location = new System.Drawing.Point(409, 929);
            this.btnModificarCompletadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarCompletadas.Name = "btnModificarCompletadas";
            this.btnModificarCompletadas.Size = new System.Drawing.Size(132, 44);
            this.btnModificarCompletadas.TabIndex = 28;
            this.btnModificarCompletadas.Text = "Modificar";
            this.btnModificarCompletadas.UseVisualStyleBackColor = false;
            this.btnModificarCompletadas.Click += new System.EventHandler(this.btnModificarCompletadas_Click);
            // 
            // btnAgregarCompletadas
            // 
            this.btnAgregarCompletadas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregarCompletadas.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompletadas.ForeColor = System.Drawing.Color.Blue;
            this.btnAgregarCompletadas.Location = new System.Drawing.Point(117, 929);
            this.btnAgregarCompletadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarCompletadas.Name = "btnAgregarCompletadas";
            this.btnAgregarCompletadas.Size = new System.Drawing.Size(151, 44);
            this.btnAgregarCompletadas.TabIndex = 27;
            this.btnAgregarCompletadas.Text = "Agregar ";
            this.btnAgregarCompletadas.UseVisualStyleBackColor = false;
            this.btnAgregarCompletadas.Click += new System.EventHandler(this.btnAgregarCompletadas_Click);
            // 
            // lbxCompletadas
            // 
            this.lbxCompletadas.BackColor = System.Drawing.Color.Bisque;
            this.lbxCompletadas.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCompletadas.ForeColor = System.Drawing.Color.Blue;
            this.lbxCompletadas.FormattingEnabled = true;
            this.lbxCompletadas.ItemHeight = 22;
            this.lbxCompletadas.Location = new System.Drawing.Point(117, 770);
            this.lbxCompletadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxCompletadas.Name = "lbxCompletadas";
            this.lbxCompletadas.Size = new System.Drawing.Size(721, 136);
            this.lbxCompletadas.TabIndex = 26;
            this.lbxCompletadas.SelectedIndexChanged += new System.EventHandler(this.lbxCompletadas_SelectedIndexChanged);
            // 
            // txtPorRealizar
            // 
            this.txtPorRealizar.BackColor = System.Drawing.Color.Bisque;
            this.txtPorRealizar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorRealizar.ForeColor = System.Drawing.Color.Blue;
            this.txtPorRealizar.Location = new System.Drawing.Point(120, 33);
            this.txtPorRealizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPorRealizar.Multiline = true;
            this.txtPorRealizar.Name = "txtPorRealizar";
            this.txtPorRealizar.Size = new System.Drawing.Size(721, 57);
            this.txtPorRealizar.TabIndex = 15;
            // 
            // txtNuevaDescripcion
            // 
            this.txtNuevaDescripcion.BackColor = System.Drawing.Color.Bisque;
            this.txtNuevaDescripcion.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaDescripcion.ForeColor = System.Drawing.Color.Blue;
            this.txtNuevaDescripcion.Location = new System.Drawing.Point(119, 119);
            this.txtNuevaDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNuevaDescripcion.Multiline = true;
            this.txtNuevaDescripcion.Name = "txtNuevaDescripcion";
            this.txtNuevaDescripcion.Size = new System.Drawing.Size(723, 62);
            this.txtNuevaDescripcion.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 746);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tarea completadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nueva Tarea ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Modificar Tarea ";
            // 
            // CMS_Daltonico
            // 
            this.CMS_Daltonico.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_Daltonico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.CMS_Daltonico.Name = "CMS_Daltonico";
            this.CMS_Daltonico.Size = new System.Drawing.Size(115, 28);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorToolStripMenuItem,
            this.foreColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backColorToolStripMenuItem.Text = "BackColor";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.foreColorToolStripMenuItem.Text = "ForeColor";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnModificarPorRealizar);
            this.groupBox1.Controls.Add(this.btnEliminarPorRealizar);
            this.groupBox1.Controls.Add(this.btnAgregarPorRealizar);
            this.groupBox1.Controls.Add(this.lbxA_Realizar);
            this.groupBox1.Location = new System.Drawing.Point(104, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 246);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tarea por realizar";
            // 
            // btnModificarPorRealizar
            // 
            this.btnModificarPorRealizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificarPorRealizar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPorRealizar.ForeColor = System.Drawing.Color.Blue;
            this.btnModificarPorRealizar.Location = new System.Drawing.Point(297, 184);
            this.btnModificarPorRealizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarPorRealizar.Name = "btnModificarPorRealizar";
            this.btnModificarPorRealizar.Size = new System.Drawing.Size(132, 44);
            this.btnModificarPorRealizar.TabIndex = 37;
            this.btnModificarPorRealizar.Text = "Modificar";
            this.btnModificarPorRealizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminarPorRealizar
            // 
            this.btnEliminarPorRealizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarPorRealizar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPorRealizar.ForeColor = System.Drawing.Color.Blue;
            this.btnEliminarPorRealizar.Location = new System.Drawing.Point(599, 184);
            this.btnEliminarPorRealizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPorRealizar.Name = "btnEliminarPorRealizar";
            this.btnEliminarPorRealizar.Size = new System.Drawing.Size(132, 44);
            this.btnEliminarPorRealizar.TabIndex = 36;
            this.btnEliminarPorRealizar.Text = "Eliminar";
            this.btnEliminarPorRealizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPorRealizar
            // 
            this.btnAgregarPorRealizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregarPorRealizar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPorRealizar.ForeColor = System.Drawing.Color.Blue;
            this.btnAgregarPorRealizar.Location = new System.Drawing.Point(13, 184);
            this.btnAgregarPorRealizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPorRealizar.Name = "btnAgregarPorRealizar";
            this.btnAgregarPorRealizar.Size = new System.Drawing.Size(132, 44);
            this.btnAgregarPorRealizar.TabIndex = 35;
            this.btnAgregarPorRealizar.Text = "Agregar";
            this.btnAgregarPorRealizar.UseVisualStyleBackColor = false;
            // 
            // lbxA_Realizar
            // 
            this.lbxA_Realizar.BackColor = System.Drawing.Color.Bisque;
            this.lbxA_Realizar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxA_Realizar.ForeColor = System.Drawing.Color.Blue;
            this.lbxA_Realizar.FormattingEnabled = true;
            this.lbxA_Realizar.ItemHeight = 22;
            this.lbxA_Realizar.Location = new System.Drawing.Point(7, 46);
            this.lbxA_Realizar.Margin = new System.Windows.Forms.Padding(4);
            this.lbxA_Realizar.Name = "lbxA_Realizar";
            this.lbxA_Realizar.Size = new System.Drawing.Size(723, 114);
            this.lbxA_Realizar.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnEliminarEnProgreso);
            this.groupBox2.Controls.Add(this.btnAgregarEnProgreso);
            this.groupBox2.Controls.Add(this.lbxEnProgreso);
            this.groupBox2.Controls.Add(this.btnModificarEnProgreso);
            this.groupBox2.Location = new System.Drawing.Point(104, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 258);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tareas en proceso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tareas en Progreso";
            // 
            // btnEliminarEnProgreso
            // 
            this.btnEliminarEnProgreso.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarEnProgreso.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEnProgreso.ForeColor = System.Drawing.Color.Blue;
            this.btnEliminarEnProgreso.Location = new System.Drawing.Point(603, 199);
            this.btnEliminarEnProgreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarEnProgreso.Name = "btnEliminarEnProgreso";
            this.btnEliminarEnProgreso.Size = new System.Drawing.Size(132, 44);
            this.btnEliminarEnProgreso.TabIndex = 36;
            this.btnEliminarEnProgreso.Text = "Eliminar";
            this.btnEliminarEnProgreso.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEnProgreso
            // 
            this.btnAgregarEnProgreso.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregarEnProgreso.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEnProgreso.ForeColor = System.Drawing.Color.Blue;
            this.btnAgregarEnProgreso.Location = new System.Drawing.Point(13, 199);
            this.btnAgregarEnProgreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarEnProgreso.Name = "btnAgregarEnProgreso";
            this.btnAgregarEnProgreso.Size = new System.Drawing.Size(151, 44);
            this.btnAgregarEnProgreso.TabIndex = 35;
            this.btnAgregarEnProgreso.Text = "Agregar";
            this.btnAgregarEnProgreso.UseVisualStyleBackColor = false;
            // 
            // lbxEnProgreso
            // 
            this.lbxEnProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbxEnProgreso.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEnProgreso.ForeColor = System.Drawing.Color.Red;
            this.lbxEnProgreso.FormattingEnabled = true;
            this.lbxEnProgreso.ItemHeight = 22;
            this.lbxEnProgreso.Location = new System.Drawing.Point(13, 40);
            this.lbxEnProgreso.Margin = new System.Windows.Forms.Padding(4);
            this.lbxEnProgreso.Name = "lbxEnProgreso";
            this.lbxEnProgreso.Size = new System.Drawing.Size(721, 136);
            this.lbxEnProgreso.TabIndex = 34;
            // 
            // btnModificarEnProgreso
            // 
            this.btnModificarEnProgreso.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificarEnProgreso.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEnProgreso.ForeColor = System.Drawing.Color.Blue;
            this.btnModificarEnProgreso.Location = new System.Drawing.Point(303, 199);
            this.btnModificarEnProgreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarEnProgreso.Name = "btnModificarEnProgreso";
            this.btnModificarEnProgreso.Size = new System.Drawing.Size(132, 44);
            this.btnModificarEnProgreso.TabIndex = 33;
            this.btnModificarEnProgreso.Text = "Modificar";
            this.btnModificarEnProgreso.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(941, 1055);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNuevaDescripcion);
            this.Controls.Add(this.btnEliminarCompletadas);
            this.Controls.Add(this.btnModificarCompletadas);
            this.Controls.Add(this.btnAgregarCompletadas);
            this.Controls.Add(this.lbxCompletadas);
            this.Controls.Add(this.txtPorRealizar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Tareas";
            this.CMS_Daltonico.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarCompletadas;
        private System.Windows.Forms.Button btnModificarCompletadas;
        private System.Windows.Forms.Button btnAgregarCompletadas;
        private System.Windows.Forms.ListBox lbxCompletadas;
        private System.Windows.Forms.TextBox txtPorRealizar;
        private System.Windows.Forms.TextBox txtNuevaDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip CMS_Daltonico;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificarPorRealizar;
        private System.Windows.Forms.Button btnEliminarPorRealizar;
        private System.Windows.Forms.Button btnAgregarPorRealizar;
        private System.Windows.Forms.ListBox lbxA_Realizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarEnProgreso;
        private System.Windows.Forms.Button btnAgregarEnProgreso;
        private System.Windows.Forms.ListBox lbxEnProgreso;
        private System.Windows.Forms.Button btnModificarEnProgreso;
    }
}

