namespace PracticeOnMVC.Models
{
    public class UserDal
    {
        List<User> users;
        public UserDal()
        {
            users = new List<User>()
            {
                new User() { UserName = "abc", Passwaord = "abc12", Email = "abc@gmail.com" },
                new User() { UserName = "xyz", Passwaord = "xyz@gmail.com", Email = "xyz@gmail.com" }
            };
        }

        public int ValidateUser(User user)
        {
            int res = 0;
            foreach (User u  in users)
            {
                if(u.UserName == user.UserName && u.Passwaord==user.Passwaord)
                {
                    res = 1;
                    break;
                }
            }
            return res;
        }
    }
}
