using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]

    // Scenario: Add Item A (Priority 1), Item B (Priority 5), and Item C (Priority 2).
    // Expected Result: Item B (Priority 5) should be Dequeued first.
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item A", 1);
        priorityQueue.Enqueue("Item B", 5);
        priorityQueue.Enqueue("Item C", 2);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item B", result);
    }

    [TestMethod]

    // Scenario: Add Item A (Priority 5) then Item B (Priority 5).
    // Expected Result: Item A should be Dequeued first because it was added first.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item A", 5);
        priorityQueue.Enqueue("Item B", 5);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item A", result);
    }
    // Add more test cases as needed below.
}