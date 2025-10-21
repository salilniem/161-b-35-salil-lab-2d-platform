using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //Attributes
    private int health;
    public int Health
    {
        get { return health; }
        set { health = (value < 0) ? 0 : value; }
    }
    protected Animator anim;
    protected Rigidbody2D rb;

    public void Initialize(int startHealth)
    {
        Health = startHealth;
        Debug.Log($"{this.name} is initialize Health: {this.health}");
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage} Current Health is {Health}");

        IsDead();
    }

    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else
        {
            return false;
        }
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
