public class TreeNodeViewModel
{
    public int TreeNodeId { get; set; }
    public string LinkText { get; set; } = string.Empty;
    public bool IsFolder { get; set; }
    public bool IsExpanded { get; set; }
    public bool IsLoaded { get; set; } = false; // Indicate if child nodes are loaded
    public string FullPath { get; set; } = string.Empty; // Store the full path
    public List<TreeNodeViewModel> Nodes { get; set; } = new List<TreeNodeViewModel>();
    public bool IsChecked { get; set; } = false; // Indicate if the node is checked
}
