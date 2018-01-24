﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CallerInfoExample
{
    public static class Logger
    {
        public static void Log(string message,
                               [CallerFilePath] string sourceFilePath = "",
                               [CallerLineNumber] int sourceLineNumber = 0,
                               [CallerMemberName] string callerMemberName = "")
        {
            Log($"[Message]: {message}; [Source File Path]: {sourceFilePath}; " +
              $"[Source Line Number]: {sourceLineNumber}; [Caller Member Name]: {callerMemberName}; ");
        }

        private static void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}