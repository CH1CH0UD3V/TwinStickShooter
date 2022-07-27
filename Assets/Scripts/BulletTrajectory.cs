using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrajectory : MonoBehaviour
{
    [Header("Bullet Controls")]
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;
    [SerializeField] int _damage;

    void Start()
    {
        _rb.velocity = transform.TransformDirection(new Vector3(0, 0, 1) * _speed);
        //_rb.velocity = transform.forward * _speed;
    }

    void OnCollisionEnter(Collision collision)
    {
       //on demande la destruction de la bullet au moment de la collision
       GameObject.Destroy(gameObject);

        Health targetHealth = collision.gameObject.GetComponent<Health>();
        if(targetHealth != null)
        {
            targetHealth.Damage(_damage);
        }
    }
}