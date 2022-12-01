using UnityEngine;
public class Enemy : MonoBehaviour
{
    public float speed;
    public void FixedUpdate()
    {
        transform.position += new Vector3(speed, 0, 0);
        if (transform.position.x <= -5f)
        {
            transform.position = new Vector3(4.9f, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= 5f)
        {
            transform.position = new Vector3(-5.1f, transform.position.y, transform.position.z);
        }
        transform.position += new Vector3(speed, 0, 0);
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "Dead2")
        {
            float RandX = Random.Range(-4f, 4f);
            float RandY = Random.Range(transform.position.y + 30f, transform.position.y + 65f);
            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}