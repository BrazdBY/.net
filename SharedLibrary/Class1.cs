using System;

namespace SharedLibrary
{
    public static class SayHello
    {
        public static string GetHello(string username)
        {
            return $"{DateTime.Now}: Hello, {username}!";
        }
    }
}
