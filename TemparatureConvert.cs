using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class TemparatureConvert : Form
    {
        public TemparatureConvert()
        {
            InitializeComponent();
        }

        private void btnConvertFahrenheight_Click(object sender, EventArgs e)
        {
            ConvertFromFahrenheight();
        }

        //private void txtFahrenheightChange(object sender, EventArgs e)
        //{
        //    ConvertFromFahrenheight();
        //}

        private void btnConvertCelcious_Click(object sender, EventArgs e)
        {
            ConvertFromCelcious();
        }
        //private void txtCelcious_Change(object sender, EventArgs e)
        //{
        //    ConvertFromCelcious();
        //}

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            ConvertFromKelvin();
        }

        //private void txtKelvin_change(object sender, EventArgs e)
        //{
        //    ConvertFromKelvin();
        //}

        private void ConvertFromFahrenheight()
        {
            try
            {
                float f = (float)Convert.ToDouble(txtFahrenheight.Text);
                float c = (f - 32) * (5f / 9f);
                float k = c + 273;

                txtCelcious.Text = c.ToString();
                txtKelvin.Text = k.ToString();
            }
            catch
            {
                MessageBox.Show("Try only number!");
            }
        }

        private void ConvertFromCelcious()
        {
            try
            {
                float c = (float)Convert.ToDouble(txtCelcious.Text);
                float f = c * 9 / 5 + 32;
                float k = c + 273;

                txtFahrenheight.Text = f.ToString();
                txtKelvin.Text = k.ToString();
            }
            catch
            {
                MessageBox.Show("Try only number!");
            }
        }

        private void ConvertFromKelvin()
        {
            try
            {
                float k = (float)Convert.ToDouble(txtKelvin.Text);
                float c = k - 273;
                float f = c * 9 / 5 + 32;

                txtFahrenheight.Text = f.ToString();
                txtCelcious.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Try only number!");
            }
        }
    }
}
