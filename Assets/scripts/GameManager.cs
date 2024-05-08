using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Transform player;
    public GameObject[] rings;

    public int numrings;
    public float ringDistance = 5f;
    float yPos;

    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        numrings = Manager.CurrentLevelIndex + 5;
      
        for (int i = 0; i < numrings; i++)
        {
            
            if (i == 0)
            {
                SpawnRings(0);
            }
            else
            {
                SpawnRings(Random.Range(1, rings.Length -1));
            }
        }
        SpawnRings(rings.Length - 1);


    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.y > player.position.y + 0.1f)
        {
            Manager.PassingRings++;
        }
    }

    void SpawnRings(int index)
    {
        
        GameObject newRing = Instantiate(rings[index], new Vector3(transform.position.x, yPos, transform.position.z), Quaternion.identity);
        yPos -= ringDistance;
        newRing.transform.parent = transform;
    }
}
