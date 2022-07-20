using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameForm.Text,
                    placeNumberForm.Text,
                    prizeAmountForm.Text,
                    prizePercentageForm.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                placeNameForm.Text = "";
                placeNumberForm.Text = "";
                prizeAmountForm.Text = "0";
                prizePercentageForm.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberForm.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameForm.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentrage = 0;
            bool prizeAmountValidNumber = decimal.TryParse(prizeAmountForm.Text, out prizeAmount);
            bool prizePercentageValidNumber = double.TryParse(prizePercentageForm.Text, out prizePercentrage);

            if (!prizeAmountValidNumber || !prizePercentageValidNumber)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentrage <= 0)
            {
                output = false;
            }

            if (prizePercentrage < 0 || prizePercentrage > 100)
            {
                output = false;
            }


            return output;
        }
    }
}
