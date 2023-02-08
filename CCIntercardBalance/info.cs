using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCIntercardBalance
{
    public partial class info : Form
    {
        private const string URL = "https://craigscruisers.icardinc.net";
        private string urlParameters = "";

        public info()
        {
            InitializeComponent();
        }
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                if (checkMSR())
                {
                    urlParameters = String.Format("WS_ProfileManagement/api/Card/7394/{0}/none", txtInput.Text);
                    clearForm();
                    pullInfo();
                }
                return;
               
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            urlParameters = String.Format("WS_ProfileManagement/api/Card/7394/{0}/none",txtInput.Text);
            clearForm();
            pullInfo();
        }
        private bool checkMSR()
        {
            if (txtInput.Text.StartsWith("%") && txtInput.Text.EndsWith("?"))
            {

                try
                {
                    string strtofind = "";
                    int ftocut = txtInput.Text.IndexOf(';');
                    int ltocut = txtInput.Text.LastIndexOf('?');
                    strtofind = txtInput.Text.Substring(ftocut + 1, (ltocut - ftocut - 1));



                    if (strtofind == "E")
                    {
                        MessageBox.Show(this, "Empolyee Card", "Error");
                        txtInput.Text = "";
                        return false;
                    }
                    else if (strtofind.Substring(0, 4) == "7394")
                    {
                        txtInput.Text = strtofind.Substring((strtofind.IndexOf('=') + 1)).TrimStart('0');
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;

                }
            }

            return true;

        }
              
        private void pullInfo()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                // List data response.
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body.
                    var dataObject = response.Content.ReadAsAsync<cardInfo>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                                                                                       //foreach (var d in dataObjects)
                                                                                       //{
                                                                                       //    //Console.WriteLine("{0}", d.Name);
                                                                                       //    //Console.WriteLine("{0}", d.LastName);
                                                                                       //    //Console.WriteLine("{0}", d.FirstName);
                                                                                       //    //Console.WriteLine("{0}", d.AccountNumber);
                                                                                       //    //Console.WriteLine("{0}", d.Cash);
                                                                                       //    //Console.WriteLine("{0}", d.BonusCash);
                                                                                       //    //Console.WriteLine("{0}", d.Tokens);
                                                                                       //    //Console.WriteLine("{0}", d.BonusTokens);
                                                                                       //    //Console.WriteLine("{0}", d.Points);
                                                                                       //}
                    updateForm(dataObject);
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    MessageBox.Show(this, response.ReasonPhrase, "Error");
                    txtInput.Text = "";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Failed to Reach Server");           
            }
            

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();
            txtInput.SelectAll();
            txtInput.Focus();
        }

        private void updateForm(cardInfo card)
        {
            txtAccountNumber.Text = card.AccountNumber.ToString();
            txtBonusCash.Text = card.BonusCash.ToString();
            txtBonusTokens.Text = card.BonusTokens.ToString();
            txtCash.Text = card.Cash.ToString();
            txtFirstName.Text = card.FirstName;
            txtLastName.Text = card.LastName;
            txtName.Text = card.Name;
            txtPoints.Text = card.Points.ToString();
            txtTokens.Text = card.Tokens.ToString();

            //update gates
            if (card.gates != null)
            {
                foreach (Gates item in card.gates)
                {
                    if (item.Title == "1 Attraction")
                    {
                        qtyoneattraction.Value = item.Quantity;
                    }
                    else if (item.Title == "2 Attraction")
                    {
                        qtytwoattraction.Value = item.Quantity;
                    }
                    else if (item.Title == "3 Attraction")
                    {
                        qtythreeattraction.Value = item.Quantity;
                    }
                }
            }
            

        }
        
        private void clearForm()
        {
            txtAccountNumber.Text = "";
            txtBonusCash.Text = "";
            txtBonusTokens.Text = "";
            txtCash.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtPoints.Text = "";
            txtTokens.Text = "";
            qtyoneattraction.Value = 0;
            qtytwoattraction.Value = 0;
            qtythreeattraction.Value = 0;
        }
        
        //check for txtbox being a number

        //call api

        //present infomation
        public class Gates
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public int Quantity { get; set; }
            public List<GateReaders> gateReaders { get; set; }
        }

        public class GateReaders
        {
            public string Name { get; set; }
            public int DeviceTag { get; set; }
        }
        public class cardInfo
        {

            public string Name { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int AccountNumber { get; set; }
            public double Cash { get; set; }
            public double BonusCash { get; set; }
            public int Tokens { get; set; }
            public int BonusTokens { get; set; }
            public int Points { get; set; }
            public bool TpActive { get; set; }
            public bool? TpStartOnSwipe { get; set; }
            public DateTime TpStartTime { get; set; }
            public DateTime TpEndTime { get; set; }
            public int TpDuration { get; set; }
            public string CardImage { get; set; }
            public int AvatarId { get; set; }
            public int CorpId { get; set; }
            public List<string> Products { get; set; }
            public List<Gates> gates { get; set; }




        }

        
    }
    
   
}
