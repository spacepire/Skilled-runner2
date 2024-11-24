using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Settings")]
    [SerializeField] float speed;
    [SerializeField] float slideSpeed;

    //float roadWidth = 10;

    [Header("Elements")]

    private Vector3 clickedScreenPosition;
    private Vector3 clickedPlayerPosition;
    void Update()
    {
        MoveForward();
        ManageControl();
    }

    private void MoveForward()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }

    private void ManageControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickedScreenPosition = Input.mousePosition;
            clickedPlayerPosition = transform.position;
        }
        else if (Input.GetMouseButton(0))
        {
            float xScreenDifference = Input.mousePosition.x - clickedScreenPosition.x;

            xScreenDifference /= Screen.width;
            xScreenDifference *= slideSpeed;

            Vector3 position = transform.position;
            position.x = clickedPlayerPosition.x + xScreenDifference;
            transform.position = position;

            //transform.position = clickedPlayerPosition + Vector3.right * xScreenDifference;

        }
    }
}
