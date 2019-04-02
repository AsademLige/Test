namespace Test
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
            this.UpBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.RigthBtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Mover = new Mover_C.TCircleMover();
            this.SuspendLayout();
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(355, 338);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(75, 37);
            this.UpBtn.TabIndex = 1;
            this.UpBtn.Text = "Up";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // LeftBtn
            // 
            this.LeftBtn.Location = new System.Drawing.Point(274, 381);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(75, 37);
            this.LeftBtn.TabIndex = 2;
            this.LeftBtn.Text = "Rigth";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // RigthBtn
            // 
            this.RigthBtn.Location = new System.Drawing.Point(436, 381);
            this.RigthBtn.Name = "RigthBtn";
            this.RigthBtn.Size = new System.Drawing.Size(75, 37);
            this.RigthBtn.TabIndex = 3;
            this.RigthBtn.Text = "Rigth";
            this.RigthBtn.UseVisualStyleBackColor = true;
            this.RigthBtn.Click += new System.EventHandler(this.RigthBtn_Click);
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(355, 381);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(75, 37);
            this.DownBtn.TabIndex = 4;
            this.DownBtn.Text = "Down";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(580, 17);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(198, 316);
            this.List.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mover
            // 
            this.Mover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mover.CircleSize = 150;
            this.Mover.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mover.Location = new System.Drawing.Point(231, 12);
            this.Mover.Name = "Mover";
            this.Mover.ObjColor = System.Drawing.Color.Red;
            this.Mover.Size = new System.Drawing.Size(343, 321);
            this.Mover.TabIndex = 0;
            this.Mover.X = 75;
            this.Mover.Y = 75;
            this.Mover.OnMoveleft += new Mover_C.TCircleMover.DelegateOnMoveleft(this.Mover_OnMoveleft);
            this.Mover.OnMoveRigth += new Mover_C.TCircleMover.DelegateOnMoveRigth(this.Mover_OnMoveRigth);
            this.Mover.OnMoveUp += new Mover_C.TCircleMover.DelegateOnMoveUp(this.Mover_OnMoveUp);
            this.Mover.OnMoveDown += new Mover_C.TCircleMover.DelegateOnMoveDown(this.Mover_OnMoveDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.List);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.RigthBtn);
            this.Controls.Add(this.LeftBtn);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.Mover);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Mover_C.TCircleMover Mover;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button RigthBtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button button1;
    }
}

