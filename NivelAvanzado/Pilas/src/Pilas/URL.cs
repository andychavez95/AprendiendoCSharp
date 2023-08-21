namespace Pilas
{
    public class URL
    {
        private string url;
        
        public URL (string url)
        {
            this.url = url;
        }

        public string getURL()
        {
            return this.url;
        }

        public void setURL(string url)
        {
            this.url = url;
        }
    }
}
