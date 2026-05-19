using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: I added 3 values to the queue, test1 with priority of 3, test2 with 5 and test3 with 10
    // Expected Result: test 3 should be dequeued first
    // Defect(s) Found: the code fails to check what is the biggest priority value, it dequeues whatever is bigger than the first one.
    public void TestPriorityQueue_1()
    {
        var priorityQueue1 = new PriorityQueue();
        priorityQueue1.Enqueue("test1", 3);
        priorityQueue1.Enqueue("test3", 10);
        priorityQueue1.Enqueue("test2", 5);
        string value = priorityQueue1.Dequeue();
        Assert.AreEqual("test3", value , $"the returned value was {value}" );
        
    }

    [TestMethod]
    // Scenario: Try to get the highest priority value when there is 2 high priority with equal values.
    // Expected Result: test2
    // Defect(s) Found: the function was returning the last value with the higher number, when it should dequeue the first value with that same priority.
    public void TestPriorityQueue_2()
    {
        var priorityQueue2 = new PriorityQueue();
        priorityQueue2.Enqueue("test1", 1);
        priorityQueue2.Enqueue("test2", 7);
        priorityQueue2.Enqueue("test3", 6);
        priorityQueue2.Enqueue("test4", 7);
        string value = priorityQueue2.Dequeue();
        Assert.AreEqual("test2", value , $"the returned value was {value}" );
    }

    // Add more test cases as needed below.
}