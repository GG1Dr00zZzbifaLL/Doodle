using UnityEngine;
public class Tucha : Platform
{
    public new void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Destroy(gameObject, 0.1f);
        }
    }
    public new void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "Dead2")
        {
            float RandX = Random.Range(-4f, 4f);
            float RandY = Random.Range(transform.position.y + 10f, transform.position.y + 20f);
            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
