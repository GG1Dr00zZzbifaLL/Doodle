using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public float horizontal;
    public Rigidbody2D VRigid;
    public static PlayerController instance;
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void FixedUpdate()
    {
        
           if(transform.position.x <= -5f)
            {
                transform.position = new Vector3(4.9f, transform.position.y, transform.position.z);
            }
           if (transform.position.x >= 5f)
            {
                transform.position = new Vector3(-5.1f, transform.position.y, transform.position.z);
            }
        
            transform.position += new Vector3(0.5f, 0, 0) * Input.GetAxis("Horizontal");
       if(Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }

       if(Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

       else if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        VRigid.velocity = new Vector2(Input.acceleration.x * 10f, VRigid.velocity.y);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Dead")
        {
            SceneManager.LoadScene(0);
        }
        else if (collision.collider.name == "Enemy")
        {
            SceneManager.LoadScene(0);
        }
        else if(collision.collider.name == "EnemyX")
        {
            SceneManager.LoadScene(0);
        }
    }
}
