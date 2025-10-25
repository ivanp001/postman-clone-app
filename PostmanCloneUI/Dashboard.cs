using PostmanCloneLibrary;
using System.Security.Policy;

namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {

        private readonly IApiAccess api = new ApiAccess();
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void callApi_Click(object sender, EventArgs e)
        {
            systemStatus.Text = "Calling API...";
            resultsText.Text = string.Empty;

            //validate data URL in Postman Library
            if (api.IsValidUrl(apiText.Text) == false)
            {
                systemStatus.Text = "Invalid URL";
                return;
            }

            try
            {
                resultsText.Text = await api.CallApiAsync(apiText.Text);

                systemStatus.Text = "Ready";

            }
            catch (Exception ex)
            {

                resultsText.Text = "Error message" + ex.Message;
                systemStatus.Text = "Error";

            }
        }
    }
}
