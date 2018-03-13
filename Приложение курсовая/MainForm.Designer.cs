namespace Приложение_курсовая
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_InOutPut = new System.Windows.Forms.TextBox();
            this.bt_Backspace = new System.Windows.Forms.Button();
            this.bt_ClearAll = new System.Windows.Forms.Button();
            this.bt_Negote = new System.Windows.Forms.Button();
            this.bt_Root = new System.Windows.Forms.Button();
            this.bt_Pow = new System.Windows.Forms.Button();
            this.bt_Multiple = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_DivideRevers = new System.Windows.Forms.Button();
            this.bt_Divide = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_Equal = new System.Windows.Forms.Button();
            this.bt_Sub = new System.Windows.Forms.Button();
            this.bt_Point = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_Mod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_InOutPut
            // 
            this.tb_InOutPut.Location = new System.Drawing.Point(15, 15);
            this.tb_InOutPut.Margin = new System.Windows.Forms.Padding(4);
            this.tb_InOutPut.MaxLength = 20;
            this.tb_InOutPut.Name = "tb_InOutPut";
            this.tb_InOutPut.ReadOnly = true;
            this.tb_InOutPut.Size = new System.Drawing.Size(200, 23);
            this.tb_InOutPut.TabIndex = 23;
            this.tb_InOutPut.TabStop = false;
            this.tb_InOutPut.Text = "0";
            this.tb_InOutPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_InOutPut.TextChanged += new System.EventHandler(this.tb_InOutPut_TextChanged);
            // 
            // bt_Backspace
            // 
            this.bt_Backspace.Location = new System.Drawing.Point(15, 45);
            this.bt_Backspace.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Backspace.Name = "bt_Backspace";
            this.bt_Backspace.Size = new System.Drawing.Size(36, 28);
            this.bt_Backspace.TabIndex = 22;
            this.bt_Backspace.Text = "←";
            this.bt_Backspace.UseVisualStyleBackColor = true;
            this.bt_Backspace.Click += new System.EventHandler(this.bt_Backspace_Click);
            // 
            // bt_ClearAll
            // 
            this.bt_ClearAll.Location = new System.Drawing.Point(56, 45);
            this.bt_ClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ClearAll.Name = "bt_ClearAll";
            this.bt_ClearAll.Size = new System.Drawing.Size(36, 28);
            this.bt_ClearAll.TabIndex = 1;
            this.bt_ClearAll.Text = "C";
            this.bt_ClearAll.UseVisualStyleBackColor = true;
            this.bt_ClearAll.Click += new System.EventHandler(this.bt_ClearAll_Click);
            // 
            // bt_Negote
            // 
            this.bt_Negote.Location = new System.Drawing.Point(97, 45);
            this.bt_Negote.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Negote.Name = "bt_Negote";
            this.bt_Negote.Size = new System.Drawing.Size(36, 28);
            this.bt_Negote.TabIndex = 2;
            this.bt_Negote.Text = "±";
            this.bt_Negote.UseVisualStyleBackColor = true;
            this.bt_Negote.Click += new System.EventHandler(this.bt_Negote_Click);
            // 
            // bt_Root
            // 
            this.bt_Root.Location = new System.Drawing.Point(179, 45);
            this.bt_Root.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Root.Name = "bt_Root";
            this.bt_Root.Size = new System.Drawing.Size(36, 28);
            this.bt_Root.TabIndex = 4;
            this.bt_Root.Text = "√";
            this.bt_Root.UseVisualStyleBackColor = true;
            this.bt_Root.Click += new System.EventHandler(this.bt_Root_Click);
            // 
            // bt_Pow
            // 
            this.bt_Pow.Location = new System.Drawing.Point(179, 78);
            this.bt_Pow.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Pow.Name = "bt_Pow";
            this.bt_Pow.Size = new System.Drawing.Size(36, 28);
            this.bt_Pow.TabIndex = 9;
            this.bt_Pow.Text = "x^y";
            this.bt_Pow.UseVisualStyleBackColor = true;
            this.bt_Pow.Click += new System.EventHandler(this.bt_Pow_Click);
            // 
            // bt_Multiple
            // 
            this.bt_Multiple.Location = new System.Drawing.Point(138, 45);
            this.bt_Multiple.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Multiple.Name = "bt_Multiple";
            this.bt_Multiple.Size = new System.Drawing.Size(36, 28);
            this.bt_Multiple.TabIndex = 3;
            this.bt_Multiple.Text = "*";
            this.bt_Multiple.UseVisualStyleBackColor = true;
            this.bt_Multiple.Click += new System.EventHandler(this.bt_Multiple_Click);
            // 
            // bt_9
            // 
            this.bt_9.Location = new System.Drawing.Point(97, 78);
            this.bt_9.Margin = new System.Windows.Forms.Padding(4);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(36, 28);
            this.bt_9.TabIndex = 7;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = true;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_8
            // 
            this.bt_8.Location = new System.Drawing.Point(56, 78);
            this.bt_8.Margin = new System.Windows.Forms.Padding(4);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(36, 28);
            this.bt_8.TabIndex = 6;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = true;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_7
            // 
            this.bt_7.Location = new System.Drawing.Point(15, 78);
            this.bt_7.Margin = new System.Windows.Forms.Padding(4);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(36, 28);
            this.bt_7.TabIndex = 5;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(138, 144);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(36, 28);
            this.bt_Add.TabIndex = 18;
            this.bt_Add.Text = "+";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(97, 144);
            this.bt_3.Margin = new System.Windows.Forms.Padding(4);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(36, 28);
            this.bt_3.TabIndex = 17;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(56, 144);
            this.bt_2.Margin = new System.Windows.Forms.Padding(4);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(36, 28);
            this.bt_2.TabIndex = 16;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(15, 144);
            this.bt_1.Margin = new System.Windows.Forms.Padding(4);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(36, 28);
            this.bt_1.TabIndex = 15;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_DivideRevers
            // 
            this.bt_DivideRevers.Location = new System.Drawing.Point(179, 111);
            this.bt_DivideRevers.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DivideRevers.Name = "bt_DivideRevers";
            this.bt_DivideRevers.Size = new System.Drawing.Size(36, 28);
            this.bt_DivideRevers.TabIndex = 14;
            this.bt_DivideRevers.Text = "1/x";
            this.bt_DivideRevers.UseVisualStyleBackColor = true;
            this.bt_DivideRevers.Click += new System.EventHandler(this.bt_DivideRevers_Click);
            // 
            // bt_Divide
            // 
            this.bt_Divide.Location = new System.Drawing.Point(138, 78);
            this.bt_Divide.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Divide.Name = "bt_Divide";
            this.bt_Divide.Size = new System.Drawing.Size(36, 28);
            this.bt_Divide.TabIndex = 8;
            this.bt_Divide.Text = "/";
            this.bt_Divide.UseVisualStyleBackColor = true;
            this.bt_Divide.Click += new System.EventHandler(this.bt_Divide_Click);
            // 
            // bt_6
            // 
            this.bt_6.Location = new System.Drawing.Point(97, 111);
            this.bt_6.Margin = new System.Windows.Forms.Padding(4);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(36, 28);
            this.bt_6.TabIndex = 12;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(56, 111);
            this.bt_5.Margin = new System.Windows.Forms.Padding(4);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(36, 28);
            this.bt_5.TabIndex = 11;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(15, 111);
            this.bt_4.Margin = new System.Windows.Forms.Padding(4);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(36, 28);
            this.bt_4.TabIndex = 10;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_Equal
            // 
            this.bt_Equal.Location = new System.Drawing.Point(179, 144);
            this.bt_Equal.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Equal.Name = "bt_Equal";
            this.bt_Equal.Size = new System.Drawing.Size(36, 61);
            this.bt_Equal.TabIndex = 0;
            this.bt_Equal.Text = "=";
            this.bt_Equal.UseVisualStyleBackColor = true;
            this.bt_Equal.Click += new System.EventHandler(this.bt_Equal_Click);
            // 
            // bt_Sub
            // 
            this.bt_Sub.Location = new System.Drawing.Point(138, 177);
            this.bt_Sub.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Sub.Name = "bt_Sub";
            this.bt_Sub.Size = new System.Drawing.Size(36, 28);
            this.bt_Sub.TabIndex = 21;
            this.bt_Sub.Text = "-";
            this.bt_Sub.UseVisualStyleBackColor = true;
            this.bt_Sub.Click += new System.EventHandler(this.bt_Sub_Click);
            // 
            // bt_Point
            // 
            this.bt_Point.Location = new System.Drawing.Point(97, 177);
            this.bt_Point.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Point.Name = "bt_Point";
            this.bt_Point.Size = new System.Drawing.Size(36, 28);
            this.bt_Point.TabIndex = 20;
            this.bt_Point.Text = ",";
            this.bt_Point.UseVisualStyleBackColor = true;
            this.bt_Point.Click += new System.EventHandler(this.bt_Point_Click);
            // 
            // bt_0
            // 
            this.bt_0.Location = new System.Drawing.Point(15, 177);
            this.bt_0.Margin = new System.Windows.Forms.Padding(4);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(77, 28);
            this.bt_0.TabIndex = 19;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = true;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // bt_Mod
            // 
            this.bt_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bt_Mod.Location = new System.Drawing.Point(138, 111);
            this.bt_Mod.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Mod.Name = "bt_Mod";
            this.bt_Mod.Size = new System.Drawing.Size(36, 28);
            this.bt_Mod.TabIndex = 13;
            this.bt_Mod.Text = "mod";
            this.bt_Mod.UseVisualStyleBackColor = true;
            this.bt_Mod.Click += new System.EventHandler(this.bt_Mod_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 212);
            this.Controls.Add(this.bt_Mod);
            this.Controls.Add(this.bt_Equal);
            this.Controls.Add(this.bt_Sub);
            this.Controls.Add(this.bt_Point);
            this.Controls.Add(this.bt_0);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.bt_DivideRevers);
            this.Controls.Add(this.bt_Divide);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_Pow);
            this.Controls.Add(this.bt_Multiple);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.bt_Root);
            this.Controls.Add(this.bt_Negote);
            this.Controls.Add(this.bt_ClearAll);
            this.Controls.Add(this.bt_Backspace);
            this.Controls.Add(this.tb_InOutPut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ОПЗ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Backspace;
        private System.Windows.Forms.Button bt_ClearAll;
        private System.Windows.Forms.Button bt_Negote;
        private System.Windows.Forms.Button bt_Root;
        private System.Windows.Forms.Button bt_Pow;
        private System.Windows.Forms.Button bt_Multiple;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_DivideRevers;
        private System.Windows.Forms.Button bt_Divide;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_Equal;
        private System.Windows.Forms.Button bt_Sub;
        private System.Windows.Forms.Button bt_Point;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_Mod;
        private System.Windows.Forms.TextBox tb_InOutPut;
    }
}

