using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI _nameText;
    public TextMeshProUGUI _dialogueText;
    


    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartTalking(Dialogue dialogue)
    {
        Debug.Log("Starting " + dialogue._charcterName);

        _nameText.text = dialogue._charcterName;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNext();
    }

    public void DisplayNext()
    {if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        //_dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(Type(sentence));
    }

    IEnumerator Type (string sentence)
    {
        _dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            _dialogueText.text += letter;
            yield return null;
        }
    }


    void EndDialogue()
    {
        Debug.Log("end of convo");
    }

}
