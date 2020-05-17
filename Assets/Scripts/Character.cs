using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    [SerializeField] private int playerSpeed;

    private Rigidbody2D rBody;
    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    private void PlayerMovement()
    {
        var moveInput = Input.GetAxis("Horizontal");
        rBody.velocity = new Vector2(moveInput * playerSpeed * Time.fixedDeltaTime, rBody.velocity.y);
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rBody.velocity = Vector2.up * 5f;
        }
        
        PlayerMovement();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.name == "barrel(Clone)")
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
    }
}
