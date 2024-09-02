using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpike : MonoBehaviour
{
    public Transform startPoint; // Ustaw w inspectorze pozycjê startow¹, gdzie gracz ma zostaæ przeniesiony

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Sprawdzamy, czy obiekt to gracz
        {
            print("Gracz wszed³ w pu³apkê!");

            // Przenosimy gracza na pozycjê startow¹
            other.transform.position = startPoint.position;
        }
    }
}
