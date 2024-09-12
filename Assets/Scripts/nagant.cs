using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nagant : MonoBehaviour
{
    public float offset;

    public GameObject projectile;
    public GameObject shotEffect;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public AudioSource shot;

    public bool Sling = false;

    // Flaga do kontrolowania komunikatu
    private bool hasDisplayedNoWeaponMessage = false;

    private void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (MixerAudio.Instance != null)
        {
            shot.volume = MixerAudio.Instance.Volume;
        }

        if (Sling)
        {
            hasDisplayedNoWeaponMessage = false; // Resetujemy flagę, gdy broń jest dostępna

            if (timeBtwShots <= 0)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    Instantiate(projectile, shotPoint.position, transform.rotation);
                    timeBtwShots = startTimeBtwShots;

                    shot.Play();
                }
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }
        else
        {
            // Sprawdzenie, czy komunikat został już wyświetlony
            if (!hasDisplayedNoWeaponMessage)
            {
                Debug.Log("Nie masz broni! Nie możesz strzelać.");
                hasDisplayedNoWeaponMessage = true; // Ustawiamy flagę, by komunikat nie pojawiał się wielokrotnie
            }
        }
    }
}
