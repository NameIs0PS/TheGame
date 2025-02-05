using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar; // ������ �� ������� ��� ����������� ��������
    public PlayerHealth playerHealth; // ������ �� ��������� PlayerHealth

    void Start()
    {
        // ������� ������ ������ � �������� ��������� PlayerHealth
        playerHealth = FindObjectOfType<PlayerHealth>();

        // �������������� �������� ��������
        if (playerHealth != null)
        {
            healthBar.value = (float)playerHealth.currentHealth / playerHealth.maxHealth;
        }
    }

    void Update()
    {
        // ��������� �������� ��������, ���� ��������� PlayerHealth ������
        if (playerHealth != null)
        {
            healthBar.value = (float)playerHealth.currentHealth / playerHealth.maxHealth; // ��������� �������� ������ ��������
        }
    }
}
