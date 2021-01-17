using UnityEngine;

public class Bullet : MonoBehaviour
{
    // stores a float 
    public float speed = 10;
    
    //Create a varible that store a UIManager;
    public UIManager manager;
    
     
    // Start is called before the first frame update
    void Start()
    {
        
       // Here we are just trying to initialize the manager variable.
       // We are basically trying to find UIManager from all our gameobjects in the game
        // and store that to our manager variable
        manager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-1 * Time.deltaTime * speed,0);
       
        // write the code here....
        if (transform.position.y > 6)
        {
            // destroy the object
            Destroy(gameObject);
        }
    }
    
    // call back method. its automatically gets triggered 
    // when this object(bullet) hits any other game object.
    // 'other' is the thing got hit by this object

    void OnCollisionEnter2D(Collision2D other)
    {
        Enemy e = other.gameObject.GetComponent<Enemy>();
        
        // destroy the 
        Destroy(this.gameObject);
        if (e != null)
        {
            // take away health from the enemy.
            e.health = e.health - 1;
            
            manager.UpdateScore(1);
        }
    }
}
