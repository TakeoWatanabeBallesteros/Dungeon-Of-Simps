using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2DodgeMovement : MonoBehaviour
{
    DodgeState dodgeState;
    float dodgeDistance = 2;
    Rigidbody2D rb;
    Transform player;
    int _direction = 1;
    // Start is called before the first frame update
    private void OnEnable() {
        dodgeState.OnMove += Dodge;
    }
    private void OnDisable() {
        dodgeState.OnMove -= Dodge;
    }
    void Awake() {
        dodgeState = GetComponent<DodgeState>();
    }
    void Start()
    {
        player = PlayerSingleton.Instance.transform;
        rb = GetComponent<Rigidbody2D>();
    }

    void Dodge(){
        StartCoroutine(_Dodge());
    }
    IEnumerator _Dodge(){
        _direction = -_direction;
        Vector2 direction = Vector2.Perpendicular(player.position - transform.position);
        rb.velocity = Vector2.zero;
        rb.AddForce(_direction*direction*dodgeDistance,ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.1f);
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0;
    }
}
