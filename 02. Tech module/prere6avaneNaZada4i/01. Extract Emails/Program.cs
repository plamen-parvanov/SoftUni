namespace _01.Extract_Emails
{

    using System;
    using System.Text.RegularExpressions;

    public class RegexEx
    {

        public static void Main()
        {


            string pettern = @"(\s|^)[a-z0-9]+([-._][a-z0-9]+)?@([a-z]+\-?[a-z]+\.)?([a-z]+\-?[a-z]+\.[a-z]+)";
            //@"([a-z]+|[0-9]+)(\.[a-z]+|[0-9]+|[a-z]+|_[a-z]+|-[a-z]+)@[a-z]+(-[a-z]+\.[a-z]+|\.[a-z]+\.[a-z]+|\.[a-z]+)";
            Regex regex = new Regex(pettern);

            string text = Console.ReadLine();

           // var text = ".Examples of valid users: stephan@abv.bg , mike03@abv.bg, s.johnson@abv.bg, st_steward@abv.bg, softuni-bulgaria@abv.bg, 12345@abv.bg.Examples of invalid users: --123@abv.bg, .....@abv.bg, nakov_ -@abv.bg, _steve @abv.bg, .info@abv.bg. < host > is a sequence of at least two words, separated by dots .Each word is sequence of letters and can have hyphens  between the letters.Examples of hosts: 123@softuni.bg, 123@software-university.com, 123@intoprogramming.info, 123@mail.softuni.org.Examples of invalid hosts: 123@helloworld, 123@.unknown.soft., 123@invalid-host-, 123@invalid - .Examples of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy.Examples of invalid emails: --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld, mike@.unknown.soft., s.johnson@invalid-.";

            MatchCollection matches = regex.Matches(text);
           

            foreach (Match email in matches)
            {
                
                    Console.WriteLine(email.Value);
                
            }
        }
    }
}
