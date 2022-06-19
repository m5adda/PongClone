using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Ball : MonoBehaviour
{
    public GameObject scorerightText;
    public GameObject scoreleftText;
    int scoreRight;
    int scoreLeft;
    public float speed = 30;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        
    }
    float hitFactor (Vector2 ballPos,Vector2 racketPos,float racketHeight)
    {
        // || 1 <- at the top of the racket
        // ||
        // || 0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket 
        return (ballPos.y - racketPos.y) / racketHeight; 
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Wallright")
        {
            //this line will just add 1 point to the score
            scoreRight++;
            scorerightText.GetComponent<TextMeshProUGUI>().text = scoreRight.ToString();
        }
        if (col.gameObject.name == "Wallleft")
        {
            scoreLeft++;
            scoreleftText.GetComponent<TextMeshProUGUI>().text = scoreLeft.ToString();
        }
        {
            // Note: 'col' holds the collision information. If the
            // Ball collided with a racket, then:
            //   col.gameObject is the racket
            //   col.transform.position is the racket's position
            //   col.collider is the racket's collider

            // Hit the left Racket?
            if (col.gameObject.name == "RacketLeft")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // Hit the right Racket?
        if (col.gameObject.name == "RacketRight")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;


            }
        }
    }
}
