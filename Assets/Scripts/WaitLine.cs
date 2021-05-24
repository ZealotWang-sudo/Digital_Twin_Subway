using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitLine : MonoBehaviour
{

    public int waitingNumber = 0; 

    public GameObject spawner; 
    // Start is called before the first frame update
      void OnTriggerEnter(Collider col){

      	if(col.tag == "Pedestrian"){
              
		  //  Destroy(gameObject); 
            waitingNumber++ ; 
		}
        
      	if(col.tag == "EnterZone"){
              
		  //  Destroy(gameObject); 
           
          //  spawner.GetComponent<PedestrianController>().count -= waitingNumber  ;
           waitingNumber = 0 ; 
		}
        
      
    }
      

      void OnTriggerExit(Collider col){

      	if(col.tag == "Pedestrian"){
              
		  //  Destroy(gameObject); 
            waitingNumber-- ; 
		}
        
      
    }
}
