using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sling : MonoBehaviour
{
    public GameObject slingObject; // Obiekt procy w scenie
    public bool hasSling = false; // Czy gracz ma proc�?
    public float shootingForce = 10f; // Si�a strza�u

    void Start()
    {
        // Ukrywamy proc� na pocz�tku gry
        slingObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (hasSling)
            {
                Shoot();
            }
            else
            {
                Debug.Log("Nie masz procy! Nie mo�esz strzela�.");
            }
        }
    }

    public void CollectSling()
    {
        hasSling = true;
        slingObject.SetActive(true); // Uwidoczniamy proc�
        Debug.Log("Zebra�e� proc�! Mo�esz teraz strzela�.");
    }

    void Shoot()
    {
        Debug.Log("Strzelanie z procy!");
    }
}
