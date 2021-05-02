namespace RNGPredictToolFor180
{
    partial class frmTool
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
            this.btnGo = new System.Windows.Forms.Button();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.lstvwSets = new System.Windows.Forms.ListView();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFrameID = new System.Windows.Forms.Label();
            this.chckdLstBxP1 = new System.Windows.Forms.CheckedListBox();
            this.chckdLstBxP2 = new System.Windows.Forms.CheckedListBox();
            this.chckdLstBxP3 = new System.Windows.Forms.CheckedListBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtCentisecond = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.txtFrameID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(924, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(326, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(61, 12);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(25, 22);
            this.txtMinute.TabIndex = 0;
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstvwSets
            // 
            this.lstvwSets.GridLines = true;
            this.lstvwSets.HideSelection = false;
            this.lstvwSets.Location = new System.Drawing.Point(12, 41);
            this.lstvwSets.Name = "lstvwSets";
            this.lstvwSets.Size = new System.Drawing.Size(1238, 620);
            this.lstvwSets.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstvwSets.TabIndex = 2;
            this.lstvwSets.UseCompatibleStateImageBehavior = false;
            this.lstvwSets.View = System.Windows.Forms.View.Details;
            this.lstvwSets.Visible = false;
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(393, 12);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(100, 22);
            this.txtRange.TabIndex = 3;
            this.txtRange.Text = "13";
            this.txtRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(333, 15);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(54, 17);
            this.lblRange.TabIndex = 5;
            this.lblRange.Text = "Range:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time:";
            // 
            // lblFrameID
            // 
            this.lblFrameID.AutoSize = true;
            this.lblFrameID.Location = new System.Drawing.Point(586, 15);
            this.lblFrameID.Name = "lblFrameID";
            this.lblFrameID.Size = new System.Drawing.Size(69, 17);
            this.lblFrameID.TabIndex = 7;
            this.lblFrameID.Text = "Frame ID:";
            // 
            // chckdLstBxP1
            // 
            this.chckdLstBxP1.CheckOnClick = true;
            this.chckdLstBxP1.FormattingEnabled = true;
            this.chckdLstBxP1.Items.AddRange(new object[] {
            "A bird box.",
            "A golden circle on a red circle.",
            "A pair of earrings.",
            "A parakeet on the left shoulder.",
            "A statue with scary eyes.",
            "A suspended ceiling. (Enemy)",
            "A suspended ceiling. (Open)",
            "A swirling container.",
            "A treasure of four stone statues.",
            "At the bottom of a huge wall painting.",
            "At the bottom of a pillar.",
            "At the bottom of a swirl tile pyramid.",
            "Between four birds.",
            "Between the red and green striped pillars.",
            "Between the twin stars.",
            "By a wind jump board.",
            "Double containers. (Left)",
            "Double containers. (Right)",
            "He\'s holding a box.",
            "In front of a bird chest under four feathers.",
            "In front of the double containers. (Left)",
            "In front of the double containers. (Right)",
            "Inside a statue storage area. (Left)",
            "Inside a statue storage area. (Right)",
            "Near the six pillars. (Close, left)",
            "Near the six pillars. (Close, right)",
            "Near the six pillars. (Far, left)",
            "Near the six pillars. (Far, right)",
            "On a sandy path to a stone statue head. (Close)",
            "On a sandy path to a stone statue head. (Middle)",
            "On a sandy path to a stone statue head. (Far)",
            "On the pillar.",
            "On the side of a bird chest under four feathers",
            "On the spiral tile.",
            "On the top of ten fingers.",
            "Over the head.",
            "Stone statue quartet. (Left)",
            "Stone statue quartet. (Right)",
            "The altar with six pillars.",
            "The head of the 4th stone statue.",
            "The place pointed out by two priests.",
            "\"Wild Canyon Track.\""});
            this.chckdLstBxP1.Location = new System.Drawing.Point(4, 51);
            this.chckdLstBxP1.Name = "chckdLstBxP1";
            this.chckdLstBxP1.Size = new System.Drawing.Size(362, 599);
            this.chckdLstBxP1.TabIndex = 8;
            // 
            // chckdLstBxP2
            // 
            this.chckdLstBxP2.CheckOnClick = true;
            this.chckdLstBxP2.FormattingEnabled = true;
            this.chckdLstBxP2.Items.AddRange(new object[] {
            "A bird box in the shade.",
            "A bird box. (Back-left)",
            "A bird box. (Center-left)",
            "A bird box. (Top)",
            "A red gate. (Lower)",
            "A red gate. (Upper)",
            "A suspended ceiling.",
            "A swirl pyramid.",
            "A swirling arrow.",
            "A swirling container.",
            "A terrace with two legs. (Behind weight)",
            "A terrace with two legs. (Under weight)",
            "Armored carpool. (Back)",
            "Armored carpool. (Middle)",
            "At the bottom of a pillar.",
            "At the foot of a pillar.",
            "Behind a face. (Center)",
            "Behind a face. (Right)",
            "Four swirling eyes.",
            "Four whirling eyes.",
            "Inside a statue storage area.",
            "Near a chair.",
            "Near the six pillars. (Close, left)",
            "Near the six pillars. (Close, right)",
            "Near the six pillars. (Far, left)",
            "Near the six pillars. (Far, right)",
            "On a railway. (Right, close)",
            "On a railway. (Right, far)",
            "On a railway. (Upper)",
            "On a sandy path that leads to a stone statue head.",
            "On a sandy path to a stone statue head. (Close)",
            "On a sandy path to a stone statue head. (Middle)",
            "On a sandy path to a stone statue head. (Far)",
            "Stone statue quartet. (Left)",
            "Stone statue quartet. (Right)",
            "Under the elbow.",
            "Under the wings of two birds.",
            "Where the wind blows",
            "\"Wild Canyon Track.\" (Center)",
            "\"Wild Canyon Track.\" (Right)"});
            this.chckdLstBxP2.Location = new System.Drawing.Point(369, 51);
            this.chckdLstBxP2.Name = "chckdLstBxP2";
            this.chckdLstBxP2.Size = new System.Drawing.Size(373, 599);
            this.chckdLstBxP2.TabIndex = 9;
            // 
            // chckdLstBxP3
            // 
            this.chckdLstBxP3.CheckOnClick = true;
            this.chckdLstBxP3.FormattingEnabled = true;
            this.chckdLstBxP3.Items.AddRange(new object[] {
            "A pillar without a treasure.",
            "A sandpit.",
            "A sandy path to the head of a stone statue. (Weight)",
            "A terrace with two legs. (Static)",
            "Between the red pillars. (Behind weight)",
            "Between the red pillars. (Under weight)",
            "Between two stone statues.",
            "By a tall pillar.",
            "Four whirling eyes. (Sandy path side)",
            "Four whirling eyes. (Storage area side)",
            "In a storm zone. (Bottom)",
            "In a storm zone. (Top, bird chest side)",
            "In a storm zone. (Top, double containers side)",
            "In front of a mountain with green and red stripes. (Chest side, far from chest)",
            "In front of a mountain with red and green stripes. (Chest side, close to chest)",
            "In front of a mountain with red and green stripes. (Double containers side)",
            "In the center of the 8th pillar.",
            "On a red circle.",
            "On a sandy path to a statue head. (Moving)",
            "On the lap of a wall painting.",
            "On the scary eyes in the \"Wild Canyon Track.\"",
            "Orbiting above the face.",
            "Over the tilted pillar.",
            "Red and green stripes. (Moving)",
            "Swirling.",
            "The altar with six pillars.",
            "The arrow pointing to the right.",
            "The beginning room.",
            "The golden path.",
            "Where the wind blows. (Moving)",
            "Where wind is generated. (Static)",
            "\"Wild Canyon Track.\""});
            this.chckdLstBxP3.Location = new System.Drawing.Point(747, 51);
            this.chckdLstBxP3.Name = "chckdLstBxP3";
            this.chckdLstBxP3.Size = new System.Drawing.Size(509, 599);
            this.chckdLstBxP3.TabIndex = 10;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(110, 12);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(25, 22);
            this.txtSecond.TabIndex = 1;
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCentisecond
            // 
            this.txtCentisecond.Location = new System.Drawing.Point(159, 12);
            this.txtCentisecond.Name = "txtCentisecond";
            this.txtCentisecond.Size = new System.Drawing.Size(25, 22);
            this.txtCentisecond.TabIndex = 2;
            this.txtCentisecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblColon
            // 
            this.lblColon.AutoSize = true;
            this.lblColon.Location = new System.Drawing.Point(92, 15);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(12, 17);
            this.lblColon.TabIndex = 13;
            this.lblColon.Text = ":";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(141, 15);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(12, 17);
            this.lblPeriod.TabIndex = 14;
            this.lblPeriod.Text = ".";
            // 
            // txtFrameID
            // 
            this.txtFrameID.Enabled = false;
            this.txtFrameID.Location = new System.Drawing.Point(661, 12);
            this.txtFrameID.Name = "txtFrameID";
            this.txtFrameID.Size = new System.Drawing.Size(100, 22);
            this.txtFrameID.TabIndex = 4;
            this.txtFrameID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.txtFrameID);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtCentisecond);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.chckdLstBxP3);
            this.Controls.Add(this.chckdLstBxP2);
            this.Controls.Add(this.chckdLstBxP1);
            this.Controls.Add(this.lblFrameID);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.lstvwSets);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.btnGo);
            this.Name = "frmTool";
            this.Text = "RNG Predict Tool For 180 Emblems Hunting M4s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.ListView lstvwSets;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFrameID;
        private System.Windows.Forms.CheckedListBox chckdLstBxP1;
        private System.Windows.Forms.CheckedListBox chckdLstBxP2;
        private System.Windows.Forms.CheckedListBox chckdLstBxP3;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtCentisecond;
        private System.Windows.Forms.Label lblColon;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TextBox txtFrameID;
    }
}

