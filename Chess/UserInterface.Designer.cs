﻿namespace Chess
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
            uxTurnColor.BackColor = System.Drawing.SystemColors.Control;
            uxTurnColor.Font = new System.Drawing.Font("Segoe UI", 20F);
            uxTurnColor.Location = new System.Drawing.Point(736, 15);
            uxTurnColor.Name = "uxTurnColor";
            uxTurnColor.Size = new System.Drawing.Size(128, 54);
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
            uxTurn.Font = new System.Drawing.Font("Segoe UI", 20F);
            uxTurn.Location = new System.Drawing.Point(626, 15);
            uxTurn.Name = "uxTurn";
            uxTurn.Size = new System.Drawing.Size(104, 54);
            uxTurn.TabIndex = 2;
            uxTurn.Text = "Turn";
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1027, 1126);
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
    }
}

