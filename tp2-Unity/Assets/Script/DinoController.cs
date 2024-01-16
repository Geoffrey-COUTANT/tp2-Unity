using System;
using UnityEngine;

public class DinoController : MonoBehaviour
{
    [SerializeField]private Rigidbody2D Rigidbody;
    [SerializeField]private float speed;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    { 
        transform.Translate(Vector2.left * (speed * Time.deltaTime));
    }
}
