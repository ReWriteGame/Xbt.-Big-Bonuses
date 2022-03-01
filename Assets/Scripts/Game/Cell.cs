using UnityEngine;
using UnityEngine.Events;

public class Cell : MonoBehaviour
{
    [SerializeField] private GameObject open;
    [SerializeField] private GameObject close;
    [SerializeField] private GameObject select;
    
    public UnityEvent openEvent;
    public UnityEvent closeEvent;


    private bool selected = false;
    private bool isOpen = false;
    void Start()
    {
        open.SetActive(false);
        close.SetActive(true);
        select.SetActive(false);
    }


    public void Open()
    {
        if (!isOpen)
        {
            openEvent?.Invoke();
            open.SetActive(true);
            close.SetActive(false);
            isOpen = true;
        }
    }

    public void Close()
    {
        if (isOpen)
        {
            closeEvent?.Invoke();
            open.SetActive(false);
            close.SetActive(true);
            isOpen = false;
        }
    }

    public void OpenAfterSelection()
    {
        if (selected) Open();
    }

    public void ChangeSelectState()
    {
        selected = !selected;
        select.SetActive(selected);
        close.SetActive(!selected);
    }

    public void SelectOn()
    {
        selected = true;
        select.SetActive(selected);
    }
    public void SelectOff()
    {
        selected = false;
        select.SetActive(selected);
    }
}
