using System;

namespace DotaApiCore
{
    public static class SharedFunctions
    {
        public static DateTime UnixTimeStampToDateTime(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch);
        }
    }
}
