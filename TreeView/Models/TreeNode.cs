namespace TreeView.Models
{
    public class TreeNode
    {
        public string? Name { get; set; }
        public bool IsExpanded { get; set; } = false;
        public List<TreeNode> Children { get; set; } = new List<TreeNode>();
        public string? FileType { get; set; }
        public int ChildCount => Children?.Count ?? 0;
    }
}