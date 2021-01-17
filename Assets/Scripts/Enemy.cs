using UnityEngine;


public class Enemy : MonoBehaviour
{
    // declare a variable to store health.
    // 1. public/private
    // 2. type = what kind of variable is this. 
    // ------- float(decimal number = 1.2,3.5 etc) e.g. float i = 1.4f
    //-------- int (non decimal) e.g int k = 2
    //-------- bool (true or false)e.g bool i = true
    //-------- string (characters, words etc) string type = "Wolf"
    // 3. a name (e.g. health)

    public float health = 5;

    // declare a variable to hold the name of the enemy
    public string enemyName;

    // declare a variable to hold the damage done by the enemy,
    public float damage;

    // variable that say if the enemy can shoot or not. 
    public bool canShoot;

    void LateUpdate()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Player p = other.gameObject.GetComponent<Player>();

        // destroy the 

        if (p != null)
        {
            Destroy(this.gameObject);
            // take away health from the enemy.
            p.Health = p.Health - 1;
        }
    }
}