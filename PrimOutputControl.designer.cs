namespace Lead.Tool.TesetReal3
{
    partial class PrimOutputControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimOutputControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.map3D1 = new UserControls.Map3D();
            this.colorRuler1 = new UserControls.ColorRuler();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colorRuler1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(403, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 326);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.map3D1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 326);
            this.panel2.TabIndex = 3;
            // 
            // map3D1
            // 
            this.map3D1.AxisColorX = System.Drawing.Color.Red;
            this.map3D1.AxisColorY = System.Drawing.Color.Green;
            this.map3D1.AxisColorZ = System.Drawing.Color.Blue;
            this.map3D1.ColorDisMax = 5D;
            this.map3D1.ColorDisMin = -5D;
            this.map3D1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.map3D1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map3D1.EnableMouseEvents = true;
            this.map3D1.EnableZoom = true;
            this.map3D1.ForeColor = System.Drawing.Color.Yellow;
            this.map3D1.GridCellCount = 10;
            this.map3D1.GridShowXY = false;
            this.map3D1.GridShowXZ = false;
            this.map3D1.GridShowYZ = false;
            this.map3D1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.map3D1.IsUseTexture = true;
            this.map3D1.Location = new System.Drawing.Point(0, 0);
            this.map3D1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.map3D1.Name = "map3D1";
            this.map3D1.PixelsPerMM = 50D;
            this.map3D1.Size = new System.Drawing.Size(403, 326);
            this.map3D1.TabIndex = 0;
            this.map3D1.Tag = "";
            this.map3D1.ViewMode = CommonStruct.Type3D.ViewMode.Default;
            this.map3D1.Zoom = 1D;
            // 
            // colorRuler1
            // 
            this.colorRuler1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorRuler1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorRuler1.BackgroundImage")));
            this.colorRuler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorRuler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorRuler1.DownColor = System.Drawing.Color.DarkBlue;
            this.colorRuler1.IsShowValue = false;
            this.colorRuler1.Location = new System.Drawing.Point(0, 0);
            this.colorRuler1.Name = "colorRuler1";
            this.colorRuler1.Size = new System.Drawing.Size(60, 326);
            this.colorRuler1.TabIndex = 1;
            this.colorRuler1.UpColor = System.Drawing.Color.Gray;
            // 
            // PrimOutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrimOutputControl";
            this.Size = new System.Drawing.Size(463, 326);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Map3D map3D1;
        private UserControls.ColorRuler colorRuler1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
