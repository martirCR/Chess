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
            uxChessBoard = new System.Windows.Forms.FlowLayoutPanel();
            uxTurnColor = new System.Windows.Forms.Label();
            uxNew = new System.Windows.Forms.Button();
            uxTurn = new System.Windows.Forms.Label();
            uxEndTurn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // uxChessBoard
            // 
            uxChessBoard.Location = new System.Drawing.Point(13, 88);
            uxChessBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxChessBoard.Name = "uxChessBoard";
            uxChessBoard.Size = new System.Drawing.Size(1000, 1000);
            uxChessBoard.TabIndex = 0;
            // 
            // uxTurnColor
            // 
            uxTurnColor.AutoSize = true;
            uxTurnColor.Location = new System.Drawing.Point(711, 15);
            uxTurnColor.Name = "uxTurnColor";
            uxTurnColor.Size = new System.Drawing.Size(58, 25);
            uxTurnColor.TabIndex = 0;
            uxTurnColor.Text = "White";
            // 
            // uxNew
            // 
            uxNew.Location = new System.Drawing.Point(13, 15);
            uxNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            uxNew.Name = "uxNew";
            uxNew.Size = new System.Drawing.Size(108, 52);
            uxNew.TabIndex = 1;
            uxNew.Text = "New Game";
            uxNew.UseVisualStyleBackColor = true;
            uxNew.Click += NewClick;
            // 
            // uxTurn
            // 
            uxTurn.AutoSize = true;
            uxTurn.Location = new System.Drawing.Point(648, 15);
            uxTurn.Name = "uxTurn";
            uxTurn.Size = new System.Drawing.Size(47, 25);
            uxTurn.TabIndex = 2;
            uxTurn.Text = "Turn";
            // 
            // uxEndTurn
            // 
            uxEndTurn.Location = new System.Drawing.Point(127, 15);
            uxEndTurn.Name = "uxEndTurn";
            uxEndTurn.Size = new System.Drawing.Size(112, 52);
            uxEndTurn.TabIndex = 3;
            uxEndTurn.Text = "End Turn";
            uxEndTurn.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1027, 1126);
            Controls.Add(uxEndTurn);
            Controls.Add(uxTurn);
            Controls.Add(uxNew);
            Controls.Add(uxTurnColor);
            Controls.Add(uxChessBoard);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "UserInterface";
            Text = "Chess Board";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel uxChessBoard;
        private System.Windows.Forms.Label uxTurnColor;
        private System.Windows.Forms.Button uxNew;
        private System.Windows.Forms.Label uxTurn;
        private System.Windows.Forms.Button uxEndTurn;
    }
}

