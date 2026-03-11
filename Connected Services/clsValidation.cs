using BusinessLayer;
using System;
using System.Text.RegularExpressions;

namespace bescnesLayer
{
    public class clsValidation
    {
        // تحقق من نص فارغ
       static public bool IsNotEmpty(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        // تحقق من الايميل
        static public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // تحقق الرقم القومي
        static public bool IsNationalNoValid(string nationalNo, string currentNo)
        {
            // 1) ممنوع يكون فاضي
            if (string.IsNullOrWhiteSpace(nationalNo))
                return false;

            // 2) لازم 14 رقم
            //if (nationalNo.Length != 14)
            //    return false;

            // 3) لازم يكون كله أرقام
            //if (!Regex.IsMatch(nationalNo, @"^\d{14}$"))
            //    return false;

            // 4) لو الرقم بتاع الشخص الحالي → OK
            if (nationalNo == currentNo)
                return true;

            // 5) لو مترتبش على حد تاني → OK
            return !clsContact.isPepoleEXsist(nationalNo);
        }


        // تحقق رقم الهاتف
        static public bool IsPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;

            string pattern = @"^\d{10,15}$"; // بين 10 و15 رقم
            return Regex.IsMatch(phone, pattern);
        }

        // تحقق رقم صحيح (Integer)
        static public bool IsInteger(string input)
        {
            return int.TryParse(input, out _);
        }

        // تحقق رقم عشري (Decimal)
        static public bool IsDecimal(string input)
        {
            return decimal.TryParse(input, out _);
        }

        // تحقق رقم داخل نطاق معين
        static public bool IsNumberInRange(string input, decimal min, decimal max)
        {
            if (decimal.TryParse(input, out decimal num))
            {
                return num >= min && num <= max;
            }
            return false;
        }

        // تحقق تاريخ
        static public bool IsValidDate(string dateStr)
        {
            return DateTime.TryParse(dateStr, out _);
        }

        // تحقق طول النص بين min و max
        static public bool IsLengthValid(string input, int minLength, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            return input.Length >= minLength && input.Length <= maxLength;
        }

        // تحقق نص يحتوي على أرقام فقط
        static public bool IsNumeric(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^\d+$");
        }

        // تحقق نص يحتوي على حروف فقط
        static public bool IsAlpha(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
    }
}
