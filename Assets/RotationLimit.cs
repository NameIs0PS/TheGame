using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLimit : MonoBehaviour
{
    private Vector3 startPosition; // Исходная позиция персонажа

    void Start()
    {
        // Сохраняем начальную позицию
        startPosition = transform.position;
    }

    void Update()
    {
        // Проверяем значения по осям x и z
        if (Mathf.Abs(transform.rotation.eulerAngles.x) >= 90f || Mathf.Abs(transform.rotation.eulerAngles.z) >= 90f)
        {
            ResetRotation();
        }
    }

    void ResetRotation()
    {
        // Сбрасываем вращение по осям x и z
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.x = 0f; // Устанавливаем угол X в 0
        currentRotation.z = 0f; // Устанавливаем угол Z в 0
        transform.rotation = Quaternion.Euler(currentRotation); // Применяем новое вращение

        // Если у вас есть Rigidbody, сбрасываем скорость
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.zero; // Обнуляем скорость
            rb.angularVelocity = Vector3.zero; // Обнуляем угловую скорость
        }
    }
}
