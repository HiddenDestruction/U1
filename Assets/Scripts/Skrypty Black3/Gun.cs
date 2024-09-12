using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Nagant;  // Obiekt broni, który bêdzie zniszczony po podniesieniu
    public GameObject Hand;    // Broñ w rêce, która stanie siê aktywna

    // Dodaj referencjê do skryptu 'nagant'
    public nagant nagantScript;  // Musisz ustawiæ to w inspektorze lub znaleŸæ obiekt w kodzie

    private void Start()
    {
        Hand.SetActive(false);   // Broñ w rêce ukryta na pocz¹tku
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
                Debug.Log("Broñ podniesiona, strzelanie aktywne.");
            }
            else
            {
                Debug.LogWarning("Strzelanie nieaktywne.");
            }
        }
    }
}
