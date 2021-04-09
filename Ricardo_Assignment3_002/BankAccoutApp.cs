using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ricardo_Assignment3_002
{
    public partial class BankAccountApp : Form
    {


        private BankAccount newBankAccount;
        public BankAccountApp()
        {
            InitializeComponent();
            //Disable botton deposit and Withdraw , because when start dont neeed.
            btn_Deposit.Enabled = false;
            btn_withdraw.Enabled = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit Program?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        //Button Create Account
        private void btn_create_Click(object sender, EventArgs e)
        {


            try
            {
                if (tx_name.Text != "" || tx_amount.Text != "")
                {
                    // BankAccount nAccount = new BankAccount(tx_name.Text, Convert.ToDouble(tx_amount.Text));
                    //new DataAccount(tx_name.Text, Convert.ToDouble(tx_amount.Text);
                    newBankAccount = new BankAccount(tx_name.Text, Convert.ToDouble(tx_amount.Text));
                    lb_balance_value.Text = newBankAccount.getBalance().ToString("C");
                    //Show label on the button with resume operation. 
                    lb_string.Text = newBankAccount.ToString();
                }
                else
                {
                    MessageBox.Show("Enter with Value", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }
            finally
            {
                if (newBankAccount is null)
                {
                    MessageBox.Show("Invalid Value", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    //IF THE ACCOUNT IS CREATER ENABLE BUTTON AND HIDDEN BUTON CREATE ACCOUNT
                    tx_amount.Text = "";
                    btn_create.Visible = false;
                    btn_Deposit.Enabled = true;
                    btn_withdraw.Enabled = true;
                    MessageBox.Show("Account Created");
                }

            }


        }
        //Accept just number
        private void tx_amount_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }
        }

        // BUTTON DEPOSIT
        private void btn_Deposit_Click(object sender, EventArgs e)
        {

            try
            {

                if (tx_amount.Text != "")
                {
                    newBankAccount.deposit(Convert.ToDouble(tx_amount.Text));
                    lb_balance_value.Text = Convert.ToString(newBankAccount.getBalance().ToString("C"));
                    tx_amount.Text = "";

                    MessageBox.Show("Deposit Ok", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Show label on the button with resume operation.
                    lb_string.Text = newBankAccount.ToString();

                }
                else
                {
                    MessageBox.Show("Enter Value of Deposit", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tx_amount.Focus();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }

        }

        //button withdraw
        private void btn_withdraw_Click(object sender, EventArgs e)
        {

            try
            {
                if (tx_amount.Text != "")
                {
                    newBankAccount.withdraw(Convert.ToDouble(tx_amount.Text));
                    lb_balance_value.Text = Convert.ToString(newBankAccount.getBalance().ToString("C"));
                    tx_amount.Text = "";
                    //Show label on the button with resume operation.
                    lb_string.Text = newBankAccount.ToString();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetType().Name);

            }
        }
    }
}
