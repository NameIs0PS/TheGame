using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthBar; // ������ �� ������� ��� ����������� ��������

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar(); // �������������� ��������� ��������
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Player Health: " + currentHealth);
        UpdateHealthBar(); // ��������� ��������� ��������

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth; // ������������ �������� ������������ ���������
        }
        UpdateHealthBar(); // ��������� ��������� ��������
    }

    void UpdateHealthBar()
    {
        if (healthBar != null)
        {
            healthBar.value = (float)currentHealth / maxHealth; // ��������� �������� ��������
        }
    }

    void Die()
    {
        // ������ ������ ������ (��������, ����������� �������)
        Destroy(gameObject);
    }
}

