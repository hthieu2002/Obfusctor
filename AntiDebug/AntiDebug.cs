using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace AntiDebug
{
    public static class AntiDebug
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool IsDebuggerPresent();

        public static void ApplyPatch()
        {
            var harmony = new Harmony("com.antidebug.protection");
            harmony.Patch(
                original: AccessTools.PropertyGetter(typeof(Debugger), "IsAttached"),
                prefix: new HarmonyMethod(typeof(AntiDebug), nameof(BlockDebuggerIsAttached))
            );

            harmony.Patch(
                original: AccessTools.Method(typeof(AntiDebug), "IsDebuggerPresent"),
                prefix: new HarmonyMethod(typeof(AntiDebug), nameof(BlockIsDebuggerPresent))
            );
        }

        public static bool BlockDebuggerIsAttached(ref bool __result)
        {
            __result = false; // Chặn Debugger.IsAttached luôn trả về `false`
            return false;
        }

        public static bool BlockIsDebuggerPresent(ref bool __result)
        {
            __result = false; // Chặn IsDebuggerPresent luôn trả về `false`
            return false;
        }
    }
}
