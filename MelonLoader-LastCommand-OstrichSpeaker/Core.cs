using MelonLoader;
using HarmonyLib;
using Spine;
using System.Drawing;

[assembly: MelonInfo(typeof(MelonLoader_LastCommand_OstrichSpeaker.Core), "MelonLoader-LastCommand-OstrichSpeaker", "1.0.0", "Lea", null)]
[assembly: MelonGame("DinayaNN", "LastCommand")]

namespace MelonLoader_LastCommand_OstrichSpeaker
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
        }
    }


    [HarmonyPatch(typeof(BossOstrichSpeaker), "QustionCollectionBase", new Type[] { typeof(int), typeof(bool) })]
    public static class PatchQustionCollectionBase
    {
        private static void Postfix(ref String[] __result, int index, bool b)
        {
            int num1 = UnityEngine.Random.Range(1, 8);
            int num2 = UnityEngine.Random.Range(1, 8);
            int num3 = UnityEngine.Random.Range(1, 8);
            int add = UnityEngine.Random.Range(0, 1);

            int trig = UnityEngine.Random.Range(0, 2);
            int trigIndex = UnityEngine.Random.Range(0, 3);

            if (b)
            {
                if(trig == 0)
                {
                    switch (trigIndex)
                    {
                        case 0:
                            __result = new String[] { "<size=50%>", "cos(a + b)", "=", "cos(a)", "cos(b)", "-", "sin(a)", "sin(b)" };
                            break;
                        case 1:
                            __result = new String[] { "<size=50%>", "cos(a - b)", "=", "cos(a)", "cos(b)", "+", "sin(a)", "sin(b)" };
                            break;
                        case 2:
                            __result = new String[] { "<size=50%>", "sin(a - b)", "=", "sin(a)", "cos(b)", "-", "cos(a)", "sin(b)" };
                            break;
                        case 3:
                            __result = new String[] { "<size=50%>", "sin(a + b)", "=", "sin(a)", "cos(b)", "+", "cos(a)", "sin(b)" };
                            break;
                    }
                }
                else
                {
                    if (add == 1)
                    {
                        int result = num1 + num2 * num3;
                        __result = new String[] { num1.ToString(), "+", num2.ToString(), "x", num3.ToString(), "=", result.ToString(), "", "", "", "", "", "", "", "", "" };
                    }
                    else
                    {
                        int result = num1 - num2 * num3;
                        __result = new String[] { num1.ToString(), "-", num2.ToString(), "x", num3.ToString(), "=", result.ToString(), "", "", "", "", "", "", "", "", "" };
                    }
                }
            }
            else
            {
                if (trig == 0)
                {
                    switch (trigIndex)
                    {
                        case 0:
                            __result = new String[] { "<size=50%>", "cos(a + b)", "=", "cos(a)", "cos(b)", "+", "sin(a)", "sin(b)" };
                            break;
                        case 1:
                            __result = new String[] { "<size=50%>", "cos(a - b)", "=", "sin(a)", "cos(b)", "+", "cos(a)", "sin(b)" };
                            break;
                        case 2:
                            __result = new String[] { "<size=50%>", "sin(a - b)", "=", "sin(a)", "sin(b)", "-", "cos(a)", "cos(b)" };
                            break;
                        case 3:
                            __result = new String[] { "<size=50%>", "sin(a + b)", "=", "sin(a)", "cos(b)", "-", "cos(a)", "sin(b)" };
                            break;
                    }
                }
                else
                {
                    if (add == 1)
                    {
                        int result = num1 + num2 * num3 + 2;
                        __result = new String[] { num1.ToString(), "+", num2.ToString(), "x", num3.ToString(), "=", result.ToString(), "", "", "", "", "", "", "", "", "" };
                    }
                    else
                    {
                        int result = num1 - num2 * num3 - 2;
                        __result = new String[] { num1.ToString(), "-", num2.ToString(), "x", num3.ToString(), "=", result.ToString(), "", "", "", "", "", "", "", "", "" };
                    }
                }
            }
        }
    }

    [HarmonyPatch(typeof(BossOstrichSpeaker), "QustionCollection", new Type[] { typeof(int), typeof(bool) })]
    public static class PatchQustionCollection
    {
        private static void Postfix(ref String[] __result, int index, bool b)
        {
            int num1 = UnityEngine.Random.Range(1, 10);
            int num2 = UnityEngine.Random.Range(1, 10);
            int num3 = UnityEngine.Random.Range(1, 10);
            int add = UnityEngine.Random.Range(0, 1);

            int trig = UnityEngine.Random.Range(0, 2);
            int trigIndex = UnityEngine.Random.Range(0, 3);

            if (b)
            {
                if (trig == 0)
                {
                    switch (trigIndex)
                    {
                        case 0:
                            __result = new String[] { "<size=50%>", "cos(a + b)", "=", "cos(a)", "cos(b)", "-", "sin(a)", "sin(b)" };
                            break;
                        case 1:
                            __result = new String[] { "<size=50%>", "cos(a - b)", "=", "cos(a)", "cos(b)", "+", "sin(a)", "sin(b)" };
                            break;
                        case 2:
                            __result = new String[] { "<size=50%>", "sin(a - b)", "=", "sin(a)", "cos(b)", "-", "cos(a)", "sin(b)" };
                            break;
                        case 3:
                            __result = new String[] { "<size=50%>", "sin(a + b)", "=", "sin(a)", "cos(b)", "+", "cos(a)", "sin(b)" };
                            break;
                    }
                }
                else
                {
                    if (add == 1)
                    {
                        int result = num1 + num2 * num3;
                        __result = new String[] { num1.ToString(), "+", num2.ToString(), "x", num3.ToString(), "=", result.ToString(), "", "", "", "", "", "", "", "", "" };
                    }
                    else
                    {
                        int result = num1 - num2 * num3;
                        __result = new String[] { num1.ToString(), "-", num2.ToString(), "x", num3.ToString(), "=", result.ToString(), "", "", "", "", "", "", "", "", "" };
                    }
                }
            }
            else
            {
                if (trig == 0)
                {
                    switch (trigIndex)
                    {
                        case 0:
                            __result = new String[] { "<size=50%>", "cos(a + b)", "=", "cos(a)", "cos(b)", "+", "sin(a)", "sin(b)" };
                            break;
                        case 1:
                            __result = new String[] { "<size=50%>", "cos(a - b)", "=", "sin(a)", "cos(b)", "+", "cos(a)", "sin(b)" };
                            break;
                        case 2:
                            __result = new String[] { "<size=50%>", "sin(a - b)", "=", "sin(a)", "sin(b)", "-", "cos(a)", "cos(b)" };
                            break;
                        case 3:
                            __result = new String[] { "<size=50%>", "sin(a + b)", "=", "sin(a)", "cos(b)", "-", "cos(a)", "sin(b)" };
                            break;
                    }
                }
                else
                {
                    if (add == 1)
                    {
                        int result = num1 + num2 * num3 + 2;
                        __result = new String[] { num1.ToString(), "+", num2.ToString(), "x", num3.ToString(), "=", result.ToString(), "", "", "", "", "", "", "", "", "" };
                    }
                    else
                    {
                        int result = num1 - num2 * num3 - 2;
                        __result = new String[] { num1.ToString(), "-", num2.ToString(), "x", num3.ToString(), "=", result.ToString(), "", "", "", "", "", "", "", "", "" };
                    }
                }
            }
        }
    }


    [HarmonyPatch(typeof(BossOstrichSpeaker), "QustionCollectionCross", new Type[] { typeof(int), typeof(bool) })]
    public static class PatchQustionCollectionCross
    {
        private static void Postfix(ref String[] __result, int index, bool b)
        {
            int num1 = UnityEngine.Random.Range(1, 8);
            int num2 = UnityEngine.Random.Range(1, 8);
            int num3 = UnityEngine.Random.Range(1, 8);
            int add = UnityEngine.Random.Range(0, 1);
            int power = 2;

            int trig = UnityEngine.Random.Range(0, 2);
            int trigIndex = UnityEngine.Random.Range(0, 6);


            if (b)
            {
                if (trig == 0)
                {
                    switch (trigIndex)
                    {
                        case 0:
                            __result = new String[] { "<size=50%>", "cos(2a)", "=", "2", "*", "cos(a)^2", "-", "1" };
                            break;
                        case 1:
                            __result = new String[] { "<size=50%>", "cos(2a)", "=", "1", "-", "2", "sin(a)^2" };
                            break;
                        case 2:
                            __result = new String[] { "<size=50%>", "sin(2a)", "=", "2", "sin(a)", "cos(a)" };
                            break;
                        case 3:
                            __result = new String[] { "<size=30%>", "sin(a)", "cos(b)", "=", "1/2", "*", "[", "sin(a + b)", "+", "sin(a - b)", "]" };
                            break;
                        case 5:
                            __result = new String[] { "<size=30%>", "cos(a)", "cos(b)", "=", "1/2", "*", "[", "cos(a + b)", "+", "cos(a - b)", "]" };
                            break;
                        case 6:
                            __result = new String[] { "<size=30%>", "sin(a)", "sin(b)", "=", "-1/2", "*", "[", "cos(a + b)", "-", "cos(a - b)", "]" };
                            break;
                    }
                }
                else
                {
                    if (add == 1)
                    {
                        int result = (int)Math.Pow(num1, power) + num2 * num3;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "+", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                    else
                    {
                        int result = (int)Math.Pow(num1, power) - num2 * num3;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "-", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                }
            }
            else
            {
                if (trig == 0)
                {
                    switch (trigIndex)
                    {
                        case 0:
                            __result = new String[] { "<size=50%>", "cos(2a)", "=", "2", "*", "cos(a)^2", "+", "1" };
                            break;
                        case 1:
                            __result = new String[] { "<size=50%>", "cos(2a)", "=", "1", "+", "2", "sin(a)^2" };
                            break;
                        case 2:
                            __result = new String[] { "<size=50%>", "sin(2a)", "=", "2", "sin(a)", "sin(a)" };
                            break;
                        case 3:
                            __result = new String[] { "<size=30%>", "sin(a)", "cos(b)", "=", "-1/2", "*", "[", "sin(a + b)", "+", "sin(a - b)", "]" };
                            break;
                        case 5:
                            __result = new String[] { "<size=30%>", "cos(a)", "cos(b)", "=", "1/2", "*", "[", "sin(a + b)", "+", "sin(a - b)", "]" };
                            break;
                        case 6:
                            __result = new String[] { "<size=30%>", "sin(a)", "sin(b)", "=", "1/2", "*", "[", "cos(a + b)", "-", "cos(a - b)", "]" };
                            break;
                    }
                }
                else
                {
                    if (add == 1)
                    {
                        int result = (int)Math.Pow(num1, power) + num2 * num3 + 2;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "+", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                    else
                    {
                        int result = (int)Math.Pow(num1, power) - num2 * num3 - 2;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "-", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                }
            }
        }
    }


    [HarmonyPatch(typeof(BossOstrichSpeaker), "QustionCollectionHard", new Type[] { typeof(int), typeof(bool) })]
    public static class PatchQustionCollectionHard
    {
        private static void Postfix(ref String[] __result, int index, bool b)
        {
            int num1 = UnityEngine.Random.Range(1, 12);
            int num2 = UnityEngine.Random.Range(1, 12);
            int num3 = UnityEngine.Random.Range(1, 12);
            int add = UnityEngine.Random.Range(0, 1);
            int power = 2;

            int trig = UnityEngine.Random.Range(0, 2);
            int trigIndex = UnityEngine.Random.Range(0, 4);


            if (b)
            {
                if (trig == 0)
                {
                    switch (trigIndex)
                    {
                        case 0:
                            __result = new String[] { "<size=30%>", "sin(p)", "+", "sin(q)", "=", "2", "*", "sin([p+q]/2)", "*", "cos([p-q]/2)" };
                            break;
                        case 1:
                            __result = new String[] { "<size=30%>", "sin(p)", "-", "sin(q)", "=", "2", "*", "cos([p+q]/2)", "*", "sin([p-q]/2)" };
                            break;
                        case 2:
                            __result = new String[] { "<size=30%>", "cos(p)", "+", "cos(q)", "=", "2", "*", "cos([p+q]/2)", "*", "cos([p-q]/2)" };
                            break;
                        case 3:
                            __result = new String[] { "<size=30%>", "cos(p)", "-", "cos(q)", "=", "-2", "*", "sin([p+q]/2)", "*", "sin([p-q]/2)" };
                            break;
                    }
                }
                else
                {
                    if (add == 1)
                    {
                        int result = (int)Math.Pow(num1, power) + num2 * num3;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "+", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                    else
                    {
                        int result = (int)Math.Pow(num1, power) - num2 * num3;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "-", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                }
            }
            else
            {
                if (trig == 0)
                {
                    switch (trigIndex)
                    {
                        case 0:
                            __result = new String[] { "<size=30%>", "sin(p)", "+", "sin(q)", "=", "2", "*", "sin([p+q]/2)", "*", "sin([p-q]/2)" };
                            break;
                        case 1:
                            __result = new String[] { "<size=30%>", "sin(p)", "-", "sin(q)", "=", "2", "*", "cos([p+q]/2)", "*", "cos([p-q]/2)" };
                            break;
                        case 2:
                            __result = new String[] { "<size=30%>", "cos(p)", "+", "cos(q)", "=", "-2", "*", "cos([p+q]/2)", "*", "cos([p-q]/2)" };
                            break;
                        case 3:
                            __result = new String[] { "<size=30%>", "cos(p)", "-", "cos(q)", "=", "2", "*", "sin([p+q]/2)", "*", "sin([p-q]/2)" };
                            break;
                    }
                }
                else
                {
                    if (add == 1)
                    {
                        int result = (int)Math.Pow(num1, power) + num2 * num3 + 2;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "+", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                    else
                    {
                        int result = (int)Math.Pow(num1, power) - num2 * num3 - 2;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "-", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                }
            }
        }
    }


    [HarmonyPatch(typeof(BossOstrichSpeaker), "QustionCollectionHardEX", new Type[] { typeof(int), typeof(bool) })]
    public static class PatchQustionCollectionHardEX
    {
        private static void Postfix(ref String[] __result, int index, bool b)
        {
            int num1 = UnityEngine.Random.Range(1, 12);
            int num2 = UnityEngine.Random.Range(1, 12);
            int num3 = UnityEngine.Random.Range(1, 12);
            int add = UnityEngine.Random.Range(0, 1);
            int power = 2;

            int trig = UnityEngine.Random.Range(0, 2);
            int trigIndex = UnityEngine.Random.Range(0, 4);


            if (b)
            {
                if (trig == 0)
                {
                    switch (trigIndex)
                    {
                        case 0:
                            __result = new String[] { "<size=30%>", "sin(p)", "+", "sin(q)", "=", "2", "*", "sin([p+q]/2)", "*", "cos([p-q]/2)" };
                            break;
                        case 1:
                            __result = new String[] { "<size=30%>", "sin(p)", "-", "sin(q)", "=", "2", "*", "cos([p+q]/2)", "*", "sin([p-q]/2)" };
                            break;
                        case 2:
                            __result = new String[] { "<size=30%>", "cos(p)", "+", "cos(q)", "=", "2", "*", "cos([p+q]/2)", "*", "cos([p-q]/2)" };
                            break;
                        case 3:
                            __result = new String[] { "<size=30%>", "cos(p)", "-", "cos(q)", "=", "-2", "*", "sin([p+q]/2)", "*", "sin([p-q]/2)" };
                            break;
                    }
                }
                else
                {
                    if (add == 1)
                    {
                        int result = (int)Math.Pow(num1, power) + num2 * num3;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "+", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                    else
                    {
                        int result = (int)Math.Pow(num1, power) - num2 * num3;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "-", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                }
            }
            else
            {
                if (trig == 0)
                {
                    switch (trigIndex)
                    {
                        case 0:
                            __result = new String[] { "<size=30%>", "sin(p)", "+", "sin(q)", "=", "2", "*", "sin([p+q]/2)", "*", "sin([p-q]/2)" };
                            break;
                        case 1:
                            __result = new String[] { "<size=30%>", "sin(p)", "-", "sin(q)", "=", "2", "*", "cos([p+q]/2)", "*", "cos([p-q]/2)" };
                            break;
                        case 2:
                            __result = new String[] { "<size=30%>", "cos(p)", "+", "cos(q)", "=", "-2", "*", "cos([p+q]/2)", "*", "cos([p-q]/2)" };
                            break;
                        case 3:
                            __result = new String[] { "<size=30%>", "cos(p)", "-", "cos(q)", "=", "2", "*", "sin([p+q]/2)", "*", "sin([p-q]/2)" };
                            break;
                    }
                }
                else
                {
                    if (add == 1)
                    {
                        int result = (int)Math.Pow(num1, power) + num2 * num3 + 2;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "+", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                    else
                    {
                        int result = (int)Math.Pow(num1, power) - num2 * num3 - 2;
                        __result = new String[] { "(", num1.ToString(), ")^", power.ToString(), "-", num2.ToString(), "x", num3.ToString(), "=", result.ToString() };
                    }
                }
            }
        }
    }
}


