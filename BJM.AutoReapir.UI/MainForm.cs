namespace BJM.AutoReapir.UI
{
    public partial class MainForm : Form
    {
        // fields
        private List<Customer> customerList = new List<Customer>(); // must be instantiated first to be able to be refrenced 
        

    
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddingCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.PhoneNumber = txtPhoneNumber.Text;

            customerList.Add(customer); // adds the data from the txt boxes to the list field

            lstCustomer.DataSource = null;
            lstCustomer.DataSource = customerList;

        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lstCustomer.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                txtFirstName.Text = selectedCustomer.FirstName;
                txtLastName.Text = selectedCustomer.LastName;
                txtPhoneNumber.Text = selectedCustomer.PhoneNumber;
            }
        }
    }
}