
namespace Ricardo_Assignment3_002
{
    partial class BankAccountApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_Amount = new System.Windows.Forms.Label();
            this.lb_balance = new System.Windows.Forms.Label();
            this.lb_balance_value = new System.Windows.Forms.Label();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.tx_amount = new System.Windows.Forms.TextBox();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.gp_details = new System.Windows.Forms.GroupBox();
            this.gp_buttons = new System.Windows.Forms.GroupBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.lb_string = new System.Windows.Forms.Label();
            this.gp_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(288, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Account  App";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_name.Location = new System.Drawing.Point(101, 152);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(54, 17);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Name:";
            // 
            // lb_Amount
            // 
            this.lb_Amount.AutoSize = true;
            this.lb_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Amount.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_Amount.Location = new System.Drawing.Point(88, 199);
            this.lb_Amount.Name = "lb_Amount";
            this.lb_Amount.Size = new System.Drawing.Size(67, 17);
            this.lb_Amount.TabIndex = 2;
            this.lb_Amount.Text = "Amount:";
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_balance.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_balance.Location = new System.Drawing.Point(84, 235);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(71, 17);
            this.lb_balance.TabIndex = 3;
            this.lb_balance.Text = "Balance:";
            // 
            // lb_balance_value
            // 
            this.lb_balance_value.AutoSize = true;
            this.lb_balance_value.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_balance_value.Location = new System.Drawing.Point(218, 239);
            this.lb_balance_value.Name = "lb_balance_value";
            this.lb_balance_value.Size = new System.Drawing.Size(58, 13);
            this.lb_balance_value.TabIndex = 4;
            this.lb_balance_value.Text = "$ 0,000.00";
            // 
            // tx_name
            // 
            this.tx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_name.Location = new System.Drawing.Point(221, 152);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(219, 23);
            this.tx_name.TabIndex = 5;
            // 
            // tx_amount
            // 
            this.tx_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_amount.Location = new System.Drawing.Point(221, 199);
            this.tx_amount.Name = "tx_amount";
            this.tx_amount.Size = new System.Drawing.Size(100, 23);
            this.tx_amount.TabIndex = 6;
            this.tx_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_amount_KeyPress);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Location = new System.Drawing.Point(114, 43);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(75, 23);
            this.btn_Deposit.TabIndex = 7;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_withdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_withdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_withdraw.Location = new System.Drawing.Point(254, 43);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(75, 23);
            this.btn_withdraw.TabIndex = 8;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(541, 43);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // gp_details
            // 
            this.gp_details.ForeColor = System.Drawing.SystemColors.Window;
            this.gp_details.Location = new System.Drawing.Point(58, 119);
            this.gp_details.Name = "gp_details";
            this.gp_details.Size = new System.Drawing.Size(689, 161);
            this.gp_details.TabIndex = 10;
            this.gp_details.TabStop = false;
            this.gp_details.Text = "Account Details:";
            // 
            // gp_buttons
            // 
            this.gp_buttons.Controls.Add(this.btn_create);
            this.gp_buttons.Controls.Add(this.btn_close);
            this.gp_buttons.Controls.Add(this.btn_Deposit);
            this.gp_buttons.Controls.Add(this.btn_withdraw);
            this.gp_buttons.Location = new System.Drawing.Point(58, 315);
            this.gp_buttons.Name = "gp_buttons";
            this.gp_buttons.Size = new System.Drawing.Size(689, 100);
            this.gp_buttons.TabIndex = 11;
            this.gp_buttons.TabStop = false;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(390, 43);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(93, 23);
            this.btn_create.TabIndex = 10;
            this.btn_create.Text = "Create Account";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lb_string
            // 
            this.lb_string.AutoSize = true;
            this.lb_string.ForeColor = System.Drawing.Color.Yellow;
            this.lb_string.Location = new System.Drawing.Point(88, 442);
            this.lb_string.Name = "lb_string";
            this.lb_string.Size = new System.Drawing.Size(10, 13);
            this.lb_string.TabIndex = 12;
            this.lb_string.Text = ".";
            // 
            // BankAccountApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.lb_string);
            this.Controls.Add(this.tx_amount);
            this.Controls.Add(this.tx_name);
            this.Controls.Add(this.lb_balance_value);
            this.Controls.Add(this.lb_balance);
            this.Controls.Add(this.lb_Amount);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gp_details);
            this.Controls.Add(this.gp_buttons);
            this.Name = "BankAccountApp";
            this.Text = "CSIS-1175 - Bank Account";
            this.gp_buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_Amount;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Label lb_balance_value;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.TextBox tx_amount;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox gp_details;
        private System.Windows.Forms.GroupBox gp_buttons;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lb_string;
    }
}

