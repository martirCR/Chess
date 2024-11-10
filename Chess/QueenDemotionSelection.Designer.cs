namespace Chess
{
    partial class QueenDemotionSelection
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
            uxBishop = new System.Windows.Forms.Button();
            uxKnight = new System.Windows.Forms.Button();
            uxRook = new System.Windows.Forms.Button();
            uxDemotionLabel = new System.Windows.Forms.Label();
            uxChooseLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // uxBishop
            // 
            uxBishop.Location = new System.Drawing.Point(6, 181);
            uxBishop.Name = "uxBishop";
            uxBishop.Size = new System.Drawing.Size(187, 67);
            uxBishop.TabIndex = 0;
            uxBishop.Text = "Bishop";
            uxBishop.UseVisualStyleBackColor = true;
            uxBishop.Click += uxBishop_Click;
            // 
            // uxKnight
            // 
            uxKnight.Location = new System.Drawing.Point(392, 181);
            uxKnight.Name = "uxKnight";
            uxKnight.Size = new System.Drawing.Size(187, 67);
            uxKnight.TabIndex = 1;
            uxKnight.Text = "Knight";
            uxKnight.UseVisualStyleBackColor = true;
            uxKnight.Click += uxKnight_Click;
            // 
            // uxRook
            // 
            uxRook.Location = new System.Drawing.Point(199, 181);
            uxRook.Name = "uxRook";
            uxRook.Size = new System.Drawing.Size(187, 67);
            uxRook.TabIndex = 2;
            uxRook.Text = "Rook";
            uxRook.UseVisualStyleBackColor = true;
            uxRook.Click += uxRook_Click;
            // 
            // uxDemotionLabel
            // 
            uxDemotionLabel.AutoSize = true;
            uxDemotionLabel.Location = new System.Drawing.Point(12, 9);
            uxDemotionLabel.Name = "uxDemotionLabel";
            uxDemotionLabel.Size = new System.Drawing.Size(548, 25);
            uxDemotionLabel.TabIndex = 3;
            uxDemotionLabel.Text = "DUE TO YOUR INCOMPETENCE YOUR QUEEN HAS BEEN DEMOTED.";
            // 
            // uxChooseLabel
            // 
            uxChooseLabel.AutoSize = true;
            uxChooseLabel.Location = new System.Drawing.Point(60, 47);
            uxChooseLabel.Name = "uxChooseLabel";
            uxChooseLabel.Size = new System.Drawing.Size(432, 25);
            uxChooseLabel.TabIndex = 4;
            uxChooseLabel.Text = "Choose Which Piece Your Queen Will Be Demoted to.";
            // 
            // QueenDemotionSelection
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(586, 268);
            Controls.Add(uxChooseLabel);
            Controls.Add(uxDemotionLabel);
            Controls.Add(uxRook);
            Controls.Add(uxKnight);
            Controls.Add(uxBishop);
            Name = "QueenDemotionSelection";
            Text = "QueenDemotionSelection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button uxBishop;
        private System.Windows.Forms.Button uxKnight;
        private System.Windows.Forms.Button uxRook;
        private System.Windows.Forms.Label uxDemotionLabel;
        private System.Windows.Forms.Label uxChooseLabel;
    }
}