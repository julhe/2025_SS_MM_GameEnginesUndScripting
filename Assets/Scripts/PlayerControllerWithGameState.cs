using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerControllerWithGameState : MonoBehaviour
{
    CharacterController characterController;
    public Animator animator;


    int jumpPotions = 0;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (GameStateManager.Instance.gameState == GameState.InExploreMode)
        {
            movement.x = Input.GetAxis("Horizontal");
            movement.z = Input.GetAxis("Vertical");

            if(Input.GetKeyDown(KeyCode.Space))
            {
               
                if(jumpPotions > 0)
                {
                    // Führe springen aus.
                    animator.SetTrigger("Jump");
                    // Reduziere JumpPotions um 1
                    jumpPotions -= 1;
                }
            }
        }

        characterController.SimpleMove(movement * 10.0f);
        animator.SetFloat("MovementSpeed", characterController.velocity.magnitude);
    }

    public void ReceiveJumpPotion()
    {
        jumpPotions += 1;
    }
}
