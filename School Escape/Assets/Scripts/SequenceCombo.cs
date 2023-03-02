using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceCombo : MonoBehaviour
{
    public string sequence;
    Queue<int> activeSequence = new Queue<int>();
    int[] intSequence;

    private void Start()
    {
        intSequence = new int[sequence.Length];
        char[] sequenceChars = sequence.ToCharArray();
        for (int i = 0; i < sequenceChars.Length; i++)
        {
            intSequence[i] = sequenceChars[i] - '0';
        }
    }

    public void AddToSequence(int i)
    {
        if (activeSequence.Count == intSequence.Length)
        {
            activeSequence.Dequeue();
        }
        activeSequence.Enqueue(i);
    }

    public void CheckSequence()
    {
        for (int i = 0; i < sequence.Length; i++)
        {
            Debug.Log("Comparing " + activeSequence.Peek() + " to " + intSequence[i]);
            int currInLine = activeSequence.Dequeue();
            if (currInLine != intSequence[i])
            {
                activeSequence.Clear();
                Debug.Log("Wrong sequence!");
                return;
            }
        }
        Debug.Log("Correct sequence!");
    }

}
