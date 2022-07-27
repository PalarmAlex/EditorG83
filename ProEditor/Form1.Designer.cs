
namespace ProEditor
{
  partial class frm_edit_prog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_edit_prog));
      this.label14 = new System.Windows.Forms.Label();
      this.txt_box_prog = new System.Windows.Forms.TextBox();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.but_save = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txt_XY = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txt_G = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txt_H2 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txt_H1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txt_H = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.txt_D = new System.Windows.Forms.TextBox();
      this.but_edit = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label13 = new System.Windows.Forms.Label();
      this.txt_Step = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.txt_End = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.txt_Start = new System.Windows.Forms.TextBox();
      this.txt_Z2 = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txt_Z1 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txt_F = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.txt_S = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.but_close = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(9, 367);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(99, 13);
      this.label14.TabIndex = 2;
      this.label14.Text = "Текст программы";
      // 
      // txt_box_prog
      // 
      this.txt_box_prog.Location = new System.Drawing.Point(12, 383);
      this.txt_box_prog.Multiline = true;
      this.txt_box_prog.Name = "txt_box_prog";
      this.txt_box_prog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txt_box_prog.Size = new System.Drawing.Size(383, 287);
      this.txt_box_prog.TabIndex = 4;
      // 
      // but_save
      // 
      this.but_save.Location = new System.Drawing.Point(93, 676);
      this.but_save.Name = "but_save";
      this.but_save.Size = new System.Drawing.Size(75, 23);
      this.but_save.TabIndex = 5;
      this.but_save.Text = "Сохранить";
      this.but_save.UseVisualStyleBackColor = true;
      this.but_save.Click += new System.EventHandler(this.but_save_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txt_G);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.txt_H2);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txt_H1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txt_H);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(205, 132);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Параметры цикла G83";
      // 
      // txt_XY
      // 
      this.txt_XY.Location = new System.Drawing.Point(228, 35);
      this.txt_XY.Multiline = true;
      this.txt_XY.Name = "txt_XY";
      this.txt_XY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txt_XY.Size = new System.Drawing.Size(167, 94);
      this.txt_XY.TabIndex = 9;
      this.txt_XY.Text = "X100 Y-200\r\nX-100 Y200";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(223, 12);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(86, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Координаты XY";
      // 
      // txt_G
      // 
      this.txt_G.Location = new System.Drawing.Point(146, 97);
      this.txt_G.Name = "txt_G";
      this.txt_G.Size = new System.Drawing.Size(50, 20);
      this.txt_G.TabIndex = 7;
      this.txt_G.Text = "20";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 104);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(102, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Общая глубина - G";
      // 
      // txt_H2
      // 
      this.txt_H2.Location = new System.Drawing.Point(146, 71);
      this.txt_H2.Name = "txt_H2";
      this.txt_H2.Size = new System.Drawing.Size(50, 20);
      this.txt_H2.TabIndex = 5;
      this.txt_H2.Text = "1";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 78);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Недоход - H2";
      // 
      // txt_H1
      // 
      this.txt_H1.Location = new System.Drawing.Point(146, 45);
      this.txt_H1.Name = "txt_H1";
      this.txt_H1.Size = new System.Drawing.Size(50, 20);
      this.txt_H1.TabIndex = 3;
      this.txt_H1.Text = "3";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(99, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Глубина шага - H1";
      // 
      // txt_H
      // 
      this.txt_H.Location = new System.Drawing.Point(146, 19);
      this.txt_H.Name = "txt_H";
      this.txt_H.Size = new System.Drawing.Size(50, 20);
      this.txt_H.TabIndex = 1;
      this.txt_H.Text = "5";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(119, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Начальная высота - H";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(6, 22);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(125, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Диаметр отверстий - D";
      // 
      // txt_D
      // 
      this.txt_D.Location = new System.Drawing.Point(146, 15);
      this.txt_D.Name = "txt_D";
      this.txt_D.Size = new System.Drawing.Size(50, 20);
      this.txt_D.TabIndex = 10;
      this.txt_D.Text = "6";
      // 
      // but_edit
      // 
      this.but_edit.Location = new System.Drawing.Point(12, 676);
      this.but_edit.Name = "but_edit";
      this.but_edit.Size = new System.Drawing.Size(75, 23);
      this.but_edit.TabIndex = 7;
      this.but_edit.Text = "Выполнить";
      this.but_edit.UseVisualStyleBackColor = true;
      this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label13);
      this.groupBox2.Controls.Add(this.txt_Step);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.txt_D);
      this.groupBox2.Controls.Add(this.txt_Z2);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.txt_Z1);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.txt_F);
      this.groupBox2.Controls.Add(this.label9);
      this.groupBox2.Controls.Add(this.txt_S);
      this.groupBox2.Controls.Add(this.label10);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox2.Location = new System.Drawing.Point(12, 150);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(205, 214);
      this.groupBox2.TabIndex = 8;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Параметры программы";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(6, 152);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(89, 13);
      this.label13.TabIndex = 15;
      this.label13.Text = "Шаг кадров - ST";
      // 
      // txt_Step
      // 
      this.txt_Step.Location = new System.Drawing.Point(146, 145);
      this.txt_Step.Name = "txt_Step";
      this.txt_Step.Size = new System.Drawing.Size(50, 20);
      this.txt_Step.TabIndex = 14;
      this.txt_Step.Text = "5";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(223, 269);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(84, 13);
      this.label12.TabIndex = 13;
      this.label12.Text = "Конечный блок";
      // 
      // txt_End
      // 
      this.txt_End.Location = new System.Drawing.Point(228, 285);
      this.txt_End.Multiline = true;
      this.txt_End.Name = "txt_End";
      this.txt_End.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txt_End.Size = new System.Drawing.Size(167, 79);
      this.txt_End.TabIndex = 12;
      this.txt_End.Text = "G00 Z[Z2]\r\nG80\r\nM05\r\nM30";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(225, 150);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(91, 13);
      this.label11.TabIndex = 11;
      this.label11.Text = "Начальный блок";
      // 
      // txt_Start
      // 
      this.txt_Start.Location = new System.Drawing.Point(228, 165);
      this.txt_Start.Multiline = true;
      this.txt_Start.Name = "txt_Start";
      this.txt_Start.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txt_Start.Size = new System.Drawing.Size(167, 98);
      this.txt_Start.TabIndex = 10;
      this.txt_Start.Text = "(StepMOTOReN - Esfero 3D)\r\n(TOOL 2 - DIA[D] DRILL)\r\nG90 G17 G40 G80 G00\r\nM06 T2\r\n" +
    "S[S] M03\r\nG00 G90 Z[Z1]\r\nZ10";
      // 
      // txt_Z2
      // 
      this.txt_Z2.Location = new System.Drawing.Point(146, 119);
      this.txt_Z2.Name = "txt_Z2";
      this.txt_Z2.Size = new System.Drawing.Size(50, 20);
      this.txt_Z2.TabIndex = 7;
      this.txt_Z2.Text = "10";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 126);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(109, 13);
      this.label7.TabIndex = 6;
      this.label7.Text = "Высота в конце - Z2";
      // 
      // txt_Z1
      // 
      this.txt_Z1.Location = new System.Drawing.Point(146, 93);
      this.txt_Z1.Name = "txt_Z1";
      this.txt_Z1.Size = new System.Drawing.Size(50, 20);
      this.txt_Z1.TabIndex = 5;
      this.txt_Z1.Text = "20";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(6, 100);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(114, 13);
      this.label8.TabIndex = 4;
      this.label8.Text = "Высота в начале - Z1";
      // 
      // txt_F
      // 
      this.txt_F.Location = new System.Drawing.Point(146, 67);
      this.txt_F.Name = "txt_F";
      this.txt_F.Size = new System.Drawing.Size(50, 20);
      this.txt_F.TabIndex = 3;
      this.txt_F.Text = "70";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(6, 74);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(59, 13);
      this.label9.TabIndex = 2;
      this.label9.Text = "Подача - F";
      // 
      // txt_S
      // 
      this.txt_S.Location = new System.Drawing.Point(146, 41);
      this.txt_S.Name = "txt_S";
      this.txt_S.Size = new System.Drawing.Size(50, 20);
      this.txt_S.TabIndex = 1;
      this.txt_S.Text = "3000";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(6, 48);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(121, 13);
      this.label10.TabIndex = 0;
      this.label10.Text = "Обороты шпинделя - S";
      // 
      // but_close
      // 
      this.but_close.Location = new System.Drawing.Point(320, 676);
      this.but_close.Name = "but_close";
      this.but_close.Size = new System.Drawing.Size(75, 23);
      this.but_close.TabIndex = 9;
      this.but_close.Text = "Закрыть";
      this.but_close.UseVisualStyleBackColor = true;
      this.but_close.Click += new System.EventHandler(this.but_close_Click);
      // 
      // frm_edit_prog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(400, 706);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txt_XY);
      this.Controls.Add(this.but_close);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.txt_Start);
      this.Controls.Add(this.but_edit);
      this.Controls.Add(this.txt_End);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.but_save);
      this.Controls.Add(this.txt_box_prog);
      this.Controls.Add(this.label14);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frm_edit_prog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Редактор программ сверления";
      this.Load += new System.EventHandler(this.frm_edit_prog_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_edit_prog_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox txt_box_prog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Button but_save;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txt_H;
    private System.Windows.Forms.TextBox txt_G;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txt_H2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txt_H1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button but_edit;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txt_XY;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txt_D;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txt_Z2;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txt_Z1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txt_F;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txt_S;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Button but_close;
    private System.Windows.Forms.TextBox txt_End;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txt_Start;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox txt_Step;
  }
}

