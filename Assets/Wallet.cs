using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Wallet : MonoBehaviour
{
    public int coinCount = 0; // ���������� ��������� �����
    public TMP_Text coinCountText; // ������ �� UI ����� ��� ����������� ���������� �����

    // ����� ��� ����� ������
    public void CollectCoin()
    {
        coinCount++;
        Debug.Log("������ �������! " + coinCount);
        UpdateUI(); // ��������� ���������
    }

    // ����� ��� ���������� ����������
    void UpdateUI()
    {
        if (coinCountText != null)
        {
            coinCountText.text = "" + coinCount; // ��������� ����� � ����������� �����
        }
    }
}
