using UnityEngine;
public class collect : MonoBehaviour
{

    private bool hasCollided = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!hasCollided)
        {
            hasCollided = true;
            Destroy(gameObject);
            score.scoreAmount += 1;
        }
    }
}
