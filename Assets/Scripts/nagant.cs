using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nagant : MonoBehaviour {

    public float offset;

    public GameObject projectile;
    public GameObject shotEffect;
    public Transform shotPoint;
    // public Animator camAnim;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public AudioSource shot;

    private void Update()
    {
        // Handles the weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (MixerAudio.Instance != null)
        {
            shot.volume = MixerAudio.Instance.Volume; // Przypisanie głośności z AudioManager
        }

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                // Instantiate(shotEffect, shotPoint.position, Quaternion.identity);
                // camAnim.SetTrigger("shake");
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
                
                shot.Play();
            }
        }
        else {
            timeBtwShots -= Time.deltaTime;
        }

       
    }
}