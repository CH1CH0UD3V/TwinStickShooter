using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    //speed c'est pour le game designer,pour qu'il change la vitesse
    [SerializeField]float _speed;
    

    void FixedUpdate()
    {
        //  move
        float vertical = Input.GetAxis("Vertical");//on créé une variable que l'on nomme vertical,dans cette variable on appelle la commande GetAxis
                                                   //et on lui dit que lorsque je vais l'affilier à une commande de jeu je vais pouvoir bouger du haut vers le bas et inversement.
        
        float horizontal = Input.GetAxis("Horizontal");//on créé une variable que l'on nomme horizotal,dans cette variable on appelle la commande GetAxis
                                                       //et on lui dit que lorsque je vais l'affilier à une commande de jeu je vais pouvoir bouger de gauche vers la droite et inversement.
       
        Vector3 direction = new Vector3(horizontal, 0, vertical);//ici Vector 3 concerne les axes (x, y, z),du coup sur quel axe on va se mouvoir.
        transform.Translate(direction * Time.deltaTime * _speed, Space.World) ;
        //_rb.MovePosition(transform.position + direction);

        // rotate
        float aimVertical = Input.GetAxis("AimVertical");
        float aimHorizontal = Input.GetAxis("AimHorizontal");
        Vector3 aimDirection = new Vector3(aimHorizontal, 0, aimVertical);
        transform.LookAt( transform.position + aimDirection);
    }

}
