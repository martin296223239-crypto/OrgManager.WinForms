using OrgManager.WinForms.Data;
using OrgManager.WinForms.Domain;
using OrgManager.WinForms.Services;

namespace OrgManager.WinForms
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _db = new();
        private OrgService _orgService;
        private EmployeeService _empService;

        public MainForm()
        {
            InitializeComponent();
            _orgService = new OrgService(_db);
            _empService = new EmployeeService(_db);
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            await ReloadTreeAsync();
            await ReloadEmployeesAsync();
        }
        private async Task ReloadTreeAsync()
        {
            tvOrg.BeginUpdate();
            tvOrg.Nodes.Clear();
            foreach (var root in await _orgService.GetRootAsync())
            {
                var node = CreateTreeNode(root);
                tvOrg.Nodes.Add(node);
                await LoadChildrenAsync(node);
            }
            tvOrg.ExpandAll();
            tvOrg.EndUpdate();
        }



        private TreeNode CreateTreeNode(OrgNode n) => new TreeNode(n.Display) { Tag = n };


        private async Task LoadChildrenAsync(TreeNode treeNode)
        {
            var model = (OrgNode)treeNode.Tag!;
            var children = await _orgService.GetChildrenAsync(model.Id);
            foreach (var child in children)
            {
                var tn = CreateTreeNode(child);
                treeNode.Nodes.Add(tn);
                await LoadChildrenAsync(tn);
            }
        }
        private async Task ReloadEmployeesAsync()
        {
            dgvEmployees.DataSource = (await _empService.GetAllAsync())
            .Select(e => new { e.Id, e.Title, e.FirstName, e.LastName, e.Phone, e.Email })
            .ToList();
        }

        private async  void btnAddNode_Click(object sender, EventArgs e)
        {
            using var dlg = new OrgNodeForm(_db, parent: SelectedOrgNode);
            if (dlg.ShowDialog(this) == DialogResult.OK)
                await ReloadTreeAsync();
        }

        private async  void btnEditNode_Click(object sender, EventArgs e)
        {
            if (SelectedOrgNode == null) return;
            _db.Entry(SelectedOrgNode).State = Microsoft.EntityFrameworkCore.EntityState.Detached; // naèítame èerstvé
            using var dlg = new OrgNodeForm(_db, existingId: SelectedOrgNode.Id);
            if (dlg.ShowDialog(this) == DialogResult.OK)
                await ReloadTreeAsync();
        }

        private async  void btnDeleteNode_Click(object sender, EventArgs e)
        {
            if (SelectedOrgNode == null) return;
            if (MessageBox.Show("Naozaj odstráni?", "Potvrdenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try { await new OrgService(_db).DeleteAsync(SelectedOrgNode.Id); }
                catch (ValidationException ve) { MessageBox.Show(ve.Message); }
                await ReloadTreeAsync();
            }
        }

        private async  void btnAddEmp_Click(object sender, EventArgs e)
        {
            using var dlg = new EmployeeForm(_db);
            if (dlg.ShowDialog(this) == DialogResult.OK)
                await ReloadEmployeesAsync();
        }

        private async  void btnEditEmp_Click(object sender, EventArgs e)
        {
            if (SelectedEmployeeId is not int id) return;
            using var dlg = new EmployeeForm(_db, id);
            if (dlg.ShowDialog(this) == DialogResult.OK)
                await ReloadEmployeesAsync();
        }

        private async  void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (SelectedEmployeeId is not int id) return;
            if (MessageBox.Show("Naozaj odstráni?", "Potvrdenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _empService.DeleteAsync(id);
                await ReloadEmployeesAsync();
            }
        }

        private async void tvOrg_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = SelectedOrgNode;
            if (node == null) return;

            // (volite¾né) napr. zmeni titul okna
            this.Text = $"Vybraný uzol: [{node.Code}] {node.Name} ({node.Type})";

            // (volite¾né) filtrova zamestnancov pod¾a uzla, ak ich budeš priraïova k oddeleniam
            // Zatia¾ ponecháme len reload všetkých:
            await   ReloadEmployeesAsync();
        }

        private OrgNode? SelectedOrgNode => tvOrg.SelectedNode?.Tag as OrgNode;
        private int? SelectedEmployeeId => dgvEmployees.CurrentRow?.Cells["Id"]?.Value as int?;



    }
}
