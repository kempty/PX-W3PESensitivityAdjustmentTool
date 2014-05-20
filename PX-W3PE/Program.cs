using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PX_W3PE
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //レジストリチェック(既にレジストリに書き込まれている場合のみ起動する)
            if (LNA.IsInstalled)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("PX-W3PEのドライバがインストールされていません。\r\nこのツールは使用出来ません。",
                                "PX-W3PE感度調整ツール", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Application.Exit();
            }
        }
    }
}
