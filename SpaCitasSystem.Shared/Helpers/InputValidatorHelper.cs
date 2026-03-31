using System.Text.RegularExpressions;

namespace SpaCitasSystem.Shared.Helpers
{
    public static class InputValidatorHelper
    {
        public static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        //TELEFONO RD
        public static void FormatearTelefonoRD(TextBox txt)
        {
            var digits = Regex.Replace(txt.Text, @"\D", "");

            if (digits.Length > 10)
                digits = digits.Substring(0, 10);

            if (digits.Length >= 7)
                txt.Text = $"{digits.Substring(0, 3)}-{digits.Substring(3, 3)}-{digits.Substring(6)}";
            else if (digits.Length >= 4)
                txt.Text = $"{digits.Substring(0, 3)}-{digits.Substring(3)}";
            else
                txt.Text = digits;

            txt.SelectionStart = txt.Text.Length;
        }
        public static bool EsTelefonoValido(string telefono)
        {
            var pattern = @"^(809|829|849)-\d{3}-\d{4}$";
            return Regex.IsMatch(telefono, pattern);
        }
    }
}
