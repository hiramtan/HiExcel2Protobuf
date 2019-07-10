﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiFramework.Log;

namespace HiProtobuf.UI
{
    internal class Logger : ILogProxy
    {
        public static string Log;
        public void Print(params object[] args)
        {
            string str = "";
            for (int i = 0; i < args.Length; i++)
            {
                str += args[i].ToString();
            }
            Log += "[Print]" + str.ToString() + "\r\n";
        }

        public void Warnning(params object[] args)
        {
            string str = "";
            for (int i = 0; i < args.Length; i++)
            {
                str += args[i].ToString();
            }
            Log += "[Warnning]" + str.ToString() + "\r\n";
        }

        public void Error(params object[] args)
        {
            string str = "";
            for (int i = 0; i < args.Length; i++)
            {
                str += args[i].ToString();
            }
            Log += "[Error]" + str.ToString() + "\r\n";
        }
    }
}
