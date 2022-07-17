using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D Rigidbody;

    public float speed = 15.0f;
    

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }
}
