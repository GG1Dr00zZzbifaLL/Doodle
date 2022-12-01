using UnityEngine;
public class Platform : MonoBehaviour
{
    public float forceJump;
    //public Animator animator; 
    private PlayerController pl;
    private Rigidbody2D rb;
    private void Start()
    {
        pl = FindObjectOfType<PlayerController>();
        rb = pl.GetComponent<Rigidbody2D>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            PlayerController.instance.VRigid.velocity = Vector2.up * forceJump;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.name == "Dead")
        {
            float RandX = Random.Range(-4f, 4f);
            float RandY = Random.Range(transform.position.y + 8f, transform.position.y + 12f);
            transform.position = new Vector3(RandX, RandY, 0);
            //animator.SetTrigger("isTrigger");
        }
    }
}
