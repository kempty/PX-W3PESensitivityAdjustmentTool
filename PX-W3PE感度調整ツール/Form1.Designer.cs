namespace PX_W3PE
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.grpManual = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.trcLevel = new System.Windows.Forms.TrackBar();
            this.chkExLNA = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkAuto.Location = new System.Drawing.Point(37, 35);
            this.chkAuto.Margin = new System.Windows.Forms.Padding(4);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(174, 21);
            this.chkAuto.TabIndex = 0;
            this.chkAuto.Text = "自動コントロール ON / OFF";
            this.toolTip.SetToolTip(this.chkAuto, "チェックすると自動コントロールをONにします。\r\nONの時、手動設定の値は設定出来ません。\r\nチャンネル変更の際、ドロップ発生の可能性があるので非推奨です。");
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // grpManual
            // 
            this.grpManual.Controls.Add(this.label2);
            this.grpManual.Controls.Add(this.label1);
            this.grpManual.Controls.Add(this.numLevel);
            this.grpManual.Controls.Add(this.trcLevel);
            this.grpManual.Controls.Add(this.chkExLNA);
            this.grpManual.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpManual.Location = new System.Drawing.Point(37, 79);
            this.grpManual.Margin = new System.Windows.Forms.Padding(4);
            this.grpManual.Name = "grpManual";
            this.grpManual.Padding = new System.Windows.Forms.Padding(4);
            this.grpManual.Size = new System.Drawing.Size(453, 192);
            this.grpManual.TabIndex = 1;
            this.grpManual.TabStop = false;
            this.grpManual.Text = "手動設定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(394, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "(17h)";
            this.toolTip.SetToolTip(this.label2, "16進数でのゲインレベル");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(15, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "シリコンチューナーのゲイン調整";
            // 
            // numLevel
            // 
            this.numLevel.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numLevel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numLevel.Location = new System.Drawing.Point(338, 127);
            this.numLevel.Margin = new System.Windows.Forms.Padding(4);
            this.numLevel.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(48, 27);
            this.numLevel.TabIndex = 2;
            this.numLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLevel.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numLevel.ValueChanged += new System.EventHandler(this.numLevel_ValueChanged);
            // 
            // trcLevel
            // 
            this.trcLevel.LargeChange = 4;
            this.trcLevel.Location = new System.Drawing.Point(9, 127);
            this.trcLevel.Margin = new System.Windows.Forms.Padding(4);
            this.trcLevel.Maximum = 23;
            this.trcLevel.Name = "trcLevel";
            this.trcLevel.Size = new System.Drawing.Size(321, 45);
            this.trcLevel.TabIndex = 1;
            this.toolTip.SetToolTip(this.trcLevel, "0(00h)～23(17h)の間で設定します。");
            this.trcLevel.Scroll += new System.EventHandler(this.trcLevel_Scroll);
            // 
            // chkExLNA
            // 
            this.chkExLNA.AutoSize = true;
            this.chkExLNA.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkExLNA.Location = new System.Drawing.Point(18, 44);
            this.chkExLNA.Margin = new System.Windows.Forms.Padding(4);
            this.chkExLNA.Name = "chkExLNA";
            this.chkExLNA.Size = new System.Drawing.Size(158, 21);
            this.chkExLNA.TabIndex = 0;
            this.chkExLNA.Text = "ブースター機能 ON/OFF";
            this.toolTip.SetToolTip(this.chkExLNA, "チェックするとブースター機能をONにします。\r\n");
            this.chkExLNA.UseVisualStyleBackColor = true;
            this.chkExLNA.CheckedChanged += new System.EventHandler(this.chkExLNA_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 307);
            this.Controls.Add(this.grpManual);
            this.Controls.Add(this.chkAuto);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PX-W3PE感度調整ツール";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpManual.ResumeLayout(false);
            this.grpManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.GroupBox grpManual;
        private System.Windows.Forms.CheckBox chkExLNA;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.TrackBar trcLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label2;
    }
}

