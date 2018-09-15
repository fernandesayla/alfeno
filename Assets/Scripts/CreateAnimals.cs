using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAnimals : MonoBehaviour {

    [SerializeField]
    public Transform target;
    public GameObject animal;

    float originalY;
    public float limitBottom, limitLeft, limitRight, time,  floatStrength = 1;

	// Use this for initialization
	void Start () {
        StartCoroutine(Create(time));
		
	}
 



    IEnumerator Create(float t){
        Vector3 p = new Vector3(Random.Range(limitLeft, limitRight), limitBottom, 0.0f);

        Instantiate(animal, p, animal.transform.rotation);

        print(this.target.tag);


        animal.GetComponent<Seguir>().SetTarget(this.target);

        yield return new WaitForSeconds(t);

        StartCoroutine(Create(time));

 


        
    }
}
