using UnityEngine;

public class BuildMode : MonoBehaviour
{
    public GameObject ButtonsFolder;
    public GameObject Grid;

    public void OnClick()
    {
        if (ButtonsFolder.active == false)
        {
            ButtonsFolder.SetActive(true);

            Grid.SetActive(true);
        }
        else
        {
            ButtonsFolder.SetActive(false);

            Grid.SetActive(false);

        }
    }
}
