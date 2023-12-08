using System;
using System.Collections;
using System.Text;
using HangulVirtualKeynoard;
using UnityEngine;
using UnityEngine.UI;

public class OnScreenKeyboard : MonoBehaviour
{
    public enum CurLang {
        KR,
        EN,
    }
    public enum Caps {
        Caps,
        Uncaps
    }

    private OnScreenKeyboardInputfield currentOskInputfield;
    private InputField targetInputField;
    private string inputtedString, currentString;

    [SerializeField]
    private CurLang curLang;
    private CurLang beforeLang;
    [SerializeField]
    private Caps curCaps;
    private Caps beforeCaps;
    
    [SerializeField]
    private Button bgCloseBtn;
    [SerializeField]
    private Text showTextField;
    [SerializeField]
    private GameObject KrNormal,KrNormalCpas,EnNormal,EnNormalCpas;
    [SerializeField]
    private Button exitBtn, korBtn, engBtn, capsBtn,checkBtn;

    public string str;

    public Material newMaterial;

    private bool timeCheck;

    private float timer;
    private Renderer objectRendererOrigin;
    private Material tmpMaterial;


    Event fakeEvent;

    void Awake()
    {
        AddListenerToButtons();

        
        curLang = CurLang.KR;
        beforeLang = CurLang.KR;
        curCaps = Caps.Uncaps;
        ClearAllStrValue();
        CloseKeyboard();
    }

    private void Update()
    {
        if (targetInputField == null) return;

        //hide a mobile keyboard
        ForceToCloseMobileKeyboard();

        //Detect Language 
        if (beforeLang != curLang)
        {
            beforeLang = curLang;
            ClearAllStrValue();
            ChangeKeyboardType(curLang, curCaps);
        }

        //Detect Cap 
        if (beforeCaps != curCaps)
        {
            beforeCaps = curCaps;
            ChangeKeyboardType(curLang, curCaps);
        }

        if(timeCheck)
        {
            
            timer += Time.deltaTime;
            if(timer > 10)
            {
               Debug.Log(timer);
                
                objectRendererOrigin.material = tmpMaterial;
                timeCheck = false;
            }
            
        }


    }

    void AddListenerToButtons()
    {
        //bgCloseBtn.onClick.AddListener(CloseKeyboard);
        checkBtn.onClick.AddListener(checkString);
        exitBtn.onClick.AddListener(CloseKeyboard);
        korBtn.onClick.AddListener(() => { curLang = CurLang.KR; });
        engBtn.onClick.AddListener(() => { curLang = CurLang.EN; });
        capsBtn.onClick.AddListener(() => {
            switch (curCaps) {
                case Caps.Caps:
                    curCaps = Caps.Uncaps;
                    break;
                case Caps.Uncaps:
                    curCaps = Caps.Caps;
                    break;
            }
        });
    }
    
    public void SendKey(string value) {
        switch (value) {
            case "backspace":
            value = "";
            inputtedString = inputtedString.Length > 1 ? inputtedString.Substring(0, inputtedString.Length - 1) : "";
            if (curLang == CurLang.KR)
                fakeEvent = null;
            else
            {
                currentString = currentString.Length > 1 ? currentString.Substring(0, currentString.Length - 1) : "";
                fakeEvent = Event.KeyboardEvent("backspace");
                fakeEvent.keyCode = KeyCode.Backspace;
            }
            break;
            case "space":
            fakeEvent = Event.KeyboardEvent(value);
            fakeEvent.keyCode = KeyCode.Space;
            InputFieldProcessUpdate(fakeEvent);
            value = " ";
            break;
            case "&":
            fakeEvent = Event.KeyboardEvent("a");
            fakeEvent.keyCode = KeyCode.Ampersand;
            fakeEvent.character = value[0];
            return;
            case "^":
            fakeEvent = Event.KeyboardEvent("a");
            fakeEvent.keyCode = KeyCode.Caret;
            fakeEvent.character = value[0];
            return;
            case "%":
            fakeEvent = Event.KeyboardEvent("a");
            fakeEvent.keyCode = KeyCode.Percent;
            fakeEvent.character = value[0];
            return;
            case "#":
            fakeEvent = Event.KeyboardEvent("a");
            fakeEvent.keyCode = KeyCode.Hash;
            fakeEvent.character = value[0];
            return;
            default:
            if (value.Length != 1) {
                Debug.LogError("Ignoring spurious multi-character key value: " + value);
            }
            fakeEvent = Event.KeyboardEvent(value);
            char keyChar = value[0];
            fakeEvent.character = keyChar;
            if (Char.IsUpper(keyChar)) {
                fakeEvent.modifiers |= EventModifiers.Shift;
            }
            break;
        }

        InputProcess(value);
    }

    public void ShowKeyboard(InputField inputField, OnScreenKeyboardInputfield oskInputField) {
        Initialize(inputField, oskInputField);
        InputProcess();
        gameObject.SetActive(true);
    }

    private void CloseKeyboard()
    {
        currentOskInputfield?.SaveInputedString(inputtedString);
        gameObject.SetActive(false);
    }
    
    private void InputProcess(string value)
    {
        inputtedString += value;
        currentString += value;

        InputProcess();
    }
    
    private void InputProcess()
    {
        InputFieldProcessUpdate(fakeEvent);

        if (curLang == CurLang.KR)
        {
            StartCoroutine(HangulDelayUpdate());
        }
        else
        {
            targetInputField.text = currentString;
            currentString = GetInputFieldText();
            showTextField.text =  GetInputFieldText();
        }
    }
    
    private void Initialize(InputField inputField, OnScreenKeyboardInputfield oskInputField)
    {
        targetInputField = inputField;
        currentOskInputfield = oskInputField;
        inputtedString = oskInputField.inputtedString;

        //Set default state
        if (string.IsNullOrEmpty(targetInputField.text))
        {
            //Do check your language
            curCaps = Caps.Uncaps;
            curLang = CurLang.KR;
        }
        
        ChangeKeyboardType(curLang, curCaps);
        ForceToCloseMobileKeyboard();
    }
    
    void ChangeKeyboardType(CurLang curLang, Caps caps) {
        KrNormal.gameObject.SetActive(false);
        KrNormalCpas.gameObject.SetActive(false);
        EnNormal.gameObject.SetActive(false);
        EnNormalCpas.gameObject.SetActive(false);

        this.curLang = curLang;
        this.curCaps = caps;
        
        switch (curLang) {
            case CurLang.KR:
                korBtn.gameObject.SetActive(false);
                engBtn.gameObject.SetActive(true);
                switch (caps) {
                    case Caps.Caps:
                        KrNormalCpas.gameObject.SetActive(true);
                        break;
                    case Caps.Uncaps:
                        KrNormal.gameObject.SetActive(true);
                        break;
                }
                break;
            case CurLang.EN:
                korBtn.gameObject.SetActive(true);
                engBtn.gameObject.SetActive(false);
                switch (caps) {
                    case Caps.Caps:
                        EnNormalCpas.gameObject.SetActive(true);
                        break;
                    case Caps.Uncaps:
                        EnNormal.gameObject.SetActive(true);
                        break;
                }
                break;
        }
    }

    private void SetInputFieldText(string str)
    {
        if (targetInputField)
            targetInputField.text = str;
    }

    private string GetInputFieldText()
    {
        if (targetInputField)
        {
            inputstr(targetInputField.text);
            return targetInputField.text;
        }
        else
            return "";
    }

    private void InputFieldProcessUpdate(Event fakeEvent)
    {
        if (targetInputField)
        {
            if(fakeEvent != null)
                targetInputField.ProcessEvent(fakeEvent);
            targetInputField.ForceLabelUpdate();
        }
    }

    IEnumerator HangulDelayUpdate()
    {
        HangulHelper helper = new HangulHelper();
        StringBuilder stringBuilder = new StringBuilder();

        //한글 완성을 위한 한글조합 넣기
        for (int i = 0; i < inputtedString.Length; i++) {
            helper.Input(stringBuilder, inputtedString[i]); // ㅎ
        }

        SetInputFieldText(stringBuilder.ToString());
        inputstr(stringBuilder.ToString());
        
        yield return null;
        currentString = GetInputFieldText();
        showTextField.text =  GetInputFieldText();
    }
    
    private void ForceToCloseMobileKeyboard()
    {
        if (targetInputField == null) return;

        if (targetInputField.touchScreenKeyboard != null)
            targetInputField.touchScreenKeyboard.active = false;
    }
    
    private void ClearAllStrValue()
    {
        inputtedString = "";
        currentString = "";
        showTextField.text = "";
        
        if(targetInputField)
            targetInputField.text = "";
    }

    public void inputstr(string a)
    {
        str = a;
    }

    private void checkString()
    {
        Debug.Log(str);
        // 객체 찾기
        GameObject targetObject = GameObject.Find(str);
       
        

        // 객체가 존재하고 머터리얼이 설정되어 있다면
        if (targetObject != null)
        {
            // 렌더러 컴포넌트 가져오기 (MeshRenderer 또는 SpriteRenderer, 등)
            Renderer objectRenderer = targetObject.GetComponent<Renderer>();
            objectRendererOrigin = targetObject.GetComponent<Renderer>();
            if (targetObject.CompareTag("Book"))
            {
                // 렌더러가 존재하면
                if (objectRenderer != null)
                {
                    timeCheck = true;
                    timer = 0f;
                    // 새로운 머터리얼로 변경
                    tmpMaterial = objectRenderer.material;
                    objectRenderer.material = newMaterial;
                    //objectRenderer.material = tmpMaterial;

                    ClearAllStrValue();




                }
                else
                {
                    Debug.LogError("Renderer 컴포넌트가 없습니다.");
                }

            }
            
        }
        else
        {
            Debug.LogError("지정된 이름의 객체를 찾을 수 없습니다.");
        }


        
      
    }

}
