namespace TextBookSupport
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            studentTbx = new TextBox();
            listStudent = new ListBox();
            studentBindingSource = new BindingSource(components);
            label1 = new Label();
            supportTbx = new TextBox();
            orderSumTbx = new TextBox();
            label2 = new Label();
            listOrder = new ListBox();
            studentOrderBindingSource = new BindingSource(components);
            booksTbx = new TextBox();
            booksLbx = new ListBox();
            textbookBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentOrderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textbookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // studentTbx
            // 
            studentTbx.Location = new Point(12, 12);
            studentTbx.Name = "studentTbx";
            studentTbx.Size = new Size(164, 23);
            studentTbx.TabIndex = 0;
            studentTbx.TextChanged += studentTbx_TextChanged;
            // 
            // listStudent
            // 
            listStudent.DataSource = studentBindingSource;
            listStudent.DisplayMember = "Name";
            listStudent.FormattingEnabled = true;
            listStudent.Location = new Point(12, 41);
            listStudent.Name = "listStudent";
            listStudent.Size = new Size(164, 304);
            listStudent.TabIndex = 1;
            listStudent.ValueMember = "StudentId";
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            studentBindingSource.CurrentChanged += studentBindingSource_CurrentChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 348);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 2;
            label1.Text = "Támogatási összérték:";
            // 
            // supportTbx
            // 
            supportTbx.Location = new Point(12, 366);
            supportTbx.Name = "supportTbx";
            supportTbx.Size = new Size(164, 23);
            supportTbx.TabIndex = 3;
            // 
            // orderSumTbx
            // 
            orderSumTbx.Location = new Point(12, 419);
            orderSumTbx.Name = "orderSumTbx";
            orderSumTbx.ReadOnly = true;
            orderSumTbx.Size = new Size(164, 23);
            orderSumTbx.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 401);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 4;
            label2.Text = "Rendelések összértéke:";
            // 
            // listOrder
            // 
            listOrder.DataSource = studentOrderBindingSource;
            listOrder.DisplayMember = "Title";
            listOrder.FormattingEnabled = true;
            listOrder.Location = new Point(201, 41);
            listOrder.Name = "listOrder";
            listOrder.Size = new Size(164, 304);
            listOrder.TabIndex = 6;
            listOrder.ValueMember = "OrderSk";
            // 
            // studentOrderBindingSource
            // 
            studentOrderBindingSource.DataSource = typeof(StudentOrder);
            // 
            // booksTbx
            // 
            booksTbx.Location = new Point(468, 12);
            booksTbx.Name = "booksTbx";
            booksTbx.Size = new Size(164, 23);
            booksTbx.TabIndex = 7;
            booksTbx.TextChanged += booksTbx_TextChanged;
            // 
            // booksLbx
            // 
            booksLbx.DataSource = textbookBindingSource;
            booksLbx.DisplayMember = "Title";
            booksLbx.FormattingEnabled = true;
            booksLbx.Location = new Point(468, 41);
            booksLbx.Name = "booksLbx";
            booksLbx.Size = new Size(164, 304);
            booksLbx.TabIndex = 8;
            booksLbx.ValueMember = "TextbookID";
            // 
            // textbookBindingSource
            // 
            textbookBindingSource.DataSource = typeof(Models.Textbook);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 419);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 401);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 11;
            label3.Text = "Támogatás forintonként:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 366);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 348);
            label4.Name = "label4";
            label4.Size = new Size(168, 15);
            label4.TabIndex = 9;
            label4.Text = "Hallgatói rendelések összérték:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(468, 366);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(164, 23);
            textBox3.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 348);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 13;
            label5.Text = "Hallgatóra jutó támogatás:";
            // 
            // button1
            // 
            button1.Location = new Point(397, 138);
            button1.Name = "button1";
            button1.Size = new Size(38, 23);
            button1.TabIndex = 15;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(397, 192);
            button2.Name = "button2";
            button2.Size = new Size(38, 23);
            button2.TabIndex = 16;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(booksLbx);
            Controls.Add(booksTbx);
            Controls.Add(listOrder);
            Controls.Add(orderSumTbx);
            Controls.Add(label2);
            Controls.Add(supportTbx);
            Controls.Add(label1);
            Controls.Add(listStudent);
            Controls.Add(studentTbx);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentOrderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)textbookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox studentTbx;
        private ListBox listStudent;
        private Label label1;
        private TextBox supportTbx;
        private TextBox orderSumTbx;
        private Label label2;
        private ListBox listOrder;
        private TextBox booksTbx;
        private ListBox booksLbx;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private BindingSource studentBindingSource;
        private BindingSource textbookBindingSource;
        private Button button1;
        private Button button2;
        private BindingSource studentOrderBindingSource;
    }
}
