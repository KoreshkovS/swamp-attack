using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private GameObject _destroyEffect;
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;

    private void Start()
    {
        Invoke("DestroyProjectile", _lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
    }

    private void DestroyProjectile()
    {
        Instantiate(_destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
