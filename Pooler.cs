using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour
{

    public GameObject poolingPrefab;

    public int initialPoolingAmount;
    public int maxAmount;

    private List<GameObject> pooledObjects;

    public GameObject Get()
    {
        return null;
    }

    public GameObject Eat()
    {
        return null;
    }
}
