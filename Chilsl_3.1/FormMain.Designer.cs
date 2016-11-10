namespace Chilsl_3._1
{
    partial class Form_main
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
            this.components = new System.ComponentModel.Container();
            this.tb_x0 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tb_y0 = new System.Windows.Forms.TextBox();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_eps = new System.Windows.Forms.TextBox();
            this.lbl_caption = new System.Windows.Forms.Label();
            this.lbl_x0 = new System.Windows.Forms.Label();
            this.lbl_y0 = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_eps = new System.Windows.Forms.Label();
            this.btn_solve = new System.Windows.Forms.Button();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_x0
            // 
            this.tb_x0.Location = new System.Drawing.Point(175, 46);
            this.tb_x0.Name = "tb_x0";
            this.tb_x0.Size = new System.Drawing.Size(100, 20);
            this.tb_x0.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tb_y0
            // 
            this.tb_y0.Location = new System.Drawing.Point(175, 85);
            this.tb_y0.Name = "tb_y0";
            this.tb_y0.Size = new System.Drawing.Size(100, 20);
            this.tb_y0.TabIndex = 2;
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(175, 120);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(100, 20);
            this.tb_a.TabIndex = 3;
            this.tb_a.TextChanged += new System.EventHandler(this.tb_a_TextChanged);
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(175, 157);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(100, 20);
            this.tb_b.TabIndex = 4;
            this.tb_b.TextChanged += new System.EventHandler(this.tb_b_TextChanged);
            // 
            // tb_eps
            // 
            this.tb_eps.Location = new System.Drawing.Point(175, 195);
            this.tb_eps.Name = "tb_eps";
            this.tb_eps.Size = new System.Drawing.Size(100, 20);
            this.tb_eps.TabIndex = 5;
            this.tb_eps.TextChanged += new System.EventHandler(this.tb_eps_TextChanged);
            // 
            // lbl_caption
            // 
            this.lbl_caption.AutoSize = true;
            this.lbl_caption.Location = new System.Drawing.Point(122, 9);
            this.lbl_caption.Name = "lbl_caption";
            this.lbl_caption.Size = new System.Drawing.Size(361, 13);
            this.lbl_caption.TabIndex = 6;
            this.lbl_caption.Text = "Решение дифференциального уравнения y\'=x^2+y^2 методом Пикара";
            // 
            // lbl_x0
            // 
            this.lbl_x0.AutoSize = true;
            this.lbl_x0.Location = new System.Drawing.Point(12, 49);
            this.lbl_x0.Name = "lbl_x0";
            this.lbl_x0.Size = new System.Drawing.Size(120, 13);
            this.lbl_x0.TabIndex = 7;
            this.lbl_x0.Text = "Значение x0 (y(x0)=y0):";
            // 
            // lbl_y0
            // 
            this.lbl_y0.AutoSize = true;
            this.lbl_y0.Location = new System.Drawing.Point(12, 85);
            this.lbl_y0.Name = "lbl_y0";
            this.lbl_y0.Size = new System.Drawing.Size(72, 13);
            this.lbl_y0.TabIndex = 8;
            this.lbl_y0.Text = "Значение y0:";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(12, 120);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(117, 13);
            this.lbl_a.TabIndex = 9;
            this.lbl_a.Text = "Значение a (|x-x0|<=a):";
            this.lbl_a.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(12, 157);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(117, 13);
            this.lbl_b.TabIndex = 10;
            this.lbl_b.Text = "Значение b (|y-y0|<=b):";
            // 
            // lbl_eps
            // 
            this.lbl_eps.AutoSize = true;
            this.lbl_eps.Location = new System.Drawing.Point(12, 195);
            this.lbl_eps.Name = "lbl_eps";
            this.lbl_eps.Size = new System.Drawing.Size(147, 13);
            this.lbl_eps.TabIndex = 11;
            this.lbl_eps.Text = "Значение погрешности eps:";
            // 
            // btn_solve
            // 
            this.btn_solve.Location = new System.Drawing.Point(125, 239);
            this.btn_solve.Name = "btn_solve";
            this.btn_solve.Size = new System.Drawing.Size(75, 23);
            this.btn_solve.TabIndex = 12;
            this.btn_solve.Text = "Решить";
            this.btn_solve.UseVisualStyleBackColor = true;
            this.btn_solve.Click += new System.EventHandler(this.btn_solve_Click);
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(323, 66);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_output.Size = new System.Drawing.Size(315, 149);
            this.tb_output.TabIndex = 13;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(320, 46);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(55, 13);
            this.lbl_output.TabIndex = 14;
            this.lbl_output.Text = "Решение:";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 268);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.btn_solve);
            this.Controls.Add(this.lbl_eps);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.lbl_y0);
            this.Controls.Add(this.lbl_x0);
            this.Controls.Add(this.lbl_caption);
            this.Controls.Add(this.tb_eps);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.tb_y0);
            this.Controls.Add(this.tb_x0);
            this.Name = "Form_main";
            this.Text = "Метод Пикара";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_x0;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tb_y0;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_eps;
        private System.Windows.Forms.Label lbl_caption;
        private System.Windows.Forms.Label lbl_x0;
        private System.Windows.Forms.Label lbl_y0;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_eps;
        private System.Windows.Forms.Button btn_solve;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label lbl_output;
    }
}

