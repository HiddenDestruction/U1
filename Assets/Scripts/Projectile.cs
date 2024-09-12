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
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        explosion = (GameObject)Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(explosion, 1.3f);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            print("ababa");
        }

        if (other.CompareTag("Target"))
        {
            string targetName = other.gameObject.name;
            if (int.TryParse(targetName.Replace("Target", ""), out int level))
            {
                MixerAudio.Instance.Volume = level / 10.0f;
            }
        }
        DestroyProjectile();
    }
}
