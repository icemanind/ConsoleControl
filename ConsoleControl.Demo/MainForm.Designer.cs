namespace ConsoleControl.Demo
{
    partial class MainForm
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
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbBlock = new System.Windows.Forms.RadioButton();
            this.rbUnderline = new System.Windows.Forms.RadioButton();
            this.btnMoveCursor = new System.Windows.Forms.Button();
            this.txtCursorColumn = new System.Windows.Forms.TextBox();
            this.txtCursorRow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnWriteMessage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBackgroundColor = new System.Windows.Forms.Panel();
            this.pnlForegroundColor = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.consoleControl2 = new ConsoleControl();
            this.consoleControl1 = new ConsoleControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearConsole.Location = new System.Drawing.Point(11, 388);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(625, 31);
            this.btnClearConsole.TabIndex = 1;
            this.btnClearConsole.Text = "Clear Console Screen";
            this.btnClearConsole.UseVisualStyleBackColor = true;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnMoveCursor);
            this.groupBox1.Controls.Add(this.txtCursorColumn);
            this.groupBox1.Controls.Add(this.txtCursorRow);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNone);
            this.groupBox2.Controls.Add(this.rbBlock);
            this.groupBox2.Controls.Add(this.rbUnderline);
            this.groupBox2.Location = new System.Drawing.Point(13, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cursor Type";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(138, 21);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 2;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // rbBlock
            // 
            this.rbBlock.AutoSize = true;
            this.rbBlock.Location = new System.Drawing.Point(84, 21);
            this.rbBlock.Name = "rbBlock";
            this.rbBlock.Size = new System.Drawing.Size(52, 17);
            this.rbBlock.TabIndex = 1;
            this.rbBlock.Text = "Block";
            this.rbBlock.UseVisualStyleBackColor = true;
            this.rbBlock.CheckedChanged += new System.EventHandler(this.rbBlock_CheckedChanged);
            // 
            // rbUnderline
            // 
            this.rbUnderline.AutoSize = true;
            this.rbUnderline.Checked = true;
            this.rbUnderline.Location = new System.Drawing.Point(12, 20);
            this.rbUnderline.Name = "rbUnderline";
            this.rbUnderline.Size = new System.Drawing.Size(70, 17);
            this.rbUnderline.TabIndex = 0;
            this.rbUnderline.TabStop = true;
            this.rbUnderline.Text = "Underline";
            this.rbUnderline.UseVisualStyleBackColor = true;
            this.rbUnderline.CheckedChanged += new System.EventHandler(this.rbUnderline_CheckedChanged);
            // 
            // btnMoveCursor
            // 
            this.btnMoveCursor.Location = new System.Drawing.Point(13, 66);
            this.btnMoveCursor.Name = "btnMoveCursor";
            this.btnMoveCursor.Size = new System.Drawing.Size(103, 23);
            this.btnMoveCursor.TabIndex = 4;
            this.btnMoveCursor.Text = "Move Cursor";
            this.btnMoveCursor.UseVisualStyleBackColor = true;
            this.btnMoveCursor.Click += new System.EventHandler(this.btnMoveCursor_Click);
            // 
            // txtCursorColumn
            // 
            this.txtCursorColumn.Location = new System.Drawing.Point(85, 43);
            this.txtCursorColumn.Name = "txtCursorColumn";
            this.txtCursorColumn.Size = new System.Drawing.Size(31, 20);
            this.txtCursorColumn.TabIndex = 3;
            // 
            // txtCursorRow
            // 
            this.txtCursorRow.Location = new System.Drawing.Point(85, 21);
            this.txtCursorRow.Name = "txtCursorRow";
            this.txtCursorRow.Size = new System.Drawing.Size(31, 20);
            this.txtCursorRow.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Column (0-79):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Row (0-24):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Text:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(330, 478);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(306, 20);
            this.txtMessage.TabIndex = 4;
            // 
            // btnWriteMessage
            // 
            this.btnWriteMessage.Location = new System.Drawing.Point(329, 501);
            this.btnWriteMessage.Name = "btnWriteMessage";
            this.btnWriteMessage.Size = new System.Drawing.Size(306, 43);
            this.btnWriteMessage.TabIndex = 5;
            this.btnWriteMessage.Text = "Write Text to Console Screen at Current Cursor Position Using The Default Colors";
            this.btnWriteMessage.UseVisualStyleBackColor = true;
            this.btnWriteMessage.Click += new System.EventHandler(this.btnWriteMessage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Background Color:";
            // 
            // pnlBackgroundColor
            // 
            this.pnlBackgroundColor.Location = new System.Drawing.Point(335, 430);
            this.pnlBackgroundColor.Name = "pnlBackgroundColor";
            this.pnlBackgroundColor.Size = new System.Drawing.Size(40, 20);
            this.pnlBackgroundColor.TabIndex = 7;
            this.pnlBackgroundColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackgroundColor_Paint);
            this.pnlBackgroundColor.DoubleClick += new System.EventHandler(this.pnlBackgroundColor_DoubleClick);
            // 
            // pnlForegroundColor
            // 
            this.pnlForegroundColor.Location = new System.Drawing.Point(335, 453);
            this.pnlForegroundColor.Name = "pnlForegroundColor";
            this.pnlForegroundColor.Size = new System.Drawing.Size(40, 20);
            this.pnlForegroundColor.TabIndex = 9;
            this.pnlForegroundColor.DoubleClick += new System.EventHandler(this.pnlForegroundColor_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Foreground Color:";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // consoleControl2
            // 
            this.consoleControl2.AllowInput = true;
            this.consoleControl2.BackColor = System.Drawing.Color.Black;
            this.consoleControl2.ConsoleBackgroundColor = System.Drawing.Color.Black;
            this.consoleControl2.ConsoleForegroundColor = System.Drawing.Color.LightGray;
            this.consoleControl2.CurrentBackgroundColor = System.Drawing.Color.Black;
            this.consoleControl2.CurrentForegroundColor = System.Drawing.Color.LightGray;
            this.consoleControl2.CursorType = CursorTypes.Underline;
            this.consoleControl2.EchoInput = true;
            this.consoleControl2.ForeColor = System.Drawing.Color.LightGray;
            this.consoleControl2.Location = new System.Drawing.Point(678, 6);
            this.consoleControl2.Name = "consoleControl2";
            this.consoleControl2.ShowCursor = true;
            this.consoleControl2.Size = new System.Drawing.Size(646, 377);
            this.consoleControl2.TabIndex = 10;
            this.consoleControl2.Enter += new System.EventHandler(this.consoleControl2_Enter);
            this.consoleControl2.Leave += new System.EventHandler(this.consoleControl2_Leave);
            // 
            // consoleControl1
            // 
            this.consoleControl1.AllowInput = true;
            this.consoleControl1.BackColor = System.Drawing.Color.Black;
            this.consoleControl1.ConsoleBackgroundColor = System.Drawing.Color.Black;
            this.consoleControl1.ConsoleForegroundColor = System.Drawing.Color.LightGray;
            this.consoleControl1.CurrentBackgroundColor = System.Drawing.Color.Black;
            this.consoleControl1.CurrentForegroundColor = System.Drawing.Color.LightGray;
            this.consoleControl1.CursorType = CursorTypes.Underline;
            this.consoleControl1.EchoInput = true;
            this.consoleControl1.ForeColor = System.Drawing.Color.LightGray;
            this.consoleControl1.Location = new System.Drawing.Point(6, 6);
            this.consoleControl1.Name = "consoleControl1";
            this.consoleControl1.ShowCursor = true;
            this.consoleControl1.Size = new System.Drawing.Size(646, 377);
            this.consoleControl1.TabIndex = 0;
            this.consoleControl1.Enter += new System.EventHandler(this.consoleControl1_Enter);
            this.consoleControl1.Leave += new System.EventHandler(this.consoleControl1_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 587);
            this.Controls.Add(this.consoleControl2);
            this.Controls.Add(this.pnlForegroundColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlBackgroundColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnWriteMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearConsole);
            this.Controls.Add(this.consoleControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Console Control Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsoleControl consoleControl1;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMoveCursor;
        private System.Windows.Forms.TextBox txtCursorColumn;
        private System.Windows.Forms.TextBox txtCursorRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbBlock;
        private System.Windows.Forms.RadioButton rbUnderline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnWriteMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlBackgroundColor;
        private System.Windows.Forms.Panel pnlForegroundColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private ConsoleControl consoleControl2;
    }
}

