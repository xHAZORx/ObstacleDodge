using UnityEngine;

public class Mover : MonoBehaviour
{
[SerializeField] float moveSpeed = 10f;
    
    void Start()
    {
        PrintInstructions();
        
    }

    
    void Update()
    {
        MovePlayer();
        
    }

    void PrintInstructions()
    {
        Debug.Log(" Welcome to the game! Use the arrow keys or WASD to move the player around.");
        Debug.Log(" Avoid obstacles and explore the environment!");
        Debug.Log(" Good luck and have fun!");
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
