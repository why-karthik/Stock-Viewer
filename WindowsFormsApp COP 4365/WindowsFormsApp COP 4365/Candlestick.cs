using System;

namespace WindowsFormsApp_COP_4365
{
    internal class Candlestick
    {
        //Initialize candlestick data variables using getter and setter properties
        public decimal open { get; set; } // Represents the opening price of the candlestick
        public decimal high { get; set; } // Represents the highest price of the candlestick
        public decimal low { get; set; } // Represents the lowest price of the candlestick
        public decimal close { get; set; } // Represents the closing price of the candlestick
        public ulong volume { get; set; } // Represents the volume of the candlestick
        public DateTime date { get; set; } // Represents the date of the candlestick

        public Candlestick(string rowOfData)
        {
            //Initializes delimiters and splits data into array based on them
            char[] seperators = new char[] { ',', ' ', '"' };
            string[] subs = rowOfData.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            //Get date string to send to DateTime.Parse
            string dateString = subs[0];
            //Parse data
            date = DateTime.Parse(dateString);

            //Create temporary variable for each entry then parse data value and store on successful parse
            decimal temp;
            bool success = decimal.TryParse(subs[1], out temp);
            if (success) open = temp;

            success = decimal.TryParse(subs[2], out temp);
            if (success) high = temp;

            success = decimal.TryParse(subs[3], out temp);
            if (success) low = temp;

            success = decimal.TryParse(subs[4], out temp);
            if (success) close = temp;

            ulong tempVolume;
            success = ulong.TryParse(subs[6], out tempVolume);
            if (success) volume = tempVolume;
        }
    }
}
