using UnityEngine;

public class GrannyController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private float speed;
    void Update()
    {
        Vector2 movement = Vector2.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
            movement = Vector2.left * speed;
        else if (Input.GetKey(KeyCode.RightArrow))
            movement = Vector2.right * speed;

        movement *= Time.deltaTime;
        animator.SetFloat("velocity", movement.magnitude);
        animator.SetInteger("dir", (int)Vector2.Dot(movement.normalized, Vector2.right));
        transform.position += new Vector3(movement.x, movement.y, 0);
    }
}
