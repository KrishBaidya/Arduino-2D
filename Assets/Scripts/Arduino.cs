using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Arduino : MonoBehaviour
{
    //Creates a SerialPort
    public SerialPort port;
    void Awake()
    {   
        //Listen on SerialPort "COM3" and Baud Rate 9600
        port = new SerialPort("COM3" , 9600);
        //Opens a serial port
        port.Open();
        //Set the read time to 0.1 seconds
        port.ReadTimeout = 100;
    }
}
