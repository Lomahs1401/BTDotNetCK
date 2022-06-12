using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace BTDotNetCK.Validator
{
    public class Validators
    {
        public static string PHONE_REGEX = @"(84|0[3|5|7|8|9])+([\d]{8})\b";
        public static string ID_CARD_REGEX = @"^(\d{9})";
        public static string DATE_TIME_REGEX = @"(?<days>\d{2})/(?<months>\d{2})/(?<years>\d{4})";

        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
                return true;
            if (year % 4 == 0 && year % 100 != 0)
                return true;
            return false;
        }

        public static bool IsDateContainsAlphabet(string date)
        {
            return date.Any(alpha => char.IsLetter(alpha));
        }

        public static bool IsValidFormatDate(string date, string pattern)
        {
            if (Regex.IsMatch(date, pattern))
                return true;
            else
                return false;
        }

        public static string CheckDate(string date, string pattern)
        {
            string msg = "";
            int days = 0, months = 0, years = 0;
            Regex regex = new Regex(pattern);
            foreach (Match item in regex.Matches(date.ToString()))
            {
                days = Convert.ToInt32(item.Groups["days"].ToString());
                months = Convert.ToInt32(item.Groups["months"].ToString());
                years = Convert.ToInt32(item.Groups["years"].ToString());
            }
            if (months < 1 || months > 12 || days < 1 || days > 31)
            {
                msg = "Sai ngày hoặc tháng";
            }
            switch (months)
            {
                case 2:
                    if (IsLeapYear(years))
                    {
                        if (days > 29)
                        {
                            msg = "Năm nhuận không có ngày 30";
                        }
                        else
                            msg = "";
                    }
                    else
                    {
                        if (days > 28)
                        {
                            msg = "Năm không nhuận không có ngày 29";
                        }
                        else
                            msg = "";
                    }
                    break;
                case 4:
                    if (days > 30)
                    {
                        msg = "Tháng 4 không có ngày 31";
                    }
                    break;
                case 6:
                    if (days > 30)
                    {
                        msg = "Tháng 6 không có ngày 31";
                    }
                    break;
                case 9:
                    if (days > 30)
                    {
                        msg = "Tháng 9 không có ngày 31";
                    }
                    break;
                case 11:
                    if (days > 30)
                    {
                        msg = "Tháng 11 không có ngày 31";
                    }
                    break;
                default:
                    break;
            }
            return msg;
        }

        public static bool IsValidAge(string date, string pattern)
        {
            string days = "01", months = "01", years = "2000";
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy"); // Format current date to MM/dd/yyyy
            Regex regex = new Regex(pattern);
            foreach (Match item in regex.Matches(date))
            {
                days = item.Groups["days"].ToString();
                months = item.Groups["months"].ToString();
                years = item.Groups["years"].ToString();
            }
            if (Convert.ToInt32(currentDate.Substring(6, 4)) - Convert.ToInt32(years) > 18)
            {
                return true;
            }
            else if (Convert.ToInt32(currentDate.Substring(6, 4)) - Convert.ToInt32(years) == 18)
            {
                if (Convert.ToInt32(months) - Convert.ToInt32(currentDate.Substring(0, 2)) > 0)
                {
                    return true;
                }
                else if (Convert.ToInt32(months) - Convert.ToInt32(currentDate.Substring(0, 2)) == 0)
                {
                    if (Convert.ToInt32(days) - Convert.ToInt32(currentDate.Substring(3, 2)) >= 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidDate(string date, string pattern)
        {
            string days = "01", months = "01", years = "2000";
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy"); // Format current date to MM/dd/yyyy
            Regex regex = new Regex(pattern);
            foreach (Match item in regex.Matches(date.ToString()))
            {
                days = item.Groups["days"].ToString();
                months = item.Groups["months"].ToString();
                years = item.Groups["years"].ToString();
            }
            if (Convert.ToInt32(years) - Convert.ToInt32(currentDate.Substring(6, 4)) > 0)
            {
                return false;
            }
            else if (Convert.ToInt32(years) - Convert.ToInt32(currentDate.Substring(6, 4)) == 0)
            {
                if (Convert.ToInt32(months) - Convert.ToInt32(currentDate.Substring(0, 2)) > 0)
                {
                    return false;
                }
                else if (Convert.ToInt32(months) - Convert.ToInt32(currentDate.Substring(0, 2)) == 0)
                {
                    if (Convert.ToInt32(days) - Convert.ToInt32(currentDate.Substring(3, 2)) > 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                if (email == "")
                    return false;
                else
                {
                    MailAddress mail = new MailAddress(email);
                    return true;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool IsValidPhoneNumber(string phone, string pattern)
        {
            if (Regex.IsMatch(phone, pattern))
                return true;
            else
                return false;
        }

        public static bool IsValidIdCard(string ID_Card, string pattern)
        {
            if (Regex.IsMatch(ID_Card, pattern))
                return true;
            else
                return false;
        }
    }
}
