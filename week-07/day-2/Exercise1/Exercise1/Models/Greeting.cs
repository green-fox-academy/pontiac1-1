namespace Exercise1.Models
{
    public class Greeting
    {
        public static int id = 0;
        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting(string content = null)
        {
            Id = id++;
            Content = content;
        }
    }
}
