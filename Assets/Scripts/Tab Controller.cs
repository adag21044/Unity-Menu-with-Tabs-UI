using UnityEngine.UI;
using UnityEngine;

public class TabController : MonoBehaviour
{
    [SerializeField] private Image[] tabImages;
    [SerializeField] private GameObject[] pages;

    private void Start()
    {
        ActivateTab(0);
    }

    public void ActivateTab(int tabs)
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
            tabImages[i].color = Color.grey;
        }
        pages[tabs].SetActive(true);
        tabImages[tabs].color = Color.white;
    }
}
