using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OrgManager.WinForms.Data;
using OrgManager.WinForms.Domain;
using OrgManager.WinForms.Services;

namespace OrgManager.WinForms
{
    public partial class OrgNodeForm : Form
    {
        private readonly AppDbContext _db;
        private readonly OrgService _svc;
        private readonly int? _existingId;
        private readonly OrgNode? _parent;
        private OrgNode _model = new();

        public OrgNodeForm(AppDbContext db, OrgNode? parent = null, int? existingId = null)
        {
            InitializeComponent();
            _db = db; _svc = new OrgService(db);
            _parent = parent; _existingId = existingId;
        }

        private async void OrgNodeForm_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = Enum.GetValues(typeof(OrgNodeType));
            var employees = await _db.Employees.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToListAsync();
            cmbLeader.DisplayMember = nameof(Employee.ToString);
            cmbLeader.ValueMember = nameof(Employee.Id);
            cmbLeader.DataSource = employees;


            if (_existingId.HasValue)
            {
                var n = await _svc.GetAsync(_existingId.Value);
                if (n != null) _model = n;
            }
            else if (_parent != null)
            {
                _model.ParentId = _parent.Id;
                _model.Type = _parent.Type + 1; // ďalšia úroveň
            }


            BindToControls();
        }
        private void BindToControls()
        {
            cmbType.SelectedItem = _model.Type;
            txtCode.Text = _model.Code;
            txtName.Text = _model.Name;
            cmbLeader.SelectedValue = _model.LeaderEmployeeId ?? 0;
        }

        private void ReadFromControls()
        {
            _model.Type = (OrgNodeType)cmbType.SelectedItem;
            _model.Code = txtCode.Text.Trim();
            _model.Name = txtName.Text.Trim();
            _model.LeaderEmployeeId = (int?)(cmbLeader.SelectedValue is int id && id > 0 ? id : null);
        }
        private async void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                ReadFromControls();
                if (_existingId.HasValue) await _svc.UpdateAsync(_model);
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
