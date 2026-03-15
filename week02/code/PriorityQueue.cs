using System;
using System.Collections.Generic;

public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.
    /// The node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    public string Dequeue()
    {
        // BUG FIX: Verify the queue is not empty before attempting to remove
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;

        // BUG FIX 1: Changed "index < _queue.Count - 1" to "index < _queue.Count"
        // This ensures the loop checks EVERY item, including the last one.
        for (int index = 1; index < _queue.Count; index++)
        {
            // BUG FIX 2: Changed ">=" to ">"
            // This ensures that if priorities are equal, we stick with the 
            // one added first (FIFO).
            if (_queue[index].Priority > _queue[highPriorityIndex].Priority)
            {
                highPriorityIndex = index;
            }
        }

        // Get the value to return
        var value = _queue[highPriorityIndex].Value;

        // BUG FIX 3: Actually remove the item from the list.
        // Without this, the same item stays in the queue forever.
        _queue.RemoveAt(highPriorityIndex);

        return value;
    }

    // DO NOT MODIFY THE CODE IN THIS METHOD
    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    // DO NOT MODIFY THE CODE IN THIS METHOD
    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}