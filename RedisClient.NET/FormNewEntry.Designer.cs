namespace RedisClient.NET
{
    partial class FormNewEntry
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
            buttonAccept = new Button();
            buttonCancel = new Button();
            textBoxKey = new TextBox();
            label1 = new Label();
            textBoxContent = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new Point(360, 415);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(75, 23);
            buttonAccept.TabIndex = 0;
            buttonAccept.Text = "Aceptar";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(441, 415);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxKey
            // 
            textBoxKey.Location = new Point(12, 27);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(504, 23);
            textBoxKey.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Clave";
            // 
            // textBoxContent
            // 
            textBoxContent.Location = new Point(12, 81);
            textBoxContent.Multiline = true;
            textBoxContent.Name = "textBoxContent";
            textBoxContent.Size = new Size(504, 328);
            textBoxContent.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Contenido";
            // 
            // FormNewEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(textBoxContent);
            Controls.Add(label1);
            Controls.Add(textBoxKey);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAccept);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNewEntry";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva entrada";
            TopMost = true;
            Load += FormNewEntry_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAccept;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        public TextBox textBoxKey;
        public TextBox textBoxContent;
    }
}