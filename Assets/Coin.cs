using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ������, �������� � �������, ����� ��� "Player"
        if (other.CompareTag("Player"))
        {
            // �������� ��������� Wallet � ������
            Debug.Log("������� ����������� �: " + other.name);
            Wallet wallet = other.GetComponent<Wallet>();

            if (wallet != null)
            {
                wallet.CollectCoin(); // �������� ����� ��� ���������� ������ � �������
                Destroy(gameObject);  // ���������� ������ ����� �����
            }
            else
            {
                Debug.LogWarning("��������� Wallet �� ������ � ������� Player!");
            }
        }
    }
}
