using UnityEngine;

public class CharacterControllerForce : MonoBehaviour
{

    float maX;
    float movY;
    [SerializeField] private float speed;
    [SerializeField] private float force;
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //maX = Input.GetAxis("Horizontal");
        //movY = Input.GetAxis("Vertical");


        
    }


    private void FixedUpdate(){


        maX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(maX,0f,movY);
        rb.linearVelocity = new Vector3(movimiento.x,0.0f,movimiento.z)*speed; 



        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*force,ForceMode.Acceleration);
        }
    } 



      void OnTriggerEnter(Collider col){
        print(col.transform.name);
        col.transform.GetComponent<Light>().enabled=true;

    }
    private void OnTriggerExit(Collider col){
        col.transform.GetComponent<Light>().enabled=false;
    }
    
}
