using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollider : MonoBehaviour
{
    public GameObject dead;
    public int delay = 11;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            transform.parent.GetComponent<granpa>().isGrounded = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            transform.parent.GetComponent<granpa>().isGrounded = false;
            
        }
        if (other.CompareTag("YouDieCollider"))
        {
            GameObject kekw = Instantiate(dead, new Vector3(0, 0, -21), Quaternion.identity);
            Destroy (kekw, delay);
        }

        
    }
}
