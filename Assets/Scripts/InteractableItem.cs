using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    public GameObject thatObject;
    public GameObject copyObject;
    public ParticleSystem particle;
    public GameObject light;
    public Material targetMaterial;
    public GameObject brain;

    public void OnInteract()
    {
        thatObject.SetActive(false);
        //copyObject.SetActive(true);
        particle.Play();
        light.SetActive(true);
        light.GetComponent<MovingLight>().GetItMoving();

        MeshRenderer copyRenderer = copyObject.GetComponent<MeshRenderer>();
        copyRenderer.material = targetMaterial;

        brain.GetComponent<RoomsBrain>().ItemFound();
    }
}
