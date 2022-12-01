using UnityEngine;
public class Batoot : Platform
{
    public new void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "Dead2")
        {
            float RandX = Random.Range(-4f, 4f);
            float RandY = Random.Range(transform.position.y + 60f, transform.position.y + 80f);
            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
