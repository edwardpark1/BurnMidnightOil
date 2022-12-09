using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using BurnMidnightOil;
using System.Threading;

namespace BurnMidnightOil
{
    public class ActiveSession : Session
    {
        [Flags]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            //ES_USER_PRESENT = 0x00000004 // deprecated flag
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        public ActiveSession(Action<string> logSetter, Time signalDelayTime, Time totalSessionTime = null) 
            : base(logSetter, signalDelayTime, totalSessionTime)
        {
        }

        public void InvokeSession()
        {
            try
            {
                EnforceScreenSaverState(true);
            }
            catch (Win32Exception win32Exception)
            {
                logSetter($"Uh oh, we could not signal to keep it up: {win32Exception}");
            }
            catch (Exception exc)
            {
                logSetter($"Oops something wrong happened: {exc}");
            }
            finally
            {
                try
                {
                    EnforceScreenSaverState(false);
                }
                catch
                {
                    logSetter($"Unable to reset {nameof(SetThreadExecutionState)} before exiting app");
                }
            }

            logSetter($"Persist active state success");
        }

        public void EnforceScreenSaverState(bool toggleState)
        {
            bool resultSuccess;

            if (toggleState)
            {
                resultSuccess = (SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS) != 0);
            }
            else
            {
                resultSuccess = (SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS) != 0);
            }

            if (!resultSuccess)
            {
                throw new Win32Exception();
            }
        }
    }
}
