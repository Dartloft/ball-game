using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody rb;
    public float Force = 400f;

    public GameObject splitPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(rb.velocity.x, Force * Time.deltaTime, rb.velocity.z);

        GameObject newSplit = Instantiate(splitPrefab, new Vector3(transform.position.x, collision.transform.position.y + 0.19f, transform.position.z),
            transform.rotation);
        newSplit.transform.localScale = Vector3.one * Random.Range(0.8f,1.3f);
        newSplit.transform.parent = collision.transform;

        string materialname = collision.transform.GetComponent<MeshRenderer>().material.name;

        if(materialname == "centro (Instance)")
        {
            Manager.levelWin = true;
        }
        if (materialname == "unsafe (Instance)")
        {
            Manager.gameOver = true;
        }
        
    }
}
