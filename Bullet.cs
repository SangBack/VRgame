using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public ParticleSystem BulletHit;
    public Transform BulletHitPivot;
    public int damage;

    void Update()
    {
        Destroy(gameObject, 3);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            ParticleSystem BulletHitPre = Instantiate(BulletHit, BulletHitPivot.position, BulletHitPivot.rotation);
            BulletHitPre.Play();
            Destroy(gameObject);
        }

    }


}
