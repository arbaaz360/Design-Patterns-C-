using System;

namespace Observer
{
    public class SpreadSheet : IObserver
    {
        private DataSource dataSource { get; set; }

        public SpreadSheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            
            Console.WriteLine("Totals Spreadsheet got updated."+ this.dataSource.GetValue());
        }
    }
}
