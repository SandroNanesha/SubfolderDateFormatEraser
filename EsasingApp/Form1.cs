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

namespace EsasingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime from;
        private DateTime to;


        private void rec(string[] filesindirectory)
        {
            foreach (string str in filesindirectory)
            {
                if (filesindirectory.Length == 0) return;

                if (Directory.Exists(str))
                {
                    string[] subFolders = Directory.GetDirectories(str);
                    rec(subFolders);
                    
                    if(needToBeDeleted(str))
                    {
                        Directory.Delete(str, true);
                    }
                }


            }
        }

        private bool needToBeDeleted(string currPath)
        {

            String currName = new DirectoryInfo(currPath).Name;


            if (int.TryParse(currName.Substring(0, 2), out int currYear) && int.TryParse(currName.Substring(2, 2), out int currMonth) && int.TryParse(currName.Substring(4, 2), out int currDay))
            {
                currYear = 2000 + currYear;
                try
                {
                    DateTime currOne = new DateTime(currYear, currMonth, currDay);

                    if (currOne >= from && currOne <= to)
                    {
                        return true;
                    }
                } catch
                {

                }
                

                
                

            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String filePath = txtBoxFilePath.Text;

            from = dtPickerFrom.Value.Date;

            to = dtPickerTo.Value.Date;

            if (Directory.Exists(filePath))
            {
                string[] filesindirectory = Directory.GetDirectories(filePath);

                rec(filesindirectory);


                MessageBox.Show("Successfully excecuted");

            } else
            {
                MessageBox.Show("Directory does not exsist");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
