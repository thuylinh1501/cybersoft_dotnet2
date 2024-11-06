class Bai3 {
    public static List<string> findAllStartM(List<string> strings) {
        List<string> results = new List<string>();
        foreach (string str in strings) {
            if (str.StartsWith("m")) { // str.Contains("m")==true
                results.Add(str);
            }
        }
        return results;
    }
}