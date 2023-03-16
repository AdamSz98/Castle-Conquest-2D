using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterDoor : MonoBehaviour
{
    [SerializeField] AudioClip openingDoorSFX, closingDoorSFX;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetBool("Open", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseDoor()
    {
        GetComponent<Animator>().SetBool("Open", false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<Animator>().SetBool("Open", false);
        AudioSource.PlayClipAtPoint(closingDoorSFX, Camera.main.transform.position);
    }

    private void PlayOpeningDoorSFX()
    {
        AudioSource.PlayClipAtPoint(openingDoorSFX, Camera.main.transform.position);
    }
}
