namespace MazeSolver
{
    partial class MazeSolverDemo
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkDFS = new System.Windows.Forms.CheckBox();
            this.chkBFS = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDestPoint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentPosition = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearWalls = new System.Windows.Forms.Button();
            this.chkDiagonal = new System.Windows.Forms.CheckBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioTraversal = new System.Windows.Forms.RadioButton();
            this.radioCreateWall = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureMaze = new System.Windows.Forms.PictureBox();
            this.objectTimer = new System.Windows.Forms.Timer(this.components);
            this.runnerXObject = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaze)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkDFS);
            this.panel1.Controls.Add(this.chkBFS);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.chkDiagonal);
            this.panel1.Controls.Add(this.lblY);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(802, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 563);
            this.panel1.TabIndex = 0;
            // 
            // chkDFS
            // 
            this.chkDFS.AutoSize = true;
            this.chkDFS.Location = new System.Drawing.Point(55, 175);
            this.chkDFS.Name = "chkDFS";
            this.chkDFS.Size = new System.Drawing.Size(139, 20);
            this.chkDFS.TabIndex = 6;
            this.chkDFS.Text = "Depth First Search";
            this.chkDFS.UseVisualStyleBackColor = true;
            this.chkDFS.CheckedChanged += new System.EventHandler(this.chkDFS_CheckedChanged);
            this.chkDFS.Click += new System.EventHandler(this.chkDFS_Click);
            // 
            // chkBFS
            // 
            this.chkBFS.AutoSize = true;
            this.chkBFS.Location = new System.Drawing.Point(55, 123);
            this.chkBFS.Name = "chkBFS";
            this.chkBFS.Size = new System.Drawing.Size(150, 20);
            this.chkBFS.TabIndex = 5;
            this.chkBFS.Text = "Breadth First Search";
            this.chkBFS.UseVisualStyleBackColor = true;
            this.chkBFS.CheckedChanged += new System.EventHandler(this.chkBFS_CheckedChanged);
            this.chkBFS.Click += new System.EventHandler(this.chkBFS_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDestPoint);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblCurrentPosition);
            this.groupBox3.Location = new System.Drawing.Point(20, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 149);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location";
            // 
            // lblDestPoint
            // 
            this.lblDestPoint.AutoSize = true;
            this.lblDestPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestPoint.Location = new System.Drawing.Point(92, 89);
            this.lblDestPoint.Name = "lblDestPoint";
            this.lblDestPoint.Size = new System.Drawing.Size(53, 25);
            this.lblDestPoint.TabIndex = 3;
            this.lblDestPoint.Text = "(0,0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "End:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start:";
            // 
            // lblCurrentPosition
            // 
            this.lblCurrentPosition.AutoSize = true;
            this.lblCurrentPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPosition.Location = new System.Drawing.Point(92, 39);
            this.lblCurrentPosition.Name = "lblCurrentPosition";
            this.lblCurrentPosition.Size = new System.Drawing.Size(53, 25);
            this.lblCurrentPosition.TabIndex = 0;
            this.lblCurrentPosition.Text = "(0,0)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearWalls);
            this.groupBox2.Location = new System.Drawing.Point(20, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // btnClearWalls
            // 
            this.btnClearWalls.Location = new System.Drawing.Point(35, 33);
            this.btnClearWalls.Name = "btnClearWalls";
            this.btnClearWalls.Size = new System.Drawing.Size(106, 46);
            this.btnClearWalls.TabIndex = 0;
            this.btnClearWalls.Text = "Clear Walls";
            this.btnClearWalls.UseVisualStyleBackColor = true;
            this.btnClearWalls.Click += new System.EventHandler(this.btnClearWalls_Click);
            // 
            // chkDiagonal
            // 
            this.chkDiagonal.AutoSize = true;
            this.chkDiagonal.Location = new System.Drawing.Point(55, 149);
            this.chkDiagonal.Name = "chkDiagonal";
            this.chkDiagonal.Size = new System.Drawing.Size(84, 20);
            this.chkDiagonal.TabIndex = 0;
            this.chkDiagonal.Text = "Diagonal";
            this.chkDiagonal.UseVisualStyleBackColor = true;
            this.chkDiagonal.CheckedChanged += new System.EventHandler(this.chkDiagonal_CheckedChanged);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(133, 518);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(43, 16);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y: 000";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(49, 518);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(42, 16);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X: 000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioTraversal);
            this.groupBox1.Controls.Add(this.radioCreateWall);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // radioTraversal
            // 
            this.radioTraversal.AutoSize = true;
            this.radioTraversal.Location = new System.Drawing.Point(32, 57);
            this.radioTraversal.Name = "radioTraversal";
            this.radioTraversal.Size = new System.Drawing.Size(86, 20);
            this.radioTraversal.TabIndex = 6;
            this.radioTraversal.Text = "Traversal";
            this.radioTraversal.UseVisualStyleBackColor = true;
            // 
            // radioCreateWall
            // 
            this.radioCreateWall.AutoSize = true;
            this.radioCreateWall.Checked = true;
            this.radioCreateWall.Location = new System.Drawing.Point(32, 30);
            this.radioCreateWall.Name = "radioCreateWall";
            this.radioCreateWall.Size = new System.Drawing.Size(105, 20);
            this.radioCreateWall.TabIndex = 5;
            this.radioCreateWall.TabStop = true;
            this.radioCreateWall.Text = "Create Walls";
            this.radioCreateWall.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pictureMaze
            // 
            this.pictureMaze.Location = new System.Drawing.Point(35, 46);
            this.pictureMaze.Name = "pictureMaze";
            this.pictureMaze.Size = new System.Drawing.Size(750, 560);
            this.pictureMaze.TabIndex = 3;
            this.pictureMaze.TabStop = false;
            this.pictureMaze.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureMaze_Paint);
            this.pictureMaze.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureMaze_MouseMove);
            this.pictureMaze.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureMaze_MouseUp);
            // 
            // objectTimer
            // 
            this.objectTimer.Interval = 500;
            this.objectTimer.Tick += new System.EventHandler(this.objectTimer_Tick);
            // 
            // runnerXObject
            // 
            this.runnerXObject.Interval = 500;
            this.runnerXObject.Tick += new System.EventHandler(this.runnerObject_Tick);
            // 
            // MazeSolverDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 627);
            this.Controls.Add(this.pictureMaze);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MazeSolverDemo";
            this.Text = "Maze Solver";
            this.Load += new System.EventHandler(this.MazeSolverDemo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDiagonal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureMaze;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.RadioButton radioTraversal;
        private System.Windows.Forms.RadioButton radioCreateWall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearWalls;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCurrentPosition;
        private System.Windows.Forms.Label lblDestPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer objectTimer;
        private System.Windows.Forms.Timer runnerXObject;
        private System.Windows.Forms.CheckBox chkDFS;
        private System.Windows.Forms.CheckBox chkBFS;
    }
}

