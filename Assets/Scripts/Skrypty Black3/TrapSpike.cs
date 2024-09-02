using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpike : MonoBehaviour
{
    public Transform startPoint; // Ustaw w inspectorze pozycj� startow�, gdzie gracz ma zosta� przeniesiony

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Sprawdzamy, czy obiekt to gracz
        {
            print("Gracz wszed� w pu�apk�!");

            // Przenosimy gracza na pozycj� startow�
            other.transform.position = startPoint.position;
        }
    }
}
