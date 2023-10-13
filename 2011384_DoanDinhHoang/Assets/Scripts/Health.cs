using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int _maximumHealth = 100;

    int _currentHealth = 0;
    Animation _animation;

    void Start()
    {
        _currentHealth = _maximumHealth;

        _animation = GetComponentInChildren<Animation>();
    }

    public void Damage (int damegeValue)
    {
        _currentHealth -= damegeValue;

        if(_currentHealth <= 0 )
        {
            _animation["Die"].wrapMode = WrapMode.Once;

            _animation.Play("Die");

            _animation["Die"].normalizedTime = Random.value;

            Destroy(gameObject,0.5f);
        }
    }
}
