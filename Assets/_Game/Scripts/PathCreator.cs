using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathCreator : MonoBehaviour
{
    [SerializeField] List<GameObject> AllPathObjects;
    public int PathCount;

    private void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            CreatePath();
        }
    }
    public void CreatePath()
    {
        Debug.Log("1");
        int randomVal = Random.Range(0, AllPathObjects.Count);
        Instantiate(AllPathObjects[randomVal], transform.forward * PathCount, Quaternion.identity, this.transform);
        PathCount++;
    }
}
