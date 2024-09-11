using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Nagant;
    public GameObject Hand;
    //public GameObject Ammo;
    public GameObject Explosion;

    private void Start()
    {
        Hand.SetActive(false);
        //Ammo.SetActive(false);
        Explosion.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<granpa>() != null)
        {
            Destroy(Nagant);
            Hand.SetActive(true);
            //Ammo.SetActive(true);
            Explosion.SetActive(true);

            Debug.Log("Broñ podniesiona.");
        }
    }
}
