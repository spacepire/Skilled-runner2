using TMPro;
using UnityEngine;

public class CrowdCounter : MonoBehaviour
{
    [SerializeField] TMP_Text crowdCounterText;
    [SerializeField] Transform runnerParent;

    void Update()
    {

        crowdCounterText.text = runnerParent.childCount.ToString();
    }
}
