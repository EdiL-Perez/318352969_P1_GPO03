using UnityEngine;

public class ControlerCharacter : MonoBehaviour
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
        maX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");

        transform.Translate(maX*speed*Time.deltaTime,0,movY*speed*Time.deltaTime);
        
    }

    private void FixedUpdate(){
        if(Input.GetKeyDown(KeyCode.Space))
        rb.AddForce(Vector3.up*force,ForceMode.Acceleration);

    } 

    void OnTriggerEnter(Collider col){
        print(col.transform.name);
        col.transform.GetComponent<Light>().enabled=true;

    }
    private void OnTriggerExit(Collider col){
        col.transform.GetComponent<Light>().enabled=false;
    }
}
