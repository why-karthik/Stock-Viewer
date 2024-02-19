using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_COP_4365
{
    public partial class Form_Project_1 : Form
    {
        
        private List<Candlestick> candlesticks = null; //List to hold Candle Sticks

        private List<Candlestick> filterCandlesticks = null; //List to hold Filtered Candle Sticks

        private BindingList<Candlestick> boundCandlesticks = null; //Binding list of candlesticks

        private DateTime startDate = new DateTime(2022,01,01); //starting date by user
        private DateTime endDate = DateTime.Now; //ending date by user

        /// <summary>
        /// Form constructor
        /// </summary>
        public Form_Project_1()
        {
            InitializeComponent();
            //Construct list of candlesticks with size 1024
            candlesticks = new List<Candlestick>(1024);
        }

        /// <summary>
        /// Triggers the event to open File dialog if Stock Picker got clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_StockPicker_Click(object sender, EventArgs e)
        {
            //On button click changes the text
            Text = "Stock Picker Clicked";

            //OPens the File directory where stocks are stored
            openFileDialog_StockPicker.ShowDialog();
        }

        /// <summary>
        /// Update button clicked will edit the chart based on the selected range of dates by user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Update_Click(object sender, EventArgs e)
        {
            //Makesures that the date format is right and they are in correct order
            if ((candlesticks.Count != 0) & (startDate <= endDate))
            {
                //candle sticks will be filtered candlesticks according to date range
                filterList();

                //Displays the filtered candle sticks
                displayCandlesticks();
            }
        }

        /// <summary>
        /// When file is choosed, if reads the file, filteres the candle sticks and then displays them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog_StockPicker_FileOk(object sender, CancelEventArgs e)
        {
            //Display text on the Windows Form
            this.Text = "Loading Slected File...";
            //Read file and makes candlesticks
            goReadFile();
            //candle sticks will be filtered candlesticks according to date range 
            filterList();
            //Displays the filtered candle sticks
            displayCandlesticks();
        }

        /// <summary>
        /// Reads the .csv file provided and makes the candle sticks
        /// </summary>
        /// <param name="filename">"Name of the file"</param>
        /// <returns>returns a list of candle sticks</returns>
        private List<Candlestick> goReadFile(string filename)
        {
            //Display filename on the Windos Form
            this.Text = Path.GetFileName(filename);
            //Reference string to check whether the format we are anticipating is same as the file
            const string referenceString = "Date,Open,High,Low,Close,Adj Close,Volume";

            //list to store candle sticks
            List<Candlestick> list = new List<Candlestick>();
            //Pass file path and filename to StreamReader constructor
            using (StreamReader sr = new StreamReader(filename))
            {
                //Reads the first line
                string line = sr.ReadLine();
                //checks whether the format is correct
                if (line == referenceString)
                {
                    //Reads each line in the file
                    while((line = sr.ReadLine()) != null)
                    {
                        //make a new candlestick based on the read line
                        Candlestick cs = new Candlestick(line);
                        list.Add(cs);
                    }
                    list.Reverse();
                }
                //if File Data is not in the expected format
                else
                { Text = "Bad File: " + Path.GetFileName(filename); }
            }
            return list; //Return the list of candle sticks
        }

        /// <summary>
        /// goReadFile overLoad Function
        /// </summary>
        private void goReadFile()
        {
            //reads the data and returns candle sticks
            candlesticks = goReadFile(openFileDialog_StockPicker.FileName);
            //The candlestciks are made into a bindinglist
            boundCandlesticks = new BindingList<Candlestick>(candlesticks);
        }

        /// <summary>
        /// Filters the candlesticks based on the start and end dates provided by the User
        /// </summary>
        /// <param name="list">"List of Candle Sticks"</param>
        /// <returns>Filtered list of Candlesticks</returns>
        private List<Candlestick> filterList(List<Candlestick> list, DateTime start, DateTime end)
        {
            List<Candlestick> filteredList = new List<Candlestick>(list.Count);
            //Iterates over all candlesticks to add them to filteredlist  based on their date
            foreach (Candlestick cs in list) 
            {
                //Check if date is inclusively within range and store in filtered list
                if ((cs.date >= start) & (cs.date <= end))
                { filteredList.Add(cs); }
            }
            return filteredList;
        }

        /// <summary>
        /// Overload for filterList method
        /// </summary>
        private void filterList()
        {
            //Filters the candlesticks based on the start and end dates provided by the User
            filterCandlesticks = filterList(candlesticks, startDate, endDate);
            //bindiglist of filtered candlesticks
            boundCandlesticks = new BindingList<Candlestick>(filterCandlesticks);
        }

        /// <summary>
        /// Displays the normalized chart of candlesticks
        /// </summary>
        /// <param name="bindList"> BindingList of candle sticks</param>
        private void displayCandlesticks(BindingList<Candlestick> bindList)
        {
            //Datasource of datagrid view is set to bindinglist of candle sticks
            dataGridView_Candlestick.DataSource = bindList;

            //normalize the chart y axis based on the lowest of low and highest of highs
            normalizeChart();

            //Datasource of chart is set to binding list of candlesticks
            chart_OHLCV.DataSource = bindList;
            chart_OHLCV.DataBind();
        }

        /// <summary>
        /// Overloading displayCandlesticks
        /// </summary>
        private void displayCandlesticks()
        {
            //Displays the normalized chart of candlesticks
            displayCandlesticks(boundCandlesticks);
        }

        /// <summary>
        /// Normalized the Y axis of chart by geting the lowest of low and highest of high in the bindinglist
        /// </summary>
        /// <param name="bindList">Binding List of candle sticks</param>
        private void normalizeChart(BindingList<Candlestick> bindList)
        {
            //Set starting conditions for min and max variables
            decimal min = bindList.First().low, max = 0;
            //Iterate through each candle stick in list
            foreach (Candlestick c in bindList) 
            {
                //Check for greatest value (Ymax) and lowest value (Ymin)
                if (c.low < min) { min = c.low; }
                if (c.high > max) { max = c.high; }
            }
            //Set the Y axis of the chart area to (+-)2% of the ranges rounded to 2 decimal places
            chart_OHLCV.ChartAreas["ChartArea_OHLC"].AxisY.Minimum = Math.Round(Decimal.ToDouble(min) * 0.98, 2);
            chart_OHLCV.ChartAreas["ChartArea_OHLC"].AxisY.Maximum = Math.Round(Decimal.ToDouble(max) * 1.02, 2);
        }

        /// <summary>
        /// Overloading of normalizeChart method
        /// </summary>
        private void normalizeChart()
        {
            //Normalizes the Y axis of chart by geting the lowest of low and highest of high in the bindinglist
            normalizeChart(boundCandlesticks);
        }

        /// <summary>
        /// Date time picker event to update starting date when value of start date is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            //Storing the starting date
            startDate = dateTimePicker_startDate.Value;
        }

        /// <summary>
        /// Date time picker event to update starting date when value of end date is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_endDate_ValueChanged(object sender, EventArgs e)
        {
            //Storing the ending date
            endDate = dateTimePicker_endDate.Value;
        }

        private void dataGridView_Candlestick_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Project_1_Load(object sender, EventArgs e)
        {

        }
    }
}
