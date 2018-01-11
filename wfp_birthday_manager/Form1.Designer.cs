namespace wfp_birthday_manager
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxt_birthday = new System.Windows.Forms.MaskedTextBox();
            this.btn_confirmAdd = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_attLista = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_confirmDel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_confirmEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adicionarNovaPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPesssoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(202, 86);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(266, 26);
            this.txt_name.TabIndex = 3;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(202, 154);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(266, 26);
            this.txt_lastname.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxt_birthday);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_lastname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Location = new System.Drawing.Point(13, 564);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(513, 291);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New person info";
            // 
            // mtxt_birthday
            // 
            this.mtxt_birthday.Location = new System.Drawing.Point(202, 222);
            this.mtxt_birthday.Mask = "00/00/0000";
            this.mtxt_birthday.Name = "mtxt_birthday";
            this.mtxt_birthday.Size = new System.Drawing.Size(91, 26);
            this.mtxt_birthday.TabIndex = 5;
            this.mtxt_birthday.ValidatingType = typeof(System.DateTime);
            // 
            // btn_confirmAdd
            // 
            this.btn_confirmAdd.Location = new System.Drawing.Point(13, 116);
            this.btn_confirmAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_confirmAdd.Name = "btn_confirmAdd";
            this.btn_confirmAdd.Size = new System.Drawing.Size(267, 77);
            this.btn_confirmAdd.TabIndex = 8;
            this.btn_confirmAdd.Text = "Confirmar dados";
            this.btn_confirmAdd.UseVisualStyleBackColor = true;
            this.btn_confirmAdd.Click += new System.EventHandler(this.btn_confirmAdd_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(13, 29);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(267, 77);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Adicionar nova pessoa";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_attLista
            // 
            this.btn_attLista.Location = new System.Drawing.Point(561, 455);
            this.btn_attLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_attLista.Name = "btn_attLista";
            this.btn_attLista.Size = new System.Drawing.Size(191, 37);
            this.btn_attLista.TabIndex = 11;
            this.btn_attLista.Text = "Atualizar lista";
            this.btn_attLista.UseVisualStyleBackColor = true;
            this.btn_attLista.Click += new System.EventHandler(this.btn_attLista_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(813, 29);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(267, 77);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Deletar pessoa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1100, 29);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(685, 802);
            this.checkedListBox1.TabIndex = 16;
            // 
            // btn_confirmDel
            // 
            this.btn_confirmDel.Location = new System.Drawing.Point(813, 116);
            this.btn_confirmDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_confirmDel.Name = "btn_confirmDel";
            this.btn_confirmDel.Size = new System.Drawing.Size(267, 77);
            this.btn_confirmDel.TabIndex = 19;
            this.btn_confirmDel.Text = "Confirmar deleção";
            this.btn_confirmDel.UseVisualStyleBackColor = true;
            this.btn_confirmDel.Click += new System.EventHandler(this.btn_confirmDel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(813, 203);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(267, 77);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "Editar pessoa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_confirmEdit
            // 
            this.btn_confirmEdit.Location = new System.Drawing.Point(813, 290);
            this.btn_confirmEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_confirmEdit.Name = "btn_confirmEdit";
            this.btn_confirmEdit.Size = new System.Drawing.Size(267, 77);
            this.btn_confirmEdit.TabIndex = 21;
            this.btn_confirmEdit.Text = "Confirmar edição";
            this.btn_confirmEdit.UseVisualStyleBackColor = true;
            this.btn_confirmEdit.Click += new System.EventHandler(this.btn_confirmEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(440, 418);
            this.dataGridView1.TabIndex = 22;
            // 
            // adicionarNovaPessoaToolStripMenuItem
            // 
            this.adicionarNovaPessoaToolStripMenuItem.Name = "adicionarNovaPessoaToolStripMenuItem";
            this.adicionarNovaPessoaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // editarPesssoaToolStripMenuItem
            // 
            this.editarPesssoaToolStripMenuItem.Name = "editarPesssoaToolStripMenuItem";
            this.editarPesssoaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // excluirPessoaToolStripMenuItem
            // 
            this.excluirPessoaToolStripMenuItem.Name = "excluirPessoaToolStripMenuItem";
            this.excluirPessoaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // procurarToolStripMenuItem
            // 
            this.procurarToolStripMenuItem.Name = "procurarToolStripMenuItem";
            this.procurarToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 869);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_confirmEdit);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_confirmDel);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_attLista);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_confirmAdd);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Add person";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_confirmAdd;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_attLista;
        private System.Windows.Forms.MaskedTextBox mtxt_birthday;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_confirmDel;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_confirmEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem adicionarNovaPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPesssoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarToolStripMenuItem;
    }
}

