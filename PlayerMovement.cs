using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public bool alive = true;
    public bool isGameStarted = false;
    public float speed = 5;
    public Rigidbody rb;
    public float horizontalSpeed = 2;

    float horizontalInput;

    public UI_Manager Uİmanager;
    public AudioManager audioManager;

    public void FixedUpdate()
    {
        if (isGameStarted == true)
        {

            Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
            Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalSpeed;
            rb.MovePosition(rb.position + forwardMove + horizontalMove);
        }

    }

    public void Start()
    {
      
    }



    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            StartGame();
        }


        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -3)
        {
            Die();
        }

       
    }
    public void StartGame()
    {
        isGameStarted = true;
        Uİmanager.GameStarted();
        
    }
       
public void Die()
    {              
            alive = false;
            audioManager.dieSound.Play();
            Debug.Log("died");
            Invoke("Restart", 0.2f);         
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
