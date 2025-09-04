using UnityEngine;

public class Rebote : MonoBehaviour
{
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("activaAnim", true);   // Activa la animación
        }
        else
        {
            animator.SetBool("activaAnim", false);  // Vuelve al estado base
        }
        
    }
}
