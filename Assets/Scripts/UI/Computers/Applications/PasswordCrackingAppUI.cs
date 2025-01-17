using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PasswordCrackingAppUI : MonoBehaviour
{
    private MonitorAppUI monitorAppUI;

    [SerializeField]
    private ConvertedPasswordUI convertedPasswordPrefab;
    [SerializeField]
    private Transform convertedPasswordsHolder;
    [SerializeField]
    private TMP_InputField inputField;
    [SerializeField]
    private Button decompressButton;
    [SerializeField]
    private Button goBackToInputFieldButton;

    [SerializeField]
    private Button binButton;
    [SerializeField]
    private Button octButton;
    [SerializeField]
    private Button decButton;
    [SerializeField]
    private Button hexButton;
    [SerializeField]
    private Button atbashButton;
    [SerializeField]
    private Button caesarButton;
    [SerializeField]
    private TMP_InputField caesarParameterInputField;

    private string currentPassword;
    private string originalPassword;
    private Stack<ConvertedPasswordUI> previousConvertedPasswordUIStack;

    [SerializeField]
    private TMP_Text detectionChanceTextField;
    private const string DetectionChanceText = "Detection Chance: ";

    public void InitializePasswordCrackingApp(string appName)
    {
        monitorAppUI = GetComponent<MonitorAppUI>();
        monitorAppUI.SetAppName(appName);

        InitializePasswordCracking();
        SetDetectionChanceText();

        DetectionManager.DetectionOccured += () =>
        {
            // DisableApp();
            if (monitorAppUI != null)
            {
                monitorAppUI.CloseApp();
            }
        };
        DetectionManager.DetectionRemoved += () =>
        {
            // EnableApp();
            SetDetectionChanceText();
        };
    }

    private void InitializePasswordCracking()
    {
        previousConvertedPasswordUIStack = new();

        originalPassword = currentPassword = "";

        if (!DetectionManager.WasDetected)
        {
            EnableApp();
        }
        else
        {
            DisableApp();
        }
    }

    private void EnableApp()
    {
        inputField.onEndEdit.AddListener(ChangeOriginalPassword);
        decompressButton.onClick.AddListener(DecompressPassword);
        goBackToInputFieldButton.onClick.AddListener(GoBackToInputField);

        binButton.onClick.AddListener(BinDecode);
        octButton.onClick.AddListener(OctDecode);
        decButton.onClick.AddListener(DecDecode);
        hexButton.onClick.AddListener(HexDecode);
        atbashButton.onClick.AddListener(AtbashDecode);
        caesarButton.onClick.AddListener(CaesarDecode);
    }

    private void DisableApp()
    {
        inputField.onEndEdit.RemoveListener(ChangeOriginalPassword);
        decompressButton.onClick.RemoveListener(DecompressPassword);
        goBackToInputFieldButton.onClick.RemoveListener(GoBackToInputField);

        binButton.onClick.RemoveListener(BinDecode);
        octButton.onClick.RemoveListener(OctDecode);
        decButton.onClick.RemoveListener(DecDecode);
        hexButton.onClick.RemoveListener(HexDecode);
        atbashButton.onClick.RemoveListener(AtbashDecode);
        caesarButton.onClick.RemoveListener(CaesarDecode);
    }

    private void ChangeOriginalPassword(string newPassword)
    {
        RemoveAllPasswordTextFields();
        originalPassword = currentPassword = newPassword;
    }
    private void DecompressPassword()
    {
        string compressedPassword = inputField.text;
        if (TextCompressor.TryGetDecompressedText(compressedPassword, out string decompressedPassword))
        {
            RemoveAllPasswordTextFields();
            // originalPassword = currentPassword = inputField.text = decompressedPassword;
            currentPassword = decompressedPassword;
            CreateNewPasswordTextField(decompressedPassword);
        }
        else
        {
            Debug.Log("Decompression failed.");
        }
    }
    private void GoBackToInputField()
    {
        currentPassword = originalPassword;
        RemoveAllPasswordTextFields();
    }

    private void BinDecode()
    {
        int decodeBase = 2;
        currentPassword = ASCIIEncryption.Decode(currentPassword, decodeBase);
        AddDecodedPassword();
    }
    private void OctDecode()
    {
        int decodeBase = 8;
        currentPassword = ASCIIEncryption.Decode(currentPassword, decodeBase);
        AddDecodedPassword();
    }
    private void DecDecode()
    {
        int decodeBase = 10;
        currentPassword = ASCIIEncryption.Decode(currentPassword, decodeBase);
        AddDecodedPassword();
    }
    private void HexDecode()
    {
        int decodeBase = 16;
        currentPassword = ASCIIEncryption.Decode(currentPassword, decodeBase);
        AddDecodedPassword();
    }
    private void AtbashDecode()
    {
        currentPassword = AtbashCipher.DefaultEncode(currentPassword);
        AddDecodedPassword();
    }
    private void CaesarDecode()
    {
        int shift = Int32.Parse(caesarParameterInputField.text);
        currentPassword = CaesarCipher.Encode(currentPassword, CaesarCipher.DefaultBase, shift);
        AddDecodedPassword();
    }

    private void AddDecodedPassword()
    {
        CreateNewPasswordTextField(currentPassword);

        DetectionManager.CheckDetection();
        SetDetectionChanceText();
    }

    private void SetDetectionChanceText()
    {
        int detectionChanceNumber = -(DetectionManager.CurrentDetectionChance - 100);
        detectionChanceTextField.text = DetectionChanceText + detectionChanceNumber.ToString() + "%";
    }

    private void CreateNewPasswordTextField(string newPassword)
    {
        ConvertedPasswordUI convertedPasswordUI = Instantiate(convertedPasswordPrefab.gameObject,
            convertedPasswordsHolder).GetComponent<ConvertedPasswordUI>();

        convertedPasswordUI.InitializeConvertedPasswordUI(newPassword);
        convertedPasswordUI.GoBackToPasswordTriggered += GoBackToPassword;
        previousConvertedPasswordUIStack.Push(convertedPasswordUI);
    }

    private void GoBackToPassword(ConvertedPasswordUI targetConvertedPasswordUI)
    {
        while (true)
        {
            ConvertedPasswordUI convertedPasswordUI = previousConvertedPasswordUIStack.Peek();
            if (convertedPasswordUI == targetConvertedPasswordUI)
            {
                currentPassword = previousConvertedPasswordUIStack.Peek().PasswordString;
                break;
            }
            convertedPasswordUI.DestroySelf();
            previousConvertedPasswordUIStack.Pop();
        }
    }

    private void RemoveAllPasswordTextFields()
    {
        while (previousConvertedPasswordUIStack.TryPop(out ConvertedPasswordUI convertedPasswordUI))
        {
            convertedPasswordUI.DestroySelf();
        }
        currentPassword = originalPassword;
    }
}
