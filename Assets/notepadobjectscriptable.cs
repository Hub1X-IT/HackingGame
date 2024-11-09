using UnityEngine;

[CreateAssetMenu(fileName = "notepadobjectscriptable", menuName = "Scriptable Objects/notepadobjectscriptable")]
public class notepadobjectscriptable : ScriptableObject
{
    [Tooltip("Text for the desktop notepad")]
    public string notepadtext = string.Empty;
}
