using UnityEditor.ShaderGraph.Drawing.Inspector.PropertyDrawers;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float slideSpeed;


    private Vector3 clickScreePostion;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }

    private void MoveForward()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickScreePostion = Input.mousePosition;
        }
    }

    //private void
}
