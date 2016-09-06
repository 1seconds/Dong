using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScripts : MonoBehaviour
{

    public void ClickStartBtn()
    {
        // 01 스테이지로 씬 이동
        SceneManager.LoadScene("01");
        
    }

    public void ClickSettingBtn()
    {
        Debug.Log("셋팅 화면으로 전환");
    }
}
