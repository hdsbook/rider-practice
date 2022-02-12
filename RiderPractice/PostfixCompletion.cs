using System.Collections.Generic;

namespace RiderPractice
{
    public class PostfixCompletion
    {
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