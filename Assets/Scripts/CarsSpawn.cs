using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsSpawn : MonoBehaviour
{
    public GameObject car;
    //public GameObject goalObject;
    public GameObject exitOption;
   // public GameObject[] spawnOptions;

   

    void Start()
    {
        Invoke("SpawnAgent", 0);
        
    }


    

    
    public void SpawnAgent(){
        
        
       
        GameObject na = (GameObject) Instantiate(car, this.transform.position, this.transform.rotation);

        GameObject exit = exitOption;

        na.GetComponent<carSetDestination>().target = exit.transform;


    }
}
