using System.Globalization;

namespace carvedrock.bl.principles
{
    /// <summary>
    /// definition keep it simple, stupid
    /// definicio mantelo simple, estupido
    /// </summary>
    public class KISS
    {
        public string GetMonth(int month)
        {
            var NicCulture = new CultureInfo("es-NI");
            DateTimeFormatInfo nicaraguaDateTimeFormat = (DateTimeFormatInfo)NicCulture.DateTimeFormat.Clone();

            if ((month < 1) || (month > 12)) throw new InvalidOperationException("The month must be in range 1 to 12");

            return nicaraguaDateTimeFormat.GetMonthName(month);
        }
    }
}