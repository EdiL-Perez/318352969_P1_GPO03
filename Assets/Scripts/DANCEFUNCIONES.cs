using UnityEngine;

public class DANCEFUNCIONES : MonoBehaviour
{
    [SerializeField] private Animator[] animators;
    [SerializeField] private AudioClip[] Audios;
    [SerializeField] private AudioSource AudioSource;
    [SerializeField] private GameObject[] character;
    int indexCharacter= 0;
    bool ActivaBaile = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*if(Input.GetKeyDown(KeyCode.O))
        {
            ActivaBaile= false;
            animators[indexCharacter].SetBool("Baila",ActivaBaile);
                AudioSource.Stop();
        
        }
        */
 


        /*public void changecharacter(){

            if(indexCharacter < character.Length-1)
                indexCharacter++;
                else
                    indexCharacter = 0;


            for(int i= 0; i < character.Length; i++){
                character[i].SetActive(false);
                AudioSource.Stop();
                
            }
            character[indexCharacter].SetActive(true);
            animators[indexCharacter].SetBool("Baila",ActivaBaile);
            if(ActivaBaile == true){
                AudioSource.clip=Audios[indexCharacter];
                AudioSource.Play();
            }
            else{
                AudioSource.Stop();
            }

            
        }

        //public void ActivaBaile(){

            //ActivaBaile = true;
            //animators[indexCharacter].SetBool("Baila",ActivaBaile);
            //AudioSource.clip=Audios[indexCharacter];
            //if(!AudioSource.isPlaying){
            //    AudioSource.Play();
            //}

        //}
        */




    }
}
