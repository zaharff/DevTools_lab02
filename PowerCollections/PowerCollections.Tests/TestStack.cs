using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PowerCollections.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Count_must_be_zero_since_the_stack_is_empty_Lenght_must_be_ten_since_the_value_ten_was_passed_to_the_constructor()
        {
            Stack<int> stack = new Stack<int>(10);

            Assert.AreEqual(0, stack.Count);
            Assert.AreEqual(10, stack.Lenght);
        }
        [TestMethod]
        public void Push_take_on_Top_and_increase_Count()
        {
            var Stack = new Stack (-10);
            Stack.Push (100); 
            Assert.AreEqual(100, stack.Top());
            Assert.AreEqual(1, stack.Count);

    }  
        [TestMethod]
        public void remove_an_element_from_the_vertex_and_return_its_value()
        {
            var Stack = new Stack (10);
            Stack.Push (100);
            Stack.Push (10);  
            Assert.AreEqual(100, stack.Pop());
            Assert.AreEqual(10, stack.Pop());

    }
        [TestMethod]
        public void  isEmpty_should_be_true_for_an_unfilled_stack()
        {
            Stack<bool> stack = new Stack<bool> (4);         
            Assert.IsTrue(stack.IsEmpty());

}
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void An_exception_is_expected_when_passing_a_negative_value_to_the_constructor() 
        {
            Stack<int> stack = new Stack<int>(-5);
        }
    
      
        [TestMethod]
        public void isEmpty_should_be_False()
        {
            Stack<int> stack = new Stack<int>(4);
            Stack.Push(5);
            Stack.Push(1);
            Stack.Push(6);

            Assert.IsFalse(stack.IsEmpty());
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void push_shoud_give_an_error_when_stack_overflow()
        {
            Stack<int> stack = new Stack<int>(2);

            Stack.Push(1);
            Stack.Push(2);
            Stack.Push(3);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void pop_should_give_an_error_when_stack_is_empty()
        {
            Stack<int> stack = new Stack<int>(4);
            Stack.Pop();
        }
        [TestMethod]
          public void GetEnumerator_should_return_an_inverted_array()
        {
            Stack<int> stack = new Stack<int>(5);
            int[] array  = new int[] { 1, 3, 4 };

            foreach (int t in array)
            {
                stack.Push(t);
            }

            var kg = from k in stack select k;
            kg = kg.Reverse();  
            Assert.IsTrue(array.SequenceEqual(kg));
        }
}
}
