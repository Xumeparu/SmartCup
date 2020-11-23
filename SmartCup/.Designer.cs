namespace SmartCup
{
    partial class Cup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cup));
            this.smartCupDataSet = new SmartCup.SmartCupDataSet();
            this.drinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drinksTableAdapter = new SmartCup.SmartCupDataSetTableAdapters.DrinksTableAdapter();
            this.tableAdapterManager = new SmartCup.SmartCupDataSetTableAdapters.TableAdapterManager();
            this.getCompote = new System.Windows.Forms.Button();
            this.getTea = new System.Windows.Forms.Button();
            this.getCoffee = new System.Windows.Forms.Button();
            this.getWater = new System.Windows.Forms.Button();
            this.drinksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replenishStock = new System.Windows.Forms.Button();
            this.temperatureTitle = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.smartCupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // smartCupDataSet
            // 
            this.smartCupDataSet.DataSetName = "SmartCupDataSet";
            this.smartCupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drinksBindingSource
            // 
            this.drinksBindingSource.DataMember = "Drinks";
            this.drinksBindingSource.DataSource = this.smartCupDataSet;
            // 
            // drinksTableAdapter
            // 
            this.drinksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DrinksTableAdapter = this.drinksTableAdapter;
            this.tableAdapterManager.UpdateOrder = SmartCup.SmartCupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // getCompote
            // 
            this.getCompote.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.getCompote.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.getCompote.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.getCompote.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.getCompote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getCompote.Location = new System.Drawing.Point(45, 44);
            this.getCompote.Name = "getCompote";
            this.getCompote.Size = new System.Drawing.Size(150, 50);
            this.getCompote.TabIndex = 2;
            this.getCompote.Text = "Compote";
            this.getCompote.UseVisualStyleBackColor = true;
            this.getCompote.Click += new System.EventHandler(this.getCompote_Click);
            // 
            // getTea
            // 
            this.getTea.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.getTea.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.getTea.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.getTea.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.getTea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getTea.Location = new System.Drawing.Point(45, 100);
            this.getTea.Name = "getTea";
            this.getTea.Size = new System.Drawing.Size(150, 50);
            this.getTea.TabIndex = 3;
            this.getTea.Text = "Tea";
            this.getTea.UseVisualStyleBackColor = true;
            this.getTea.Click += new System.EventHandler(this.getTea_Click);
            // 
            // getCoffee
            // 
            this.getCoffee.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.getCoffee.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.getCoffee.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.getCoffee.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.getCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getCoffee.Location = new System.Drawing.Point(45, 156);
            this.getCoffee.Name = "getCoffee";
            this.getCoffee.Size = new System.Drawing.Size(150, 50);
            this.getCoffee.TabIndex = 4;
            this.getCoffee.Text = "Coffee";
            this.getCoffee.UseVisualStyleBackColor = true;
            this.getCoffee.Click += new System.EventHandler(this.getCoffee_Click);
            // 
            // getWater
            // 
            this.getWater.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.getWater.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.getWater.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.getWater.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.getWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getWater.Location = new System.Drawing.Point(45, 212);
            this.getWater.Name = "getWater";
            this.getWater.Size = new System.Drawing.Size(150, 50);
            this.getWater.TabIndex = 5;
            this.getWater.Text = "Water";
            this.getWater.UseVisualStyleBackColor = true;
            this.getWater.Click += new System.EventHandler(this.getWater_Click);
            // 
            // drinksDataGridView
            // 
            this.drinksDataGridView.AllowUserToAddRows = false;
            this.drinksDataGridView.AllowUserToDeleteRows = false;
            this.drinksDataGridView.AutoGenerateColumns = false;
            this.drinksDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.drinksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drinksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drinksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.drinksDataGridView.DataSource = this.drinksBindingSource;
            this.drinksDataGridView.Location = new System.Drawing.Point(407, 44);
            this.drinksDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.drinksDataGridView.Name = "drinksDataGridView";
            this.drinksDataGridView.ReadOnly = true;
            this.drinksDataGridView.Size = new System.Drawing.Size(436, 218);
            this.drinksDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID drink";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID drink";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Drink";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn3.HeaderText = "Value, ml";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 143;
            // 
            // replenishStock
            // 
            this.replenishStock.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.replenishStock.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.replenishStock.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.replenishStock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.replenishStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replenishStock.Location = new System.Drawing.Point(45, 378);
            this.replenishStock.Name = "replenishStock";
            this.replenishStock.Size = new System.Drawing.Size(150, 71);
            this.replenishStock.TabIndex = 7;
            this.replenishStock.Text = "Replenish stock";
            this.replenishStock.UseVisualStyleBackColor = true;
            this.replenishStock.Click += new System.EventHandler(this.replenishStock_Click);
            // 
            // temperatureTitle
            // 
            this.temperatureTitle.AutoSize = true;
            this.temperatureTitle.Location = new System.Drawing.Point(403, 312);
            this.temperatureTitle.Name = "temperatureTitle";
            this.temperatureTitle.Size = new System.Drawing.Size(154, 24);
            this.temperatureTitle.TabIndex = 8;
            this.temperatureTitle.Text = "Temperature:";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Location = new System.Drawing.Point(563, 312);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(0, 24);
            this.temperature.TabIndex = 9;
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.exit.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(693, 399);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 50);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(41, 17);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 24);
            this.time.TabIndex = 11;
            // 
            // Cup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 493);
            this.ControlBox = false;
            this.Controls.Add(this.time);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.temperatureTitle);
            this.Controls.Add(this.replenishStock);
            this.Controls.Add(this.getWater);
            this.Controls.Add(this.getCoffee);
            this.Controls.Add(this.getTea);
            this.Controls.Add(this.getCompote);
            this.Controls.Add(this.drinksDataGridView);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Cup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cup";
            this.Load += new System.EventHandler(this.Cup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smartCupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SmartCupDataSet smartCupDataSet;
        private System.Windows.Forms.BindingSource drinksBindingSource;
        private SmartCupDataSetTableAdapters.DrinksTableAdapter drinksTableAdapter;
        private SmartCupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button getCompote;
        private System.Windows.Forms.Button getTea;
        private System.Windows.Forms.Button getCoffee;
        private System.Windows.Forms.Button getWater;
        private System.Windows.Forms.DataGridView drinksDataGridView;
        private System.Windows.Forms.Button replenishStock;
        private System.Windows.Forms.Label temperatureTitle;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label time;
    }
}