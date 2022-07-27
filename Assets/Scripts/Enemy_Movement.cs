using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;
    [SerializeField] Rigidbody _player;
    [SerializeField] float _cooldown = 2f;
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _bullet_Spawn_Enemy;


    public float lastBullet = 2;
    void FixedUpdate()
    {

        // posDestination - posActuelle
        //étant dans FixedUpdate ce sera fixeDeltaTime.
        Vector3 toPlayer = (_player.transform.position - transform.position) * _speed * Time.fixedDeltaTime;
        toPlayer = new Vector3(toPlayer.x, 0, toPlayer.z);
        //toPlayer c'est une variable pour dire vers le joueur
        //transform.Translate(en direction du joueur, par rapport à son espace)
        transform.Translate(toPlayer, Space.World);
        //_rb.MovePosition(transform.position - toPlayer);

        transform.LookAt(_player.transform);
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);


        if(Time.time >= _cooldown + lastBullet)
        {
            lastBullet = Time.time;
            GameObject.Instantiate(_bullet, _bullet_Spawn_Enemy.position, _bullet_Spawn_Enemy.rotation);
        }
    }
}
