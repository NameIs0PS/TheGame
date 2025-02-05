using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBarrel : MonoBehaviour
{
    public float explosionForce = 500f; // Сила взрыва
    public float explosionRadius = 5f; // Радиус взрыва
    public GameObject explosionEffect; // Эффект взрыва (можно добавить префаб)

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Уничтожение игрока
            Destroy(collision.gameObject);

            // Взрывная логика
            Explode();
        }
    }

    void Explode()
    {
        // Создание эффекта взрыва
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }

        // Уничтожение самой бочки
        Destroy(gameObject);
    }
}
