
namespace Simulacion_U3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tablaUniforme = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnUniformeOk = new MaterialSkin.Controls.MaterialButton();
            this.TxtB = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtA = new MaterialSkin.Controls.MaterialTextBox();
            this.txtN = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.TbExponencial = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.TxtExpMedia = new MaterialSkin.Controls.MaterialTextBox();
            this.btnOk = new MaterialSkin.Controls.MaterialButton();
            this.txtExp1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtExpN = new MaterialSkin.Controls.MaterialTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.InfoProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUniforme)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbExponencial)).BeginInit();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2561393_square_icon.png");
            this.imageList1.Images.SetKeyName(1, "Circle.png");
            this.imageList1.Images.SetKeyName(2, "Home.png");
            this.imageList1.Images.SetKeyName(3, "Triangle.png");
            this.imageList1.Images.SetKeyName(4, "gato.png");
            this.imageList1.Images.SetKeyName(5, "uno.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1274, 653);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.ImageKey = "Home.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1266, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.Controls.Add(this.materialCard1);
            this.tabPage2.ImageKey = "Triangle.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VA TI (UNIFORME)";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.tablaUniforme);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(203, 3);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1060, 604);
            this.materialCard2.TabIndex = 2;
            // 
            // tablaUniforme
            // 
            this.tablaUniforme.AllowUserToAddRows = false;
            this.tablaUniforme.AllowUserToDeleteRows = false;
            this.tablaUniforme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaUniforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUniforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.tablaUniforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaUniforme.Location = new System.Drawing.Point(14, 14);
            this.tablaUniforme.Name = "tablaUniforme";
            this.tablaUniforme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaUniforme.Size = new System.Drawing.Size(1032, 576);
            this.tablaUniforme.TabIndex = 0;
            this.tablaUniforme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUniforme_CellClick);
            this.tablaUniforme.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.tablaUniforme_EditingControlShowing);
            this.tablaUniforme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpN_KeyPress);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Medicion";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Ri";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Resultado";
            this.Column3.Name = "Column3";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnUniformeOk);
            this.materialCard1.Controls.Add(this.TxtB);
            this.materialCard1.Controls.Add(this.TxtA);
            this.materialCard1.Controls.Add(this.txtN);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(200, 604);
            this.materialCard1.TabIndex = 1;
            // 
            // btnUniformeOk
            // 
            this.btnUniformeOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUniformeOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUniformeOk.Depth = 0;
            this.btnUniformeOk.HighEmphasis = true;
            this.btnUniformeOk.Icon = null;
            this.btnUniformeOk.Location = new System.Drawing.Point(68, 190);
            this.btnUniformeOk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUniformeOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUniformeOk.Name = "btnUniformeOk";
            this.btnUniformeOk.Size = new System.Drawing.Size(64, 36);
            this.btnUniformeOk.TabIndex = 3;
            this.btnUniformeOk.Text = "ok";
            this.btnUniformeOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUniformeOk.UseAccentColor = false;
            this.btnUniformeOk.UseVisualStyleBackColor = true;
            this.btnUniformeOk.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // TxtB
            // 
            this.TxtB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtB.Depth = 0;
            this.TxtB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtB.Hint = "B";
            this.TxtB.LeadingIcon = null;
            this.TxtB.Location = new System.Drawing.Point(17, 131);
            this.TxtB.MaxLength = 50;
            this.TxtB.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtB.Multiline = false;
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(166, 50);
            this.TxtB.TabIndex = 2;
            this.TxtB.Text = "";
            this.TxtB.TrailingIcon = null;
            this.TxtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpN_KeyPress);
            this.TxtB.Validating += new System.ComponentModel.CancelEventHandler(this.TxtB_Validating);
            // 
            // TxtA
            // 
            this.TxtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtA.Depth = 0;
            this.TxtA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtA.Hint = "A";
            this.TxtA.LeadingIcon = null;
            this.TxtA.Location = new System.Drawing.Point(17, 74);
            this.TxtA.MaxLength = 50;
            this.TxtA.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtA.Multiline = false;
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(166, 50);
            this.TxtA.TabIndex = 1;
            this.TxtA.Text = "";
            this.TxtA.TrailingIcon = null;
            this.TxtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpN_KeyPress);
            this.TxtA.Validating += new System.ComponentModel.CancelEventHandler(this.TxtA_Validating);
            // 
            // txtN
            // 
            this.txtN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtN.Depth = 0;
            this.txtN.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtN.Hint = "N";
            this.txtN.LeadingIcon = null;
            this.txtN.Location = new System.Drawing.Point(17, 17);
            this.txtN.MaxLength = 50;
            this.txtN.MouseState = MaterialSkin.MouseState.OUT;
            this.txtN.Multiline = false;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(166, 50);
            this.txtN.TabIndex = 0;
            this.txtN.Text = "";
            this.txtN.TrailingIcon = null;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpN_KeyPress);
            this.txtN.Validating += new System.ComponentModel.CancelEventHandler(this.txtN_Validating);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.ImageKey = "2561393_square_icon.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1266, 610);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pagina 3";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.ImageKey = "Circle.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1266, 610);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pagina4";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialCard4);
            this.tabPage5.Controls.Add(this.materialCard3);
            this.tabPage5.ImageKey = "gato.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1266, 610);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Va Ti (Exponencial)";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.TbExponencial);
            this.materialCard4.Depth = 0;
            this.materialCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(200, 0);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(1066, 610);
            this.materialCard4.TabIndex = 1;
            // 
            // TbExponencial
            // 
            this.TbExponencial.AllowUserToAddRows = false;
            this.TbExponencial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.NullValue = "0";
            this.TbExponencial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TbExponencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbExponencial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.TbExponencial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbExponencial.Location = new System.Drawing.Point(14, 14);
            this.TbExponencial.Name = "TbExponencial";
            this.TbExponencial.Size = new System.Drawing.Size(1038, 582);
            this.TbExponencial.TabIndex = 0;
            this.TbExponencial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbExponencial_CellClick);
            this.TbExponencial.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.TbExponencial_EditingControlShowing_1);
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Numero";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Ri";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Resultado";
            this.Column6.Name = "Column6";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.TxtExpMedia);
            this.materialCard3.Controls.Add(this.btnOk);
            this.materialCard3.Controls.Add(this.txtExp1);
            this.materialCard3.Controls.Add(this.txtExpN);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(0, 0);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(200, 610);
            this.materialCard3.TabIndex = 0;
            // 
            // TxtExpMedia
            // 
            this.TxtExpMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtExpMedia.Depth = 0;
            this.TxtExpMedia.Enabled = false;
            this.TxtExpMedia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtExpMedia.Hint = "Media";
            this.TxtExpMedia.LeadingIcon = null;
            this.TxtExpMedia.Location = new System.Drawing.Point(17, 543);
            this.TxtExpMedia.MaxLength = 50;
            this.TxtExpMedia.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtExpMedia.Multiline = false;
            this.TxtExpMedia.Name = "TxtExpMedia";
            this.TxtExpMedia.Size = new System.Drawing.Size(166, 50);
            this.TxtExpMedia.TabIndex = 3;
            this.TxtExpMedia.Text = "";
            this.TxtExpMedia.TrailingIcon = null;
            // 
            // btnOk
            // 
            this.btnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOk.Depth = 0;
            this.btnOk.HighEmphasis = true;
            this.btnOk.Icon = null;
            this.btnOk.Location = new System.Drawing.Point(70, 132);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(64, 36);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOk.UseAccentColor = false;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtExp1
            // 
            this.txtExp1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExp1.Depth = 0;
            this.txtExp1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtExp1.Hint = "1/λ";
            this.txtExp1.LeadingIcon = null;
            this.txtExp1.Location = new System.Drawing.Point(19, 73);
            this.txtExp1.MaxLength = 50;
            this.txtExp1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtExp1.Multiline = false;
            this.txtExp1.Name = "txtExp1";
            this.txtExp1.Size = new System.Drawing.Size(166, 50);
            this.txtExp1.TabIndex = 1;
            this.txtExp1.Text = "";
            this.txtExp1.TrailingIcon = null;
            this.txtExp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpN_KeyPress);
            this.txtExp1.Validating += new System.ComponentModel.CancelEventHandler(this.txtExp1_Validating);
            // 
            // txtExpN
            // 
            this.txtExpN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpN.Depth = 0;
            this.txtExpN.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtExpN.Hint = "N";
            this.txtExpN.LeadingIcon = null;
            this.txtExpN.Location = new System.Drawing.Point(19, 17);
            this.txtExpN.MaxLength = 50;
            this.txtExpN.MouseState = MaterialSkin.MouseState.OUT;
            this.txtExpN.Multiline = false;
            this.txtExpN.Name = "txtExpN";
            this.txtExpN.Size = new System.Drawing.Size(166, 50);
            this.txtExpN.TabIndex = 0;
            this.txtExpN.Text = "";
            this.txtExpN.TrailingIcon = null;
            this.txtExpN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpN_KeyPress);
            this.txtExpN.Validating += new System.ComponentModel.CancelEventHandler(this.txtExpN_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InfoProvider
            // 
            this.InfoProvider.ContainerControl = this;
            this.InfoProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("InfoProvider.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Text = "Simulacion U3";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUniforme)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TbExponencial)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnUniformeOk;
        private MaterialSkin.Controls.MaterialTextBox TxtB;
        private MaterialSkin.Controls.MaterialTextBox TxtA;
        private MaterialSkin.Controls.MaterialTextBox txtN;
        private System.Windows.Forms.DataGridView tablaUniforme;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.DataGridView TbExponencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox TxtExpMedia;
        private MaterialSkin.Controls.MaterialButton btnOk;
        private MaterialSkin.Controls.MaterialTextBox txtExp1;
        private MaterialSkin.Controls.MaterialTextBox txtExpN;
        private System.Windows.Forms.ErrorProvider InfoProvider;
    }
}

