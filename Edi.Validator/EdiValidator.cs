using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edi.Validator.Services;
using Newtonsoft.Json;

namespace Edi.Validator
{
    public partial class EdiValidator : Form
    {
        private readonly EdiNationClient ediNationClient;

        public EdiValidator()
        {
            this.ediNationClient = new EdiNationClient();
            InitializeComponent();
        }

        private void edi_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void edi_output_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(edi_output.Text) || !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                edi_output.Clear();
                textBox1.Clear();
            }

            if (string.IsNullOrWhiteSpace(edi_input.Text))
            {
                return;
            }

            var x12parsedOutput = await this.ediNationClient.ReadX12PayloadContent(edi_input.Text);

            if(x12parsedOutput == null)
            {
                edi_output.Text = "Failed to parse X12 payload due to malformed input payload.";
                return;
            }

            if(x12parsedOutput.Result.Status == "success")
            {
                edi_output.Text = "The X12 payload was successfully parsed.";
            }
            else
            {
                edi_output.Text = JsonConvert.SerializeObject(x12parsedOutput.Result, Formatting.Indented);
            }

            var x12validationOutput = await this.ediNationClient.ValidateX12Content(x12parsedOutput);

            if (x12validationOutput == default)
            {
                textBox1.Text = "Failed to validate the X12 payload due to malformed payload content.";
            }
            else
            {
                textBox1.Text = JsonConvert.SerializeObject(x12validationOutput, Formatting.Indented);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edi_input.Clear();
            edi_output.Clear();
            textBox1.Clear();
        }

        private void edi_output_response_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
