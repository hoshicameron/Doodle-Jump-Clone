using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] private float jumpForce=600f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        var rBody2d = other.gameObject.GetComponent<Rigidbody2D>();
        if (rBody2d.velocity.y <= 0)
        {
            rBody2d.AddForce(Vector2.up*jumpForce);
        }
    }
}
