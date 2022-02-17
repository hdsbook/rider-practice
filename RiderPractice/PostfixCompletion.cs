using System.Collections.Generic;

namespace RiderPractice
{
    /// <summary>
    /// Postfix completion
    /// 指標放在每一個函式的句末，tab展開
    /// </summary>
    public class PostfixCompletion
    {
        /// <summary>
        /// 可以推遲「命名」這件事，專注在如何產生資料，最後再決定要命名為何
        /// </summary>
        public void dotVar()
        {
            new User().var
        }
        
        public void dotIf(int a)
        {
            a > 0.if
        }
        
        public void dotNot(int a)
        {
            a > 0.not
        }
        
        public void dotUsing()
        {
            new User().using
        }
        
        public void dotNew()
        {
            UserRepository.new
        }
        
        public void dotReturn()
        {
            new Result().return
        }
        
        public void dotForeach()
        {
            var items = new List<int> {1, 2, 3};
            items.foreach
        }

        public void dotSwitch(GenderEnum gender)
        {
            gender.switch
        }
    }

    public enum GenderEnum
    {
        Male = 1,
        Female = 2,
    }

    public class Result
    {
    }

    public class UserRepository
    {
    }
    
    public class User
    {
    }
}