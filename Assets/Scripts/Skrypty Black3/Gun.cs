using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Nagant;  // Obiekt broni, kt�ry b�dzie zniszczony po podniesieniu
    public GameObject Hand;    // Bro� w r�ce, kt�ra stanie si� aktywna

    // Dodaj referencj� do skryptu 'nagant'
    public nagant nagantScript;  // Musisz ustawi� to w inspektorze lub znale�� obiekt w kodzie

    private void Start()
    {
        Hand.SetActive(false);   // Bro� w r�ce ukryta na pocz�tku
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<granpa>() != null)  // Sprawdzenie, czy koliduje z graczem
        {
            Destroy(Nagant);      
            Hand.SetActive(true); 

            if (nagantScript != null)
            {
                nagantScript.Sling = true;  
                Debug.Log("Bro� podniesiona, strzelanie aktywne.");
            }
            else
            {
                Debug.LogWarning("Strzelanie nieaktywne.");
            }
        }
    }
}
