namespace Actividad_En_El_Aula8._1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            tbImporte = new TextBox();
            btnConfirmar = new Button();
            lbxVer = new ListBox();
            btnActualizar = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnImportar = new Button();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 39);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 104);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 171);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 2;
            label3.Text = "Importe:";
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tbNombre.Location = new Point(115, 39);
            tbNombre.Multiline = true;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(145, 33);
            tbNombre.TabIndex = 3;
            // 
            // tbDNI
            // 
            tbDNI.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tbDNI.Location = new Point(115, 104);
            tbDNI.Multiline = true;
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(145, 33);
            tbDNI.TabIndex = 4;
            // 
            // tbImporte
            // 
            tbImporte.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tbImporte.Location = new Point(115, 171);
            tbImporte.Multiline = true;
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(145, 33);
            tbImporte.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(283, 93);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(272, 66);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lbxVer
            // 
            lbxVer.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbxVer.FormattingEnabled = true;
            lbxVer.ItemHeight = 19;
            lbxVer.Location = new Point(12, 226);
            lbxVer.Name = "lbxVer";
            lbxVer.Size = new Size(664, 289);
            lbxVer.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(684, 226);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(193, 66);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportar
            // 
            btnImportar.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnImportar.Location = new Point(684, 324);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(193, 66);
            btnImportar.TabIndex = 9;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExportar.Location = new Point(684, 430);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(193, 66);
            btnExportar.TabIndex = 10;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 517);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(btnActualizar);
            Controls.Add(lbxVer);
            Controls.Add(btnConfirmar);
            Controls.Add(tbImporte);
            Controls.Add(tbDNI);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNombre;
        private TextBox tbDNI;
        private TextBox tbImporte;
        private Button btnConfirmar;
        private ListBox lbxVer;
        private Button btnActualizar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnImportar;
        private Button btnExportar;
    }
}
