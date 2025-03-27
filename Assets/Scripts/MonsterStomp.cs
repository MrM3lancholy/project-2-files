using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStomp : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "enemy")
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
        }
    }
}
