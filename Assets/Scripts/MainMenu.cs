using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public TankSpawner tankSpawner;   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GreenTank()
    {
        Debug.Log("Green Tank");
        tankSpawner.CreateTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);
    }

    public void RedTank()
    {
        Debug.Log("Red Tank");
        tankSpawner.CreateTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);
    }

    public void BlueTank()
    {
        Debug.Log("Blue Tank");
        tankSpawner.CreateTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);
    }
}
