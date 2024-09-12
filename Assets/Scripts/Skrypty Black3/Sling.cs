using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sling : MonoBehaviour
{
    public GameObject slingObject; // Obiekt procy w scenie
    public bool hasSling = false; // Czy gracz ma procê?
    public float shootingForce = 10f; // Si³a strza³u

    void Start()
    {
        // Ukrywamy procê na pocz¹tku gry
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
                Debug.Log("Nie masz procy! Nie mo¿esz strzelaæ.");
            }
        }
    }

    public void CollectSling()
    {
        hasSling = true;
        slingObject.SetActive(true); // Uwidoczniamy procê
        Debug.Log("Zebra³eœ procê! Mo¿esz teraz strzelaæ.");
    }

    void Shoot()
    {
        Debug.Log("Strzelanie z procy!");
    }
}
