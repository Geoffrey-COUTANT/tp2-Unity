using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private int score = 0;
    private float jumpForce = 30;
    [SerializeField] private Rigidbody2D Rigidbody;
    [SerializeField] private Timer timer;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        // Ajoute une force vers le haut pour simuler le saut
        Rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        // Annule la vélocité horizontale pour éliminer l'inertie
        Rigidbody.velocity = new Vector2(0, Rigidbody.velocity.y);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Dinosaur"))
        {
            ChangeScene();
        }
        if (other.gameObject.CompareTag("money"))
        {
            Destroy(other.gameObject);
            score++;
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("LooseScene");
    }
}