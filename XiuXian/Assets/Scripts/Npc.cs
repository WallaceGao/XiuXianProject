using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Character
{
    bool _IsFriend;
    private Transform _Target;
    [SerializeField]
    private float distence;
    
    protected override void Awake()
    { 
        base.Awake();
        _Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        _Speed = _BesicSpeed;
    }

    protected override void Update()
    {
        base.Update();
        if (Vector2.Distance(transform.position, _Target.position) >  distence)
        {
            transform.position = Vector2.MoveTowards(transform.position, _Target.position, _Speed * Time.deltaTime);
        }
    }
}
