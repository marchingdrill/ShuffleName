namespace BlazorWasm1
{
    public class ShuffleWordService
    {
        // 文字列配列の順序をランダムに入れ替える
        public string[] Shuffle(IEnumerable<string> words)
        {
            var random = new Random();
            return words.OrderBy(_ => random.Next()).ToArray();
        }
    }
}
