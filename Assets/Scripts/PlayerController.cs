using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Hız, fizik ve yön için değişkenler oluşturduk
    [SerializeField]float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    [SerializeField] float playerMinY;
    [SerializeField] float playerMaxY;



    // Start is called before the first frame update
    void Start()
    {
        // rb'yi playerin sahip olduğu component'e bağladık
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // Y ekseninde hareket etmek için input atadık
        float directionY = Input.GetAxisRaw("Vertical");

        // Oyuncunun yönünü belirten vectör'ü tanımladık
        playerDirection = new Vector2(0, directionY).normalized;        
    }

    void FixedUpdate()
    {
        // Oyuncuya hız verdik
        rb.velocity = playerDirection * playerSpeed;
    }
}
