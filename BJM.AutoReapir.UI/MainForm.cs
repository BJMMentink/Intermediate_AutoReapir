using BJM.AutoReapir.BL;
using BJM.AutoRepair.BL;
using BJM.AutoRepair.PL;

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

        private DateTime startTime = DateTime.MinValue;

        public MainForm()
        {
            InitializeComponent();

            Type type = typeof(CustomerCollection);
            try
            {
                CustomerCollection? temp = DataAccess.LoadXml(type) as CustomerCollection;
                customers = (temp != null) ? temp : new CustomerCollection();
            }
            catch (Exception)
            {
                customers = new CustomerCollection();
            }
            if (customers.Count > 0) 
            {
                RebindCustomers();
            }

            
            
            startTime = DateTime.Now;
            staTime.Text = "00:00:00";

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

                RebindVehicles(selectedCustomer.Vehicles);
            }
        }

        private void RebindVehicles(List<Vehicle> vehicles)
        {
            lstVehicles.DataSource = null;
            lstVehicles.DataSource = vehicles;
        }

        private void RebindCustomers()
        {
            lstCustomer.DataSource = null; // unbind
            lstCustomer.DataSource = customers; // rebind
            dgvCustomer.DataSource = null;
            dgvCustomer.DataSource = customers;
            dgvCustomer.Columns["FullName"].Visible = false;
            dgvCustomer.Columns["PhoneNumber"].HeaderText = "Phone Number";
            
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            TimeSpan sinceStart = DateTime.Now - startTime;
            staTime.Text = sinceStart.ToString("hh\\:mm\\:ss");
            //staTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            customers.SaveToXml();
        }
    }
}