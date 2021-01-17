using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemySpaceship : MonoBehaviour
{
    // define a variable that store the speed of an asteroid.
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-1 * Time.deltaTime * speed,0);
        if (transform.position.y < -6)
        {
            // destroy the object
            Destroy(gameObject);
        }
    }
}
