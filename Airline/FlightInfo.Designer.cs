
namespace Airline
{
    partial class FlightInfo
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
            this.departureText = new System.Windows.Forms.TextBox();
            this.arrivalTimeText = new System.Windows.Forms.TextBox();
            this.destinationText = new System.Windows.Forms.TextBox();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.flightNameText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seatsText = new System.Windows.Forms.TextBox();
            this.flightClassText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flightChargesText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flight Info";
            // 
            // departureText
            // 
            this.departureText.Location = new System.Drawing.Point(530, 47);
            this.departureText.Multiline = true;
            this.departureText.Name = "departureText";
            this.departureText.Size = new System.Drawing.Size(242, 29);
            this.departureText.TabIndex = 25;
            // 
            // arrivalTimeText
            // 
            this.arrivalTimeText.Location = new System.Drawing.Point(129, 196);
            this.arrivalTimeText.Multiline = true;
            this.arrivalTimeText.Name = "arrivalTimeText";
            this.arrivalTimeText.Size = new System.Drawing.Size(242, 29);
            this.arrivalTimeText.TabIndex = 24;
            // 
            // destinationText
            // 
            this.destinationText.Location = new System.Drawing.Point(129, 146);
            this.destinationText.Multiline = true;
            this.destinationText.Name = "destinationText";
            this.destinationText.Size = new System.Drawing.Size(242, 29);
            this.destinationText.TabIndex = 23;
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(129, 96);
            this.sourceText.Multiline = true;
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(242, 29);
            this.sourceText.TabIndex = 22;
            // 
            // flightNameText
            // 
            this.flightNameText.Location = new System.Drawing.Point(129, 47);
            this.flightNameText.Multiline = true;
            this.flightNameText.Name = "flightNameText";
            this.flightNameText.Size = new System.Drawing.Size(242, 29);
            this.flightNameText.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(414, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Departure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Arrival Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Flight Name";
            // 
            // seatsText
            // 
            this.seatsText.Location = new System.Drawing.Point(530, 198);
            this.seatsText.Multiline = true;
            this.seatsText.Name = "seatsText";
            this.seatsText.Size = new System.Drawing.Size(242, 29);
            this.seatsText.TabIndex = 29;
            // 
            // flightClassText
            // 
            this.flightClassText.Location = new System.Drawing.Point(530, 96);
            this.flightClassText.Multiline = true;
            this.flightClassText.Name = "flightClassText";
            this.flightClassText.Size = new System.Drawing.Size(242, 29);
            this.flightClassText.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(414, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Seats";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(414, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Flight Class";
            // 
            // flightChargesText
            // 
            this.flightChargesText.Location = new System.Drawing.Point(530, 146);
            this.flightChargesText.Multiline = true;
            this.flightChargesText.Name = "flightChargesText";
            this.flightChargesText.Size = new System.Drawing.Size(242, 29);
            this.flightChargesText.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(414, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Flight Charges";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add Flight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FlightInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flightChargesText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.seatsText);
            this.Controls.Add(this.flightClassText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.departureText);
            this.Controls.Add(this.arrivalTimeText);
            this.Controls.Add(this.destinationText);
            this.Controls.Add(this.sourceText);
            this.Controls.Add(this.flightNameText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FlightInfo";
            this.Text = "FlightInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox departureText;
        private System.Windows.Forms.TextBox arrivalTimeText;
        private System.Windows.Forms.TextBox destinationText;
        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.TextBox flightNameText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seatsText;
        private System.Windows.Forms.TextBox flightClassText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox flightChargesText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}