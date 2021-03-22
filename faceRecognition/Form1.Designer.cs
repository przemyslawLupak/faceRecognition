
namespace faceRecognition
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.CaptureCamera = new System.Windows.Forms.PictureBox();
            this.CaptureButton = new System.Windows.Forms.Button();
            this.DetectionButton = new System.Windows.Forms.Button();
            this.PersonName = new System.Windows.Forms.TextBox();
            this.TrainButton = new System.Windows.Forms.Button();
            this.Detected = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptureCamera
            // 
            this.CaptureCamera.Location = new System.Drawing.Point(12, 115);
            this.CaptureCamera.Name = "CaptureCamera";
            this.CaptureCamera.Size = new System.Drawing.Size(776, 428);
            this.CaptureCamera.TabIndex = 0;
            this.CaptureCamera.TabStop = false;
            // 
            // CaptureButton
            // 
            this.CaptureButton.Location = new System.Drawing.Point(12, 24);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.Size = new System.Drawing.Size(97, 23);
            this.CaptureButton.TabIndex = 1;
            this.CaptureButton.Text = "Capture";
            this.CaptureButton.UseVisualStyleBackColor = true;
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // DetectionButton
            // 
            this.DetectionButton.Location = new System.Drawing.Point(12, 69);
            this.DetectionButton.Name = "DetectionButton";
            this.DetectionButton.Size = new System.Drawing.Size(97, 23);
            this.DetectionButton.TabIndex = 2;
            this.DetectionButton.Text = "Detection";
            this.DetectionButton.UseVisualStyleBackColor = true;
            this.DetectionButton.Click += new System.EventHandler(this.DetectionButton_Click);
            // 
            // PersonName
            // 
            this.PersonName.Location = new System.Drawing.Point(267, 26);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(123, 20);
            this.PersonName.TabIndex = 3;
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(267, 69);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(97, 23);
            this.TrainButton.TabIndex = 5;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // Detected
            // 
            this.Detected.Location = new System.Drawing.Point(127, 3);
            this.Detected.Name = "Detected";
            this.Detected.Size = new System.Drawing.Size(127, 106);
            this.Detected.TabIndex = 7;
            this.Detected.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(396, 24);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add person";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(499, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 96);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(656, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 96);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Detected);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.PersonName);
            this.Controls.Add(this.DetectionButton);
            this.Controls.Add(this.CaptureButton);
            this.Controls.Add(this.CaptureCamera);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CaptureCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CaptureCamera;
        private System.Windows.Forms.Button CaptureButton;
        private System.Windows.Forms.Button DetectionButton;
        private System.Windows.Forms.TextBox PersonName;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.PictureBox Detected;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

