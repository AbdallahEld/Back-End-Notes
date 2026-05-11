using static Intoduction_To_Delegate.Program;

namespace Intoduction_To_Delegate
{
    internal class Util
    {
        internal static void HardWrok(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10);
                Thread.Sleep(100);
            }
        }


        internal static void Transform<T>(T[] values, Transformer<T> t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }

        internal static void TransformAll(int[] values, ITransformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t.Transform(values[i]);
        }
    }
}
