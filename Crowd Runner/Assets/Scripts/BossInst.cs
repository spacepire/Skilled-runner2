using UnityEngine;

public class BossInst : MonoBehaviour
{
    [SerializeField] GameObject bossArea;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {
            Debug.Log("Çalışıyor");
            Instantiate(bossArea, new Vector3(0f,0f,0f + transform.position.z + 50), Quaternion.identity);
        }
    }

}
