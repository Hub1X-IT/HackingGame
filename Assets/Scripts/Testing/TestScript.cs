using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Script for testing whatever is needed

    public DiskNew disk1;

    private void Awake()
    {

        Debug.Log(disk1.Name);
        Debug.Log(disk1.ChildDataContainersDictionary.Count);
        foreach (var name in disk1.ChildDataContainersDictionary.Keys)
        {
            Debug.Log($"{name}: {disk1.ChildDataContainersDictionary[name]}");
        }
    }
}