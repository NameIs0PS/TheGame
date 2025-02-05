using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float speed = 5f; // Скорость движения
    public int damage = 20; // Урон, который будет наноситься игроку

    void Update()
    {
        // Пример простого движения влево и вправо
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Логика возврата на место или изменения направления
        if (transform.position.x > 60 || transform.position.x < -60)
        {
            speed = -speed; // Меняем направление при достижении границ
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Проверяем, что столкновение произошло с игроком
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>(); // Получаем компонент PlayerHealth у игрока
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage); // Наносим урон игроку
            }
        }
    }
}
