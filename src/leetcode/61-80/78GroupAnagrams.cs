internal static partial class Problem
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        List<IList<string>> res = [];
        Dictionary<string, List<string>> dic = [];

        foreach (string item in strs)
        {
            char[] aitem = item.ToCharArray();
            Array.Sort(aitem);
            string sorted = new string(aitem);

            if (dic.TryGetValue(sorted, out List<string> arr))
            {
                arr.Add(item);
                dic[sorted] = arr;
            }
            else
            {
                dic[sorted] = new() { item };
            }
        }

        foreach ((string key, List<string> value) in dic)
        {
            res.Add(value);
        }

        return res;
    }

     public static IList<IList<string>> GroupAnagramsFaster(string[] strs) 
    {
        Dictionary<string, List<string>> result = [];

        foreach(var s in strs)
        {
            char[] count = new char[26];
            foreach(var c in s)
            {
                count[c - 'a']++;
            }
            var key = new string(count);
            if(!result.ContainsKey(key)){
                result[key] = [];
            }
            result[key].Add(s);
        }

         return [.. result.Values];
    }
    

}
