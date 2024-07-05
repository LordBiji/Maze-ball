using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class MazeController : MonoBehaviour
{
    [SerializeField] private Transform frameTrans;
    public float direction = 0; //kita declare dulu directionnya
    public float rotationSpeed = 50; //declare rotation speed
    void Start()
    {
        Debug.Log("nihj");
        Debug.Log("hello");
    }

    private void Update() //manggillnya setiap update bakal rotasi tapi secara default 0
    {
        Debug.Log(direction);
        frameTrans.Rotate(0, 0, direction * rotationSpeed * Time.deltaTime);
    }

    public void rotateLeft() //ngubah direction rotation nya jadi 1
    {
        direction = 1;
    }

    public void rotateRight()  //sama aja tapi -1
    {
        direction = -1;
    }

    public void resetRotation() //ngasih tau kalo directionya 0 kalo ga ditahan
    {
        Debug.Log("no rotation");
        direction = 0;
    }
}
