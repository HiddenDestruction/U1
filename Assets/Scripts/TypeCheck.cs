using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeCheck : MonoBehaviour
{
    public string code;
    public bool entry = false;
    [SerializeField] private Transform teleport;
    void OnTriggerStay2D(Collider2D other)
    {
         
        if (other.CompareTag("Player"))
        {
            entry = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            entry = false;
            if (code == "12345")
            {
                print("12345 YES!");
                other.transform.position = teleport.position;

            }
            
        }

    }



        void Update()
    {
        if (entry == true)
        {
        foreach (char c in Input.inputString)
        {
                code += c;
                // print(code);
        }
        }

    }
}
