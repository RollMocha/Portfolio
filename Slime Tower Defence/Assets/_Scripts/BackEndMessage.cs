using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BackEnd;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackEndMessage : MonoBehaviour
{
    //[Header("Login & Register")]
    public InputField ID;
    public InputField PW;

    BackendReturnObject bro = new BackendReturnObject();
    //bool isSuccess = false;

    void Start()
    {
        // 세 번째 방법 (비동기)
        Backend.InitializeAsync(true, callback => {
            if (callback.IsSuccess())
            {
                Debug.Log("초기화 성공!");
                // 초기화 성공 시 로직
            }
            else
            {
                Debug.LogError("초기화 실패!");
                // 초기화 실패 시 로직
            }
        });
    }

    void Update()
    {
        Backend.AsyncPoll();
    }

    //초기화 성공 이후 버튼 등을 통해 함수 실행
    public void CustomSignUp()
    {
        string id = ID.text; // 원하는 아이디
        string password = PW.text; // 원하는 비밀번호

        Backend.BMember.CustomSignUp(id, password, callback => {
            if (callback.IsSuccess())
            {
                Debug.Log("회원가입에 성공했습니다");
            }
            else
            {
                Debug.LogError("회원가입 실패!");
                Debug.LogError(bro); // 뒤끝의 리턴케이스를 로그로 보여줍니다.
            }
        });    
    }

    public void CustomLogin()
    {
        string id = ID.text; // 원하는 아이디
        string password = PW.text; // 원하는 비밀번호

        Backend.BMember.CustomLogin(id, password, callback => {
            if (callback.IsSuccess())
            {
                Debug.Log("로그인에 성공했습니다");
                TitleSceneChange();
            }
            else
            {
                Debug.LogError("로그인 실패!");
                Debug.LogError(bro); // 뒤끝의 리턴케이스를 로그로 보여줍니다.
            }
        });
    }

    public void TitleSceneChange()//게임 씬 로드
    {
        SceneManager.LoadScene("TitleScene");
    }
}