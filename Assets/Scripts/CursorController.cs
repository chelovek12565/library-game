using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Camera mainCamera;
    public Texture2D customCursor;
    private CursorControls cursorControls;

    private void Start()
    {
        cursorControls.Mouse.Click.started += _ => StartedClick();
        cursorControls.Mouse.Click.performed += _ => EndedClick();
    }

    private void StartedClick()
    {

    }

    private void EndedClick()
    {
        DetectObject();
    }

    void Awake()
    {
        cursorControls = new CursorControls();
        Cursor.SetCursor(customCursor, Vector2.zero, CursorMode.ForceSoftware);
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void OnEnable()
    {
        cursorControls.Enable();
    }

    private void OnDisable()
    {
        cursorControls.Disable();
    }

    public void DetectObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(cursorControls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            InteractableItem item = hit.transform.GetComponent<InteractableItem>();

            if (item)
            {
                item.OnInteract();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
