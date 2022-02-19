using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public Vector2 direction;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Kick()
    {
        _rigidbody2D.AddForce(direction, ForceMode2D.Force);
    }
}
