class Bai2 {
     public static List<int> twoSumDictionary(List<int> lst, int target){
        // Khai báo 1 dictionary để đánh dấu từng số trong danh sách lst
        // key lưu giá trị từng phần tử của mảng
        // value lưu chỉ số của phần tử tương ứng
        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();
        for (int i = 0; i < lst.Count; i++){
            int completion = target - lst[i];
            if(seenNumbers.ContainsKey(completion)){
                return new List<int> {seenNumbers[completion], i};
            } else {
                // nếu completion không nằm trong dic => add vào dic để đánh dấu
                seenNumbers.Add(lst[i], i);
            }
        }
        return null;
    }
}