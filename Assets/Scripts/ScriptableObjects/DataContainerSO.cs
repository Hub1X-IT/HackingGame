using UnityEngine;

public class DataContainerSO : ScriptableObject
{
    [SerializeField]
    private string selfName;

    public string SelfName => selfName;

    public FolderSO ParentFolderSO { get; set; }
}
