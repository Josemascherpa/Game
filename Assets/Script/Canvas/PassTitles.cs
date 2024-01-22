
using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PassTitles : MonoBehaviour, IPointerClickHandler
{    
    [SerializeField] private GameObject text1;
    [SerializeField] private GameObject text2;
    [SerializeField] private GameObject text3;  
    [SerializeField]private AssetReference menuGame;  
    public float timeBetweenTitles=2f;

    private bool passTitlesCorou = true;
    private void Awake() {
        Cursor.visible=false;
    }

    private void Start()
    {
        StartCoroutine("PassTitlesCorru");
    }
    public void OnPointerClick(PointerEventData eventData)
    {        
        if (text1.activeSelf)
        {
            StopCoroutine("PassTitlesCorru");
            text1.SetActive(false);
            text2.SetActive(true);
            StartCoroutine("PassTitlesCorru");
        }
        else if (text2.activeSelf)
        {
            StopCoroutine("PassTitlesCorru");            
            text2.SetActive(false);
            text3.SetActive(true);
            StartCoroutine("PassTitlesCorru");
        }
        else if (text3.activeSelf)
        {
            StopAllCoroutines();
            MenuGame();
        }
    }        

    IEnumerator PassTitlesCorru()
    {
        while (passTitlesCorou)
        {
            yield return new WaitForSeconds(timeBetweenTitles);            
            if (text1.activeSelf)
            {
                text1.SetActive(false);
                text2.SetActive(true);
            }
            else if (text2.activeSelf)
            {
                text2.SetActive(false);
                text3.SetActive(true);
            }
            else if (text3.activeSelf)
            {                
                MenuGame();
            }
        }
    }

    private async void MenuGame(){
        await SceneManagerBehaviour.Instance.ChangeScene(menuGame);
    }

}
