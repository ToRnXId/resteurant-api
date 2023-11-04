using ResteurantClientApp.Containers;
using RestSharp;

namespace ResteurantClientApp
{
    public partial class MainForm : Form
    {
        private readonly MainFormServicesContainer _container;

        public MainForm(MainFormServicesContainer container)
        {
            _container = container;
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

        private async void GetResteurantsBTN_Click(object sender, EventArgs e)
        {
            try 
            {
                var resteurants = await _container.ResteurantService.GetAllResteraunts();
                foreach (var resteurant in resteurants)
                {
                    responseLBL.Text = $"Name: {resteurant.Name}\n" +
                        $"Description: {resteurant.Description}\n" +
                        $"Category: {resteurant.Category}\n" +
                        $"Contact Number: {resteurant.ContactNumber}\n" +
                        $"Contact Email: {resteurant.ContactEmail}\n" +
                        $"Delivery: {resteurant.HasDelivery}\n" +
                        $"###############################################";
                }
            }
            catch (Exception exc)
            {
                responseLBL.Text = $"{exc.Message}, {exc.InnerException}";
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