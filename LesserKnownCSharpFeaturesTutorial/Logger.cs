using System;
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

        [Obsolete("This method is will be removed in the future. Use Log(string message) instead.")]
        public static void Log(string message, string callerMemberName)
        {
            Log($"[Message]: {message}; [Caller Member Name]: {callerMemberName}; ");
        }

        private static void Log(string message)
        {
            //you see this messages on output windows. if not, right click on that window and chech 'Program Output'
            Debug.WriteLine(message);
        }
    }
}
