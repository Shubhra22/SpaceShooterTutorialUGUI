
using UnityEngine;

public class Test : MonoBehaviour
{
    //What?
    // name - SStart
    // argument - no
    // body - everything inside {}
    // return - what is the value of the mathod
    // 1. void 2. any data type (float, int, bool , class etc)
    
    
    // Why??
    // to break codes into more readable section.
    // make code Modular
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // what is the return type of this method?
    // void ??
    // called when collided with something.
    private void OnCollisionEnter2D(Collision2D other)
    {
        
    }

    // is this a method?
    
    // method

//    returntype Name()
//    {
//        
//    }

    //UpdateHealth();
    
    // name? 
    // retun
    // arg? 
    // body?
    
    // what is this argument? -- 
    public int UpdateHealth(int val)
    {
        val = val - 1;
        return val;
    }
    
    // 
    // type - (number(int, float), names(string), objects(GameObject, Classes, etc), boolean (true falsse))
    // name
    //  either initalize/ not
    
    // declare a variable what can store the health of the player???
    
    // When I get hit take some damage.

    public int health;
    public int damage;
    // loose health(number).
    // 




}
