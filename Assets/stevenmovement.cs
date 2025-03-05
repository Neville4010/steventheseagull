using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stevenmovement : MonoBehaviour
{
    public float movementSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    private bool isFacingRight = true;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * movementSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movementSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY);

        Flip();
    }

    private void Flip()
    {
        if (isFacingRight && speedX < 0f || !isFacingRight && speedX > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
