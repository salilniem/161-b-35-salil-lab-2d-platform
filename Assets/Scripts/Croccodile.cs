using UnityEngine;

public class Croccodile : Enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(100);

    }
    public override void Behavior()
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
