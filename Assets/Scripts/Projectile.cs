using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float damage = 50;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Health>();
        Debug.Log("dealing damage here!");
        health.DealDamage(damage);
    }
}
