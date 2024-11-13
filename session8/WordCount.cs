class WordCount {
    public static Dictionary<string, int> wordCount(List<string> words){
        Dictionary<string, int> count = new Dictionary<string, int>();
        // C1: duyệt for theo index
        for (int i = 0; i < words.Count; i++){
            if(count.ContainsKey(words[i])){
                count[words[i]]++; // xuất hiện nhiều lần
            } else {
                count[words[i]] = 1; // xuất hiện lần đầu
            }
        }
        // C2: duyệt for theo từng item
        foreach (string word in words){
            if(count.ContainsKey(word)){
                count[word]++; // xuất hiện nhiều lần
            } else {
                count[word] = 1; // xuất hiện lần đầu
            }
        }
        return count;
    }
}