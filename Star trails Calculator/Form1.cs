using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_trails_Calculator
{
    public partial class Form1 : Form
    {
        double CameraFocalLength;
        double CropFactorSize;
        

        public Form1()
        {
            InitializeComponent();
        }

        //Textbox components
        private void FocalLengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check that the incoming input isn't any non-numeric char, a decimal, or the CTRL button
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void FocalLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            //Converts Focal Length entered by user to a double for calculation.
            string FocalLengthTextBoxValue = FocalLengthTextBox.Text;
            CameraFocalLength = Double.Parse(FocalLengthTextBoxValue);
        }

        private void UseCropSensor_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enables the crop sensor size combo box, depending on the state.
            //True = Crop sensor is used, False = Full frame is used
            if (UseCropSensor_State.SelectedItem.ToString() == "True")
            {
               CropFactor.Enabled = true;
            }
            else
            {
                    CropFactor.Enabled = false;
            }
            
        }

        private void CropFactor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CropFactorStringValue;

            //Each crop size, depending on what is selected
            //will be converted to a double for use in calculations.
            if (CropFactor.SelectedItem.ToString() == "1.5")
            {
                CropFactorStringValue = CropFactor.SelectedItem.ToString();
                CropFactorSize = Convert.ToDouble(CropFactorStringValue);
            }

            if (CropFactor.SelectedItem.ToString() == "1.6")
            {
                CropFactorStringValue = CropFactor.SelectedItem.ToString();
                CropFactorSize = Convert.ToDouble(CropFactorStringValue);
            }

            if (CropFactor.SelectedItem.ToString() == "2.0")
            {
                CropFactorStringValue = CropFactor.SelectedItem.ToString();
                CropFactorSize = Convert.ToDouble(CropFactorStringValue);
            }

            if (CropFactor.SelectedItem.ToString() == "2.7")
            {
                CropFactorStringValue = CropFactor.SelectedItem.ToString();
                CropFactorSize = Convert.ToDouble(CropFactorStringValue);
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double ExposureRule600, ExposureRule500;
            
            //Current bug: Accounting for empty string input on any of the inputs.
            //TODO: Check incoming input for null and empty.
            if(FocalLengthTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("One or more inputs are empty. Please try again.");
            }
            
            //For crop sensor calculations, depending on crop size
            if(UseCropSensor_State.SelectedItem.ToString() == "True" && FocalLengthTextBox.Text.Trim() != string.Empty)
            {
                if(PrintState.SelectedItem.ToString() == "True")
                {
                    ExposureRule600 = Math.Round(600.0 / (CameraFocalLength * CropFactorSize), 0, MidpointRounding.AwayFromZero);
                    MessageBox.Show("Exposure time for cropped sensors using the 600 Rule: " + ExposureRule600, "Resulting Exposure Time");
                }

                if(PrintState.SelectedItem.ToString() == "False")
                {
                    ExposureRule500 = Math.Round(500.0 / (CameraFocalLength * CropFactorSize), 0, MidpointRounding.AwayFromZero);
                    MessageBox.Show("Exposure time for cropped sensors using the 500 Rule: " + ExposureRule500, "Resulting Exposure Time");
                }
            }

            //For full frame calculations
            if(UseCropSensor_State.SelectedItem.ToString() == "False" && FocalLengthTextBox.Text.Trim() != string.Empty)
            {
                if (PrintState.SelectedItem.ToString() == "True")
                {
                    ExposureRule600 = Math.Round(600.0 / CameraFocalLength, 0, MidpointRounding.AwayFromZero);
                    MessageBox.Show("Exposure time for full frame sensors using the 600 Rule: " + ExposureRule600, "Resulting Exposure Time");
                }


                if (PrintState.SelectedItem.ToString() == "False")
                {
                    ExposureRule500 = Math.Round(500.0 / CameraFocalLength, 0, MidpointRounding.AwayFromZero);
                    MessageBox.Show("Exposure time for full frame sensors using the 500 Rule: " + ExposureRule500, "Resulting Exposure Time");
                }
            }

            
        }


    }
}
