namespace EFDay1
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
            DGV_Players = new DataGridView();
            txt_name = new TextBox();
            txt_position = new TextBox();
            txt_nationality = new TextBox();
            cb_team_name = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Players).BeginInit();
            SuspendLayout();
            // 
            // DGV_Players
            // 
            DGV_Players.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Players.Location = new Point(10, 250);
            DGV_Players.Name = "DGV_Players";
            DGV_Players.RowHeadersWidth = 51;
            DGV_Players.Size = new Size(786, 188);
            DGV_Players.TabIndex = 0;
            DGV_Players.CellContentClick += DGV_Players_CellContentClick;
            DGV_Players.RowHeaderMouseDoubleClick += DGV_Players_RowHeaderMouseDoubleClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(633, 3);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 1;
            txt_name.TextChanged += textBox1_TextChanged;
            // 
            // txt_position
            // 
            txt_position.Location = new Point(633, 42);
            txt_position.Name = "txt_position";
            txt_position.Size = new Size(125, 27);
            txt_position.TabIndex = 2;
            txt_position.TextChanged += textBox2_TextChanged;
            // 
            // txt_nationality
            // 
            txt_nationality.Location = new Point(633, 81);
            txt_nationality.Name = "txt_nationality";
            txt_nationality.Size = new Size(125, 27);
            txt_nationality.TabIndex = 3;
            txt_nationality.TextChanged += txt_nationality_TextChanged;
            // 
            // cb_team_name
            // 
            cb_team_name.FormattingEnabled = true;
            cb_team_name.Location = new Point(633, 123);
            cb_team_name.Name = "cb_team_name";
            cb_team_name.Size = new Size(125, 28);
            cb_team_name.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(550, 3);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 6;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 42);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 7;
            label2.Text = "position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 84);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 8;
            label3.Text = "nationality";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 126);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 9;
            label4.Text = "Team Name";
            // 
            // button1
            // 
            button1.Location = new Point(633, 171);
            button1.Name = "button1";
            button1.Size = new Size(125, 41);
            button1.TabIndex = 10;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(525, 177);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 11;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(428, 183);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_team_name);
            Controls.Add(txt_nationality);
            Controls.Add(txt_position);
            Controls.Add(txt_name);
            Controls.Add(DGV_Players);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Players).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_Players;
        private TextBox txt_name;
        private TextBox txt_position;
        private TextBox txt_nationality;
        private ComboBox cb_team_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button btn_update;
        private Button btn_delete;
    }
}
