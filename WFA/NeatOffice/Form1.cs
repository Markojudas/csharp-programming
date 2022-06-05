using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace NeatOffice
{
    public partial class MainForm : Form
    {
        private GraphAlgorithms g;
        private PrintDocument printDocument = new PrintDocument();
        private string stringToPrint;
        private bool endPrint;

        public MainForm()
        {
            InitializeComponent();
            clock.Start();
            g = new GraphAlgorithms(toolStripProgressBar1, toolStripStatusLabel2, statusStrip2);
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            endPrint = false;
        }

        static bool equalFlag;

        private void Button_Click(object sender, EventArgs e)
        {
            if (equalFlag)
                calc_display.Text = "";


            if (((Button)sender).Text == ".")
            {
                calc_display.Text += "0" + ((Button)sender).Text;
            }
            else
            {
                calc_display.Text += ((Button)sender).Text;

            }

            equalFlag = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (calc_display.Text.Length == 0)
                return;

            if (calc_display.Text.Contains("^"))
            {
                string[] nums = calc_display.Text.Split('^');
                double x = double.Parse(nums[0]);
                double y = double.Parse(nums[1]);
                double result = Math.Pow(x, y);
                calc_display.Text = result.ToString();
            }
            
            calc_display.Text += "+";
            equalFlag = false;
            
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (calc_display.Text.Contains("^"))
            {
                string[] nums = calc_display.Text.Split('^');
                double x = double.Parse(nums[0]);
                double y = double.Parse(nums[1]);
                double result = Math.Pow(x, y);
                calc_display.Text = result.ToString();
            }
            calc_display.Text += "-";
            equalFlag = false;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (calc_display.Text.Length == 0)
                return;

            if (calc_display.Text.Contains("^"))
            {
                string[] nums = calc_display.Text.Split('^');
                double x = double.Parse(nums[0]);
                double y = double.Parse(nums[1]);
                double result = Math.Pow(x, y);
                calc_display.Text = result.ToString();
            }
            calc_display.Text += "*";
            equalFlag = false;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (calc_display.Text.Length == 0)
                return;

            if (calc_display.Text.Contains("^"))
            {
                string[] nums = calc_display.Text.Split('^');
                double x = double.Parse(nums[0]);
                double y = double.Parse(nums[1]);
                double result = Math.Pow(x, y);
                calc_display.Text = result.ToString();
            }
            calc_display.Text += "/";
            equalFlag = false;
        }

        private void Equal_Click(object sender, EventArgs e)
        {   

            
            var result = new object();

            if (calc_display.Text.Contains("^"))
            {
                string[] nums = calc_display.Text.Split('^');
                try
                {
                    double x = double.Parse(nums[0]);
                    double y = double.Parse(nums[1]);
                    result = Math.Pow(x, y);

                }
                catch
                {
                    result = "NaN";
                }               
            }
            else
                result = Calculate(calc_display.Text);
            calc_history_display.Text += calc_display.Text + " = " + result + Environment.NewLine;
            calc_display.Text = result.ToString();
            equalFlag = true;
        }

        private object Calculate(string expression)
        {
            DataTable dt = new DataTable();
            var v = new object();
            try
            {
                v = dt.Compute(expression, "");
            }
            catch
            {
                v = "NaN";
            }

            return v;
        }

        private void Global_Click(object sender, EventArgs e)
        {
            calc_display.Text = "";
            equalFlag = false;
        }

        private void IsUnary(string text, out bool res, out double num)
        {
            res = double.TryParse(text, out num);
        }

        private void Sign_Change(object sender, EventArgs e)
        {
            if (calc_display.Text.Length == 0)
                return;

            IsUnary(calc_display.Text, out bool res, out double num);
            if (res)
                calc_display.Text = (num * -1).ToString();
                
        }

        private void Square(object sender, EventArgs e)
        {
            if (calc_display.Text.Length == 0)
                return;

            IsUnary(calc_display.Text, out bool res, out double num);

            if (res)
            {
                double result = Math.Pow(num, 2);
                calc_history_display.Text += num + "^2 = " + result + Environment.NewLine;
                calc_display.Text = result.ToString();
            }
        }

        private void SquareRoot(object sender, EventArgs e)
        {

            if (calc_display.Text.Length == 0)
                return;

            IsUnary(calc_display.Text, out bool res, out double num);

            if (res)
            {
                double result = Math.Sqrt(num);
                calc_history_display.Text += "sqrt(" + num + ") = " + result + Environment.NewLine;
                calc_display.Text = result.ToString();
            }

        }

        private void Power_Of(object sender, EventArgs e)
        {
            if (calc_display.Text.Length == 0)
                return;

            calc_display.Text += "^";
            equalFlag = false;
        }

        private void Percent(object sender, EventArgs e)
        {

            if (calc_display.Text.Length == 0)
                return;

            IsUnary(calc_display.Text, out bool res, out double num);

            if (res)
            {
                double result = num / 100;
                calc_history_display.Text += num + "/100 = " + result + Environment.NewLine;
                calc_display.Text = result.ToString();
            }
        }

        private void One_Nth(object sender, EventArgs e)
        {
            if (calc_display.Text.Length == 0)
                return;

            IsUnary(calc_display.Text, out bool res, out double num);

            if (num == 0)
                MessageBox.Show("Cannot Divide by 0", "Calc Error");
            else if (res)
            {
                double result = 1 / num;
                calc_history_display.Text += "1/" + num + " = " + result + Environment.NewLine;
                calc_display.Text = result.ToString();
            }
        }

        private void Log10(object sender, EventArgs e)
        {

            if (calc_display.Text.Length == 0)
                return;

            IsUnary(calc_display.Text, out bool res, out double num);

            if (num <= 0)
                MessageBox.Show("Invalid Input", "Calc Error");
            else if (res)
            {
                double result = Math.Log10(num);
                calc_history_display.Text += "log(" + num + ") = " + result + Environment.NewLine;
                calc_display.Text = result.ToString();
            }
        }

        private void Sine(object sender, EventArgs e)
        {

            if (calc_display.Text.Length == 0)
                return;

            IsUnary(calc_display.Text, out bool res, out double num);

            if (res)
            {
                double result = Math.Sin(num);
                calc_history_display.Text += "sin(" + num + ") = " + result + Environment.NewLine;
                calc_display.Text = result.ToString();

            }
        }

        private void Cosine(object sender, EventArgs e)
        {
            if (calc_display.Text.Length == 0)
                return;

            IsUnary(calc_display.Text, out bool res, out double num);

            if (res)
            {
                double result = Math.Cos(num);
                calc_history_display.Text += "cos(" + num + ") = " + result + Environment.NewLine;
                calc_display.Text = result.ToString();

            }
        }

        private void Tan(object sender, EventArgs e)
        {

            if (calc_display.Text.Length == 0)
                return;

            IsUnary(calc_display.Text, out bool res, out double num);

            if (res)
            {
                double result = Math.Tan(num);
                calc_history_display.Text += "tan(" + num + ") = " + result + Environment.NewLine;
                calc_display.Text = result.ToString();

            }
        }

        private void Change_Calc_Color(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            DialogResult y = f.ShowDialog(this);
            
            if (y == DialogResult.OK)
                calc_keys.BackColor = f.Color;
        }

        private void Change_DayCounter_Color(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            DialogResult y = f.ShowDialog(this);

            if (y == DialogResult.OK)
                splitContainer2.Panel2.BackColor = f.Color;
        }

        private void Change_GraphSection_Color(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            DialogResult y = f.ShowDialog(this);

            if (y == DialogResult.OK)
                splitContainer1.Panel2.BackColor = f.Color;
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (calc_display.Text.Length == 0)
                return;
            else if (calc_display.Text.Length == 1)
                calc_display.Text = "";
            else
            {
                string newText = "";
                for (int i = 0; i < calc_display.Text.Length - 1; i++)
                    newText += calc_display.Text[i];
                calc_display.Text = newText;
            }
                
        }

        private void ChangeFont(object sender, EventArgs e)
        {
            FontDialog x = new FontDialog();
            DialogResult y = x.ShowDialog(this);

            if (y == DialogResult.OK)
                calc_display.Font = x.Font;
        }

        private void InfoMessage(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Created by Jose Hernandez", "Info");
        }

        private void Open_Txt(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "txt files (*.txt)|*.txt";
            DialogResult y = x.ShowDialog(this);

            if(y == DialogResult.OK)
            {
                try
                {
                    g.ReadGraphFromTXTFile(x.FileName);
                    import_box.Items.Add(x.FileName);
                }
                catch
                {
                    MessageBox.Show("Please select a correct formatted file", "Error Opening File");
                    toolStripStatusLabel2.Text = "Ready!";
                }
            }           
        }

        private void Open_CSV(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "csv files (*.csv)|*.csv";
            DialogResult y = x.ShowDialog(this);

            if (y == DialogResult.OK)
            {
                try
                {
                    g.ReadGraphFromCSVFile(x.FileName);
                    import_box.Items.Add(x.FileName);
                }
                catch
                {
                    MessageBox.Show("Please select a correct formatted file", "Error Opening File");
                    toolStripStatusLabel2.Text = "Ready!";
                }               
            }      
        }

        private void Open_Multi(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Multiselect = true;
            x.Filter = "all supported (*.csv,*.txt)|*.csv;*.txt|csv files (*.csv)|*.csv|*.txt files (*.txt)|*.txt";
            DialogResult y = x.ShowDialog(this);
            if (y == DialogResult.OK)
            {
                string[] selected_files = x.FileNames;

                foreach (string file in selected_files)
                {
                    if (file.Contains(".txt"))
                    {
                        try
                        {
                            g.ReadGraphFromTXTFile(file);
                            import_box.Items.Add(file);
                        }
                        catch
                        {
                            MessageBox.Show("Please select a correct formatted file", "Error Opening File");
                            toolStripStatusLabel2.Text = "Ready!";
                        }
                    }
                    else
                    {
                        try
                        {
                            g.ReadGraphFromCSVFile(file);
                            import_box.Items.Add(file);
                        }
                        catch
                        {
                            MessageBox.Show("Please select a correct formatted file", "Error Opening File");
                            toolStripStatusLabel2.Text = "Ready!";
                        }
                    }
                }             
            }
        }

        private void Delete_Selected(object sender, EventArgs e)
        {
            if (import_box.Items.Count > 0)
                import_box.Items.RemoveAt(import_box.SelectedIndex);
        }

        private void Delete_All_Imports(object sender, EventArgs e)
        {
            if (import_box.Items.Count > 0)
                import_box.Items.Clear();
        }

        private void Prim(object sender, EventArgs e)
        {
            if (import_box.Items.Count > 0 && import_box.SelectedItems.Count > 0)
            {
                g.GetMST(import_box.SelectedItem.ToString());
                string x = "MST: " + import_box.SelectedItem.ToString();

                result_box.Items.Add(x);
            }
            

        }

        private void FindShortestPath(object sender, EventArgs e)
        {
            if (import_box.Items.Count > 0 && import_box.SelectedItems.Count > 0)
            {
                g.Dijkstra(import_box.SelectedItem.ToString());
                string x = "Shortest Paths: " + import_box.SelectedItem.ToString();

                result_box.Items.Add(x);
            }
            
        }

        private void Change_BG(object sender, EventArgs e)
        {
            ColorDialog x = new ColorDialog();
            DialogResult y = x.ShowDialog(this);
            if (y == DialogResult.OK)
                BackColor = x.Color;
        }

        private void Save_Result(object sender, EventArgs e)
        {
            if (result_box.Items.Count > 0 && result_box.SelectedItems.Count > 0)
            {
                SaveFileDialog x = new SaveFileDialog();
                x.Filter = "txt files (*.txt)|*.txt";

                DialogResult y = x.ShowDialog(this);

                if (y == DialogResult.OK)
                {
                    if (result_box.SelectedItem.ToString().Contains("Shortest Paths: "))
                    {
                        int fnameIndex = result_box.SelectedItem.ToString().IndexOf(":");
                        string fname = result_box.SelectedItem.ToString().Substring(fnameIndex + 2);
                        //MessageBox.Show(fname); //debug
                        g.WriteSSSPSolutionTo(x.FileName, fname);
                    }
                    else
                    {
                        int fnameIndex = result_box.SelectedItem.ToString().IndexOf(":");
                        string fname = result_box.SelectedItem.ToString().Substring(fnameIndex + 2);
                        //MessageBox.Show(fname); //debug

                        g.WriteMSTSolutionTo(x.FileName, fname);
                    }

                    result_box.Items.RemoveAt(result_box.SelectedIndex);
                }              
            }
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            clock.Interval = 1000;
            mainStripLbl.Text = "Good Day! Today is: " + DateTime.Now;
            statusStrip1.Update();
        }

        private void Clear_History(object sender, EventArgs e)
        {
            calc_history_display.Text = "";
        }

        private void Save_Calc_History(object sender, EventArgs e)
        {
            if (calc_history_display.Text == "")
            {
                MessageBox.Show("Please load the calculator's history", "Nothing to Save");
                return;
            }
            string[] historyLines = calc_history_display.Lines;
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "txt files (*.txt)|*.txt";
            DialogResult y = x.ShowDialog(this);

            if (y == DialogResult.OK)
            {
                StreamWriter fileWriter = new StreamWriter(x.FileName);

                foreach (string line in historyLines)
                    fileWriter.WriteLine(line);
                fileWriter.Close();
            }
        }

        private void Load_History(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "txt files (*.txt)|*.txt";
            DialogResult y = x.ShowDialog(this);

            if (y == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(x.FileName);
                calc_history_display.Text = "";
                foreach (string line in lines)
                {
                    if (line.Length > 0)
                        calc_history_display.Text += line + Environment.NewLine;
                }                
            }
        }

        private void Print_History(object sender, EventArgs e)
        {
            if (calc_history_display.Text == "")
            {
                MessageBox.Show("Please load the calculator's history", "Nothing To Print");
                return;
            }
            PrintDialog x = new PrintDialog();
            PrintDocument doc = new PrintDocument();

            doc.PrintPage += new PrintPageEventHandler(HistoryPrintPage);
            doc.DocumentName = "Calculator History";
            x.Document = doc;

            DialogResult y = x.ShowDialog(this);

            if (y == DialogResult.OK)
                doc.Print();
        }

        private void HistoryPrintPage(object sender, PrintPageEventArgs e)
        {
          e.Graphics.DrawString(calc_history_display.Text,
                                new Font("Arial", 20, FontStyle.Regular),
                                Brushes.Black,
                                20,
                                20);
        }

        private void Clear_Entry(object sender, EventArgs e)
        {
            if (calc_display.Text == "")
                return;

            if(calc_display.Text.Contains("+") || calc_display.Text.Contains("-") || calc_display.Text.Contains("*")
                || calc_display.Text.Contains("/") || calc_display.Text.Contains("^"))
            {
                
                string[] nums = calc_display.Text.Split(new char[] { '+', '-', '*', '/', '^' });
                int numsLength = nums.Length;

                if (nums[numsLength - 1] == "")
                {
                    //MessageBox.Show("this is running" + nums.Length.ToString());
                    string lastEntry = nums[numsLength - 2];
                    string newEntry = "";
                    //MessageBox.Show(lastEntry + lastEntry.Length.ToString());
                    for (int i = 0; i < calc_display.Text.Length - (lastEntry.Length + 1); i++)
                        newEntry += calc_display.Text[i];
                    calc_display.Text = newEntry;
                }
                else
                {
                    string lastEntry = nums[numsLength - 1];

                    string newEntry = "";
                    for (int i = 0; i < calc_display.Text.Length - lastEntry.Length; i++)
                        newEntry += calc_display.Text[i];

                    calc_display.Text = newEntry;
                }             
            }
            else
            {
                calc_display.Text = "";
            }
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.daysUpDown.ActiveControl != null)
                return;
            int c = this.fromDatePicker.Value.CompareTo(this.toDatePicker.Value);
            int days = 0;
            DateTime temp;
            if (c > 0)
            {
                temp = this.toDatePicker.Value;
                while (!temp.Date.Equals(fromDatePicker.Value.Date))
                {
                    days--;
                    temp = temp.AddDays(1);
                }
            }
            else
            {
                temp = this.fromDatePicker.Value;
                while (!temp.Date.Equals(toDatePicker.Value.Date))
                {
                    days++;
                    temp = temp.AddDays(1);
                }
            }
            this.daysUpDown.Value = days;
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.daysUpDown.ActiveControl != null)
                return;
            int c = this.fromDatePicker.Value.CompareTo(this.toDatePicker.Value);
            int days = 0;
            DateTime temp;

            if (c > 0)
            {
                temp = this.toDatePicker.Value;
                while (!temp.Date.Equals(fromDatePicker.Value.Date))
                {
                    days--;
                    temp = temp.AddDays(1);
                }
            }
            else
            {
                temp = this.fromDatePicker.Value;
                while (!temp.Date.Equals(toDatePicker.Value.Date))
                {
                    days++;
                    temp = temp.AddDays(1);
                }
            }
            this.daysUpDown.Value = days;
        }

        private void daysUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (this.daysUpDown.ActiveControl != null)
            {
                if (daysUpDown.Value >= 0)
                    this.toDatePicker.Value = this.fromDatePicker.Value.AddDays((double)daysUpDown.Value);
                else
                    this.fromDatePicker.Value = this.toDatePicker.Value.AddDays(-1 * (double)daysUpDown.Value);
            }
        }

        private void ReadFile()
        {
                string tempFile = @"C:\temp\.printtempfile.temp";
                FileStream fs = File.Create(tempFile);
                fs.Close();

                if (result_box.SelectedItem.ToString().Contains("Shortest Paths: "))
                {
                    int fnameIndex = result_box.SelectedItem.ToString().IndexOf(":");
                    string fname = result_box.SelectedItem.ToString().Substring(fnameIndex + 2);
                    g.WriteSSSPSolutionTo(tempFile, fname);
                }
                else
                {
                    int fnameIndex = result_box.SelectedItem.ToString().IndexOf(":");
                    string fname = result_box.SelectedItem.ToString().Substring(fnameIndex + 2);
                    g.WriteMSTSolutionTo(tempFile, fname);
                }

                printDocument.DocumentName = "Results";

                using (FileStream stream = new FileStream(tempFile, FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {
                    stringToPrint = reader.ReadToEnd();
                }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            int charactersOnePage = 0;
            int linesPerPage = 0;
                        
            e.Graphics.MeasureString(stringToPrint, this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnePage, out linesPerPage);

            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);

            stringToPrint = stringToPrint.Substring(charactersOnePage);

            e.HasMorePages = (stringToPrint.Length > 0);
            endPrint = true;
        }


        private void Print_Results_Click(object sender, EventArgs e)
        {
            if(result_box.Items.Count > 0 && result_box.SelectedItems.Count > 0)
            {
                PrintDialog x = new PrintDialog();
                DialogResult y = x.ShowDialog(this);

                if (y == DialogResult.OK)
                {
                    ReadFile();
                    printDocument.Print();

                    if (endPrint)
                        result_box.Items.RemoveAt(result_box.SelectedIndex);
                    File.Delete(@"C:\temp\.printtempfile.temp");
                }
            }
            else
            {
                MessageBox.Show("Nothing to print", "Error to print");
            }
            endPrint = false;
        }

        private void calc_history_display_TextChanged(object sender, EventArgs e)
        {
            calc_history_display.SelectionStart = calc_history_display.Text.Length;
            calc_history_display.ScrollToCaret();
        }
    }
}
