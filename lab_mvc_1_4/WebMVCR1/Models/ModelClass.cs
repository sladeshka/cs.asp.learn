namespace WebMVCR1.Models
{
    public class ModelClass
    {
        public static string Hello() {
            return (DateTime.Now.Hour < 12 ? "Good morning" : "Good afternoon");
        }
    }
}
