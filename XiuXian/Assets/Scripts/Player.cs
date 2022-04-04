using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character
{
    private Vector2 _Movement;

    protected override void Awake()
    {
        base.Awake();
        _Speed = _BesicSpeed;
    }

    protected override void Update()
    {
        base.Update();
        Move();
    }

    private void Move()
    {
        _Movement.x = Input.GetAxisRaw("Horizontal");
        _Movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + _Movement * _Speed * Time.fixedDeltaTime);
    }
}
