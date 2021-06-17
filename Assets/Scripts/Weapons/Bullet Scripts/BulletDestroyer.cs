using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    public GameObject particles;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Destroy(gameObject, 3);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Enemy")){
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
        }
        else if(other.gameObject.CompareTag("Props")){
            other.gameObject.GetComponent<BidonDestroy>().TakeDamage(1);
        }
        gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        animator.SetTrigger("Hit");
        Instantiate(particles, transform.position, new Quaternion(-.7f, 0, 0, 0));
        Destroy(gameObject, animator.GetCurrentAnimatorStateInfo(0).length);
    }
}
