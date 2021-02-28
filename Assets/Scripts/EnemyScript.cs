using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int speed = 3;
    public GameObject Player;

    void Awake(){
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    
    void OnTriggerEnter2D(Collider2D other){
        if (other.name == "Ground")
        {
            Debug.Log("Hello");
            Destroy(gameObject);
        }
        if (other.tag == "Bullet")
        {
            Debug.Log("Krish");
            Destroy(gameObject);
            Destroy(other.gameObject);


            Player.GetComponent<Arduino>().port.WriteLine("1");
        }
    }
    
}
