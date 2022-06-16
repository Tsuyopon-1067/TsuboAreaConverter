namespace 坪面積変換
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_1 = new System.Windows.Forms.Label();
            this.btn_act = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label_answer = new System.Windows.Forms.Label();
            this.btn_i = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_0 = new System.Windows.Forms.RadioButton();
            this.radio_1 = new System.Windows.Forms.RadioButton();
            this.radio_2 = new System.Windows.Forms.RadioButton();
            this.radio_3 = new System.Windows.Forms.RadioButton();
            this.radio_4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_1.Location = new System.Drawing.Point(49, 32);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(121, 25);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "↓坪数を入力";
            // 
            // btn_act
            // 
            this.btn_act.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_act.Location = new System.Drawing.Point(69, 124);
            this.btn_act.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_act.Name = "btn_act";
            this.btn_act.Size = new System.Drawing.Size(87, 45);
            this.btn_act.TabIndex = 1;
            this.btn_act.Text = "実行";
            this.btn_act.UseVisualStyleBackColor = true;
            this.btn_act.Click += new System.EventHandler(this.Btn_act_Click);
            // 
            // input
            // 
            this.input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.input.Location = new System.Drawing.Point(40, 71);
            this.input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(140, 36);
            this.input.TabIndex = 3;
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_answer.Location = new System.Drawing.Point(14, 172);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(0, 25);
            this.label_answer.TabIndex = 4;
            // 
            // btn_i
            // 
            this.btn_i.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_i.Location = new System.Drawing.Point(218, 71);
            this.btn_i.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_i.Name = "btn_i";
            this.btn_i.Size = new System.Drawing.Size(22, 38);
            this.btn_i.TabIndex = 5;
            this.btn_i.Text = "+";
            this.btn_i.UseVisualStyleBackColor = true;
            this.btn_i.Click += new System.EventHandler(this.Btn_i_Click);
            // 
            // btn_d
            // 
            this.btn_d.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_d.Location = new System.Drawing.Point(189, 71);
            this.btn_d.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(22, 38);
            this.btn_d.TabIndex = 6;
            this.btn_d.Text = "-";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.Btn_d_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(271, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "四捨五入オプション";
            // 
            // radio_0
            // 
            this.radio_0.AutoSize = true;
            this.radio_0.Checked = true;
            this.radio_0.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radio_0.Location = new System.Drawing.Point(276, 71);
            this.radio_0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_0.Name = "radio_0";
            this.radio_0.Size = new System.Drawing.Size(49, 19);
            this.radio_0.TabIndex = 8;
            this.radio_0.TabStop = true;
            this.radio_0.Text = "整数";
            this.radio_0.UseVisualStyleBackColor = true;
            // 
            // radio_1
            // 
            this.radio_1.AutoSize = true;
            this.radio_1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radio_1.Location = new System.Drawing.Point(276, 102);
            this.radio_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_1.Name = "radio_1";
            this.radio_1.Size = new System.Drawing.Size(98, 19);
            this.radio_1.TabIndex = 9;
            this.radio_1.Text = "小数第1位まで";
            this.radio_1.UseVisualStyleBackColor = true;
            // 
            // radio_2
            // 
            this.radio_2.AutoSize = true;
            this.radio_2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radio_2.Location = new System.Drawing.Point(276, 134);
            this.radio_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_2.Name = "radio_2";
            this.radio_2.Size = new System.Drawing.Size(98, 19);
            this.radio_2.TabIndex = 10;
            this.radio_2.Text = "小数第2位まで";
            this.radio_2.UseVisualStyleBackColor = true;
            // 
            // radio_3
            // 
            this.radio_3.AutoSize = true;
            this.radio_3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radio_3.Location = new System.Drawing.Point(276, 165);
            this.radio_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_3.Name = "radio_3";
            this.radio_3.Size = new System.Drawing.Size(98, 19);
            this.radio_3.TabIndex = 11;
            this.radio_3.Text = "小数第3位まで";
            this.radio_3.UseVisualStyleBackColor = true;
            // 
            // radio_4
            // 
            this.radio_4.AutoSize = true;
            this.radio_4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radio_4.Location = new System.Drawing.Point(276, 196);
            this.radio_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_4.Name = "radio_4";
            this.radio_4.Size = new System.Drawing.Size(98, 19);
            this.radio_4.TabIndex = 12;
            this.radio_4.Text = "小数第4位まで";
            this.radio_4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 251);
            this.Controls.Add(this.radio_4);
            this.Controls.Add(this.radio_3);
            this.Controls.Add(this.radio_2);
            this.Controls.Add(this.radio_1);
            this.Controls.Add(this.radio_0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_i);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.input);
            this.Controls.Add(this.btn_act);
            this.Controls.Add(this.label_1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "坪ってどのくらいの広さ？";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Button btn_act;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Button btn_i;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_0;
        private System.Windows.Forms.RadioButton radio_1;
        private System.Windows.Forms.RadioButton radio_2;
        private System.Windows.Forms.RadioButton radio_3;
        private System.Windows.Forms.RadioButton radio_4;
    }
}

