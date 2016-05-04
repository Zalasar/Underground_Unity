using UnityEngine;
using System.Collections;

public class BossAI : MonoBehaviour {

    Transform target;
	// Use this for initialization
	void Awake () 
    {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {
        Vector2 direction = new Vector2(target.localPosition.x - transform.localPosition.x, target.localPosition.y - transform.localPosition.y);
        if (direction.sqrMagnitude < 2)
        {
            
        }
	}
}
