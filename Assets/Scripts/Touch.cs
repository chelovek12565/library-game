using UnityEngine;

public class Touch : MonoBehaviour
{
    public float range = 5f;
    public Camera camera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Use"))
        {
            Interact();
        }
    }

    void Interact()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {
            InteractableItem item = hit.transform.GetComponent<InteractableItem>();

            if (item)
            {
                item.OnInteract();
            }
        }
    }
}
