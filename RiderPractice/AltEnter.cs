using System;

namespace RiderPractice
{
    /// <summary>
    /// 萬用鍵 Alt+Enter
    /// </summary>
    public class AltEnter
    {
        /// <summary>
        /// 反轉 if、轉為 ?:
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public int InvertIf(int age)
        {
            const int ticketPrice = 100;

            // 對 if 下 alt+enter 可以選擇 invert if, 或是 convert to ?: statement
            if (age >= 18)
            {
                return ticketPrice;
            }
            else
            {
                return (int) Math.Ceiling(ticketPrice * 0.8);
            }
        }

        /// <summary>
        /// 修正錯誤回傳型態
        /// </summary>
        /// <param name="age"></param>
        public void FixWrongResultType(int age)
        {
            const int originPrice = 100;
            var discountedPrice = age >= 18 ? originPrice :  (int) Math.Ceiling(originPrice * 0.8);
            
            // 對 discountedPrice 下 alt+enter 修正錯誤的回傳型態 (Change type of ... to int)
            // 這使我們可以在建立方法時都先宣告為 void，直到最後return時再快速決定回傳的型態為何
            return discountedPrice;
        }
        
        /// <summary>
        /// cast to int
        /// </summary>
        /// <param name="age"></param>
        public int CastToType(int age)
        {
            const int originPrice = 100;
            int discountedPrice;
            
            if (age >= 18)
            {
                discountedPrice = originPrice;
            }
            else
            {
                // 對 Math.Ceiling 下 alt+enter，選擇 cast to int
                discountedPrice = Math.Ceiling(originPrice * 0.8);
            }
            
            return discountedPrice;
        }

        /// <summary>
        /// 提取變數
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public int IntroduceVariable(int age)
        {
            const int originPrice = 100;

            // 反白 return 後方的結果 (遊標在age變數上，按一下tab，會預設向後反白最大的區塊)
            // 下 alt+enter，選擇 introduce variable，可以給複雜的運算式一個好懂的變數名稱(如 discountedPrice)
            return age >= 18 ? originPrice : (int) Math.Ceiling(originPrice * 0.8);
        }

        /// <summary>
        /// 提取參數
        /// </summary>
        public int IntroduceParameter()
        {
            const int originPrice = 100;

            // 對 age 下 alt+enter，選擇 create parameter ... in containing method
            var discountedPrice = age >= 18 ? originPrice : (int) Math.Ceiling(originPrice * 0.8);
            return discountedPrice;
        }

        /// <summary>
        /// 建立類別
        /// </summary>
        public void IntroduceClass()
        {
            // 對 MyClass 下 alt+enter 選擇 create nested type ... 快速建立類別
            // 選擇 create nested type 會建立在比較近的地方(函式正下方)，create type 會建立在較遠的地方
            var userA = new MyClass
            {

            };

            // 也可以建立Enum，建立後的第一個步驟可以調整建立的類型 type/struct/enum
            var myEnum = new MyEnum
            {

            };
        }

        /// <summary>
        /// 建立屬性
        /// </summary>
        public void IntroduceField()
        {
            // 對 每一個尚未建立的屬性下 alt+enter，可快速建立屬性
            // 建立 Gender 屬性之前，可以先建立GenderEnum、再建立Gender屬性(這樣Gender就會預設帶入GenderEnum的型別)
            // 可以利用 alt+page up/down 在錯誤點間移動
            var userA = new User
            {
                Name = "王小明",
                Age = 18,
                Gender = GenderEnum.Male,
            };
        }

        private class User
        {
        }

        /// <summary>
        /// Initialize members 初始化屬性成員
        /// </summary>
        public void InitializeMembers()
        {
            // 在空的大括孤中下 alt+enter，選擇Initialize members
            var product = new Product
            {
                
            };
        }

        public class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public int Discount { get; set; }
            public DateTime DueDate { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
            public int CreateUserId { get; set; }
            public int UpdateUserId { get; set; }
        }

        /// <summary>
        /// 修正拼字筆誤
        /// </summary>
        /// <returns></returns>
        public string FixTypo()
        {
            // 對有拼字筆誤的變數下 alt+enter，選擇 Typo in...Rename to...，會出現建議的命名修正
            var naem = "王小明";
            var messege = "弄壞了";
            var mchine = "洗衣機";
            return naem + messege + mchine;
        }

        public string UseStringInterpolation()
        {
            const string name = "王小明";
            const string message = "弄壞了";
            const string machine = "洗衣機";
            // 對 string.Format 下 alt+enter，選擇Use string interpolation 簡化寫法
            return string.Format("{0}{1}{2}", name, message, machine);
        }
        
    }

}