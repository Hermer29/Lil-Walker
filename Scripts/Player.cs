using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    public float moveSpeed = 0.2f;
    private int score = 0;
    
    private Rigidbody playersBody;

    private void Start() 
    {
        playersBody = GetComponent<Rigidbody>();    
    }

    public void Move(float x, float y)
    {
        playersBody.transform.position += new Vector3(x, 0, y) * moveSpeed;
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
    }

    public void ClearScore()
    {
        score = default;
    }
}
