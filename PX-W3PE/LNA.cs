using System;
using System.Collections.Generic;
using System.Text;

namespace PX_W3PE
{
    internal static class LNA
    {
        /// <summary>
        /// 感度設定が格納されているレジストリのキー
        /// </summary>
        private const string LNA_KEY = @"SOFTWARE\ASICEN\LNASetting\0B06_0001_PE\ISDBT";

        //各キーの名前を定数として定義
        private const string EXTERNAL_LNA_ON = "External_LNA_ON";
        private const string INTERNAL_LNA_LEVEL = "Internal_LNA_Level";
        private const string LNA_AUTO_CONTROL = "LNA_AUTO_CTRL";

        //ON/OFFのレジストリの値を定数として定義
        private const int OFF = 0x00;
        private const int ON = 0x01;

        //ゲインレベルの範囲を定数として定義
        private const int LEVEL_Min = 0x00;
        private const int LEVEL_MAX = 0x17;
        
        /// <summary>
        /// 感度設定が格納されているキーのインスタンス
        /// </summary>
        private static Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(LNA_KEY, true);
        
        /// <summary>
        /// レジストリにキーが存在すればtrueを返す (読み取り専用)
        /// </summary>
        internal static bool IsInstalled
        {
            get
            {
                //レジストリにキーが存在しない時、regkeyはnull
                return (regkey != null);
            }
        }

        /// <summary>
        /// 自動コントロールのON/OFF
        /// </summary>
        internal static bool LNA_AUTO_CTRL
        {
            // HKEY_LOCAL_MACHINE\SOFTWARE\ASICEN\LNASetting\0B06_0001_PE\ISDBT\LNA_AUTO_CTRL

            get
            {
                //レジストリの値を取得
                int regValue = (int)regkey.GetValue(LNA_AUTO_CONTROL);

                //ON(=0x01)ならtrue,OFF(=0x00)ならfalseを返す
                return (regValue == ON);
            }

            //trueが渡されたら0x01(=ON),falseが渡されたら0x00(=OFF)を書き込む
            set
            {
                int regValue = (value ? ON : OFF);

                //レジストリ書き込み
                regkey.SetValue(LNA_AUTO_CONTROL, regValue);
            }
        }

        /// <summary>
        /// ブースター機能のON/OFF
        /// </summary>
        internal static bool External_LNA_ON
        {
            // HKEY_LOCAL_MACHINE\SOFTWARE\ASICEN\LNASetting\0B06_0001_PE\ISDBT\External_LNA_ON

            get
            {
                //レジストリの値を取得
                int regValue = (int)regkey.GetValue(EXTERNAL_LNA_ON);

                //ON(=0x01)ならtrue,OFF(=0x00)ならfalseを返す
                return (regValue == ON);
            }

            //trueが渡されたら0x01(=ON),falseが渡されたら0x00(=OFF)を書き込む
            set
            {
                int regValue = (value ? ON : OFF);  //書き込む値を選択

                //レジストリ書き込み
                regkey.SetValue(EXTERNAL_LNA_ON, regValue);
            }
        }

        /// <summary>
        /// シリコンチューナーのゲイン調整。16進数で0x00～0x17の24段階の調節 
        /// </summary>
        internal static int Internal_LNA_Level
        {
            // HKEY_LOCAL_MACHINE\SOFTWARE\ASICEN\LNASetting\0B06_0001_PE\ISDBT\Internal_LNA_Level

            get
            {
                //レジストリを読み込んでそのまま返す
                return (int)regkey.GetValue(INTERNAL_LNA_LEVEL);
            }

            set
            {
                int level;

                //0x00~0x17の範囲に丸める
                if (value < LEVEL_Min)
                {
                    level = LEVEL_Min;
                }
                else if (value > LEVEL_MAX)
                {
                    level = LEVEL_MAX;
                }
                else
                {
                    level = value;
                }

                //レジストリ書き込み
                regkey.SetValue(INTERNAL_LNA_LEVEL, level);
            }
        }
    }
}