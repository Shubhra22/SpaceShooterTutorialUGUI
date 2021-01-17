using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;
public class Player : MonoBehaviour
{
    // Declare a variable.
    // name should be speed
    // type is float
    public float speed = 10;
    
    
    public Text scoreText;
    public int score = 0;

    public GameObject bullet;

    private int health = 5;
    public UIManager manager;

    public int Health 
    {
        get { return health; }
        set
        {
            health = value;
            manager.UpdateHealth(health);
        }
    }
    
    // declare a variable with name movement;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<UIManager>();
        manager.UpdateHealth(health);
    }


    // Update is called once per frame
    void Update()
    {
        //Variables : store stuff in here.
        // like a cup or a storage.

        // int (non decimal number) ,
        // float (decimal number)
        // boolean (true or false) a>10
        // Vector2 (set of 2 number that give us some point + direction) 
        
        float x = Input.GetAxis("Horizontal"); // need something that goes [-1,1]
        float y = Input.GetAxis("Vertical"); //need something that goes [-1,1]h
        transform.Translate(x * Time.deltaTime * speed ,y * Time.deltaTime * speed,0);
        
        // wrte a code to store the input for space key.
        bool shoot = Input.GetKeyDown("space");//Input.GetAxis("Jump");
        if (shoot)
        {
            // sspawn 
            Instantiate(bullet, transform.position + new Vector3(0,2,0), Quaternion.identity);
        }


    }

    private void LateUpdate()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    
}
