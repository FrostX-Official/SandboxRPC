namespace SandboxRPC
{
    partial class SandboxRPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SandboxRPC));
            this.decoPanel = new System.Windows.Forms.Panel();
            this.statetext_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stateicon_list = new System.Windows.Forms.ListBox();
            this.title_label = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.exit_btn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.hide_btn = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // decoPanel
            // 
            this.decoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(112)))), ((int)(((byte)(253)))));
            this.decoPanel.Location = new System.Drawing.Point(0, 27);
            this.decoPanel.Name = "decoPanel";
            this.decoPanel.Size = new System.Drawing.Size(455, 3);
            this.decoPanel.TabIndex = 0;
            // 
            // statetext_text
            // 
            this.statetext_text.Location = new System.Drawing.Point(15, 52);
            this.statetext_text.Multiline = true;
            this.statetext_text.Name = "statetext_text";
            this.statetext_text.Size = new System.Drawing.Size(130, 121);
            this.statetext_text.TabIndex = 1;
            this.statetext_text.Text = "In editor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "state_text";
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.White;
            this.update_button.FlatAppearance.BorderSize = 0;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Location = new System.Drawing.Point(15, 191);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 3;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(169, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "state_icon";
            // 
            // stateicon_list
            // 
            this.stateicon_list.FormattingEnabled = true;
            this.stateicon_list.Items.AddRange(new object[] {
            "sandbox-dev-logo",
            "sandbox-server-logo"});
            this.stateicon_list.Location = new System.Drawing.Point(172, 52);
            this.stateicon_list.Name = "stateicon_list";
            this.stateicon_list.Size = new System.Drawing.Size(130, 121);
            this.stateicon_list.TabIndex = 5;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(5, 6);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(68, 13);
            this.title_label.TabIndex = 6;
            this.title_label.Text = "sandbox rpc.";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.decoPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.title_label;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this;
            this.bunifuDragControl3.Vertical = true;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Red;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.ForeColor = System.Drawing.Color.Red;
            this.exit_btn.Location = new System.Drawing.Point(426, 5);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(21, 18);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this.exit_btn;
            // 
            // hide_btn
            // 
            this.hide_btn.BackColor = System.Drawing.Color.LightGray;
            this.hide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_btn.ForeColor = System.Drawing.Color.LightGray;
            this.hide_btn.Location = new System.Drawing.Point(399, 5);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(21, 18);
            this.hide_btn.TabIndex = 8;
            this.hide_btn.UseVisualStyleBackColor = false;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 2;
            this.bunifuElipse2.TargetControl = this.hide_btn;
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "sandbox rpc";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(357, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 52);
            this.label3.TabIndex = 9;
            this.label3.Text = "by clicking gray \r\nbutton above\r\nyou will transform \r\napp into tray icon";
            // 
            // SandboxRPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(453, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hide_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.stateicon_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statetext_text);
            this.Controls.Add(this.decoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SandboxRPC";
            this.Text = "sandbox rpc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel decoPanel;
        private System.Windows.Forms.TextBox statetext_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox stateicon_list;
        private System.Windows.Forms.Label title_label;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Button hide_btn;
        private System.Windows.Forms.Button exit_btn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Label label3;
    }
}

