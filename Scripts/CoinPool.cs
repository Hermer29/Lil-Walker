using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPool : MonoBehaviour
{
    public CoinPool sharedInstance;
    public int poolSize;
    public GameObject objectToPool;
    public List<GameObject> pooledCoins;

    private void Awake()
    {
        sharedInstance = this;
    }

    private void Start()
    {
        pooledCoins = new List<GameObject>();
        GameObject temp;

        for(int i = 0; i <= poolSize; i++)
        {
            temp = Instantiate(objectToPool);
            temp.SetActive(false);
            pooledCoins.Add(temp);
        }
    }

}
