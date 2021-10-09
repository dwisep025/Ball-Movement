using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // Besarnya gaya awal yang diberikan untuk mendorong bola
    public float xInitialForce;
    public float yInitialForce;

    [Header("Movement")]
    public float moveAccel;
    public float maxSpeed;
    private Rigidbody2D rig;
  
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 velocityVector = rig.velocity;
        velocityVector.x = Mathf.Clamp(velocityVector.x + moveAccel * Time.deltaTime, 0.0f, maxSpeed);

        rig.velocity = velocityVector;
    }

   
    void PushBall()
    {
        // Tentukan nilai komponen y dari gaya dorong antara -yInitialForce dan yInitialForce
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

        // Tentukan nilai acak antara 0 (inklusif) dan 2 (eksklusif)
        float randomDirection = Random.Range(0, 2);

        // Jika nilainya di bawah 1, bola bergerak ke kiri. 
        // Jika tidak, bola bergerak ke kanan.
        if (randomDirection < 1.0f)
        {
            // Gunakan gaya untuk menggerakkan bola ini.
            rig.AddForce(new Vector2(-xInitialForce, yRandomInitialForce));
        }
        else
        {
            rig.AddForce(new Vector2(xInitialForce, yRandomInitialForce));
        }
    }
}
