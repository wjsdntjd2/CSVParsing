using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParserTestDlg : MonoBehaviour
{
    public Text ResultText = null;
    public Button Load = null;
    public Button Parsing = null;
    public Button Clear = null;
    //List ListItem=


    private void Start()
    {
        Load.onClick.AddListener(OnClick_Load);
    }

    public void Init()
    {

    }

    void OnClickBtn()
    {
        LoadingTest();
    }

    void OnClick_Load()
    {
        LoadingTest();
    }

    void LoadingTest()
    {
        List<string[]> dataList = CSVParser.Load("TableData/test");

        string sResult = "";
        for (int i = 0; i < dataList.Count; i++)
        {
            string[] data = dataList[i];
            sResult += string.Format("{0},{1},{2}\n", data[0], data[1], data[2]);
        }
        ResultText.text = sResult;
    }
}
