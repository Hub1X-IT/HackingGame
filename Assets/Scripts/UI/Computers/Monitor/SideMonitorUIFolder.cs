using UnityEngine;
using UnityEngine.UI;

public class SideMonitorUIFolder : FileExplorerUIDataContainer
{
    [SerializeField]
    private Button childFoldersButton;

    [SerializeField]
    private Button folderContentButton;

    [SerializeField]
    private Sprite baseFolderIcon;

    [SerializeField]
    private Sprite lockedFolderIcon;

    [SerializeField]
    private Sprite childFoldersHiddenSprite;

    [SerializeField]
    private Sprite childFoldersShownSprite;

    private FolderSO selfFolderSO;

    private FolderSO parentFolderSO;

    private VerticalLayoutGroup verticalLayoutGroup;

    private Vector2 baseFolderSize;

    protected override void Awake()
    {
        base.Awake();

        verticalLayoutGroup = GetComponent<VerticalLayoutGroup>();

        childFoldersButton.onClick.AddListener(ToggleChildFolders);
        folderContentButton.onClick.AddListener(OpenFolderContent);

        baseFolderSize = SelfRectTransform.sizeDelta;
    }

    public void InitializeFolderUI(FolderSO folderSO)
    {
        selfFolderSO = folderSO;
        parentFolderSO = folderSO.ParentFolderSO;
        SelfDataContainerSO = folderSO;

        SetName(selfFolderSO.SelfName);

        BaseDataContainerIcon = baseFolderIcon;
        LockedDataContainerIcon = lockedFolderIcon;

        childFoldersButton.gameObject.SetActive(gameObject.activeSelf && selfFolderSO.HasChildFolders());
        childFoldersButton.image.sprite = selfFolderSO.ShouldShowChildFolders ? childFoldersShownSprite : childFoldersHiddenSprite;
        childFoldersButton.image.rectTransform.sizeDelta = selfFolderSO.ShouldShowChildFolders ? new Vector2(40, 25) : new Vector2(25, 40);
    }

    private void ToggleChildFolders()
    {
        if (TryOpenDataContainer())
        {
            selfFolderSO.ShouldShowChildFolders = !selfFolderSO.ShouldShowChildFolders;
            CurrentFileExplorer.RefreshSideFolders();
        }
    }

    private void OpenFolderContent()
    {
        CurrentFileExplorer.TryOpenFolderContent(selfFolderSO, this, new());
    }

    private void OpenParentFolderContent()
    {
        CurrentFileExplorer.TryOpenFolderContent(parentFolderSO, this, new());
    }

    protected override void OnDataContainerUnlocked()
    {
        base.OnDataContainerUnlocked();
        if (parentFolderSO != null && parentFolderSO.IsFolderContentOpen)
        {
            OpenParentFolderContent();
        }
    }

    public void RefreshChildFolders()
    {
        // Should only be called on the root folder.

        FileExplorerUIDataContainer[] childDataContainersUI = GetComponentsInChildren<FileExplorerUIDataContainer>(true);
        foreach (var childDataContainer in childDataContainersUI)
        {
            if (childDataContainer.transform.parent == transform)
            {
                childDataContainer.DestroySelf();
            }
        }

        AddChildFolders(selfFolderSO);

        RefreshFolderUISize();
    }

    public void AddChildFolders(FolderSO currentFolderSO)
    {
        foreach (var dataContainerSO in currentFolderSO.ChildDataContainers)
        {
            if (dataContainerSO is FolderSO newFolderSO)
            {
                SideMonitorUIFolder newUIFolder = Instantiate(CurrentFileExplorer.SideFolderUIPrefab.gameObject,
                    transform).GetComponent<SideMonitorUIFolder>();

                newUIFolder.InitializeFolderUI(newFolderSO);
                newUIFolder.InitializeUIDataContainer(CurrentFileExplorer);
                newUIFolder.AddChildFolders(newFolderSO);
                newUIFolder.gameObject.SetActive(currentFolderSO.ShouldShowChildFolders);
            }
        }
    }

    private void RefreshFolderUISize()
    {
        Vector2 currentSize = baseFolderSize;
        float verticalChildOffset = verticalLayoutGroup.spacing;

        FileExplorerUIDataContainer[] childDataContainersUI = GetComponentsInChildren<FileExplorerUIDataContainer>(true);

        foreach (var childDataContainerUI in childDataContainersUI)
        {
            // Only include active folders that are direct children of this folder.
            if (childDataContainerUI.gameObject.activeSelf && childDataContainerUI.transform.parent == transform)
            {
                if (childDataContainerUI is SideMonitorUIFolder childFolderUI)
                {
                    childFolderUI.RefreshFolderUISize();
                }
                // Add child data container UI.
                currentSize.x = Mathf.Max(currentSize.x, childDataContainerUI.SelfRectTransform.sizeDelta.x);
                currentSize.y += childDataContainerUI.SelfRectTransform.sizeDelta.y + verticalChildOffset;
            }
        }

        SelfRectTransform.sizeDelta = currentSize;
    }
}