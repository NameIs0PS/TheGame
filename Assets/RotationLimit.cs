using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLimit : MonoBehaviour
{
    private Vector3 startPosition; // �������� ������� ���������

    void Start()
    {
        // ��������� ��������� �������
        startPosition = transform.position;
    }

    void Update()
    {
        // ��������� �������� �� ���� x � z
        if (Mathf.Abs(transform.rotation.eulerAngles.x) >= 90f || Mathf.Abs(transform.rotation.eulerAngles.z) >= 90f)
        {
            ResetRotation();
        }
    }

    void ResetRotation()
    {
        // ���������� �������� �� ���� x � z
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.x = 0f; // ������������� ���� X � 0
        currentRotation.z = 0f; // ������������� ���� Z � 0
        transform.rotation = Quaternion.Euler(currentRotation); // ��������� ����� ��������

        // ���� � ��� ���� Rigidbody, ���������� ��������
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.zero; // �������� ��������
            rb.angularVelocity = Vector3.zero; // �������� ������� ��������
        }
    }
}
