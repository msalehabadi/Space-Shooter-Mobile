using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject laserBullet;
    [SerializeField] private Transform basicShootPoint;

    [SerializeField] private float shootinginterval;
    private float intervalReset;
    void Start()
    {
        intervalReset = shootinginterval;
    }

    // Update is called once per frame
    void Update()
    {
        shootinginterval -= Time.deltaTime;
        if (shootinginterval <= 0)
        {
            Shoot();
            shootinginterval = intervalReset;

        }
    }

    private void Shoot()
    {
        Instantiate(laserBullet, basicShootPoint.position, Quaternion.identity);
    }
}
