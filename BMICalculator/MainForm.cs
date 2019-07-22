using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMI_Form : Form
    {
        public string outputString { get; set; }
        public bool decimalExists { get; set; }
        public TextBox activeLabel { get; set; }
        public BMI_Form()
        {
            InitializeComponent();
        }

        private void BMI_Form_Load(object sender, EventArgs e)
        {
            clearForm();
            lblResult.Visible = false;
            btnResult.Visible = false;

            numBoard.Visible = false;
            activeLabel = null;
            clearNumber();
        }

        private void Imperial_CheckedChanged(object sender, EventArgs e)
        {
            imperialUnit.Visible = true;
            metricUnit.Visible = false;
        }

        private void Metric_CheckedChanged(object sender, EventArgs e)
        {
            imperialUnit.Visible = false;
            metricUnit.Visible = true;

        }
        private void CalculateBMI_Click(object sender, EventArgs e)
        {
            numBoard.Visible = false;
            float weight;
            float height;
            float bmi;
            lblResult.Visible = true;
            btnResult.Visible = true;
            if (radioBtnImperial.Checked == true)
            {
                weight = float.Parse(inputPound.Text);
                height = float.Parse(inputInch.Text);
                bmi = (weight * 730) / (height * height);
                btnResult.Text = Math.Round(bmi, 2).ToString();
            }
            else if (radioBtnMetric.Checked == true)
            {
                weight = float.Parse(inputKg.Text);
                height = float.Parse(inputMeter.Text);
                bmi = (weight) / (height * height);
                btnResult.Text = Math.Round(bmi, 2).ToString();
            }
        }
        private void clearForm()
        {
            numBoard.Visible = false;
            radioBtnImperial.Checked = false;
            radioBtnMetric.Checked = false;
            inputMeter.Text = string.Empty;
            inputPound.Text = string.Empty;
            inputInch.Text = string.Empty;
            inputKg.Text = string.Empty;
            btnResult.Text = string.Empty;
            btnResult.Visible = false;
            lblResult.Visible = false;
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private void showButton(object sender, EventArgs e)
        {
            var theBtn = sender as Button;
            var tag = theBtn.Tag.ToString();
            bool result = int.TryParse(tag, out int btnValue);
            if (result)
            {
                int maxSize = 3;
                if (decimalExists)
                {
                    maxSize = 5;
                }

                if ((outputString != "0") && (activeLabel.Text.Count() < maxSize))
                {
                    outputString += tag;
                    activeLabel.Text += outputString;
                    //outputString += tag;
                    //activeLabel.Text += outputString;

                }
            }
            if (!result)
            {
                switch (tag)
                {
                    case "clear":
                        clearNumber();
                        break;
                    case "back":
                        removeLastCharacter();
                        break;
                    case "done":
                        finalizeOutput();
                        break;
                    case "decimal":
                        addDecimalToResultLabel();
                        break;
                }
            }
            outputString = "";
        }
        private void addDecimalToResultLabel()
        {
            if (!decimalExists)
            {
                outputString += ".";
               
                activeLabel.Text += outputString;

                decimalExists = true;
            }
        }
        private void finalizeOutput()
        {
            activeLabel.Text = float.Parse(outputString).ToString();
            activeLabel.BackColor = Color.White;
            activeLabel = null;
            numBoard.Visible = false;
            //decimalExists = false;
        }
       
        private void removeLastCharacter() 
        {
            if (outputString.Length > 0)
            {

                var lastChar = outputString.Substring(outputString.Length - 1);
                if (lastChar == ".")
                {
                    decimalExists = false;
                }
                outputString = outputString.Remove(outputString.Length - 1);
                if (outputString.Length == 0)
                {
                    outputString = string.Empty;
                }
                activeLabel.Text = outputString;
            }
        }
        
        ///
        /// <summary>
        /// </summary>
        private void clearNumber()
        {
            if (activeLabel != null)
            {
                activeLabel.Text = string.Empty;
                outputString = string.Empty;
                decimalExists = false;
            }
        }


        private void activeLabel_Click(object sender, EventArgs e)
        {

            if (activeLabel != null)
            {
                activeLabel.BackColor = Color.White;
                activeLabel = null;
            }
            activeLabel = sender as TextBox;

            CheckActiveLabelHasDecimal();

            activeLabel.BackColor = Color.LightBlue;
            numBoard.Visible = true;

        }

        private void CheckActiveLabelHasDecimal()
        {
            if (activeLabel.Text != null && activeLabel.Text.Contains('.') == true)
            {
                decimalExists = true;
            }
            else
            {
                decimalExists = false;
            }
        }

        private void BMI_Form_Click(object sender, EventArgs e)
        {
            if (activeLabel != null)
            {
                activeLabel.BackColor = Color.White;
            }
            activeLabel = null;
            numBoard.Visible = false;
           
        }

        
    }
}
