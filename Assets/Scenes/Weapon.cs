using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    public Transform SpawnPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject NewBullet = Instantiate(bulletPrefab);
            NewBullet.transform.position = SpawnPoint.position;
            NewBullet.transform.rotation = SpawnPoint.rotation;
            NewBullet.GetComponent<Rigidbody>().AddForce(SpawnPoint.transform.forward * 200.0f);
        }
        
    }
}
