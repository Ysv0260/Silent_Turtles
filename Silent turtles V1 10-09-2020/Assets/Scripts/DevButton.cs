using UnityEngine;
using UnityEngine.UI;

public class DevButton : MonoBehaviour
{

    public Button BackM;
    public Button BackD;
    public Button ResetSteps;
    public bool visablity;

    // Start is called before the first frame update
    void Start()
    {
        visablity = false;
        Debug.Log("visability of buttons are " + visablity);
    }

    // Update is called once per frame

    private void Update()
    {
        BackM.gameObject.SetActive(visablity);
        BackD.gameObject.SetActive(visablity);
        ResetSteps.gameObject.SetActive(visablity);
    }

    public void DevClick()
    {
        visablity = true;
        Debug.Log("visability of buttons are " + visablity);
    }
}
