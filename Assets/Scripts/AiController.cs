using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// using UnityEngine;
using UnityEngine.AI; 
using UnityStandardAssets.Characters.ThirdPerson; 
public class AiController : MonoBehaviour
{
    public NavMeshAgent agent; 

    public string type = "Passenger"; 
    public ThirdPersonCharacter character; 
    private GameObject Controller ; 

    void start()
    {
       //Controller = GameObject.Find("PedestrianSpawn");
        //agent.updateRotation = false ; 
    }

    // Update is called once per frame
    void Update()
    {
      
        
        if(agent.remainingDistance > agent.stoppingDistance)
        {

             character.Move(agent.desiredVelocity,false, false ) ; 
        }else { 

            character.Move(Vector3.zero, false , false); 
           
        }


    }

    void OnTriggerEnter(Collider col){

      	if(col.tag == "EnterZone" && type == "Passenger"){
        
            //character.Move(Vector3.forward,false, false ) ; 
            

           //Controller.GetComponent<PedestrianController>().countDown();

             Destroy(gameObject); 
            
            
		  
        
		}else if(col.tag == "OutZone" && type == "OutPassenger"){
       
                Destroy(gameObject); 
            
        }else if(col.tag == "Barrier" && type == "Passenger" ){

                
                agent.speed = (0.1f); 
             

        }

      
    }


    void OnTriggerExit(Collider col){

    if(col.tag == "Barrier" && type == "Passenger" ){

                
                agent.speed = (0.6f); 
             

        }

      
    }
}