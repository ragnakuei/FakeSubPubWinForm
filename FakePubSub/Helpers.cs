using System.Collections.Generic;

namespace FakePubSub
{
    public static class Helpers
    {
        public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key)
        {
            dict.TryGetValue(key, out TValue result);
            return result;
        }
    }
}