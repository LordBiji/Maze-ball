using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject objek;
    Vector3 spawnposition = new Vector3(-3, 3, 0); //jangan lupa nambahin f diakhir buat float
    Quaternion spawnrotation = Quaternion.Euler(0,0,0);
    //Quaternion spawnrotation = new Quaternion(0,0,0,0); bisa juga pake yg ini
   
    void Start()
    {
        Instantiate(objek, spawnposition, spawnrotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
