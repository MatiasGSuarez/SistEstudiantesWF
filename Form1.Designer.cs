namespace EstudiantesWF
{
    partial class FormEstudiantes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxTitulo = new System.Windows.Forms.GroupBox();
            this.textTitle1 = new System.Windows.Forms.TextBox();
            this.groupBoxInfoEst = new System.Windows.Forms.GroupBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.groupBoxImage = new System.Windows.Forms.GroupBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxTituloInfo = new System.Windows.Forms.TextBox();
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelPaginas = new System.Windows.Forms.Label();
            this.buttonUltimo = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonPrimero = new System.Windows.Forms.Button();
            this.dataGridList = new System.Windows.Forms.DataGridView();
            this.textBoxTituloLista = new System.Windows.Forms.TextBox();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.groupBoxTitulo.SuspendLayout();
            this.groupBoxInfoEst.SuspendLayout();
            this.groupBoxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.groupBoxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).BeginInit();
            this.groupBoxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxTitulo
            // 
            this.groupBoxTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxTitulo.Controls.Add(this.textTitle1);
            this.groupBoxTitulo.Location = new System.Drawing.Point(2, 18);
            this.groupBoxTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTitulo.Name = "groupBoxTitulo";
            this.groupBoxTitulo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTitulo.Size = new System.Drawing.Size(1192, 58);
            this.groupBoxTitulo.TabIndex = 2;
            this.groupBoxTitulo.TabStop = false;
            // 
            // textTitle1
            // 
            this.textTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTitle1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textTitle1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle1.ForeColor = System.Drawing.SystemColors.Window;
            this.textTitle1.Location = new System.Drawing.Point(309, 14);
            this.textTitle1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTitle1.Name = "textTitle1";
            this.textTitle1.ReadOnly = true;
            this.textTitle1.Size = new System.Drawing.Size(531, 33);
            this.textTitle1.TabIndex = 0;
            this.textTitle1.Text = "SISTEMA DE ESTUDIANTES";
            this.textTitle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTitle1.TextChanged += new System.EventHandler(this.textTitle_TextChanged);
            // 
            // groupBoxInfoEst
            // 
            this.groupBoxInfoEst.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxInfoEst.Controls.Add(this.labelMail);
            this.groupBoxInfoEst.Controls.Add(this.labelDNI);
            this.groupBoxInfoEst.Controls.Add(this.labelSurname);
            this.groupBoxInfoEst.Controls.Add(this.labelName);
            this.groupBoxInfoEst.Controls.Add(this.buttonDelete);
            this.groupBoxInfoEst.Controls.Add(this.buttonCancel);
            this.groupBoxInfoEst.Controls.Add(this.buttonAdd);
            this.groupBoxInfoEst.Controls.Add(this.textBoxMail);
            this.groupBoxInfoEst.Controls.Add(this.textBoxName);
            this.groupBoxInfoEst.Controls.Add(this.textBoxSurname);
            this.groupBoxInfoEst.Controls.Add(this.textBoxDNI);
            this.groupBoxInfoEst.Controls.Add(this.groupBoxImage);
            this.groupBoxInfoEst.Controls.Add(this.textBoxTituloInfo);
            this.groupBoxInfoEst.Location = new System.Drawing.Point(2, 168);
            this.groupBoxInfoEst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfoEst.Name = "groupBoxInfoEst";
            this.groupBoxInfoEst.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInfoEst.Size = new System.Drawing.Size(543, 506);
            this.groupBoxInfoEst.TabIndex = 3;
            this.groupBoxInfoEst.TabStop = false;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMail.Location = new System.Drawing.Point(269, 340);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(59, 20);
            this.labelMail.TabIndex = 1;
            this.labelMail.Text = "E-mail";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDNI.Location = new System.Drawing.Point(4, 340);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(55, 20);
            this.labelDNI.TabIndex = 16;
            this.labelDNI.Text = "D.N.I.";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSurname.Location = new System.Drawing.Point(268, 273);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(73, 20);
            this.labelSurname.TabIndex = 15;
            this.labelSurname.Text = "Apellido";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelName.Location = new System.Drawing.Point(4, 273);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 20);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Nombre";
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleDescription = "";
            this.buttonDelete.AccessibleName = "Eliminar";
            this.buttonDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDelete.BackgroundImage = global::EstudiantesWF.Properties.Resources.baseline_delete_white_18dp;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.Location = new System.Drawing.Point(362, 415);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 57);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancel.BackgroundImage = global::EstudiantesWF.Properties.Resources.baseline_clear_white_18dp;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.Location = new System.Drawing.Point(189, 415);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 57);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAdd.BackgroundImage = global::EstudiantesWF.Properties.Resources.baseline_add_white_18dp1;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.Location = new System.Drawing.Point(21, 415);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 57);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(271, 365);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(266, 29);
            this.textBoxMail.TabIndex = 4;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 296);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(236, 29);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(268, 296);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(266, 29);
            this.textBoxSurname.TabIndex = 2;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSurname_KeyPress);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(5, 365);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDNI.Multiline = true;
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(239, 29);
            this.textBoxDNI.TabIndex = 3;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            this.textBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.Controls.Add(this.pictureBoxImage);
            this.groupBoxImage.Location = new System.Drawing.Point(100, 62);
            this.groupBoxImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxImage.Size = new System.Drawing.Size(300, 206);
            this.groupBoxImage.TabIndex = 3;
            this.groupBoxImage.TabStop = false;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImage.Image = global::EstudiantesWF.Properties.Resources.default_user;
            this.pictureBoxImage.Location = new System.Drawing.Point(47, 14);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(202, 182);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.PictureBoxImage_Click);
            // 
            // textBoxTituloInfo
            // 
            this.textBoxTituloInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTituloInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTituloInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxTituloInfo.Location = new System.Drawing.Point(58, 18);
            this.textBoxTituloInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTituloInfo.Name = "textBoxTituloInfo";
            this.textBoxTituloInfo.Size = new System.Drawing.Size(398, 19);
            this.textBoxTituloInfo.TabIndex = 12;
            this.textBoxTituloInfo.Text = "INFORMACION DEL ESTUDIANTE";
            this.textBoxTituloInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxLista.Controls.Add(this.numericUpDown);
            this.groupBoxLista.Controls.Add(this.labelPaginas);
            this.groupBoxLista.Controls.Add(this.buttonUltimo);
            this.groupBoxLista.Controls.Add(this.buttonSiguiente);
            this.groupBoxLista.Controls.Add(this.buttonAnterior);
            this.groupBoxLista.Controls.Add(this.buttonPrimero);
            this.groupBoxLista.Controls.Add(this.dataGridList);
            this.groupBoxLista.Controls.Add(this.textBoxTituloLista);
            this.groupBoxLista.Location = new System.Drawing.Point(554, 168);
            this.groupBoxLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLista.Size = new System.Drawing.Size(640, 506);
            this.groupBoxLista.TabIndex = 4;
            this.groupBoxLista.TabStop = false;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(18, 430);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(84, 26);
            this.numericUpDown.TabIndex = 10;
            this.numericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // labelPaginas
            // 
            this.labelPaginas.AutoSize = true;
            this.labelPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaginas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPaginas.Location = new System.Drawing.Point(321, 391);
            this.labelPaginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaginas.Name = "labelPaginas";
            this.labelPaginas.Size = new System.Drawing.Size(94, 29);
            this.labelPaginas.TabIndex = 2;
            this.labelPaginas.Tag = "";
            this.labelPaginas.Text = "Página";
            this.labelPaginas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonUltimo.BackgroundImage = global::EstudiantesWF.Properties.Resources.baseline_keyboard_double_arrow_right_white_18dp;
            this.buttonUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUltimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUltimo.FlatAppearance.BorderSize = 0;
            this.buttonUltimo.Location = new System.Drawing.Point(470, 425);
            this.buttonUltimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.Size = new System.Drawing.Size(93, 37);
            this.buttonUltimo.TabIndex = 9;
            this.buttonUltimo.UseVisualStyleBackColor = false;
            this.buttonUltimo.Click += new System.EventHandler(this.buttonUltimo_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSiguiente.BackgroundImage = global::EstudiantesWF.Properties.Resources.baseline_arrow_forward_ios_white_18dp;
            this.buttonSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSiguiente.FlatAppearance.BorderSize = 0;
            this.buttonSiguiente.Location = new System.Drawing.Point(369, 425);
            this.buttonSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(93, 37);
            this.buttonSiguiente.TabIndex = 8;
            this.buttonSiguiente.UseVisualStyleBackColor = false;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAnterior.BackgroundImage = global::EstudiantesWF.Properties.Resources.baseline_arrow_back_ios_white_18dp;
            this.buttonAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnterior.FlatAppearance.BorderSize = 0;
            this.buttonAnterior.Location = new System.Drawing.Point(268, 425);
            this.buttonAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(93, 37);
            this.buttonAnterior.TabIndex = 7;
            this.buttonAnterior.UseVisualStyleBackColor = false;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonPrimero
            // 
            this.buttonPrimero.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPrimero.BackgroundImage = global::EstudiantesWF.Properties.Resources.baseline_keyboard_double_arrow_left_white_18dp;
            this.buttonPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrimero.FlatAppearance.BorderSize = 0;
            this.buttonPrimero.Location = new System.Drawing.Point(166, 425);
            this.buttonPrimero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrimero.Name = "buttonPrimero";
            this.buttonPrimero.Size = new System.Drawing.Size(93, 37);
            this.buttonPrimero.TabIndex = 6;
            this.buttonPrimero.UseVisualStyleBackColor = false;
            this.buttonPrimero.Click += new System.EventHandler(this.buttonPrimero_Click);
            // 
            // dataGridList
            // 
            this.dataGridList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridList.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridList.Location = new System.Drawing.Point(8, 45);
            this.dataGridList.Name = "dataGridList";
            this.dataGridList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridList.RowHeadersWidth = 62;
            this.dataGridList.RowTemplate.Height = 28;
            this.dataGridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridList.Size = new System.Drawing.Size(626, 315);
            this.dataGridList.TabIndex = 1;
            this.dataGridList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridList_CellClick);
            this.dataGridList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridList_KeyUp);
            // 
            // textBoxTituloLista
            // 
            this.textBoxTituloLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTituloLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTituloLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTituloLista.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxTituloLista.Location = new System.Drawing.Point(164, 18);
            this.textBoxTituloLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTituloLista.Name = "textBoxTituloLista";
            this.textBoxTituloLista.Size = new System.Drawing.Size(330, 19);
            this.textBoxTituloLista.TabIndex = 0;
            this.textBoxTituloLista.Text = "LISTA DE ESTUDIANTES";
            this.textBoxTituloLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxBuscar.Controls.Add(this.textBoxBusqueda);
            this.groupBoxBuscar.Controls.Add(this.labelBuscar);
            this.groupBoxBuscar.Location = new System.Drawing.Point(2, 83);
            this.groupBoxBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxBuscar.Size = new System.Drawing.Size(1192, 75);
            this.groupBoxBuscar.TabIndex = 5;
            this.groupBoxBuscar.TabStop = false;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(108, 18);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBusqueda.Multiline = true;
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(332, 39);
            this.textBoxBusqueda.TabIndex = 1;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBuscar.Location = new System.Drawing.Point(16, 26);
            this.labelBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(79, 25);
            this.labelBuscar.TabIndex = 0;
            this.labelBuscar.Text = "Buscar";
            this.labelBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.groupBoxLista);
            this.Controls.Add(this.groupBoxInfoEst);
            this.Controls.Add(this.groupBoxTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEstudiantes";
            this.Text = "Sistema de Estudiantes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTitulo.ResumeLayout(false);
            this.groupBoxTitulo.PerformLayout();
            this.groupBoxInfoEst.ResumeLayout(false);
            this.groupBoxInfoEst.PerformLayout();
            this.groupBoxImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.groupBoxLista.ResumeLayout(false);
            this.groupBoxLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).EndInit();
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBoxTitulo;
        private System.Windows.Forms.TextBox textTitle1;
        private System.Windows.Forms.GroupBox groupBoxInfoEst;
        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxTituloInfo;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TextBox textBoxTituloLista;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridList;
        private System.Windows.Forms.Label labelPaginas;
        private System.Windows.Forms.Button buttonUltimo;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonPrimero;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }

}

