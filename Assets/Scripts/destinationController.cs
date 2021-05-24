using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destinationController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject spawner;
    public int SpawnInterval = 0;
     IEnumerator OnTriggerEnter(Collider col)
    {
        if(col.tag == "Train"){

        Destroy(col.gameObject); 
            yield return new WaitForSeconds(SpawnInterval);
          
         spawner.GetComponent<CarsSpawn>().SpawnAgent();
       
        }   
      

    }




}
