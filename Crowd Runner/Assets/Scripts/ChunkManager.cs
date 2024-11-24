using UnityEngine;

public class ChunkManager : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] Chunk[] chunkPrefab;
    void Start()
    {
        Vector3 chunkPosition = new Vector3(0f,-0.5f,0f);
        for (int i = 0; i < 5; i++)
        {
            Chunk chunkToCreate = chunkPrefab[Random.Range(0, chunkPrefab.Length)];

            if (i > 0)
            {
                chunkPosition.z += chunkToCreate.GetLength() / 2;
            }


            Chunk chunkInstantiate = Instantiate(chunkToCreate, chunkPosition, Quaternion.identity, transform);

            chunkPosition.z += chunkInstantiate.GetLength() / 2;

        }
    }
}
