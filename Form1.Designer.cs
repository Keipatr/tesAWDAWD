namespace tes
{
    partial class formTugas
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
            this.labelData = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.textBoxIsi = new System.Windows.Forms.TextBox();
            this.comboBoxPilih = new System.Windows.Forms.ComboBox();
            this.listAdd = new System.Windows.Forms.ListBox();
            this.listReplace = new System.Windows.Forms.ListBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.buttonAllRight = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonAllLeft = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.checkBlock = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(66, 33);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data :";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(63, 80);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(51, 20);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Mode:";
            // 
            // textBoxIsi
            // 
            this.textBoxIsi.Location = new System.Drawing.Point(120, 33);
            this.textBoxIsi.Name = "textBoxIsi";
            this.textBoxIsi.Size = new System.Drawing.Size(300, 27);
            this.textBoxIsi.TabIndex = 2;
            // 
            // comboBoxPilih
            // 
            this.comboBoxPilih.FormattingEnabled = true;
            this.comboBoxPilih.Items.AddRange(new object[] {
            "Add ",
            "Replace"});
            this.comboBoxPilih.Location = new System.Drawing.Point(120, 77);
            this.comboBoxPilih.Name = "comboBoxPilih";
            this.comboBoxPilih.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPilih.TabIndex = 4;
            // 
            // listAdd
            // 
            this.listAdd.FormattingEnabled = true;
            this.listAdd.ItemHeight = 20;
            this.listAdd.Location = new System.Drawing.Point(44, 172);
            this.listAdd.Name = "listAdd";
            this.listAdd.Size = new System.Drawing.Size(218, 244);
            this.listAdd.TabIndex = 5;
            this.listAdd.SelectedIndexChanged += new System.EventHandler(this.listAdd_SelectedIndexChanged);
            // 
            // listReplace
            // 
            this.listReplace.FormattingEnabled = true;
            this.listReplace.ItemHeight = 20;
            this.listReplace.Location = new System.Drawing.Point(414, 172);
            this.listReplace.Name = "listReplace";
            this.listReplace.Size = new System.Drawing.Size(226, 244);
            this.listReplace.TabIndex = 6;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(74, 132);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(94, 29);
            this.btnProses.TabIndex = 7;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // buttonAllRight
            // 
            this.buttonAllRight.Location = new System.Drawing.Point(303, 185);
            this.buttonAllRight.Name = "buttonAllRight";
            this.buttonAllRight.Size = new System.Drawing.Size(41, 29);
            this.buttonAllRight.TabIndex = 8;
            this.buttonAllRight.Text = ">>";
            this.buttonAllRight.UseVisualStyleBackColor = true;
            this.buttonAllRight.Click += new System.EventHandler(this.buttonAllRight_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(303, 224);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(41, 29);
            this.buttonRight.TabIndex = 9;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(303, 268);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(41, 29);
            this.buttonLeft.TabIndex = 10;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonAllLeft
            // 
            this.buttonAllLeft.Location = new System.Drawing.Point(303, 303);
            this.buttonAllLeft.Name = "buttonAllLeft";
            this.buttonAllLeft.Size = new System.Drawing.Size(41, 29);
            this.buttonAllLeft.TabIndex = 11;
            this.buttonAllLeft.Text = "<<";
            this.buttonAllLeft.UseVisualStyleBackColor = true;
            this.buttonAllLeft.Click += new System.EventHandler(this.buttonAllLeft_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(303, 338);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(41, 29);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "x";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // checkBlock
            // 
            this.checkBlock.AutoSize = true;
            this.checkBlock.Location = new System.Drawing.Point(414, 132);
            this.checkBlock.Name = "checkBlock";
            this.checkBlock.Size = new System.Drawing.Size(67, 24);
            this.checkBlock.TabIndex = 13;
            this.checkBlock.Text = "Block";
            this.checkBlock.UseVisualStyleBackColor = true;
            this.checkBlock.CheckedChanged += new System.EventHandler(this.checkBlock_CheckedChanged);
            // 
            // formTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBlock);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAllLeft);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonAllRight);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.listReplace);
            this.Controls.Add(this.listAdd);
            this.Controls.Add(this.comboBoxPilih);
            this.Controls.Add(this.textBoxIsi);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelData);
            this.Name = "formTugas";
            this.Text = "Form Tugas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelData;
        private Label labelMode;
        private TextBox textBoxIsi;
        private ComboBox comboBoxPilih;
        private ListBox listAdd;
        private ListBox listReplace;
        private Button btnProses;
        private Button buttonAllRight;
        private Button buttonRight;
        private Button buttonLeft;
        private Button buttonAllLeft;
        private Button buttonDelete;
        private CheckBox checkBlock;
    }
}