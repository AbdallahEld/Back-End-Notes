namespace Boxind_and_Unboxing_Challenge
{
    public static class Helper
    {
        public static void FormatUserLog(int id, DateTime time, Span<char> buffer)
        {
            int pos = 0;

            "User ".AsSpan().CopyTo(buffer[pos..]);
            pos += 5;

            id.TryFormat(buffer[pos..], out int written);
            pos += written;

            " logged in at ".AsSpan().CopyTo(buffer[pos..]);
            pos += 14;

            time.TryFormat(buffer[pos..], out written);
        }
        public static string FormatUserLogV2(int id, DateTime time)
        {
            return $"User {id} logged in at {time}";
        }
    }
}
