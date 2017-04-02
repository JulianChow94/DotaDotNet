using System;
using System.Threading.Tasks;
using DotaApiCore.Requests;

namespace DotaApiCore.SharedLib
{
    internal static class SharedFunctions
    {
        public static DateTime UnixTimeStampToDateTime(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch);
        }

        public static async Task<string> SendAndValidateRequest(Request request)
        {
            var result = request.SendRequest();
            result.EnsureSuccessStatusCode();

            var response = await result.Content.ReadAsStringAsync();

            return response;
        }
    }
}
