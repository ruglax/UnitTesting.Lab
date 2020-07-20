using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab.Silosys.WinFormsMVP.Presenter;

namespace Lab.Silosys.WinFormsMVP.View
{
    internal partial class CustomerForm : Form, ICustomerView
    {
        private bool _isEditMode = false;

        public CustomerForm()
        {
            // IMPORTANT: Se deben inicializar los componentes antes de hacer uso del presentador.
            InitializeComponent();

            var repository = new Model.CustomerXmlRepository(Application.StartupPath);
            Presenter = new CustomerPresenter(this, repository);
        }

        public IList<string> CustomerList
        {
            get => (IList<string>)customerListBox.DataSource;
            set => customerListBox.DataSource = value;
        }

        public int SelectedCustomer
        {
            get => customerListBox.SelectedIndex;
            set => customerListBox.SelectedIndex = value;
        }

        public string Address
        {
            get => addressTextBox.Text;
            set => addressTextBox.Text = value;
        }

        public string CustomerName
        {
            get => nameTextBox.Text;
            set => nameTextBox.Text = value;
        }

        public string Phone
        {
            get => phoneTextBox.Text;
            set => phoneTextBox.Text = value;
        }

        public CustomerPresenter Presenter
        { private get; set; }

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FIXME: try/catch
            Presenter.UpdateCustomerView(customerListBox.SelectedIndex);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            addressTextBox.ReadOnly = _isEditMode;
            nameTextBox.ReadOnly = _isEditMode;
            phoneTextBox.ReadOnly = _isEditMode;

            _isEditMode = !_isEditMode;

            editButton.Text = _isEditMode ? "Save" : "Edit";
            // TODO: add cancel button

            if (!_isEditMode)
            {
                // TODO: validation
                // FIXME: try/catch
                Presenter.SaveCustomer();
            }
        }
    }
}