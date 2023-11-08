namespace cs_json_indent
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
            splitContainer1 = new SplitContainer();
            textBoxInput = new TextBox();
            textBoxOutput = new TextBox();
            labelDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(0, 93);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBoxInput);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxOutput);
            splitContainer1.Size = new Size(1406, 672);
            splitContainer1.SplitterDistance = 467;
            splitContainer1.TabIndex = 0;
            // 
            // textBoxInput
            // 
            textBoxInput.AllowDrop = true;
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Location = new Point(0, 0);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(467, 672);
            textBoxInput.TabIndex = 0;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            textBoxInput.DragDrop += Control_DragDrop;
            textBoxInput.DragEnter += Control_DragEnter;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.Location = new Point(0, 0);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(935, 672);
            textBoxOutput.TabIndex = 0;
            // 
            // labelDescription
            // 
            labelDescription.AllowDrop = true;
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(17, 15);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(877, 75);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "以下の方法でJSON文字列を整形することができます。\r\n方法１：左のテキストボックスにJSON文字列を入力すると、右のテキストボックスに整形したJSON文字列が出力されます。\r\n方法２：JSONファイルをここにドラッグ＆ドロップすると整形したJSONファイルに変換します。";
            labelDescription.DragDrop += Control_DragDrop;
            labelDescription.DragEnter += Control_DragEnter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 765);
            Controls.Add(labelDescription);
            Controls.Add(splitContainer1);
            Name = "FormMain";
            Text = "JSONインデント整形";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private Label labelDescription;
    }
}