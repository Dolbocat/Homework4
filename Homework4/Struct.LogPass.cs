     
struct Account
    {
        private string login;
        private string password;

        public override string ToString()
        {
            return $"{login}, {password}";
        }
        public bool AccountLogin(string userlogin = "geek")
        {
            login = userlogin;

            if (userlogin == "geek")
                return true;
            else
                return false;
        }
        public bool AccountPassword(string userpassword = "geekbrains")
        {
            password = userpassword;
            if (userpassword == "geekbrains")
                return true;
            else
                return false;
        }
    }

