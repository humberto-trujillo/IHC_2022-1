using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : Interactable
{
    private Rigidbody rb;
    public Vector3 direction;
    public float kickForce = 10f;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected override void Interact()
    {
        base.Interact();
        // patear la pelota
        rb.AddForce(direction * kickForce);
    }
}
