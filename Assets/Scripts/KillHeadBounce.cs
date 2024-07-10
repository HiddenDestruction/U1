using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillHeadBounce : MonoBehaviour
{
    // public int delay = 1;
    public GameObject dead;
    public Vector3 test;
    // public GameObject testw;
    // public int one = 0;

    public GameObject head;

    
    void Start() { 
      test = gameObject.transform.position  + new Vector3(0.2f, -0.4f, 0.0f);
    //   testw = transform.parent.gameObject;
       
    //    loaderScript = loaderObject.GetComponent<LevelLoader>();
    }
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("GroundChecker"))
    {
        GameObject kekw = Instantiate(dead, test, Quaternion.identity);
        // Destroy(head.transform.GetChild(0).gameObject, 0.1f);
        Destroy(head);
        Destroy (kekw, 1.5f);
        print("fuck");
        // GameObject test3 = transform.parent.gameObject;
        // if (one == 0)
        // {

        //     one = 1;

        // }

        
        // test2 = .gameObject.transform.position  + new Vector3(222.3f, -0.6f, 0.0f);
        
    }
    // else if (other.CompareTag("Player"))
    // {
    //     Destroy(transform.parent.gameObject);
    // }

}
}
