using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour
{

    public static Pooler Instance;

    public GameObject pooledPrefab;

    public int initialPoolingAmount;
     
    public bool isExpandable = false;

    private List<GameObject> pooledObjects = new List<GameObject>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < initialPoolingAmount; i++)
        {
            GameObject pooledObject = Instantiate(pooledPrefab) as GameObject;
            pooledObject.SetActive(false);
            pooledObjects.Add(pooledObject);
        }
    }

    public GameObject Get()
    {
        foreach (GameObject pooledObject in pooledObjects)
        {
            if (!pooledObject.activeSelf)
            {
                return pooledObject;
            }
        }

        if (isExpandable)
        {
            GameObject newPooledObject = Instantiate(pooledPrefab) as GameObject;
            newPooledObject.SetActive(false);
            pooledObjects.Add(newPooledObject);
            return newPooledObject;
        }
        else
        {
            return null;
        }
    }
}
