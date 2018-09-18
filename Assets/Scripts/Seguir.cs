using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float velo = 1;


    // Use this for initialization
   

    // Update is called once per frame
    void Update()
    {
        var journey = target.position - this.transform.position;
        journey = journey.normalized;
        Debug.Log("Journey: " + journey);
        journey *= this.velo;
        this.transform.position += journey * Time.deltaTime;
    }

    public void SetTarget(Transform t)
    {

        this.target = t;

        Debug.Log(t.tag);
    }
}
