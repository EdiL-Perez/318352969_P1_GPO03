using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class MovBala : MonoBehaviour
{
    [SerializeField] private Transform posicionbala;
    //[SerializeField] private TMP_Text txtEnemy;
    //public int numEnemy = 0;
    Rigidbody rbb;
    public float fuerza =100.0f;
    public ControladorCubo character;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbb=GetComponent<Rigidbody>();
        posicionbala=GameObject.Find("Cube").transform;
        //txtEnemy.text = "Enemy" + numEnemy;
        rbb.AddForce(posicionbala.forward*fuerza, ForceMode.Impulse);
        character = GameObject.Find("Cube").GetComponent<ControladorCubo>();

        Destroy(this.gameObject, 1.0f);

        /*
        private void OnCollisionEnter(Collision collision){
            if(collision.transform.tag == "Enemy"){
                Destroy(Collision.gameObject);
                if(character.numEnemy > 0){
                    character.numEnemy--;
                }

            }
        }
        */



        
    }

    // Update is called once per frame
}
