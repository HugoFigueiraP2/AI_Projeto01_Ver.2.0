using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAgents : MonoBehaviour
{
    [SerializeField] private GameObject go;
    private GameObject target;
    //public bool Explosion;

    private void Start()
    {
        target = Instantiate(go);
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(GameObject.FindGameObjectWithTag("AI_Agent"));
        //Explosion = true;
    }
}
