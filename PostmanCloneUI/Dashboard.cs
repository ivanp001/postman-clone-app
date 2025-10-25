namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void callApi_Click(object sender, EventArgs e)
        {
            //validate data URL in Postman Library
            try
            {

                systemStatus.Text = "Calling API...";

                // sample code call - replace with actual API call 
                await Task.Delay(1000);

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
