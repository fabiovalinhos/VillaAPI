namespace MagicVilla_VillaAPI.Logging
{
    public class Logging : Ilogging
    {
        public void Log(string message, string type)
        {
            if (type == "error")
            {
                Console.WriteLine($"Error - {type}");
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}