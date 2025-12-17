using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace North_America
{
    public partial class Form1 : Form
    {
        public object FileName { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        // The GetFileName method gets a filename from the
        // user and assigns it to the variable passed as
        // an argument.

        // The GetCountries method accpets a filename as an
        // argument. It opens the specified file and displays
        // its contents in the countriesListBox control.


        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName;

            GetFileName(out fileName);

            GetCountries(fileName);
        }

        private void GetCountries(string fileName)
        {
            
         string country;
            // Clear the list box.
            countriesListBox.Items.Clear();
            try
            {
                // Open the file.
                StreamReader inputFile = File.OpenText(fileName);
                // Read the file's contents.
                while (!inputFile.EndOfStream)
                {
                    country = inputFile.ReadLine();
                    countriesListBox.Items.Add(country);
                }
                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void GetFileName(out string fileName)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }
            else
            {
                fileName = string.Empty;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

    }
}
