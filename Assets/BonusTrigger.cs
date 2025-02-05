using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTrigger : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered trigger: " + other.name); // Показывает имя объекта
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the bonus trigger");
            animator.SetBool("IsActive", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Object exited trigger: " + other.name); // Показывает имя объекта
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited the bonus trigger");
            animator.SetBool("IsActive", false);
        }
    }
}

