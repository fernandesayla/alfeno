using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAnimals : MonoBehaviour {

    public GameObject animal;

    public float limitBottom, limitLeft, limitRight, time;

	// Use this for initialization
	void Start () {
        StartCoroutine(Create(time));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Create(float t){
        Vector3 p = new Vector3(Random.Range(limitLeft, limitRight), limitBottom, 0.0f);

        Instantiate(animal, p, animal.transform.rotation);

        yield return new WaitForSeconds(t);

        StartCoroutine(Create(time));
        
    }
}
