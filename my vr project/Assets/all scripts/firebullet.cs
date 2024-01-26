using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class firebullet : MonoBehaviour
{
    // Start is called before the first frame update
   
    
        public float speed = 50f;
        public GameObject bulletObj;
        public Transform frontOfGun;
    

    // Update is called once per frame
    public void Fire()
    {
    GetComponent<AudioSource>().Play();
    GameObject spawnedBullet = Instantiate(bulletObj, frontOfGun.position, frontOfGun.rotation);
    spawnedBullet.GetComponent<Rigidbody>().velocity = speed * frontOfGun.forward;
    Destroy(spawnedBullet, 5f);
    }
}
