using System.Text.RegularExpressions;

namespace PringlesApp.MVVM.Model
{
    public enum PasswordScore
    {
        Blank = 0,
        VeryWeak = 1,
        Weak = 2,
        Medium = 3,
        Strong = 4,
        VeryStrong = 5
    }



    public class PasswordAdvisor
    {
        public static int CheckStrength(string password)
        {
            int score = 0;

            if (password is null)
                return score;
            if (password.Length < 4)
                return score;

            if (password.Length >= 6)
                score++;
            if (password.Length >= 10)
                score++;
            if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))   //number only //"^\d+$" if you need to match more than one digit.
                score++;
            if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //both, lower and upper case
                score++;
            if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript)) //^[A-Z]+$
                score++;

            return score;
        }

    }
}