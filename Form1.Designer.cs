
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDaegu = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnDaegu
            // 
            this.btnDaegu.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDaegu.Location = new System.Drawing.Point(56, 82);
            this.btnDaegu.Name = "btnDaegu";
            this.btnDaegu.Size = new System.Drawing.Size(148, 123);
            this.btnDaegu.TabIndex = 0;
            this.btnDaegu.Text = "채용공고";
            this.btnDaegu.UseVisualStyleBackColor = true;
            this.btnDaegu.Click += new System.EventHandler(this.btnDaegu_Click);
            // 
            // btnCom
            // 
            this.btnCom.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCom.Location = new System.Drawing.Point(270, 82);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(148, 123);
            this.btnCom.TabIndex = 1;
            this.btnCom.Text = "취업공고";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(362, 21);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 280);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.btnDaegu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDaegu;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

