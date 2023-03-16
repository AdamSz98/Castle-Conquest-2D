using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterDoor : MonoBehaviour
{
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
    }
}
