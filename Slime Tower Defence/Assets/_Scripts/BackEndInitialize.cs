/*
using BackEnd;
using UnityEngine;

public class BackEndInitialize : MonoBehaviour
{

    // .Net 4 ����
    void Awake()
    {
        Backend.Initialize(HandleBackendCallback);
    }

    void HandleBackendCallback()
    {
        if (Backend.IsInitialized)
        {
            Debug.Log("�ڳ�SDK �ʱ�ȭ �Ϸ�");

            // example 
            // ����üũ -> ������Ʈ 

            // ���� �ؽ�Ű ȹ�� 
            if (!Backend.Utils.GetGoogleHash().Equals(""))
                Debug.Log(Backend.Utils.GetGoogleHash());

            // �����ð� ȹ��
            Debug.Log(Backend.Utils.GetServerTime());
        }
        // ����
        else
        {
            Debug.LogError("Failed to initialize the backend");
        }
    }


    /*
        private void Awake()
        {
            // .Net 3 ����
            // �ʱ�ȭ
            Backend.Initialize(BRO =>
            {
                // �ʱ�ȭ ������ ��� ����
                if (BRO.IsSuccess())
                {
                    // ���� �ؽ�Ű ȹ�� 
                    if (!Backend.Utils.GetGoogleHash().Equals(""))
                        Debug.Log(Backend.Utils.GetGoogleHash());
                }
                // �ʱ�ȭ ������ ��� ���� 
                else
                {
                }
            });
        }
    

}
*/