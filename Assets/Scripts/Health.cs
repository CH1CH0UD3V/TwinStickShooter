using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] int _health;
    [SerializeField] UnityEvent _onDamage;

    public int CurrentHealth => _health;
    public void Damage(int bulletDamage)
    {
        _health = _health - bulletDamage;
        _health = Mathf.Max(0, _health);
        _onDamage.Invoke();

        if (_health <= 0)
        {
            Debug.Log("il est deeeeeeeeead");
            //GameObject.Destroy(gameObject);
            gameObject.SetActive(false);

        }
            
    }
}
