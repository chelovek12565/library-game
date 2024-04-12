using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsBrain : MonoBehaviour
{

    int itemsFounded = 0;
    public int itemsInRoom = 5;
    public GameObject door;
    public ParticleSystem particle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ItemFound()
    {
        itemsFounded += 1;
        if (itemsFounded == itemsInRoom)
        {
            EndRoom();
        }
    }

    public void EndRoom()
    {
        door.SetActive(false);
        particle.Play();
    }
}
