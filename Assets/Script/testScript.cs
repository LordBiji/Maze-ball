using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    [SerializeField] private GameObject objek;
    private void Awake()
    {
        Debug.Log("awake");
    }

    private void OnEnable()
    {
        Debug.Log("onEnabel");
    }

    void Start()
    {
        Debug.Log("start");
        Debug.Log("nama" + objek.name);
        Debug.Log("tag" + objek.tag);
      
    }


    void Update()
    {
        Debug.Log("update");
    }

    private void LateUpdate()
    {
        Debug.Log("lateUpdate");
    }

    private void OnDisable()

    {
        Debug.Log("onDisabel");
    }

    private void OnDestroy ( ) 
    {
        Debug.Log("ondestroy");
    }

    private void OnApplicationQuit()
    {
        Debug.Log("on aplication quit");
    }

}
