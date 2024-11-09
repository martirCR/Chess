namespace Chess
{
    partial class UserInterface
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
            this.uxChessBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.uxTurnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxChessBoard
            // 
            this.uxChessBoard.Location = new System.Drawing.Point(0, 95);
            this.uxChessBoard.Name = "uxChessBoard";
            this.uxChessBoard.Size = new System.Drawing.Size(800, 354);
            this.uxChessBoard.TabIndex = 0;
            // 
            // uxTurnLabel
            // 
            this.uxTurnLabel.AutoSize = true;
            this.uxTurnLabel.Location = new System.Drawing.Point(610, 34);
            this.uxTurnLabel.Name = "uxTurnLabel";
            this.uxTurnLabel.Size = new System.Drawing.Size(50, 20);
            this.uxTurnLabel.TabIndex = 0;
            this.uxTurnLabel.Text = "White";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxTurnLabel);
            this.Controls.Add(this.uxChessBoard);
            this.Name = "UserInterface";
            this.Text = "Chess Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel uxChessBoard;
        private System.Windows.Forms.Label uxTurnLabel;
    }
}

