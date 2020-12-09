
namespace Lab08
{
    partial class PrinterInfo
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
            this.tbPrinterInfo = new System.Windows.Forms.TextBox();
            this.btnAddPrinter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPrinterInfo
            // 
            this.tbPrinterInfo.Location = new System.Drawing.Point(46, 57);
            this.tbPrinterInfo.Multiline = true;
            this.tbPrinterInfo.Name = "tbPrinterInfo";
            this.tbPrinterInfo.ReadOnly = true;
            this.tbPrinterInfo.Size = new System.Drawing.Size(519, 331);
            this.tbPrinterInfo.TabIndex = 0;
            this.tbPrinterInfo.TextChanged += new System.EventHandler(this.tbPrinterInfo_TextChanged);
            // 
            // btnAddPrinter
            // 
            this.btnAddPrinter.Location = new System.Drawing.Point(610, 57);
            this.btnAddPrinter.Name = "btnAddPrinter";
            this.btnAddPrinter.Size = new System.Drawing.Size(110, 23);
            this.btnAddPrinter.TabIndex = 1;
            this.btnAddPrinter.Text = "Додати принтер";
            this.btnAddPrinter.UseVisualStyleBackColor = true;
            this.btnAddPrinter.Click += new System.EventHandler(this.btnAddPrinter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(610, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PrinterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPrinter);
            this.Controls.Add(this.tbPrinterInfo);
            this.MaximizeBox = false;
            this.Name = "PrinterInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrinterInfo;
        private System.Windows.Forms.Button btnAddPrinter;
        private System.Windows.Forms.Button btnClose;
    }
}

