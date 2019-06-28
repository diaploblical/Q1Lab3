namespace QueryTable
{
    partial class QueryTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryTableForm));
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.booksEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksEntitiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.booksEntitiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.queryCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksEntitiesBindingNavigator)).BeginInit();
            this.booksEntitiesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputTxt
            // 
            this.outputTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTxt.Location = new System.Drawing.Point(0, 28);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTxt.Size = new System.Drawing.Size(537, 491);
            this.outputTxt.TabIndex = 0;
            // 
            // booksEntitiesBindingSource
            // 
            this.booksEntitiesBindingSource.DataSource = typeof(BooksLib.BooksEntities);
            // 
            // booksEntitiesBindingNavigator
            // 
            this.booksEntitiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.booksEntitiesBindingNavigator.BindingSource = this.booksEntitiesBindingSource;
            this.booksEntitiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.booksEntitiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.booksEntitiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.booksEntitiesBindingNavigatorSaveItem});
            this.booksEntitiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.booksEntitiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.booksEntitiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.booksEntitiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.booksEntitiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.booksEntitiesBindingNavigator.Name = "booksEntitiesBindingNavigator";
            this.booksEntitiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.booksEntitiesBindingNavigator.Size = new System.Drawing.Size(537, 25);
            this.booksEntitiesBindingNavigator.TabIndex = 1;
            this.booksEntitiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // booksEntitiesBindingNavigatorSaveItem
            // 
            this.booksEntitiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.booksEntitiesBindingNavigatorSaveItem.Enabled = false;
            this.booksEntitiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("booksEntitiesBindingNavigatorSaveItem.Image")));
            this.booksEntitiesBindingNavigatorSaveItem.Name = "booksEntitiesBindingNavigatorSaveItem";
            this.booksEntitiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.booksEntitiesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // queryCmb
            // 
            this.queryCmb.FormattingEnabled = true;
            this.queryCmb.Items.AddRange(new object[] {
            "Titles and authors sorted by title",
            "Titles and authors sorted by title, further sorted last name and first name",
            "Authors grouped by title, sorted by title, further sorted by last name and first " +
                "name"});
            this.queryCmb.Location = new System.Drawing.Point(0, 534);
            this.queryCmb.Name = "queryCmb";
            this.queryCmb.Size = new System.Drawing.Size(537, 21);
            this.queryCmb.TabIndex = 3;
            this.queryCmb.SelectedIndexChanged += new System.EventHandler(this.QueryCmb_SelectedIndexChanged);
            // 
            // QueryTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 607);
            this.Controls.Add(this.queryCmb);
            this.Controls.Add(this.booksEntitiesBindingNavigator);
            this.Controls.Add(this.outputTxt);
            this.Name = "QueryTableForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QueryTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksEntitiesBindingNavigator)).EndInit();
            this.booksEntitiesBindingNavigator.ResumeLayout(false);
            this.booksEntitiesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.BindingSource booksEntitiesBindingSource;
        private System.Windows.Forms.BindingNavigator booksEntitiesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton booksEntitiesBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox queryCmb;
    }
}

