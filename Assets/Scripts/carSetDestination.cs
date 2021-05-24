using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSetDestination : MonoBehaviour
{
    public Transform target;
    public GameObject doors;

    public GameObject enterBox; 

	[SerializeField] private Animator animationController ; 
	public int stoppingTime = 10; 


    UnityEngine.AI.NavMeshAgent agent;



    // private bool m_waiting = false; 
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		animationController = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);


    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        //doors.SetActive(false);
		animationController.SetBool("OpenDoors",true); 
        agent.isStopped = true;
       // enterBox.SetActive(true); 
       
        yield return new WaitForSeconds(stoppingTime);

        // enterBox.SetActive(false);         
        animationController.SetBool("OpenDoors",false); 
		yield return new WaitForSeconds(2);
		agent.isStopped = false;
        // doors.SetActive(true);
    }




    //    if(nums[mid] >= target){
    //         right = mid - 1;
    
    //     }else{
    //         left = mid + 1 
    //     }
    public virtual void OnTriggerEnter(Collider col)
    {



		if(col.tag == "Stopper"){
           
		    StartCoroutine(ExampleCoroutine());
        
		}


    }
    // public virtual void OnTriggerStay(Collider col)
    //{





    // agent.velocity = Vector3.zero;
    // if(col.tag == "WaitZone")
    // {
    // 	WaitZone waitZone = col.GetComponent<WaitZone>();
    // 	if(waitZone.type == type)
    // 	{
    // 		if(type == TrafficType.Pedestrian)
    // 		{
    // 			if(CheckOppositeWAitZone(waitZone))
    // 				return;
    // 		}
    // 		m_CurrentWaitZone = waitZone;
    // 		if(!waitZone.canPass)
    // 			m_IsWaiting = true;
    // 	}
    // }
    // }
    public virtual void OnTriggerExit(Collider col)
    {

    }


}
