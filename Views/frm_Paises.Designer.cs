namespace Semana2_Tarea1
{
    partial class frm_paises
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
            btn_grabar = new Button();
            btn_editar = new Button();
            btn_eliminar = new Button();
            btn_cancelar = new Button();
            lst_paises = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txt_nombre_pais = new TextBox();
            SuspendLayout();
            // 
            // btn_grabar
            // 
            btn_grabar.Location = new Point(147, 508);
            btn_grabar.Name = "btn_grabar";
            btn_grabar.Size = new Size(186, 110);
            btn_grabar.TabIndex = 0;
            btn_grabar.Text = "Grabar";
            btn_grabar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(373, 508);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(186, 110);
            btn_editar.TabIndex = 1;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(588, 508);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(186, 110);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(808, 508);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(186, 110);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // lst_paises
            // 
            lst_paises.FormattingEnabled = true;
            lst_paises.ItemHeight = 28;
            lst_paises.Location = new Point(588, 107);
            lst_paises.Name = "lst_paises";
            lst_paises.Size = new Size(406, 340);
            lst_paises.TabIndex = 4;
            lst_paises.DoubleClick += lst_paises_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(586, 58);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 5;
            label1.Text = "Lista de Paises";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 107);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 6;
            label2.Text = "Nombre del Pais";
            // 
            // txt_nombre_pais
            // 
            txt_nombre_pais.Location = new Point(147, 148);
            txt_nombre_pais.Name = "txt_nombre_pais";
            txt_nombre_pais.Size = new Size(385, 34);
            txt_nombre_pais.TabIndex = 7;
            // 
            // frm_paises
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 643);
            Controls.Add(txt_nombre_pais);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lst_paises);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(btn_grabar);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frm_paises";
            Text = "Paises";
            Load += frm_paises_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_grabar;
        private Button btn_editar;
        private Button btn_eliminar;
        private Button btn_cancelar;
        private ListBox lst_paises;
        private Label label1;
        private Label label2;
        private TextBox txt_nombre_pais;
    }
}
