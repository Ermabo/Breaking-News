using WebLib.WebFunctions;
using WebLib.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakingNews
{
    public partial class FormMain : Form
    {
        private string siteUrl;
        private string keyword;
        private IWebCollector collector;
        private IWebCalculator calculator;


        public FormMain()
        {
            siteUrl = string.Empty;
            keyword = string.Empty;
            collector = new WebCollector();
            calculator = new WebCalculator();
            InitializeComponent();
        }

        
        private void CheckKeyword()
        {
            if (rbTrump.Checked)
                keyword = "Trump";

            else if (rbEkonomi.Checked)
                keyword = "Ekonomi";

            else if (rbPolis.Checked)
                keyword = "Polis";

            else if (rbHemlig.Checked)
                keyword = "Hemlig";
        }

        private void CheckSite()
        {
            if (rbAfonbladet.Checked)
                siteUrl = "http://aftonbladet.se";

            else if (rbExpressen.Checked)
                siteUrl = "http://expressen.se";

            else if (rbDagensNyheter.Checked)
                siteUrl = "http://dn.se";
        }

        private async void btnGetStatistics_Click(object sender, EventArgs e)
        {
            // -1 is the "Fail value".
            int totalMatches = -1;

            tbResult.Text = "Please wait";

            CheckSite();
            CheckKeyword();
            
            try
            {
               await Task.Run(() => collector.GetHTMLFromUrl(siteUrl));
            }
                
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (collector != null || collector.HtmlCode != null)
            {
                if (collector.HtmlCode != string.Empty)
                {
                    // We end up here if we have a valid url.
                    try
                    {
                        totalMatches = await Task.Run(() => calculator.CalculateNumberOfHits(collector, keyword));
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("Unable to fetch HTML code. Make sure you are connected to the internet and that the websites are accessible");
            }
            else
                MessageBox.Show("Unable to fetch HTML code. Make sure you are connected to the internet and that the websites are accessible");

            // If total matches are a different nr than -1 we print it out cause then we have valid data.
            if (totalMatches != -1)
                tbResult.Text = totalMatches.ToString();

            else
                tbResult.Text = "!?Error?!";
        }
    }
}
