using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что объект, вошедший в триггер, имеет тег "Player"
        if (other.CompareTag("Player"))
        {
            // Получаем компонент Wallet у игрока
            Debug.Log("Монетка столкнулась с: " + other.name);
            Wallet wallet = other.GetComponent<Wallet>();

            if (wallet != null)
            {
                wallet.CollectCoin(); // Вызываем метод для добавления монеты в кошелек
                Destroy(gameObject);  // Уничтожаем монету после сбора
            }
            else
            {
                Debug.LogWarning("Компонент Wallet не найден у объекта Player!");
            }
        }
    }
}
