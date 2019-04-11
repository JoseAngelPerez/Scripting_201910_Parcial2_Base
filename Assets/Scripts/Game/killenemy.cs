using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killenemy : MonoBehaviour
{
    [SerializeField] GameObject pool;
    [SerializeField] GameObject pooler;

    private void Start()
    {
        pool= GameObject.FindGameObjectWithTag("pool");
        pooler = GameObject.FindGameObjectWithTag("pooler");
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag ==("player"))
        {
            transform.position = pool.transform.position;
            pooler.GetComponent<Pooler>().restantes= pooler.GetComponent<Pooler>().restantes-1;
        }
    }
}
