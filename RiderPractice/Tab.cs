using System.Collections.Generic;
using System.Linq;

namespace RiderPractice
{
    /// <summary>
    /// tab 快速選取程式碼
    /// </summary>
    public class Tab
    {
        /*
            不需要理解下列程式碼的內容
            請將遊標放在第一個 if 的 i 和 f 之間，然後按下tab鍵
            你會發現當你的遊標「不是在行首」的時候，tab的行為不是插入縮排，而是反白選取一個程式碼區塊
            按下第一次時預設選取最大的區塊，繼續按tab會縮小選取的範圍，縮到最小再按就會變成導覽每一個變數或宣告區塊
            
            你可以嘗試將遊標放在這段程式碼的任意位置(比如：參數、函式名稱…)按tab，或是shift+tab，你會理解它選取、導覽的規則
            
            Tips: 
            1. 善用tab，可以快速導覽修改物件屬性值、快速選取程式碼區塊…
            2. 可以快速移動到某個code block之下 (tab反白一個code block，再按向右或向下方向鍵)，code block指由換行隔開的程式碼區塊
            3. 當遊標在行尾時，可以用 shift + tab，快速反白最後一個項目
         */
        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0)
                return new List<string>();
            
            var map = new Dictionary<char, List<string>> {
                {'2', new List<string> { "a", "b", "c" }},
                {'3', new List<string> { "d", "e", "f" }},
                {'4', new List<string> { "g", "h", "i" }},
                {'5', new List<string> { "j", "k", "l" }},
                {'6', new List<string> { "m", "n", "o" }},
                {'7', new List<string> { "p", "q", "r", "s" }},
                {'8', new List<string> { "t", "u", "v" }},
                {'9', new List<string> { "w", "x", "y", "z" }},
            };
            
            if (digits.Length == 1) 
                return map[digits[0]];

            var result = map[digits[0]];
            for (var i = 1; i < digits.Length; i++)
            {
                var digit = digits[i];
                result = (from newChar in map[digit] from resItem in result select resItem + newChar).ToList();
            }
            return result;
        }
    }
}