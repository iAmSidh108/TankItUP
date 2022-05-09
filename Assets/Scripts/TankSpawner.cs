using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
    public Transform[] spawnPoints;
    void Start()
    {

        /* foreach (Transform sPoint in spawnPoints)
         {
             sPoint.gameObject.SetActive(false);
         }
        */
        // Transform newTrans = GetSpawnPoints();
        //Instantiate(tankView.gameObject, newTrans.position, newTrans.rotation);
        CreateTank();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform GetSpawnPoints()
    {
        return spawnPoints[Random.Range(0, spawnPoints.Length)];
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel();
        TankController tankController = new TankController(tankView, tankModel);
    }
}
