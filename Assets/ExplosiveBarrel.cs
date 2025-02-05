using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBarrel : MonoBehaviour
{
    public float explosionForce = 500f; // ���� ������
    public float explosionRadius = 5f; // ������ ������
    public GameObject explosionEffect; // ������ ������ (����� �������� ������)

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // ����������� ������
            Destroy(collision.gameObject);

            // �������� ������
            Explode();
        }
    }

    void Explode()
    {
        // �������� ������� ������
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }

        // ����������� ����� �����
        Destroy(gameObject);
    }
}
