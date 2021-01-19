using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{

    public GameObject Bullet;
   
    public GameObject bulletpoint;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            shoot();
        }

    }

    void shoot()
    {
        GameObject clone = Instantiate(Bullet, bulletpoint.transform.position, bulletpoint.transform.rotation);
        clone.GetComponent<Rigidbody2D>().AddForce(bulletpoint.transform.right * speed) ;
    }
}
