using PostmanCloneLibrary;
using System.Security.Policy;
using System.Text;

namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {

        private readonly IApiAccess api = new ApiAccess();
        public Dashboard()
        {
            InitializeComponent();
            httpVerbSelection.SelectedItem = "GET";
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

            HttpAction action;
            if (Enum.TryParse(httpVerbSelection.SelectedItem!.ToString(), out action) == false)
            {
                systemStatus.Text = "Invalid HTTP verb";
                return;
            }


            try
            {
                if (httpVerbSelection?.SelectedItem?.ToString() == "POST")
                {
                    var content = new StringContent(bodyText.Text, Encoding.UTF8, "application/json");
                    resultsText.Text = await api.CallApiAsync(apiText.Text, content);
                    systemStatus.Text = "XXXXXXXXXXXXXXXXX";
                }
                if (httpVerbSelection?.SelectedItem?.ToString() == "GET")
                {
                    resultsText.Text = await api.CallApiAsync(apiText.Text, null);
                    resultsTab.Focus();
                }

                callData.SelectedTab = resultsTab;
                // systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {

                resultsText.Text = "Error message" + ex.Message;
                systemStatus.Text = "Error";

            }
        }
    }
}
