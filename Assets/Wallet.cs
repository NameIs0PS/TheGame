using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Wallet : MonoBehaviour
{
    public int coinCount = 0; // Количество собранных монет
    public TMP_Text coinCountText; // Ссылка на UI текст для отображения количества монет

    // Метод для сбора монеты
    public void CollectCoin()
    {
        coinCount++;
        Debug.Log("Монета собрана! " + coinCount);
        UpdateUI(); // Обновляем интерфейс
    }

    // Метод для обновления интерфейса
    void UpdateUI()
    {
        if (coinCountText != null)
        {
            coinCountText.text = "" + coinCount; // Обновляем текст с количеством монет
        }
    }
}
