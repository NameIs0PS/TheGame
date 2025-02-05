using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthBar; // Ссылка на слайдер для отображения здоровья

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar(); // Инициализируем индикатор здоровья
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Player Health: " + currentHealth);
        UpdateHealthBar(); // Обновляем индикатор здоровья

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
            currentHealth = maxHealth; // Ограничиваем здоровье максимальным значением
        }
        UpdateHealthBar(); // Обновляем индикатор здоровья
    }

    void UpdateHealthBar()
    {
        if (healthBar != null)
        {
            healthBar.value = (float)currentHealth / maxHealth; // Обновляем значение слайдера
        }
    }

    void Die()
    {
        // Логика смерти игрока (например, уничтожение объекта)
        Destroy(gameObject);
    }
}

