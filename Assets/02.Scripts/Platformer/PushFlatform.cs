using System;
using UnityEngine;

public class PushFlatform : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D targetRb;
    [SerializeField] private float PushPower;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            targetRb = other.GetComponent<Rigidbody2D>();
            Invoke("PushCharater", 1f);
        }
    }

    private void PushCharater()
    {
        targetRb.AddForceY(PushPower, ForceMode2D.Impulse);
        animator.SetTrigger("Push");
    }
}
