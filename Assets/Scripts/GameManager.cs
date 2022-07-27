using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] Health _playerHealth;
    [SerializeField] Health _enemyHealth;

    [SerializeField] UnityEvent _onLose;
    [SerializeField] UnityEvent _onWin;
    [SerializeField] UnityEvent _onDraw;
    void Update()
    {
        if (_playerHealth.CurrentHealth <= 0 && _enemyHealth.CurrentHealth <= 0)
        {
            // égalité
            _onDraw.Invoke();
        }
        else if (_playerHealth.CurrentHealth <= 0)
        {
            //perdu
            _onLose.Invoke();
        }
        else if (_enemyHealth.CurrentHealth <= 0)
        {
            //gagné
            _onWin.Invoke();
        }

    }
}
