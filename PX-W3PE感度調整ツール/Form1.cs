using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PX_W3PE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkAuto.Checked = LNA.LNA_AUTO_CTRL;
            chkExLNA.Checked = LNA.External_LNA_ON;
            trcLevel.Value = LNA.Internal_LNA_Level;
            numLevel.Value = trcLevel.Value;
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            //チェック状態をレジストリに反映
            LNA.LNA_AUTO_CTRL = chkAuto.Checked;

            //チェックが無い時のみ、手動設定項目を有効にする
            grpManual.Enabled = !chkAuto.Checked;
        }

        private void chkExLNA_CheckedChanged(object sender, EventArgs e)
        {
            //チェック状態をレジストリに反映
            LNA.External_LNA_ON = chkExLNA.Checked;
        }

        private void trcLevel_Scroll(object sender, EventArgs e)
        {
            //スライダーの数値を数字ボックスに反映
            numLevel.Value = trcLevel.Value;
        }

        private void numLevel_ValueChanged(object sender, EventArgs e)
        {
            //数字ボックスの数値をスライダーに反映
            trcLevel.Value = (int)numLevel.Value;

            //スライダーの数値をレジストリに反映
            LNA.Internal_LNA_Level = trcLevel.Value;

            label2.Text = "(" + trcLevel.Value.ToString("X2") + "h)";
        }
    }
}
