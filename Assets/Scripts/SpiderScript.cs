using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderScript : MonoBehaviour {

    Animator anim;
    float speed = 5;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        transform.parent.transform.Rotate(new Vector3(0, Random.Range(0, 360), 0));
        StartCoroutine(ChangeDirection());
    }
	
	// Update is called once per frame
	void Update () {
        transform.parent.transform.Translate(-Vector3.forward * Time.deltaTime * 0.2f);
    }

    void OnMouseDown()
    {
        Destroy(transform.parent.gameObject);
        //anim.SetTrigger("Jump");
        //StartCoroutine(Scale(Random.Range(0.01f, 0.5f)));
        //transform.localScale = new Vector3 (rand, rand, rand);
        //transform.parent.transform.Rotate(new Vector3(0, Random.Range(0, 360), 0));
    }

    IEnumerator ChangeDirection()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            transform.parent.transform.Rotate(new Vector3(0, Random.Range(0, 360), 0));
        }
    }

    IEnumerator Scale(float rand)
    {
        while(transform.localScale != new Vector3(rand, rand, rand))
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, new Vector3(rand, rand, rand), Time.deltaTime);
            yield return null;
        }
    }
}
