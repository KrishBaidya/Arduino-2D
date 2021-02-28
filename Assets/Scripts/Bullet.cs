using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed = 10;
    
    private void Update(){
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if (transform.position.y >= 20)
        {
            Destroy(gameObject);
        }
    }
}
