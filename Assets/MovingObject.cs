using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float speed = 5f; // �������� ��������
    public int damage = 20; // ����, ������� ����� ���������� ������

    void Update()
    {
        // ������ �������� �������� ����� � ������
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // ������ �������� �� ����� ��� ��������� �����������
        if (transform.position.x > 60 || transform.position.x < -60)
        {
            speed = -speed; // ������ ����������� ��� ���������� ������
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ���������, ��� ������������ ��������� � �������
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>(); // �������� ��������� PlayerHealth � ������
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage); // ������� ���� ������
            }
        }
    }
}
