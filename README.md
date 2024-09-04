# Unity Menu with Tabs UI

This project demonstrates a simple implementation of a menu and tab controller system in Unity, allowing for easy toggling of menu visibility and tab switching within the menu.

## Features

- **MenuController**: Controls the visibility of a menu using the Tab key.
- **TabController**: Manages tab selection and displays corresponding pages while updating the tab colors.

## Scripts

### MenuController.cs

This script handles the toggling of the menu canvas when the Tab key is pressed.

```csharp
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject menuCanvas;

    private void Start()
    {
        // Hide the menu canvas at the start
        menuCanvas.SetActive(false);
    }

    private void Update()
    {
        // Toggle the menu canvas visibility when the Tab key is pressed
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            menuCanvas.SetActive(!menuCanvas.activeSelf);
        }
    }
}
```

### TabController.cs

This script manages the tabs within the menu, allowing users to switch between different pages by clicking on the tabs. It updates the visual representation of the tabs and the associated pages.

```csharp
using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    [SerializeField] private Image[] tabImages;
    [SerializeField] private GameObject[] pages;

    private void Start()
    {
        // Activate the first tab on start
        ActivateTab(0);
    }

    public void ActivateTab(int tabIndex)
    {
        // Deactivate all pages and reset tab colors
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
            tabImages[i].color = Color.grey;
        }
        // Activate the selected tab and page
        pages[tabIndex].SetActive(true);
        tabImages[tabIndex].color = Color.white;
    }
}
```
