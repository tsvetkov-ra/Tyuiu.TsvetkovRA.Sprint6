using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.TsvetkovRA.Sprint6.Task1.V14
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxСondition_CMV = new GroupBox();
            textBoxTask_CMV = new TextBox();
            pictureBoxFormula_CMV = new PictureBox();
            groupBoxInput_CMV = new GroupBox();
            labelStopValue_CMV = new Label();
            textBoxStopValue_CMV = new TextBox();
            labelStartValue_CMV = new Label();
            textBoxStartValue_CMV = new TextBox();
            buttonHelp_CMV = new Button();
            buttonDone_CMV = new Button();
            groupBoxOutput_CMV = new GroupBox();
            labelResult_CMV = new Label();
            textBoxResult_CMV = new TextBox();
            groupBoxСondition_CMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_CMV).BeginInit();
            groupBoxInput_CMV.SuspendLayout();
            groupBoxOutput_CMV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxСondition_CMV
            // 
            groupBoxСondition_CMV.Controls.Add(textBoxTask_CMV);
            groupBoxСondition_CMV.Controls.Add(pictureBoxFormula_CMV);
            groupBoxСondition_CMV.Location = new Point(23, 12);
            groupBoxСondition_CMV.Name = "groupBoxСondition_CMV";
            groupBoxСondition_CMV.Size = new Size(513, 310);
            groupBoxСondition_CMV.TabIndex = 6;
            groupBoxСondition_CMV.TabStop = false;
            groupBoxСondition_CMV.Tag = "";
            groupBoxСondition_CMV.Text = "Условие";
            // 
            // textBoxTask_CMV
            // 
            textBoxTask_CMV.BorderStyle = BorderStyle.None;
            textBoxTask_CMV.Location = new Point(6, 22);
            textBoxTask_CMV.Multiline = true;
            textBoxTask_CMV.Name = "textBoxTask_CMV";
            textBoxTask_CMV.ReadOnly = true;
            textBoxTask_CMV.Size = new Size(217, 145);
            textBoxTask_CMV.TabIndex = 0;
            textBoxTask_CMV.TabStop = false;
            textBoxTask_CMV.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вынести в виде таблицы.";
            // 
            // pictureBoxFormula_CMV
            // 
            pictureBoxFormula_CMV.Image = (System.Drawing.Image)resources.GetObject("pictureBoxFormula_CMV.Image");
            pictureBoxFormula_CMV.Location = new Point(268, 22);
            pictureBoxFormula_CMV.Name = "pictureBoxFormula_CMV";
            pictureBoxFormula_CMV.Size = new Size(192, 36);
            pictureBoxFormula_CMV.TabIndex = 1;
            pictureBoxFormula_CMV.TabStop = false;
            // 
            // groupBoxInput_CMV
            // 
            groupBoxInput_CMV.Controls.Add(labelStopValue_CMV);
            groupBoxInput_CMV.Controls.Add(textBoxStopValue_CMV);
            groupBoxInput_CMV.Controls.Add(labelStartValue_CMV);
            groupBoxInput_CMV.Controls.Add(textBoxStartValue_CMV);
            groupBoxInput_CMV.Location = new Point(23, 328);
            groupBoxInput_CMV.Name = "groupBoxInput_CMV";
            groupBoxInput_CMV.Size = new Size(296, 107);
            groupBoxInput_CMV.TabIndex = 7;
            groupBoxInput_CMV.TabStop = false;
            groupBoxInput_CMV.Text = "Ввод данных";
            // 
            // labelStopValue_CMV
            // 
            labelStopValue_CMV.AutoSize = true;
            labelStopValue_CMV.Location = new Point(148, 51);
            labelStopValue_CMV.Name = "labelStopValue_CMV";
            labelStopValue_CMV.Size = new Size(75, 15);
            labelStopValue_CMV.TabIndex = 8;
            labelStopValue_CMV.Text = "Конец шага:";
            // 
            // textBoxStopValue_CMV
            // 
            textBoxStopValue_CMV.Location = new Point(148, 72);
            textBoxStopValue_CMV.Name = "textBoxStopValue_CMV";
            textBoxStopValue_CMV.Size = new Size(117, 23);
            textBoxStopValue_CMV.TabIndex = 7;
            textBoxStopValue_CMV.Text = "5";
            // 
            // labelStartValue_CMV
            // 
            labelStartValue_CMV.AutoSize = true;
            labelStartValue_CMV.Location = new Point(6, 51);
            labelStartValue_CMV.Name = "labelStartValue_CMV";
            labelStartValue_CMV.Size = new Size(72, 15);
            labelStartValue_CMV.TabIndex = 6;
            labelStartValue_CMV.Text = "Старт шага:";
            // 
            // textBoxStartValue_CMV
            // 
            textBoxStartValue_CMV.Location = new Point(6, 72);
            textBoxStartValue_CMV.Name = "textBoxStartValue_CMV";
            textBoxStartValue_CMV.Size = new Size(126, 23);
            textBoxStartValue_CMV.TabIndex = 0;
            textBoxStartValue_CMV.Text = "-5";
            // 
            // buttonHelp_CMV
            // 
            buttonHelp_CMV.BackColor = SystemColors.Highlight;
            buttonHelp_CMV.Location = new Point(325, 344);
            buttonHelp_CMV.Name = "buttonHelp_CMV";
            buttonHelp_CMV.Size = new Size(84, 91);
            buttonHelp_CMV.TabIndex = 10;
            buttonHelp_CMV.Text = "Справка";
            buttonHelp_CMV.UseVisualStyleBackColor = false;
            buttonHelp_CMV.Click += buttonHelp_Click;
            // 
            // buttonDone_CMV
            // 
            buttonDone_CMV.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_CMV.Location = new Point(415, 344);
            buttonDone_CMV.Name = "buttonDone_CMV";
            buttonDone_CMV.Size = new Size(124, 91);
            buttonDone_CMV.TabIndex = 9;
            buttonDone_CMV.Text = "Выполнить";
            buttonDone_CMV.UseVisualStyleBackColor = false;
            buttonDone_CMV.Click += buttonDone_Click;
            // 
            // groupBoxOutput_CMV
            // 
            groupBoxOutput_CMV.Controls.Add(labelResult_CMV);
            groupBoxOutput_CMV.Controls.Add(textBoxResult_CMV);
            groupBoxOutput_CMV.Location = new Point(542, 12);
            groupBoxOutput_CMV.Name = "groupBoxOutput_CMV";
            groupBoxOutput_CMV.Size = new Size(240, 417);
            groupBoxOutput_CMV.TabIndex = 11;
            groupBoxOutput_CMV.TabStop = false;
            groupBoxOutput_CMV.Text = "Вывод данных";
            // 
            // labelResult_CMV
            // 
            labelResult_CMV.AutoSize = true;
            labelResult_CMV.Location = new Point(6, 31);
            labelResult_CMV.Name = "labelResult_CMV";
            labelResult_CMV.Size = new Size(63, 15);
            labelResult_CMV.TabIndex = 8;
            labelResult_CMV.Text = "Результат:";
            // 
            // textBoxResult_CMV
            // 
            textBoxResult_CMV.Font = new System.Drawing.Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_CMV.Location = new Point(6, 57);
            textBoxResult_CMV.Multiline = true;
            textBoxResult_CMV.Name = "textBoxResult_CMV";
            textBoxResult_CMV.ReadOnly = true;
            textBoxResult_CMV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CMV.Size = new Size(228, 354);
            textBoxResult_CMV.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 440);
            Controls.Add(groupBoxOutput_CMV);
            Controls.Add(groupBoxСondition_CMV);
            Controls.Add(groupBoxInput_CMV);
            Controls.Add(buttonHelp_CMV);
            Controls.Add(buttonDone_CMV);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Чигуров М. В. ";
            groupBoxСondition_CMV.ResumeLayout(false);
            groupBoxСondition_CMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_CMV).EndInit();
            groupBoxInput_CMV.ResumeLayout(false);
            groupBoxInput_CMV.PerformLayout();
            groupBoxOutput_CMV.ResumeLayout(false);
            groupBoxOutput_CMV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxСondition_CMV;
        private TextBox textBoxTask_CMV;
        private PictureBox pictureBoxFormula_CMV;
        private GroupBox groupBoxInput_CMV;
        private Label labelStartValue_CMV;
        private TextBox textBoxStartValue_CMV;
        private Button buttonHelp_CMV;
        private Button buttonDone_CMV;
        private Label labelStopValue_CMV;
        private TextBox textBoxStopValue_CMV;
        private GroupBox groupBoxOutput_CMV;
        private Label labelResult_CMV;
        private TextBox textBoxResult_CMV;
    }
}
