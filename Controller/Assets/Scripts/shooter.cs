using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float bullets = 20;
    public TMP_Text bulletsText;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           OnSpaceDown();

           bullets -= 1;
        }
       
    }

    public void OnSpaceDown()
    {
       
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        
        bulletsText.text = bullets.ToString();


        

    }

}
