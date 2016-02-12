using UnityEngine;
using System.Collections;

public class GObject : MonoBehaviour {

    public int life = 3;
    public float speed;

    protected Vector3 direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public virtual void Update () {
        transform.position += direction * speed * Time.deltaTime;
	}
}
