using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSPeed;
        public TankTypes tankTypes;
        public Material color;
    }

    public List<Tank> Tanks;
    public TankView tankView;
    public Transform[] spawnPoints;
    void Start()
    {

        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform GetSpawnPoints()
    {
        return spawnPoints[Random.Range(0, spawnPoints.Length)];
    }

    public void CreateTank(TankTypes tankTypes)
    {
        if (tankTypes == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(Tanks[1].movementSpeed, Tanks[1].rotationSPeed, Tanks[1].tankTypes, Tanks[1].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
        else if (tankTypes == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(Tanks[2].movementSpeed, Tanks[2].rotationSPeed, Tanks[2].tankTypes, Tanks[2].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
        else if (tankTypes == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(Tanks[0].movementSpeed, Tanks[0].rotationSPeed, Tanks[0].tankTypes, Tanks[0].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
        
    }
}
