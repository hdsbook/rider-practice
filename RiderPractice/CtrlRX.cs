using System;

namespace RiderPractice
{
    /// <summary>
    /// Ctrl R 系列快捷鍵
    /// </summary>
    public class CtrlRX
    {
        /// <summary>
        /// 省略變數宣告 Inline: Ctrl + R + I
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public bool IsNotAdult(int age)
        {
            // 對 isNotAdult 下 ctrl+R+I，可以簡化為一行(省去變數宣告 inline statement)
            var isNotAdult = age < 18;
            return isNotAdult;
        }
        
        /// <summary>
        /// 提取變數 Introduce Variable: Ctrl + R + V
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public bool IsAdult(int age)
        {
            // 反白 age >= 18，下Ctrl+R+V，提取變數為 isAdult
            return age >= 18;
        }
        
        /// <summary>
        /// 提取參數 Introduce Parameter: Ctrl + R + P
        /// </summary>
        /// <returns></returns>
        public bool CheckIsAdult()
        {
            // 對 age 下 ctrl+R+P，可以提取參數
            int age = 18;
            return age >= 18;
        }

        /// <summary>
        /// 提取函式 Introduce Method: Ctrl + R + M
        /// </summary>
        /// <returns></returns>
        public string GetSortedListString()
        {
            var list = new[] {1, 2, 3, 4, 5};

            
            // 反白以下程式碼到 for 結束，下Ctrl+R+M，選擇 extract method，將此區塊提取函式取名為 BubbleSort
            var len = list.Length;
            for (var i = 1; i <= len - 1; i++)
            for (var j = 1; j <= len - i; j++)
            {
                if (list[j] < list[j - 1])
                    (list[j], list[j - 1]) = (list[j - 1], list[j]); //二數交換
            }
            // 反白至此
            

            return string.Join(",", list);
        }
    }
}
