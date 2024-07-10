using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudShot : MonoBehaviour
{
    GameObject loaderObject;
    CloudTeleport loaderScript;

   void Start()
    { 
        loaderObject = GameObject.Find("CloudTeleport");
        loaderScript = loaderObject.GetComponent<CloudTeleport>();
    }

    void OnTriggerEnter(Collider other)
    {       
        if (other.CompareTag("Bullet"))
        {
            print("Button shot");
            loaderScript.CloudShot = true;
        }
    }
}