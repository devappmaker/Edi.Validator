
namespace Edi.Validator
{
    partial class EdiValidator
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
            this.edi_input_payload = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.edi_input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.edi_output_response = new System.Windows.Forms.GroupBox();
            this.edi_output = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edi_input_payload.SuspendLayout();
            this.edi_output_response.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edi_input_payload
            // 
            this.edi_input_payload.Controls.Add(this.button2);
            this.edi_input_payload.Controls.Add(this.edi_input);
            this.edi_input_payload.Controls.Add(this.button1);
            this.edi_input_payload.Location = new System.Drawing.Point(12, 12);
            this.edi_input_payload.Name = "edi_input_payload";
            this.edi_input_payload.Size = new System.Drawing.Size(377, 534);
            this.edi_input_payload.TabIndex = 0;
            this.edi_input_payload.TabStop = false;
            this.edi_input_payload.Text = "Input";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(278, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // edi_input
            // 
            this.edi_input.Location = new System.Drawing.Point(7, 22);
            this.edi_input.Multiline = true;
            this.edi_input.Name = "edi_input";
            this.edi_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edi_input.Size = new System.Drawing.Size(364, 383);
            this.edi_input.TabIndex = 0;
            this.edi_input.TextChanged += new System.EventHandler(this.edi_input_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(7, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edi_output_response
            // 
            this.edi_output_response.Controls.Add(this.edi_output);
            this.edi_output_response.Location = new System.Drawing.Point(404, 12);
            this.edi_output_response.Name = "edi_output_response";
            this.edi_output_response.Size = new System.Drawing.Size(510, 268);
            this.edi_output_response.TabIndex = 1;
            this.edi_output_response.TabStop = false;
            this.edi_output_response.Text = "X12 Parsing Output";
            this.edi_output_response.Enter += new System.EventHandler(this.edi_output_response_Enter);
            // 
            // edi_output
            // 
            this.edi_output.Location = new System.Drawing.Point(6, 22);
            this.edi_output.Multiline = true;
            this.edi_output.Name = "edi_output";
            this.edi_output.ReadOnly = true;
            this.edi_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edi_output.Size = new System.Drawing.Size(498, 241);
            this.edi_output.TabIndex = 0;
            this.edi_output.TextChanged += new System.EventHandler(this.edi_output_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(498, 241);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(404, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "X12 Validation Output";
            // 
            // EdiValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.edi_output_response);
            this.Controls.Add(this.edi_input_payload);
            this.Name = "EdiValidator";
            this.Text = "EDI Validator";
            this.edi_input_payload.ResumeLayout(false);
            this.edi_input_payload.PerformLayout();
            this.edi_output_response.ResumeLayout(false);
            this.edi_output_response.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox edi_input_payload;
        private System.Windows.Forms.GroupBox edi_output_response;
        private System.Windows.Forms.TextBox edi_input;
        private System.Windows.Forms.TextBox edi_output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

