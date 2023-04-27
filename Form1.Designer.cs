namespace secondtolast
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
            this.components = new System.ComponentModel.Container();
            this.btn_test = new System.Windows.Forms.Button();
            this.txt_test = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_BHappy = new System.Windows.Forms.TextBox();
            this.txt_CaptureRate = new System.Windows.Forms.TextBox();
            this.txt_Habitat = new System.Windows.Forms.TextBox();
            this.txt_GrowthRate = new System.Windows.Forms.TextBox();
            this.txt_EggGroup = new System.Windows.Forms.TextBox();
            this.lbl_BHappy = new System.Windows.Forms.Label();
            this.lbl_CaptureRate = new System.Windows.Forms.Label();
            this.lbl_Habitat = new System.Windows.Forms.Label();
            this.lbl_GrowthRate = new System.Windows.Forms.Label();
            this.lbl_EggGroup = new System.Windows.Forms.Label();
            this.lbl_FlavorText = new System.Windows.Forms.Label();
            this.rtx_FlavorText = new System.Windows.Forms.RichTextBox();
            this.txt_PokeID = new System.Windows.Forms.TextBox();
            this.ep_InputValidation = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep_InputValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(12, 12);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(94, 29);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "get spicies";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // txt_test
            // 
            this.txt_test.Location = new System.Drawing.Point(3, 145);
            this.txt_test.Name = "txt_test";
            this.txt_test.Size = new System.Drawing.Size(125, 27);
            this.txt_test.TabIndex = 1;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(134, 148);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(46, 20);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "name";
            this.lbl_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_BHappy
            // 
            this.txt_BHappy.Location = new System.Drawing.Point(3, 178);
            this.txt_BHappy.Name = "txt_BHappy";
            this.txt_BHappy.Size = new System.Drawing.Size(125, 27);
            this.txt_BHappy.TabIndex = 3;
            // 
            // txt_CaptureRate
            // 
            this.txt_CaptureRate.Location = new System.Drawing.Point(3, 214);
            this.txt_CaptureRate.Name = "txt_CaptureRate";
            this.txt_CaptureRate.Size = new System.Drawing.Size(125, 27);
            this.txt_CaptureRate.TabIndex = 4;
            // 
            // txt_Habitat
            // 
            this.txt_Habitat.Location = new System.Drawing.Point(3, 244);
            this.txt_Habitat.Name = "txt_Habitat";
            this.txt_Habitat.Size = new System.Drawing.Size(125, 27);
            this.txt_Habitat.TabIndex = 5;
            // 
            // txt_GrowthRate
            // 
            this.txt_GrowthRate.Location = new System.Drawing.Point(3, 277);
            this.txt_GrowthRate.Name = "txt_GrowthRate";
            this.txt_GrowthRate.Size = new System.Drawing.Size(125, 27);
            this.txt_GrowthRate.TabIndex = 6;
            // 
            // txt_EggGroup
            // 
            this.txt_EggGroup.Location = new System.Drawing.Point(3, 310);
            this.txt_EggGroup.Name = "txt_EggGroup";
            this.txt_EggGroup.Size = new System.Drawing.Size(125, 27);
            this.txt_EggGroup.TabIndex = 7;
            // 
            // lbl_BHappy
            // 
            this.lbl_BHappy.AutoSize = true;
            this.lbl_BHappy.Location = new System.Drawing.Point(134, 181);
            this.lbl_BHappy.Name = "lbl_BHappy";
            this.lbl_BHappy.Size = new System.Drawing.Size(110, 20);
            this.lbl_BHappy.TabIndex = 8;
            this.lbl_BHappy.Text = "base happiness";
            // 
            // lbl_CaptureRate
            // 
            this.lbl_CaptureRate.AutoSize = true;
            this.lbl_CaptureRate.Location = new System.Drawing.Point(134, 214);
            this.lbl_CaptureRate.Name = "lbl_CaptureRate";
            this.lbl_CaptureRate.Size = new System.Drawing.Size(89, 20);
            this.lbl_CaptureRate.TabIndex = 9;
            this.lbl_CaptureRate.Text = "capture rate";
            // 
            // lbl_Habitat
            // 
            this.lbl_Habitat.AutoSize = true;
            this.lbl_Habitat.Location = new System.Drawing.Point(134, 247);
            this.lbl_Habitat.Name = "lbl_Habitat";
            this.lbl_Habitat.Size = new System.Drawing.Size(56, 20);
            this.lbl_Habitat.TabIndex = 10;
            this.lbl_Habitat.Text = "habitat";
            // 
            // lbl_GrowthRate
            // 
            this.lbl_GrowthRate.AutoSize = true;
            this.lbl_GrowthRate.Location = new System.Drawing.Point(130, 280);
            this.lbl_GrowthRate.Name = "lbl_GrowthRate";
            this.lbl_GrowthRate.Size = new System.Drawing.Size(86, 20);
            this.lbl_GrowthRate.TabIndex = 11;
            this.lbl_GrowthRate.Text = "growth rate";
            // 
            // lbl_EggGroup
            // 
            this.lbl_EggGroup.AutoSize = true;
            this.lbl_EggGroup.Location = new System.Drawing.Point(134, 313);
            this.lbl_EggGroup.Name = "lbl_EggGroup";
            this.lbl_EggGroup.Size = new System.Drawing.Size(79, 20);
            this.lbl_EggGroup.TabIndex = 12;
            this.lbl_EggGroup.Text = "egg group";
            // 
            // lbl_FlavorText
            // 
            this.lbl_FlavorText.AutoSize = true;
            this.lbl_FlavorText.Location = new System.Drawing.Point(424, 87);
            this.lbl_FlavorText.Name = "lbl_FlavorText";
            this.lbl_FlavorText.Size = new System.Drawing.Size(105, 20);
            this.lbl_FlavorText.TabIndex = 14;
            this.lbl_FlavorText.Text = "one flavor text";
            // 
            // rtx_FlavorText
            // 
            this.rtx_FlavorText.Location = new System.Drawing.Point(321, 110);
            this.rtx_FlavorText.Name = "rtx_FlavorText";
            this.rtx_FlavorText.Size = new System.Drawing.Size(429, 157);
            this.rtx_FlavorText.TabIndex = 15;
            this.rtx_FlavorText.Text = "";
            // 
            // txt_PokeID
            // 
            this.txt_PokeID.Location = new System.Drawing.Point(112, 13);
            this.txt_PokeID.Name = "txt_PokeID";
            this.txt_PokeID.Size = new System.Drawing.Size(46, 27);
            this.txt_PokeID.TabIndex = 16;
            this.txt_PokeID.TextChanged += new System.EventHandler(this.txt_PokeID_TextChanged);
            this.txt_PokeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PokeID_KeyPress);
            this.txt_PokeID.Validating += new System.ComponentModel.CancelEventHandler(this.txt_PokeID_Validating);
            // 
            // ep_InputValidation
            // 
            this.ep_InputValidation.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_PokeID);
            this.Controls.Add(this.rtx_FlavorText);
            this.Controls.Add(this.lbl_FlavorText);
            this.Controls.Add(this.lbl_EggGroup);
            this.Controls.Add(this.lbl_GrowthRate);
            this.Controls.Add(this.lbl_Habitat);
            this.Controls.Add(this.lbl_CaptureRate);
            this.Controls.Add(this.lbl_BHappy);
            this.Controls.Add(this.txt_EggGroup);
            this.Controls.Add(this.txt_GrowthRate);
            this.Controls.Add(this.txt_Habitat);
            this.Controls.Add(this.txt_CaptureRate);
            this.Controls.Add(this.txt_BHappy);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_test);
            this.Controls.Add(this.btn_test);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_InputValidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_test;
        private TextBox txt_test;
        private Label lbl_Name;
        private TextBox txt_BHappy;
        private TextBox txt_CaptureRate;
        private TextBox txt_Habitat;
        private TextBox txt_GrowthRate;
        private TextBox txt_EggGroup;
        private Label lbl_BHappy;
        private Label lbl_CaptureRate;
        private Label lbl_Habitat;
        private Label lbl_GrowthRate;
        private Label lbl_EggGroup;
        private Label lbl_FlavorText;
        private RichTextBox rtx_FlavorText;
        private TextBox txt_PokeID;
        private ErrorProvider ep_InputValidation;
    }
}