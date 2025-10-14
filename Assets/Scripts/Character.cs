using UnityEngine;

public class Character : MonoBehaviour
{
    //Attributes
    private int health;
    public int Health
    {
        get { return health; }
        set { health = (value < 0) ? 0 : value; }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
