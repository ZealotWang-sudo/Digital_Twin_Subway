using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
public class PedestrianController : MonoBehaviour
{
    
    public GameObject pedestrian;

     public GameObject[] waitLines;

     public int count = 0; 

     private GameObject exit ; 

     private int waitingSpace; 

     public int spawnTime = 0; 

    //public GameObject goalObject;
    void Start()
    {   
        

    
          Invoke("SpawnPedestrian", 0);

    
    }   

    public void countZero(){
        count = 0; 
    }

    public void SpawnPedestrian(){


        GameObject agent = (GameObject) Instantiate(pedestrian, this.transform.position, this.transform.rotation);
       
        
       exit = waitLines[count]; 
        agent.GetComponent<NavMeshAgent>().SetDestination(exit.transform.position); 
 
        if(count < waitLines.Length  - 1){
       
            count ++ ; 

        }else{
            count = 0; 
        }
       
    

        Invoke("SpawnPedestrian", spawnTime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
