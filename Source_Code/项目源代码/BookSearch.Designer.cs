
namespace BookAdmin
{
    partial class BookSearch
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
            this.components = new System.ComponentModel.Container();
            this.bookAdminDataSet = new BookAdmin.BookAdminDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new BookAdmin.BookAdminDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new BookAdmin.BookAdminDataSetTableAdapters.TableAdapterManager();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookAdminDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookAdminDataSet
            // 
            this.bookAdminDataSet.DataSetName = "BookAdminDataSet";
            this.bookAdminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.bookAdminDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.UpdateOrder = BookAdmin.BookAdminDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AutoGenerateColumns = false;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1});
            this.bookDataGridView.DataSource = this.bookBindingSource;
            this.bookDataGridView.Location = new System.Drawing.Point(0, 36);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.RowHeadersWidth = 62;
            this.bookDataGridView.RowTemplate.Height = 31;
            this.bookDataGridView.Size = new System.Drawing.Size(964, 415);
            this.bookDataGridView.TabIndex = 1;
            this.bookDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookId";
            this.dataGridViewTextBoxColumn1.HeaderText = "BookId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn2.HeaderText = "Author";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn3.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Categories";
            this.dataGridViewTextBoxColumn4.HeaderText = "Categories";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BookName";
            this.dataGridViewTextBoxColumn5.HeaderText = "BookName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Cover";
            this.dataGridViewImageColumn1.HeaderText = "Cover";
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1120, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(1002, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 41);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bookBindingSource, "Cover", true));
            this.pictureBox1.Location = new System.Drawing.Point(1002, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(1002, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(209, 29);
            this.textBox2.TabIndex = 5;
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookDataGridView);
            this.Name = "BookSearch";
            this.Text = "书籍检索（点击图片可以打开书籍）";
            this.Load += new System.EventHandler(this.BookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookAdminDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookAdmin.BookAdminDataSet bookAdminDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BookAdmin.BookAdminDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private BookAdmin.BookAdminDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}