namespace AnyaProject
{
    partial class Piramida
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
            this.y1 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.y3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gradus = new System.Windows.Forms.TextBox();
            this.haight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.build2d = new System.Windows.Forms.Button();
            this.build3d = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(215, 39);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(100, 20);
            this.y1.TabIndex = 0;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(109, 39);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 20);
            this.x1.TabIndex = 1;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(109, 65);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 20);
            this.x2.TabIndex = 2;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(215, 65);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(100, 20);
            this.y2.TabIndex = 3;
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(109, 91);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(100, 20);
            this.x3.TabIndex = 4;
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(215, 91);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(100, 20);
            this.y3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Первая точка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вторая точка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Третья точка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Координата X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Координата Y";
            // 
            // gradus
            // 
            this.gradus.Location = new System.Drawing.Point(215, 155);
            this.gradus.Name = "gradus";
            this.gradus.Size = new System.Drawing.Size(100, 20);
            this.gradus.TabIndex = 11;
            this.gradus.Text = "0";
            // 
            // haight
            // 
            this.haight.Location = new System.Drawing.Point(109, 155);
            this.haight.Name = "haight";
            this.haight.Size = new System.Drawing.Size(100, 20);
            this.haight.TabIndex = 12;
            this.haight.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Выдавливание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Расстояние";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Угол наклона";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(157, 218);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(109, 20);
            this.fileName.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Название файла";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(125, 265);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 19;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(215, 265);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 20;
            this.load.Text = "Загрузить";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // build2d
            // 
            this.build2d.Location = new System.Drawing.Point(125, 305);
            this.build2d.Name = "build2d";
            this.build2d.Size = new System.Drawing.Size(165, 23);
            this.build2d.TabIndex = 21;
            this.build2d.Text = "Построить 2д";
            this.build2d.UseVisualStyleBackColor = true;
            this.build2d.Click += new System.EventHandler(this.build2d_Click);
            // 
            // build3d
            // 
            this.build3d.Location = new System.Drawing.Point(125, 334);
            this.build3d.Name = "build3d";
            this.build3d.Size = new System.Drawing.Size(165, 23);
            this.build3d.TabIndex = 22;
            this.build3d.Text = "Построить 3д";
            this.build3d.UseVisualStyleBackColor = true;
            this.build3d.Click += new System.EventHandler(this.build3d_Click);
            // 
            // Piramida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 387);
            this.Controls.Add(this.build3d);
            this.Controls.Add(this.build2d);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.haight);
            this.Controls.Add(this.gradus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.y1);
            this.Name = "Piramida";
            this.Text = "Piramida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.TextBox y3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gradus;
        private System.Windows.Forms.TextBox haight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button build2d;
        private System.Windows.Forms.Button build3d;
    }
}