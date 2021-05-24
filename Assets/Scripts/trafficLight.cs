using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficLight : MonoBehaviour
{
    // Start is called before the first frame update

    

    public GameObject stopper1;
    // public GameObject stopper2;
   

    public bool lightSwitch = true;

    public int timeSwitch; 

    void Start()
    {



        // Get the current material applied on the GameObject

        // Set the new material on the GameObject

        StartCoroutine(ExampleCoroutine());





    }


    IEnumerator ExampleCoroutine()
    {

        while (true)
        {
            lightSwitch = !lightSwitch;
            if (lightSwitch)
            {
                
               stopper1.transform.Translate(Vector3.up * 10, Space.World);
            }
            else
            {
              stopper1.transform.Translate(Vector3.down * 10, Space.World);
            
            }
            yield return new WaitForSeconds(timeSwitch);


        }


    }

 

    // Update is called once per frame





}
