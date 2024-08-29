using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;
    public GameObject explosion;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        // Pocisk porusza się do przodu
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        // Tworzenie efektu wybuchu i niszczenie pocisku
        explosion = (GameObject)Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(explosion, 1.3f);
        Destroy(gameObject);
    }

    // Wykrywanie kolizji
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            print("ababa"); // Wiadomość dla podłoża
        }

        // Sprawdzenie, czy pocisk trafił w tarczę (Target)
        if (other.CompareTag("Target"))
        {
            // Pobranie nazwy tarczy i ustalenie poziomu głośności
            string targetName = other.gameObject.name;
            if (int.TryParse(targetName.Replace("Target", ""), out int level))
            {
                // Ustawienie poziomu głośności w grze
                MixerAudio.Instance.Volume = level / 10.0f;
            }
        }

        // Zniszczenie pocisku po kolizji
        DestroyProjectile();
    }
}
