using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar; // Ссылка на слайдер для отображения здоровья
    public PlayerHealth playerHealth; // Ссылка на компонент PlayerHealth

    void Start()
    {
        // Находим объект игрока и получаем компонент PlayerHealth
        playerHealth = FindObjectOfType<PlayerHealth>();

        // Инициализируем значение слайдера
        if (playerHealth != null)
        {
            healthBar.value = (float)playerHealth.currentHealth / playerHealth.maxHealth;
        }
    }

    void Update()
    {
        // Обновляем значение слайдера, если компонент PlayerHealth найден
        if (playerHealth != null)
        {
            healthBar.value = (float)playerHealth.currentHealth / playerHealth.maxHealth; // Обновляем значение полосы здоровья
        }
    }
}
