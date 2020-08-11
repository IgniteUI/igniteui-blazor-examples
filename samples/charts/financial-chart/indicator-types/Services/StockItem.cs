using System;

namespace Samples.Services
{    
    public class StockItem
    {
        public DateTime Time { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
        public int Index { get; set; }
        public string Label {  get { return this.Time.ToShortDateString(); } }
                
        public new string ToString()
        {
            return this.Time.ToString("MMM/dd/yyyy") + " " + this.Open.ToString("0");
        }

        public StockItem Clone()
        {
            var copy = new StockItem();
            copy.Time = this.Time; 
            copy.Open = this.Open; 
            copy.High = this.High; 
            copy.Low = this.Low; 
            copy.Close = this.Close; 
            copy.Volume = this.Volume;
            return copy;
        }        
    }
    
}
