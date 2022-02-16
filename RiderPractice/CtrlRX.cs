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
        /// 提取變數
        /// </summary>
        /// <param name="age"></param>
        /// <param name="originPrice"></param>
        /// <returns></returns>
        public int GetDiscountedPrice(int age, int originPrice)
        {
            // 反白 return 後方的結果 (遊標在age變數上，按一下tab，會預設向後反白最大的區塊)
            // 下 ctrl+R+V，可以提取變數
            return age >= 5 ? originPrice : (int) Math.Ceiling(originPrice * 0.8);
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

        /// <summary>
        /// 修改參數順序、移除參數: Ctrl + R + S
        /// </summary>
        /// <returns></returns>
        public void CtrlRS()
        {
            // 對 DoSomeThing 下 Ctrl+R+S，會跳出可以調整參數順序、移除參數的面版，一但改變，所有調用的函式都會跟著改
            DoSomeThing(123, "abc", 0.5);
            DoSomeThing(456, "def", 0.6);
            DoSomeThing(789, "ghi", 0.7);
        }

        private void DoSomeThing(int number, string text, double doubleNum)
        {
            // do nothing
        }

        /// <summary>
        /// 提取屬性: Ctrl+R+F
        /// </summary>
        public void CtrlRF()
        {
            // 對 myModel 下 Ctrl+R+F, 可以提取為類別的屬性
            var myModel = new MyModel();
        }

    }
    
    public class MyModel
    {
    }
}
