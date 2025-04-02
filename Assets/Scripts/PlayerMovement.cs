using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    private Animator animator;
    private bool isFacingRight = true;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical"); // Allow vertical movement
        Vector2 movement = new Vector2(moveX, moveY).normalized; // Normalize diagonal movement
        transform.Translate(movement * speed * Time.deltaTime);

        if (movement.magnitude > 0)
        {
            animator.SetTrigger("isRunning"); // Set the trigger
        }

        if (moveX > 0 && !isFacingRight) Flip();
        else if (moveX < 0 && isFacingRight) Flip();
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
