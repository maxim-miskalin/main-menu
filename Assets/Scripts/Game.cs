using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Transform _menu;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && !_menu.gameObject.activeSelf)
        {
            _menu.gameObject.SetActive(true);
        }
    }

    public void CloseMenu()
    {
        _menu.gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("Выход из игры...");
        Application.Quit();
    }
}
