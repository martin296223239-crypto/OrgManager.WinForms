using Microsoft.EntityFrameworkCore;
using OrgManager.WinForms.Data;
using OrgManager.WinForms.Domain;


namespace OrgManager.WinForms.Services
{
    public class OrgService
    {
        private readonly AppDbContext _db;
        public OrgService(AppDbContext db) => _db = db;


        public async Task<List<OrgNode>> GetRootAsync_orig() =>
        await _db.OrgNodes.Where(o => o.ParentId == null).OrderBy(o => o.Name).ToListAsync();


        public async Task<List<OrgNode>> GetChildrenAsync_orig(int parentId) =>
        await _db.OrgNodes.Where(o => o.ParentId == parentId).OrderBy(o => o.Name).ToListAsync();

        public async Task<List<OrgNode>> GetRootAsync() =>
    await _db.OrgNodes
        .Include(o => o.Leader)        // 
        .Where(o => o.ParentId == null)
        .OrderBy(o => o.Name)
        .ToListAsync();

        public async Task<List<OrgNode>> GetChildrenAsync(int parentId) =>
            await _db.OrgNodes
                .Include(o => o.Leader)        // 
                .Where(o => o.ParentId == parentId)
                .OrderBy(o => o.Name)
                .ToListAsync();

        public async Task<OrgNode?> GetAsync(int id) => await _db.OrgNodes.FindAsync(id);


        public async Task<OrgNode> CreateAsync(OrgNode node)
        {
            Validate(node);
            await EnsureDepthAsync(node.ParentId);
            _db.OrgNodes.Add(node);
            await _db.SaveChangesAsync();
            return node;
        }


        public async Task UpdateAsync(OrgNode node)
        {
            Validate(node);
            _db.OrgNodes.Update(node);
            await _db.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            var node = await _db.OrgNodes.Include(x => x.Children).FirstOrDefaultAsync(x => x.Id == id);
            if (node == null) return;
            if (node.Children.Any())
                throw new ValidationException("Najprv odstráňte podriadené uzly.");
            _db.OrgNodes.Remove(node);
            await _db.SaveChangesAsync();
        }


        private static void Validate(OrgNode n)
        {
            if (string.IsNullOrWhiteSpace(n.Code)) throw new ValidationException("Názov je povinný.");
            if (string.IsNullOrWhiteSpace(n.Name)) throw new ValidationException("Popis je povinný.");
        }


        private async Task EnsureDepthAsync(int? parentId)
        {
            // Povoliť max. 4 úrovne: Company(0) → Division(1) → Project(2) → Department(3)
            int depth = 0;
            var current = parentId.HasValue ? await _db.OrgNodes.FindAsync(parentId.Value) : null;
            while (current != null)
            {
                depth++;
                if (depth >= 4)
                    throw new ValidationException("Maximálna hĺbka hierarchie je 4.");
                current = current.ParentId.HasValue ? await _db.OrgNodes.FindAsync(current.ParentId.Value) : null;
            }
        }
    }
}