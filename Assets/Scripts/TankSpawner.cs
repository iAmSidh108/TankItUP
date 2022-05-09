using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public Transform[] spawnPoints;
    void Start()
    {
        //
        foreach (Transform sPoint in spawnPoints)
        {
            sPoint.gameObject.SetActive(false);
        }

        Transform newTrans = GetSpawnPoints();
        Instantiate(tankPrefab, newTrans.position, newTrans.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform GetSpawnPoints()
    {
        return spawnPoints[Random.Range(0, spawnPoints.Length)];
    }
}
