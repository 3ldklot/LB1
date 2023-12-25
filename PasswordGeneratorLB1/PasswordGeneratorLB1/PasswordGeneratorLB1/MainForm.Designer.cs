namespace PasswordGeneratorLB1
{
    partial class MainForm
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
            this.groupBoxGenParams = new System.Windows.Forms.GroupBox();
            this.labelPasswordLengthValue = new System.Windows.Forms.Label();
            this.labelPasswordLength = new System.Windows.Forms.Label();
            this.trackBarPasswordLength = new System.Windows.Forms.TrackBar();
            this.checkBoxUseUppercaseLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxUseLowercaseLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxUseDigits = new System.Windows.Forms.CheckBox();
            this.checkUseSpecialSymbols = new System.Windows.Forms.CheckBox();
            this.buttonGeneratePassword = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelGeneratedPassword = new System.Windows.Forms.Label();
            this.labelPasswordCopiedToClipboard = new System.Windows.Forms.Label();
            this.labelWarningMessageTitle = new System.Windows.Forms.Label();
            this.labelWarningMessage = new System.Windows.Forms.Label();
            this.textBoxGeneratedPassword = new System.Windows.Forms.TextBox();
            this.timerShowLabelCopiedToClipboard = new System.Windows.Forms.Timer(this.components);
            this.imageListDefault = new System.Windows.Forms.ImageList(this.components);
            this.toolTipForControl = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxGenParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGenParams
            // 
            this.groupBoxGenParams.Controls.Add(this.labelPasswordLengthValue);
            this.groupBoxGenParams.Controls.Add(this.labelPasswordLength);
            this.groupBoxGenParams.Controls.Add(this.trackBarPasswordLength);
            this.groupBoxGenParams.Controls.Add(this.checkBoxUseUppercaseLetters);
            this.groupBoxGenParams.Controls.Add(this.checkBoxUseLowercaseLetters);
            this.groupBoxGenParams.Controls.Add(this.checkBoxUseDigits);
            this.groupBoxGenParams.Controls.Add(this.checkUseSpecialSymbols);
            this.groupBoxGenParams.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGenParams.Name = "groupBoxGenParams";
            this.groupBoxGenParams.Size = new System.Drawing.Size(560, 171);
            this.groupBoxGenParams.TabIndex = 0;
            this.groupBoxGenParams.TabStop = false;
            this.groupBoxGenParams.Text = "Параметры генерации";
            // 
            // labelPasswordLengthValue
            // 
            this.labelPasswordLengthValue.AutoSize = true;
            this.labelPasswordLengthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordLengthValue.Location = new System.Drawing.Point(143, 118);
            this.labelPasswordLengthValue.Name = "labelPasswordLengthValue";
            this.labelPasswordLengthValue.Size = new System.Drawing.Size(23, 13);
            this.labelPasswordLengthValue.TabIndex = 6;
            this.labelPasswordLengthValue.Text = "##";
            // 
            // labelPasswordLength
            // 
            this.labelPasswordLength.AutoSize = true;
            this.labelPasswordLength.Location = new System.Drawing.Point(6, 118);
            this.labelPasswordLength.Name = "labelPasswordLength";
            this.labelPasswordLength.Size = new System.Drawing.Size(138, 13);
            this.labelPasswordLength.TabIndex = 5;
            this.labelPasswordLength.Text = "Длина пароля (символов)";
            // 
            // trackBarPasswordLength
            // 
            this.trackBarPasswordLength.Location = new System.Drawing.Point(184, 112);
            this.trackBarPasswordLength.Minimum = 5;
            this.trackBarPasswordLength.Name = "trackBarPasswordLength";
            this.trackBarPasswordLength.Size = new System.Drawing.Size(368, 45);
            this.trackBarPasswordLength.TabIndex = 4;
            this.trackBarPasswordLength.Value = 5;
            this.trackBarPasswordLength.ValueChanged += new System.EventHandler(this.trackBarPasswordLength_ValueChanged);
            // 
            // checkBoxUseUppercaseLetters
            // 
            this.checkBoxUseUppercaseLetters.AutoSize = true;
            this.checkBoxUseUppercaseLetters.Location = new System.Drawing.Point(9, 89);
            this.checkBoxUseUppercaseLetters.Name = "checkBoxUseUppercaseLetters";
            this.checkBoxUseUppercaseLetters.Size = new System.Drawing.Size(277, 17);
            this.checkBoxUseUppercaseLetters.TabIndex = 3;
            this.checkBoxUseUppercaseLetters.Text = "Использовать прописные латинские буквы: A - Z";
            this.checkBoxUseUppercaseLetters.UseVisualStyleBackColor = true;
            this.checkBoxUseUppercaseLetters.CheckedChanged += new System.EventHandler(this.checkBoxUseUppercaseLetters_CheckedChanged);
            // 
            // checkBoxUseLowercaseLetters
            // 
            this.checkBoxUseLowercaseLetters.AutoSize = true;
            this.checkBoxUseLowercaseLetters.Location = new System.Drawing.Point(9, 66);
            this.checkBoxUseLowercaseLetters.Name = "checkBoxUseLowercaseLetters";
            this.checkBoxUseLowercaseLetters.Size = new System.Drawing.Size(266, 17);
            this.checkBoxUseLowercaseLetters.TabIndex = 2;
            this.checkBoxUseLowercaseLetters.Text = "Использовать строчные латинские буквы: a - z";
            this.checkBoxUseLowercaseLetters.UseVisualStyleBackColor = true;
            this.checkBoxUseLowercaseLetters.CheckedChanged += new System.EventHandler(this.checkBoxUseLowercaseLetters_CheckedChanged);
            // 
            // checkBoxUseDigits
            // 
            this.checkBoxUseDigits.AutoSize = true;
            this.checkBoxUseDigits.Location = new System.Drawing.Point(9, 43);
            this.checkBoxUseDigits.Name = "checkBoxUseDigits";
            this.checkBoxUseDigits.Size = new System.Drawing.Size(163, 17);
            this.checkBoxUseDigits.TabIndex = 1;
            this.checkBoxUseDigits.Text = "Использовать цифры: 0 - 9";
            this.checkBoxUseDigits.UseVisualStyleBackColor = true;
            this.checkBoxUseDigits.CheckedChanged += new System.EventHandler(this.сheckBoxUseDigits_CheckedChanged);
            // 
            // checkUseSpecialSymbols
            // 
            this.checkUseSpecialSymbols.AutoSize = true;
            this.checkUseSpecialSymbols.Location = new System.Drawing.Point(9, 20);
            this.checkUseSpecialSymbols.Name = "checkUseSpecialSymbols";
            this.checkUseSpecialSymbols.Size = new System.Drawing.Size(336, 17);
            this.checkUseSpecialSymbols.TabIndex = 0;
            this.checkUseSpecialSymbols.Text = "Использовать символы: #  !  $  ;  _  ?  &&  ^  %  @  *  (  )  {  }  [  ]";
            this.checkUseSpecialSymbols.UseVisualStyleBackColor = true;
            this.checkUseSpecialSymbols.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonGeneratePassword
            // 
            this.buttonGeneratePassword.Location = new System.Drawing.Point(12, 199);
            this.buttonGeneratePassword.Name = "buttonGeneratePassword";
            this.buttonGeneratePassword.Size = new System.Drawing.Size(138, 23);
            this.buttonGeneratePassword.TabIndex = 1;
            this.buttonGeneratePassword.Text = "&Сгенерировать пароль";
            this.toolTipForControl.SetToolTip(this.buttonGeneratePassword, "Сгенерировать надёжный пароль с заданной длинной и используемыми символами");
            this.buttonGeneratePassword.UseVisualStyleBackColor = true;
            this.buttonGeneratePassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(461, 269);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "&Выход";
            this.toolTipForControl.SetToolTip(this.buttonExit, "Выйти из программы");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelGeneratedPassword
            // 
            this.labelGeneratedPassword.AutoSize = true;
            this.labelGeneratedPassword.Location = new System.Drawing.Point(156, 204);
            this.labelGeneratedPassword.Name = "labelGeneratedPassword";
            this.labelGeneratedPassword.Size = new System.Drawing.Size(141, 13);
            this.labelGeneratedPassword.TabIndex = 4;
            this.labelGeneratedPassword.Text = "Сгенерированный пароль:";
            // 
            // labelPasswordCopiedToClipboard
            // 
            this.labelPasswordCopiedToClipboard.AutoSize = true;
            this.labelPasswordCopiedToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordCopiedToClipboard.ForeColor = System.Drawing.Color.Green;
            this.labelPasswordCopiedToClipboard.Location = new System.Drawing.Point(300, 224);
            this.labelPasswordCopiedToClipboard.Name = "labelPasswordCopiedToClipboard";
            this.labelPasswordCopiedToClipboard.Size = new System.Drawing.Size(224, 13);
            this.labelPasswordCopiedToClipboard.TabIndex = 5;
            this.labelPasswordCopiedToClipboard.Text = "Пароль скопирован в буфер обмена";
            this.labelPasswordCopiedToClipboard.Visible = false;
            // 
            // labelWarningMessageTitle
            // 
            this.labelWarningMessageTitle.AutoSize = true;
            this.labelWarningMessageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarningMessageTitle.ForeColor = System.Drawing.Color.Black;
            this.labelWarningMessageTitle.Location = new System.Drawing.Point(84, 238);
            this.labelWarningMessageTitle.Name = "labelWarningMessageTitle";
            this.labelWarningMessageTitle.Size = new System.Drawing.Size(175, 13);
            this.labelWarningMessageTitle.TabIndex = 6;
            this.labelWarningMessageTitle.Text = "Проверка мощности пароля";
            this.labelWarningMessageTitle.Click += new System.EventHandler(this.labelWarningMessageTitle_Click);
            // 
            // labelWarningMessage
            // 
            this.labelWarningMessage.Cursor = System.Windows.Forms.Cursors.No;
            this.labelWarningMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWarningMessage.Location = new System.Drawing.Point(12, 255);
            this.labelWarningMessage.Name = "labelWarningMessage";
            this.labelWarningMessage.Size = new System.Drawing.Size(150, 23);
            this.labelWarningMessage.TabIndex = 7;
            this.labelWarningMessage.Text = "Увеличьте мощность пароля";
            this.labelWarningMessage.Click += new System.EventHandler(this.labelWarningMessage_Click);
            // 
            // textBoxGeneratedPassword
            // 
            this.textBoxGeneratedPassword.Location = new System.Drawing.Point(303, 201);
            this.textBoxGeneratedPassword.Name = "textBoxGeneratedPassword";
            this.textBoxGeneratedPassword.Size = new System.Drawing.Size(230, 20);
            this.textBoxGeneratedPassword.TabIndex = 8;
            // 
            // timerShowLabelCopiedToClipboard
            // 
            this.timerShowLabelCopiedToClipboard.Interval = 2000;
            this.timerShowLabelCopiedToClipboard.Tick += new System.EventHandler(this.timerShowLabelCopiedToClipboard_Tick);
            // 
            // imageListDefault
            // 
            this.imageListDefault.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListDefault.ImageSize = new System.Drawing.Size(24, 24);
            this.imageListDefault.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(179, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Пароль достаточно мощный";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonGeneratePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(584, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGeneratedPassword);
            this.Controls.Add(this.labelWarningMessage);
            this.Controls.Add(this.labelWarningMessageTitle);
            this.Controls.Add(this.labelPasswordCopiedToClipboard);
            this.Controls.Add(this.labelGeneratedPassword);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGeneratePassword);
            this.Controls.Add(this.groupBoxGenParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(9, 20);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мегагенератор паролей";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxGenParams.ResumeLayout(false);
            this.groupBoxGenParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGenParams;
        private System.Windows.Forms.Label labelPasswordLengthValue;
        private System.Windows.Forms.Label labelPasswordLength;
        private System.Windows.Forms.TrackBar trackBarPasswordLength;
        private System.Windows.Forms.CheckBox checkBoxUseUppercaseLetters;
        private System.Windows.Forms.CheckBox checkBoxUseLowercaseLetters;
        private System.Windows.Forms.CheckBox checkBoxUseDigits;
        private System.Windows.Forms.CheckBox checkUseSpecialSymbols;
        private System.Windows.Forms.Button buttonGeneratePassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelGeneratedPassword;
        private System.Windows.Forms.Label labelPasswordCopiedToClipboard;
        private System.Windows.Forms.Label labelWarningMessageTitle;
        private System.Windows.Forms.Label labelWarningMessage;
        private System.Windows.Forms.TextBox textBoxGeneratedPassword;
        private System.Windows.Forms.Timer timerShowLabelCopiedToClipboard;
        private System.Windows.Forms.ImageList imageListDefault;
        private System.Windows.Forms.ToolTip toolTipForControl;
        private System.Windows.Forms.Label label1;
    }
}

