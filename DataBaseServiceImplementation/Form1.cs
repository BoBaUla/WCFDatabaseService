using DataBaseServiceImplementation.Proxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFDataBaseService;
using WCFDataBaseService.DataBaseInterfaces;
using WCFDataBaseService.DataBaseClasses;
using WCFDataBaseService.Exceptions;

namespace DataBaseServiceImplementation
{
    public partial class Form1 : Form
    {
        DataBaseInteractionProxy _proxy;
        string message = "Please check the database-settings in 'DataBaseService.cs'";
        WebServiceHost _webhost = null;
        public Form1()
        {
            InitializeComponent();
            try
            {
                _proxy = new DataBaseInteractionProxy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(message);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                var person = new BindingSource(_proxy.GetName(textBoxReadByID.Text), null);
                dataGridViewSelectedPerson.DataSource = person;
            }
            catch (Exception ex)
            {
                MessageBox.Show(message);
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                _proxy.AddName(textBoxCreateName.Text);
                UpdateGridView();
            }
            catch(InvalidNameException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _proxy.ChangeName(textBoxUpdateByID.Text, textBoxUpdateName.Text);
                UpdateGridView();
            }
            catch(InvalidNameException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _proxy.DeleteName(textBoxDeleteByID.Text);
            UpdateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(message);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateGridView();
                groupBox2.Enabled = !groupBox2.Enabled;
            }       
            catch (Exception ex)
            {
                MessageBox.Show(message);
            }
        }

        private void UpdateGridView()
        {
            dataGridViewTablePerson.Controls.Clear();
            var items = new BindingList<Person>(_proxy.GetTable());
            dataGridViewTablePerson.DataSource = items;
        }

        private void buttonWebhost_Click(object sender, EventArgs e)
        {
            string endpoint = "http://localhost:8734/WCTDataBaseInteraction/DataBaseService/";
            _webhost = new WebServiceHost(
                new DataBaseService(), 
                new Uri(endpoint)
                );
            _webhost.Open();
            buttonWebhost.Enabled = !buttonWebhost.Enabled;
            buttonWebStop.Enabled = !buttonWebStop.Enabled;
        }

        private void buttonWebStop_Click(object sender, EventArgs e)
        {
            _webhost.Close();
            buttonWebhost.Enabled = !buttonWebhost.Enabled;
            buttonWebStop.Enabled = !buttonWebStop.Enabled;
        }

    }
}
