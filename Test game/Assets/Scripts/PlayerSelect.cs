using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour
{
    public GameObject[] characters;
    private int index = 0;

    private void Start()
    {
        characters = new GameObject[transform.childCount];

        for (int j = 0; j < transform.childCount; j++)
        {
            characters[j] = transform.GetChild(j).gameObject;
        }

        foreach (GameObject go in characters)
        {
            go.SetActive(false);
        }

        if (characters[0])
        {
            characters[0].SetActive(true);
        }
    }

    public void SetLeft()
    {
        characters[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = characters.Length - 1;
        }
        characters[index].SetActive(true);
    }

    public void SetRight()
    {
        characters[index].SetActive(false);
        index++;
        if (index == characters.Length)
        {
            index = 0;
        }
        characters[index].SetActive(true);
    }

    public void StartScene()
    {
        PlayerPrefs.SetInt("SelectPlayer", index);
        SceneManager.LoadScene("Level1");
    }
}