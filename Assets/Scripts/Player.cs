using UnityEngine;

public class Player : MonoBehaviour
{
    public bool canMove;

    // Update is called once per frame
    void Update()
    {
        if (!canMove) return;
        if(Input.GetMouseButton(0))
        {
            Vector2 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (!GetComponent<CircleCollider2D>().OverlapPoint(mousPos))
                return;
            GetComponent<Rigidbody2D>().MovePosition(mousPos);
        }
        
        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Moved)
            {
                Vector2 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if (!GetComponent<CircleCollider2D>().OverlapPoint(mousPos))
                    return;
                GetComponent<Rigidbody2D>().MovePosition(mousPos);
            }
        }
    }
}
