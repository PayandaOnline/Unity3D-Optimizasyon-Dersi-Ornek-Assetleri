using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public void SahneDegistir(string sahneAdi)
    {
        SceneManager.LoadScene(sahneAdi);
    }
}
