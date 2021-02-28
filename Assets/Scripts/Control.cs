using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Arduino))]
public class Control : MonoBehaviour
{
    public int min , max;
    public int speed = 1;
    public GameObject bullet;

    public Arduino Arduino;

    void Awake(){
        Arduino = GetComponent<Arduino>();
    }
    
    void Update(){
        if (Arduino.port.ReadLine() == "LEFT")
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Arduino.port.ReadLine() == "RIGHT")
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (Arduino.port.ReadLine() == "FIRE")
        {
            Instantiate(bullet, transform.position , Quaternion.identity);
        }
    }
}
