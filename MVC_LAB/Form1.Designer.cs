namespace MVC_LAB
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
            this.numericPointsCount = new System.Windows.Forms.NumericUpDown();
            this.update = new System.Windows.Forms.Button();
            this.matrixView = new System.Windows.Forms.DataGridView();
            this.findSolution = new System.Windows.Forms.Button();
            this.randFill = new System.Windows.Forms.Button();
            this.solutionsBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericPointsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).BeginInit();
            this.SuspendLayout();
            // 
            // numericPointsCount
            // 
            this.numericPointsCount.Location = new System.Drawing.Point(12, 12);
            this.numericPointsCount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericPointsCount.Name = "numericPointsCount";
            this.numericPointsCount.Size = new System.Drawing.Size(120, 22);
            this.numericPointsCount.TabIndex = 1;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(12, 40);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(120, 23);
            this.update.TabIndex = 2;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // matrixView
            // 
            this.matrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixView.ColumnHeadersVisible = false;
            this.matrixView.Location = new System.Drawing.Point(554, 8);
            this.matrixView.Name = "matrixView";
            this.matrixView.RowHeadersVisible = false;
            this.matrixView.RowHeadersWidth = 30;
            this.matrixView.RowTemplate.Height = 24;
            this.matrixView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixView.Size = new System.Drawing.Size(675, 696);
            this.matrixView.TabIndex = 3;
            this.matrixView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.matrixView_CellBeginEdit);
            this.matrixView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrixView_CellContentClick);
            this.matrixView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrixView_CellEndEdit);
            this.matrixView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.matrixView_CellValidating);
            this.matrixView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrixView_CellValueChanged);
            // 
            // findSolution
            // 
            this.findSolution.Location = new System.Drawing.Point(12, 99);
            this.findSolution.Name = "findSolution";
            this.findSolution.Size = new System.Drawing.Size(120, 23);
            this.findSolution.TabIndex = 4;
            this.findSolution.Text = "find solution";
            this.findSolution.UseVisualStyleBackColor = true;
            this.findSolution.Click += new System.EventHandler(this.findSolution_Click);
            // 
            // randFill
            // 
            this.randFill.Location = new System.Drawing.Point(13, 70);
            this.randFill.Name = "randFill";
            this.randFill.Size = new System.Drawing.Size(119, 23);
            this.randFill.TabIndex = 5;
            this.randFill.Text = "random fill";
            this.randFill.UseVisualStyleBackColor = true;
            this.randFill.Click += new System.EventHandler(this.randFill_Click);
            // 
            // solutionsBox
            // 
            this.solutionsBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solutionsBox.FormattingEnabled = true;
            this.solutionsBox.HorizontalScrollbar = true;
            this.solutionsBox.ItemHeight = 17;
            this.solutionsBox.Location = new System.Drawing.Point(13, 129);
            this.solutionsBox.Name = "solutionsBox";
            this.solutionsBox.Size = new System.Drawing.Size(535, 565);
            this.solutionsBox.TabIndex = 6;
            this.solutionsBox.SelectedIndexChanged += new System.EventHandler(this.solutionsBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 716);
            this.Controls.Add(this.solutionsBox);
            this.Controls.Add(this.randFill);
            this.Controls.Add(this.findSolution);
            this.Controls.Add(this.matrixView);
            this.Controls.Add(this.update);
            this.Controls.Add(this.numericPointsCount);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericPointsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericPointsCount;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView matrixView;
        private System.Windows.Forms.Button findSolution;
        private System.Windows.Forms.Button randFill;
        private System.Windows.Forms.ListBox solutionsBox;
    }
}

