using BJM.AutoReapir.BL;
namespace BJM.AutoReapir.UI
{

    // OOP Pillars
    // 1. Encapsulation -- Packeges up related data and methods
    // 2. Inheritance -- Getting stuff for free
    // 3. Polymorphism -- 
    // **4. Abstraction -- Dont need to know "how" Blissful Ignorance.
    public partial class MainForm : Form
    {
        // fields
        private CustomerCollection customers = new CustomerCollection(); // must be instantiated first to be able to be refrenced 



        public MainForm()
        {
            InitializeComponent();

            customers.LoadTestCustomers();
            RebindCustomers();
        }

        private void btnAddingCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.PhoneNumber = txtPhoneNumber.Text;

            customers.Add(customer); // adds the data from the txt boxes to the list field

            RebindCustomers();

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
        private void RebindCustomers()
        {
            lstCustomer.DataSource = null; // unbind
            lstCustomer.DataSource = customers; // rebind
        }

    }
}