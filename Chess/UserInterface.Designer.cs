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
            this.uxTurnColor = new System.Windows.Forms.Label();
            this.uxNew = new System.Windows.Forms.Button();
            this.uxTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxChessBoard
            // 
            this.uxChessBoard.Location = new System.Drawing.Point(0, 95);
            this.uxChessBoard.Name = "uxChessBoard";
            this.uxChessBoard.Size = new System.Drawing.Size(800, 354);
            this.uxChessBoard.TabIndex = 0;
            // 
            // uxTurnColor
            // 
            this.uxTurnColor.AutoSize = true;
            this.uxTurnColor.Location = new System.Drawing.Point(640, 12);
            this.uxTurnColor.Name = "uxTurnColor";
            this.uxTurnColor.Size = new System.Drawing.Size(50, 20);
            this.uxTurnColor.TabIndex = 0;
            this.uxTurnColor.Text = "White";
            // 
            // uxNew
            // 
            this.uxNew.Location = new System.Drawing.Point(12, 12);
            this.uxNew.Name = "uxNew";
            this.uxNew.Size = new System.Drawing.Size(97, 42);
            this.uxNew.TabIndex = 1;
            this.uxNew.Text = "New Game";
            this.uxNew.UseVisualStyleBackColor = true;
            this.uxNew.Click += new System.EventHandler(this.NewClick);
            // 
            // uxTurn
            // 
            this.uxTurn.AutoSize = true;
            this.uxTurn.Location = new System.Drawing.Point(583, 12);
            this.uxTurn.Name = "uxTurn";
            this.uxTurn.Size = new System.Drawing.Size(41, 20);
            this.uxTurn.TabIndex = 2;
            this.uxTurn.Text = "Turn";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxTurn);
            this.Controls.Add(this.uxNew);
            this.Controls.Add(this.uxTurnColor);
            this.Controls.Add(this.uxChessBoard);
            this.Name = "UserInterface";
            this.Text = "Chess Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel uxChessBoard;
        private System.Windows.Forms.Label uxTurnColor;
        private System.Windows.Forms.Button uxNew;
        private System.Windows.Forms.Label uxTurn;
    }
}

