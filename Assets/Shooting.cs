using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public LayerMask player;
    float nextFire = 0;
    public float fireRate;
    public GameObject projectile;
    

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        nextFire += Time.deltaTime;

        if (nextFire >= fireRate)
        {
            Instantiate(projectile, firepoint.position, Quaternion.identity);
            nextFire = 0;
        }
    }
}
