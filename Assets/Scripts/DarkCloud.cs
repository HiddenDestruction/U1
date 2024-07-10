using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkCloud : MonoBehaviour
{
    // public GameObject cloud;

public int thrust = 1;
public Rigidbody2D rb;
// public Gameobject dead;


    void Start() { 
       rb = GetComponent<Rigidbody2D>(); 
       
       
    //    loaderScript = loaderObject.GetComponent<LevelLoader>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {       
        // cloud = GameObject.FindGameObjectsWithTag("DarkCloud");

        // GameObject objectMain = foundOne.transform.parent.gameObject;
        if (other.CompareTag("Bullet"))
        {
            print("wewe44");
            rb.gravityScale = 1f;
            rb.velocity = Vector3.down * thrust;
            

        }



        //  if (other.GetComponent<DarkCloud>() != null)
        // {
        //     print("333333");
        // }
    }
}
