namespace TAH.ManagerList.ui
{
    public partial class FrmManagerList : Form
    {
        public FrmManagerList()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // Stores the user input in a string variable called strDepartmentInput.
            string strDepartmentInput = txtDepartment.Text.ToLower().Trim();
            // Creates a string variable called strManager.
            string strManager;

            // Uses a switch statement to determine the manager based on the department input.
            switch (strDepartmentInput)
            {
                case "sales":
                    strManager = "Angela";
                    lblResult.Text = $"The manager of {strDepartmentInput} is {strManager}.";
                    break;
                case "it":
                    strManager = "Kevin";
                    lblResult.Text = $"The manager of {strDepartmentInput} is {strManager}.";
                    break;
                case "marketing":
                    strManager = "Oscar";
                    lblResult.Text = $"The manager of {strDepartmentInput} is {strManager}.";
                    break;
                case "hr":
                    strManager = "Pam";
                    lblResult.Text = $"The manager of {strDepartmentInput} is {strManager}.";
                    break;
                case "shipping":
                    strManager = "Darryl";
                    lblResult.Text = $"The manager of {strDepartmentInput} is {strManager}.";
                    break;
                default:
                    // If the department input does not match any of the cases, display an error message.
                    lblResult.Text = "Unknown Department.";
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit the application
            Application.Exit();
        }
    }
}
