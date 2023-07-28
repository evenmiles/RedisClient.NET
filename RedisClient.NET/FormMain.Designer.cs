namespace RedisClient.NET
{
    partial class FormMain
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            splitContainer1 = new SplitContainer();
            buttonNewKey = new Button();
            buttonRefresh = new Button();
            buttonRemoveKeys = new Button();
            dataGridViewKeys = new DataGridView();
            ColumnKey = new DataGridViewTextBoxColumn();
            buttonConnect = new Button();
            label2 = new Label();
            label1 = new Label();
            textPort = new TextBox();
            textServer = new TextBox();
            radioButtonText = new RadioButton();
            radioButtonJSON = new RadioButton();
            textResult = new TextBox();
            textBoxKeySelected = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeys).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonNewKey);
            splitContainer1.Panel1.Controls.Add(buttonRefresh);
            splitContainer1.Panel1.Controls.Add(buttonRemoveKeys);
            splitContainer1.Panel1.Controls.Add(dataGridViewKeys);
            splitContainer1.Panel1.Controls.Add(buttonConnect);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(textPort);
            splitContainer1.Panel1.Controls.Add(textServer);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(radioButtonText);
            splitContainer1.Panel2.Controls.Add(radioButtonJSON);
            splitContainer1.Panel2.Controls.Add(textResult);
            splitContainer1.Panel2.Controls.Add(textBoxKeySelected);
            splitContainer1.Size = new Size(1058, 579);
            splitContainer1.SplitterDistance = 218;
            splitContainer1.TabIndex = 0;
            // 
            // buttonNewKey
            // 
            buttonNewKey.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonNewKey.Enabled = false;
            buttonNewKey.Location = new Point(12, 542);
            buttonNewKey.Name = "buttonNewKey";
            buttonNewKey.Size = new Size(100, 23);
            buttonNewKey.TabIndex = 8;
            buttonNewKey.Text = "Nueva entrada";
            buttonNewKey.UseVisualStyleBackColor = true;
            buttonNewKey.Click += ButtonNewKey_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRefresh.Enabled = false;
            buttonRefresh.Location = new Point(104, 100);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(100, 23);
            buttonRefresh.TabIndex = 7;
            buttonRefresh.Text = "Actualizar";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // buttonRemoveKeys
            // 
            buttonRemoveKeys.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRemoveKeys.Enabled = false;
            buttonRemoveKeys.Location = new Point(104, 542);
            buttonRemoveKeys.Name = "buttonRemoveKeys";
            buttonRemoveKeys.Size = new Size(100, 23);
            buttonRemoveKeys.TabIndex = 6;
            buttonRemoveKeys.Text = "Eliminar seleccionadas";
            buttonRemoveKeys.UseVisualStyleBackColor = true;
            buttonRemoveKeys.Click += ButtonRemoveKeys_Click;
            // 
            // dataGridViewKeys
            // 
            dataGridViewKeys.AllowUserToAddRows = false;
            dataGridViewKeys.AllowUserToResizeColumns = false;
            dataGridViewKeys.AllowUserToResizeRows = false;
            dataGridViewKeys.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewKeys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewKeys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKeys.Columns.AddRange(new DataGridViewColumn[] { ColumnKey });
            dataGridViewKeys.Enabled = false;
            dataGridViewKeys.Location = new Point(12, 129);
            dataGridViewKeys.Name = "dataGridViewKeys";
            dataGridViewKeys.ReadOnly = true;
            dataGridViewKeys.RowHeadersVisible = false;
            dataGridViewKeys.RowTemplate.Height = 25;
            dataGridViewKeys.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKeys.Size = new Size(192, 407);
            dataGridViewKeys.TabIndex = 5;
            dataGridViewKeys.SelectionChanged += DataGridViewKeys_SelectionChanged;
            // 
            // ColumnKey
            // 
            ColumnKey.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnKey.HeaderText = "Claves";
            ColumnKey.Name = "ColumnKey";
            ColumnKey.ReadOnly = true;
            ColumnKey.Resizable = DataGridViewTriState.False;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(12, 100);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(100, 23);
            buttonConnect.TabIndex = 4;
            buttonConnect.Text = "Conectar";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += ButtonConnect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Puerto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Servidor";
            // 
            // textPort
            // 
            textPort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textPort.Location = new Point(12, 71);
            textPort.Name = "textPort";
            textPort.Size = new Size(192, 23);
            textPort.TabIndex = 1;
            textPort.Text = "6379";
            // 
            // textServer
            // 
            textServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textServer.Location = new Point(12, 27);
            textServer.Name = "textServer";
            textServer.Size = new Size(192, 23);
            textServer.TabIndex = 0;
            textServer.Text = "localhost";
            // 
            // radioButtonText
            // 
            radioButtonText.AutoSize = true;
            radioButtonText.Location = new Point(62, 40);
            radioButtonText.Name = "radioButtonText";
            radioButtonText.Size = new Size(53, 19);
            radioButtonText.TabIndex = 4;
            radioButtonText.Text = "Texto";
            radioButtonText.UseVisualStyleBackColor = true;
            radioButtonText.CheckedChanged += RadioButtonText_CheckedChanged;
            // 
            // radioButtonJSON
            // 
            radioButtonJSON.AutoSize = true;
            radioButtonJSON.Checked = true;
            radioButtonJSON.Location = new Point(3, 40);
            radioButtonJSON.Name = "radioButtonJSON";
            radioButtonJSON.Size = new Size(53, 19);
            radioButtonJSON.TabIndex = 3;
            radioButtonJSON.TabStop = true;
            radioButtonJSON.Text = "JSON";
            radioButtonJSON.UseVisualStyleBackColor = true;
            radioButtonJSON.CheckedChanged += RadioButtonJSON_CheckedChanged;
            // 
            // textResult
            // 
            textResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textResult.Location = new Point(3, 71);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.ReadOnly = true;
            textResult.Size = new Size(828, 494);
            textResult.TabIndex = 2;
            // 
            // textBoxKeySelected
            // 
            textBoxKeySelected.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxKeySelected.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxKeySelected.Location = new Point(3, 11);
            textBoxKeySelected.Name = "textBoxKeySelected";
            textBoxKeySelected.ReadOnly = true;
            textBoxKeySelected.Size = new Size(828, 23);
            textBoxKeySelected.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 579);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "RedisClient.NET [Desconectado]";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeys).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox textServer;
        private Button buttonConnect;
        private Label label2;
        private Label label1;
        private TextBox textPort;
        private DataGridView dataGridViewKeys;
        private DataGridViewTextBoxColumn ColumnKey;
        private TextBox textBoxKeySelected;
        private TextBox textResult;
        private Button buttonRemoveKeys;
        private Button buttonRefresh;
        private Button buttonNewKey;
        private RadioButton radioButtonText;
        private RadioButton radioButtonJSON;
    }
}