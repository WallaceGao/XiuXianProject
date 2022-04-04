using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    protected Text _LastName;
    [SerializeField]
    protected Text _FristName;
    [SerializeField]
    protected uint _Age;
    [SerializeField]
    protected uint _MaxAge;
    [SerializeField]
    protected uint _XiuWei;
    [SerializeField]
    protected uint _MaxXiuWei;
    [SerializeField]
    protected uint _Health;
    [SerializeField]
    protected uint _MaxHealth;
    [SerializeField]
    protected uint _ZhenYuan;
    [SerializeField]
    protected uint _MaxZhenYuan;
    [SerializeField]
    protected uint _Speed;
    [SerializeField]
    protected uint _BesicSpeed;
    
    [SerializeField]
    protected int _Dao;
    [SerializeField]
    protected int _Jian;
    [SerializeField]
    protected int _Qiang;
    [SerializeField]
    protected int _Quan;
    [SerializeField]
    protected int _FuCheng;
    [SerializeField]
    protected int _Jin;
    [SerializeField]
    protected int _Mu;
    [SerializeField]
    protected int _Shui;
    [SerializeField]
    protected int _Huo;
    [SerializeField]
    protected int _Tu;
    [SerializeField]
    protected Rigidbody2D rb;

    protected virtual void Awake() { }
    protected virtual void Update() {}
}
