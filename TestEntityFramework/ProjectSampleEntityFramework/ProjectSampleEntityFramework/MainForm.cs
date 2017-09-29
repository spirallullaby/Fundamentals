using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
using System.Collections.ObjectModel;

namespace ProjectSampleEntityFramework
{
    public partial class MainForm : Form
    {
        //TO run correctly setup connection string
        private const string connectionString = @"";
        Model model;
        public MainForm()
        {
            model = new Model(connectionString);
            InitializeComponent();
            model.EMPLOYEES.Load();
            var employeeViews = new ObservableCollection<EmployeeView>(model.EMPLOYEES.Local.Select(emp => new EmployeeView(emp)));
            this.dataGridView.DataSource = employeeViews
                .ToBindingList();                
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.model.SaveChanges();
        }
    }
}
