namespace Observer
{
    public class DataSource :Subject
    {
        private string value { get; set; }
        public string GetValue()
        {
            return value;
        }
        public void SetValue(string value)
        {
            this.value = value;
            this.NotifyObservers();
        }
    }
}
