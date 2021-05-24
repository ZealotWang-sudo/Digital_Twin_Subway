using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class OutTrain : MonoBehaviour
{
    // Start is called before the first frame update

      public GameObject Outpedestrian;

      public GameObject exit ;

      public GameObject[] trainExits ; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnTriggerEnter(Collider col){

      
        
      	if(col.tag == "EnterZone"){
              
		  //  Destroy(gameObject);  
           
          //  spawner.GetComponent<PedestrianController>().count -= waitingNumber  ;
         //  waitingNumber = 0 ; 


        for(int i = 0 ; i < trainExits.Length; i ++ ){


            GameObject agent = (GameObject) Instantiate(Outpedestrian, trainExits[i].transform.position, trainExits[i].transform.rotation);
       
	         agent.GetComponent<NavMeshAgent>().SetDestination(exit.transform.position); 


        }

	}

        
      
    }
}
