using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetect : MonoBehaviour
{
    //bool Input.GetKey();
    [SerializeField] GameObject _Bullet;
    [SerializeField] Transform _Bullet_Spawn;


    void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject.Instantiate(_Bullet, _Bullet_Spawn.position, _Bullet_Spawn.rotation);

            Debug.Log("pan enculé");

        }

        
    }
}
