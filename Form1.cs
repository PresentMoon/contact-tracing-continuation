using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Viewer
{
    public partial class ContactTracingViewer : Form
    {
        public ContactTracingViewer()
        {
            InitializeComponent();
        }

        private void ReadFileBttn_Click(object sender, EventArgs e)
        {
            /*const int SIZE = 7;
            string[] numbers = new string[SIZE];
            int index = 0;
            StreamReader inputFile;
            inputFile = File.OpenText("contacts.txt");
            while (index < numbers.Length && inputFile.EndOfStream)
            {
                numbers[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();

            foreach (string value in numbers)
            {
                RecordsBox.Items.Add(value);
            }*/

            /*using (StreamReader sr = new StreamReader("contacts.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    RecordsBox.Items.Add(line);
                }
                sr.Close();*/

            /*using (StreamReader file = new StreamReader(@"C:\Users\user\Documents\Contacts Traced\contacts.txt", true))
            {
                string records;
                while ((records = file.ReadLine()) != null)
                {
                    RecordsBox.Items.Add(records);
                }
                file.Close();*/

            /*string[]records = File.ReadLine("contacts.txt");
            foreach (string lines in records)
            {
                RecordsBox.Items.Add(records.ToArray());
            }*/


            const int SIZE = 42;
            string[] numbers = new string[SIZE];
            int index = 0;
            StreamReader inputFile;
            inputFile = File.OpenText("contacts.txt");

            while (index < numbers.Length && inputFile.EndOfStream)
            {
                numbers[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();
            foreach (string records in numbers)
            {
                RecordsBox.Items.Add(records);
            }
        }
    }
}

