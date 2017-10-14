namespace CalcularPerimetroFigura
{
    partial class CalculateFigure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateFigure));
            this.questionObject = new System.Windows.Forms.Label();
            this.kindFigure = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.imageFigure = new System.Windows.Forms.ImageList(this.components);
            this.pictureFigure = new System.Windows.Forms.PictureBox();
            this.resultKind = new System.Windows.Forms.Label();
            this.questionKindCalculate = new System.Windows.Forms.Label();
            this.selectCalculate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.resultValue = new System.Windows.Forms.Label();
            this.messageFail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // questionObject
            // 
            this.questionObject.AutoSize = true;
            this.questionObject.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionObject.Location = new System.Drawing.Point(12, 52);
            this.questionObject.Name = "questionObject";
            this.questionObject.Size = new System.Drawing.Size(269, 16);
            this.questionObject.TabIndex = 1;
            this.questionObject.Text = "Which is the figure you want to calculate?";
            // 
            // kindFigure
            // 
            this.kindFigure.FormattingEnabled = true;
            this.kindFigure.Items.AddRange(new object[] {
            "Rectangle",
            "Triangule",
            "Circule"});
            this.kindFigure.Location = new System.Drawing.Point(287, 52);
            this.kindFigure.Name = "kindFigure";
            this.kindFigure.Size = new System.Drawing.Size(121, 21);
            this.kindFigure.TabIndex = 2;
            this.kindFigure.SelectedIndexChanged += new System.EventHandler(this.KindFigure_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(124, 9);
            this.title.MinimumSize = new System.Drawing.Size(200, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 25);
            this.title.TabIndex = 3;
            this.title.Text = "Calculate Figure";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageFigure
            // 
            this.imageFigure.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageFigure.ImageStream")));
            this.imageFigure.TransparentColor = System.Drawing.Color.Transparent;
            this.imageFigure.Images.SetKeyName(0, "Circule.png");
            this.imageFigure.Images.SetKeyName(1, "rectangle.png");
            this.imageFigure.Images.SetKeyName(2, "triangule.png");
            // 
            // pictureFigure
            // 
            this.pictureFigure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureFigure.Enabled = false;
            this.pictureFigure.Location = new System.Drawing.Point(15, 103);
            this.pictureFigure.Name = "pictureFigure";
            this.pictureFigure.Size = new System.Drawing.Size(150, 200);
            this.pictureFigure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFigure.TabIndex = 4;
            this.pictureFigure.TabStop = false;
            this.pictureFigure.Visible = false;
            // 
            // resultKind
            // 
            this.resultKind.AutoSize = true;
            this.resultKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultKind.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultKind.Location = new System.Drawing.Point(15, 330);
            this.resultKind.Name = "resultKind";
            this.resultKind.Size = new System.Drawing.Size(71, 23);
            this.resultKind.TabIndex = 5;
            this.resultKind.Text = "KIND";
            this.resultKind.Visible = false;
            // 
            // questionKindCalculate
            // 
            this.questionKindCalculate.AutoSize = true;
            this.questionKindCalculate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionKindCalculate.Location = new System.Drawing.Point(171, 103);
            this.questionKindCalculate.Name = "questionKindCalculate";
            this.questionKindCalculate.Size = new System.Drawing.Size(269, 16);
            this.questionKindCalculate.TabIndex = 6;
            this.questionKindCalculate.Text = "What calculation do you want to perform?";
            this.questionKindCalculate.Visible = false;
            // 
            // selectCalculate
            // 
            this.selectCalculate.FormattingEnabled = true;
            this.selectCalculate.Items.AddRange(new object[] {
            "Area",
            "Perimeter"});
            this.selectCalculate.Location = new System.Drawing.Point(174, 133);
            this.selectCalculate.Name = "selectCalculate";
            this.selectCalculate.Size = new System.Drawing.Size(121, 21);
            this.selectCalculate.TabIndex = 7;
            this.selectCalculate.Visible = false;
            this.selectCalculate.SelectedIndexChanged += new System.EventHandler(this.SelectCalculate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Muestra1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Muestra2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Muestra3";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(308, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(308, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCalculate.Enabled = false;
            this.buttonCalculate.Location = new System.Drawing.Point(224, 280);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.TabIndex = 14;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Visible = false;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // resultValue
            // 
            this.resultValue.AutoSize = true;
            this.resultValue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.resultValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultValue.Location = new System.Drawing.Point(92, 330);
            this.resultValue.Name = "resultValue";
            this.resultValue.Size = new System.Drawing.Size(64, 24);
            this.resultValue.TabIndex = 15;
            this.resultValue.Text = "result";
            this.resultValue.UseWaitCursor = true;
            this.resultValue.Visible = false;
            // 
            // messageFail
            // 
            this.messageFail.AutoSize = true;
            this.messageFail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageFail.ForeColor = System.Drawing.Color.Red;
            this.messageFail.Location = new System.Drawing.Point(162, 330);
            this.messageFail.Name = "messageFail";
            this.messageFail.Size = new System.Drawing.Size(58, 15);
            this.messageFail.TabIndex = 16;
            this.messageFail.Text = "mistake";
            this.messageFail.Visible = false;
            // 
            // CalculateFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 375);
            this.Controls.Add(this.messageFail);
            this.Controls.Add(this.resultValue);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectCalculate);
            this.Controls.Add(this.questionKindCalculate);
            this.Controls.Add(this.resultKind);
            this.Controls.Add(this.pictureFigure);
            this.Controls.Add(this.title);
            this.Controls.Add(this.kindFigure);
            this.Controls.Add(this.questionObject);
            this.Name = "CalculateFigure";
            this.Text = "Calculate Figure Perimeter and Area";
            ((System.ComponentModel.ISupportInitialize)(this.pictureFigure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label questionObject;
        private System.Windows.Forms.ComboBox kindFigure;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ImageList imageFigure;
        private System.Windows.Forms.PictureBox pictureFigure;
        private System.Windows.Forms.Label resultKind;
        private System.Windows.Forms.Label questionKindCalculate;
        private System.Windows.Forms.ComboBox selectCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label resultValue;
        private System.Windows.Forms.Label messageFail;
    }
}

