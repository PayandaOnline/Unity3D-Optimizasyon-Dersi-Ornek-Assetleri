using UnityEngine;
using UnityEngine.UI;
public class FrameRate : MonoBehaviour
{

    private static FrameRate _FpsOlcer = null;
    int avgFrameRate;
    public Text display_Text;
    public bool freezeFrameRate = true;
    // Use this for initialization
    void Awake()
    {
        if(freezeFrameRate)
        {
            Application.targetFrameRate = 60;
        }
    }
    public void Update()
    {
            float current = 0;
            current = (int)(1f / Time.unscaledDeltaTime);
            avgFrameRate = (int)current;
            display_Text.text = avgFrameRate.ToString() + " FPS";
    }
}
