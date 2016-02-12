using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Orc : GObject {

    public List<GameObject> path = new List<GameObject>();

    private int target = 0;
    private Vector3 moveToDirection;

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT");
        if (other.tag=="trigger")
        {
            if (target <path.Count-1)
            {
                target++; 
            }
            else
            {
                target = 0;
            }
              
        }
    }
	
	// Update is called once per frame
    public override void Update()
    {
        moveToDirection = path[target].transform.position - transform.position;
        moveToDirection.Normalize();

        if (moveToDirection.x < direction.x && direction.x > -1)
        {
            direction.x -= 0.01f * speed;
        }

        if (moveToDirection.x > direction.x && direction.x < 1)
        {
            direction.x += 0.01f * speed;
        }

        if (moveToDirection.z < direction.z && direction.z > -1)
        {
            direction.z -= 0.01f * speed;
        }

        if (moveToDirection.z > direction.z && direction.z < 1)
        {
            direction.z += 0.01f * speed;
        }

        base.Update();
    }
}
