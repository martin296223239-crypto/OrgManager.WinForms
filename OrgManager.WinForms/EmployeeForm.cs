using OrgManager.WinForms.Data;
using OrgManager.WinForms.Domain;
using OrgManager.WinForms.Services;


namespace OrgManager.WinForms
{
    public partial class EmployeeForm : Form
    {
        private readonly AppDbContext _db;
        private readonly EmployeeService _svc;
        private readonly int? _id;
        private Employee _model = new();


        public EmployeeForm(AppDbContext db, int? id = null)
        {
            InitializeComponent();
            _db = db; _svc = new EmployeeService(db); _id = id;
        }


        private async void EmployeeForm_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var m = await _svc.GetAsync(_id.Value);
                if (m != null) _model = m;
            }
            BindToControls();
        }


        private void BindToControls()
        {
            txtTitle.Text = _model.Title;
            txtFirst.Text = _model.FirstName;
            txtLast.Text = _model.LastName;
            txtPhone.Text = _model.Phone;
            txtEmail.Text = _model.Email;
        }


        private void ReadFromControls()
        {
            _model.Title = txtTitle.Text?.Trim();
            _model.FirstName = txtFirst.Text.Trim();
            _model.LastName = txtLast.Text.Trim();
            _model.Phone = txtPhone.Text?.Trim();
            _model.Email = txtEmail.Text?.Trim();
        }


        private async void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                ReadFromControls();
                if (_id.HasValue) await _svc.UpdateAsync(_model);
                else await _svc.CreateAsync(_model);
                DialogResult = DialogResult.OK;
            }
            catch (ValidationException ex)
            { MessageBox.Show(ex.Message, "Upozornenie"); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}