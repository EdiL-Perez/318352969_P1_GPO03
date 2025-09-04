using UnityEngine;

public class ControlarBaile : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public bool baile=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            baile = !baile;
            anim.SetBool("ActivaBaile",true);
        }
    }
}
