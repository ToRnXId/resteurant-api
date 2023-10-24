using RestSharp;

namespace ResteurantClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateResteruantBTN_Click(object sender, EventArgs e)
        {
            createRestNameLBL.Visible = true;
            createRestDescriptionLBL.Visible = true;
            createRestCategoryLBL.Visible = true;
            createRestHasDeliveryLBL.Visible = true;
            createRestContactEmailLBL.Visible = true;
            createRestContactNumberLBL.Visible = true;
            createRestNameTB.Visible = true;
            createRestDescriptionTB.Visible = true;
            createRestCategoryTB.Visible = true;
            createRestHasDeliveryTB.Visible = true;
            createRestContactEmailTB.Visible = true;
            createRestContactNumberMTB.Visible = true;
            createRestDoneBTN.Visible = true;
            createRestCancelBTN.Visible = true;
        }

        private void GetResteurantsBTN_Click(object sender, EventArgs e)
        {
            try 
            {
                var client = new RestClient("https://localhost:7013");
                var request = new RestRequest("/Resteurant", Method.Get);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    responseLBL.Text = response?.Content?.ToString();
                }
                else
                {
                    responseLBL.Text = response.ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                responseLBL.Text = ex.Message;
            }
        }

        private void ClearInformationBTN_Click(object sender, EventArgs e)
        {
            responseLBL.Text = "";
        }

        private void CreateRestDoneBTN_Click(object sender, EventArgs e)
        {

        }

        private void CreateRestCancelBTN_Click(object sender, EventArgs e)
        {
            createRestNameLBL.Visible = false;
            createRestDescriptionLBL.Visible = false;
            createRestCategoryLBL.Visible = false;
            createRestHasDeliveryLBL.Visible = false;
            createRestContactEmailLBL.Visible = false;
            createRestContactNumberLBL.Visible = false;
            createRestNameTB.Visible = false;
            createRestDescriptionTB.Visible = false;
            createRestCategoryTB.Visible = false;
            createRestHasDeliveryTB.Visible = false;
            createRestContactEmailTB.Visible = false;
            createRestContactNumberMTB.Visible = false;
            createRestDoneBTN.Visible = false;
            createRestCancelBTN.Visible = false;
        }
    }
}