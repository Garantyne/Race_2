namespace Race_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxFromSC = new System.Windows.Forms.TextBox();
            this.textBoxFromPC = new System.Windows.Forms.TextBox();
            this.textBoxFromTruck = new System.Windows.Forms.TextBox();
            this.textBoxFromBus = new System.Windows.Forms.TextBox();
            this.SportCar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(395, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFromSC
            // 
            this.textBoxFromSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFromSC.Location = new System.Drawing.Point(93, 384);
            this.textBoxFromSC.Name = "textBoxFromSC";
            this.textBoxFromSC.Size = new System.Drawing.Size(100, 26);
            this.textBoxFromSC.TabIndex = 1;
            // 
            // textBoxFromPC
            // 
            this.textBoxFromPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFromPC.Location = new System.Drawing.Point(293, 384);
            this.textBoxFromPC.Name = "textBoxFromPC";
            this.textBoxFromPC.Size = new System.Drawing.Size(100, 26);
            this.textBoxFromPC.TabIndex = 2;
            // 
            // textBoxFromTruck
            // 
            this.textBoxFromTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFromTruck.Location = new System.Drawing.Point(690, 384);
            this.textBoxFromTruck.Name = "textBoxFromTruck";
            this.textBoxFromTruck.Size = new System.Drawing.Size(100, 26);
            this.textBoxFromTruck.TabIndex = 3;
            // 
            // textBoxFromBus
            // 
            this.textBoxFromBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFromBus.Location = new System.Drawing.Point(491, 384);
            this.textBoxFromBus.Name = "textBoxFromBus";
            this.textBoxFromBus.Size = new System.Drawing.Size(100, 26);
            this.textBoxFromBus.TabIndex = 4;
            // 
            // SportCar
            // 
            this.SportCar.AutoSize = true;
            this.SportCar.Location = new System.Drawing.Point(90, 351);
            this.SportCar.Name = "SportCar";
            this.SportCar.Size = new System.Drawing.Size(60, 16);
            this.SportCar.TabIndex = 5;
            this.SportCar.Text = "SportCar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "PasangerCar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buss";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Truck";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SportCar);
            this.Controls.Add(this.textBoxFromBus);
            this.Controls.Add(this.textBoxFromTruck);
            this.Controls.Add(this.textBoxFromPC);
            this.Controls.Add(this.textBoxFromSC);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxFromSC;
        private System.Windows.Forms.TextBox textBoxFromPC;
        private System.Windows.Forms.TextBox textBoxFromTruck;
        private System.Windows.Forms.TextBox textBoxFromBus;
        private System.Windows.Forms.Label SportCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

