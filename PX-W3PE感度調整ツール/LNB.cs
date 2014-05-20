using System;
using System.Collections.Generic;
using System.Text;

namespace PX_W3PE
{
    internal static class LNB
    {
        /// <summary>
        /// LNB電源供給の設定が格納されているレジストリのキー
        /// </summary>
        private const string LNB_KEY = @"HKEY_LOCAL_MACHINE\SOFTWARE\ASICEN\LNBPower\0B06_0001_PE";

        //各キーの名前を定数として定義
        private const string LNBONOFF = "LNBONOFF";
        private const string DEVICEENABLE = "DeviceEnable";

        //ON/OFFのレジストリの値を定数として定義
        private const int OFF = 0x00;
        private const int ON = 0x01;

        /// <summary>
        /// 感度設定が格納されているキーのインスタンス
        /// </summary>
        private static Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(LNB_KEY, true);
    }
}
