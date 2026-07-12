# Data Structures

Data Structures are about how data is stored and organized in different structures.

# Algorithms

Algorithms are methods used to solve different problems, often by searching through and manipulating data structures.

# Types of Data Structures

## 1. Primitive Data Structures

Primitive Data Structures are built-in data types that store a single value.

**Examples:**
- `int`
- `float`
- `char`

## 2. Abstract Data Structures

Abstract Data Structures are used to store primitive data in an organized and efficient way.

**Examples:**
- Array
- Linked List
- Stack
- Queue
- Tree
- Graph

# Theory and Terminology

| Term | Description |
|--------|-------------|
| Algorithm | A set of step-by-step instructions to solve a specific problem. |
| Data Structure | A way of organizing data so it can be used efficiently. Common data structures include arrays, linked lists, and binary trees. |
| Time Complexity | A measure of the amount of time an algorithm takes to run, depending on the amount of data it processes. |
| Space Complexity | A measure of the amount of memory an algorithm uses, depending on the amount of data it processes. |
| Big O Notation | A mathematical notation used to describe the time and space complexity of an algorithm. |
| Recursion | A programming technique where a function calls itself. |
| Divide and Conquer | A method of solving a problem by breaking it into smaller sub-problems, solving them, and combining the results. |
| Brute Force | A simple method where an algorithm tries all possible solutions and chooses the correct one. |

# Array

An array is a data structure used to store multiple elements of the same type.

Arrays are used by many algorithms.

## 1. Bubble Sort

Bubble Sort is a sorting algorithm that sorts an unsorted array from the lowest value to the highest value.

### Steps

1. Compare the first two values in the array.
2. If the first value is greater than the second value, swap them.
3. Continue comparing adjacent values throughout the array.
4. Repeat the process until the array is sorted.

---

## 2. Selection Sort

Selection Sort finds the lowest value in the array and moves it to the front of the unsorted part.

### Steps

1. Go through the array to find the lowest value.
2. Move the lowest value to the front of the unsorted part of the array.
3. Repeat the process for the remaining unsorted elements.
4. Continue until the entire array is sorted.

---

## 3. Insertion Sort

Insertion Sort divides the array into a sorted part and an unsorted part.

### Steps

1. Take the first value from the unsorted part.
2. Compare it with values in the sorted part.
3. Insert it into the correct position in the sorted part.
4. Repeat until all values are sorted.

---

## 4. Quick Sort

Quick Sort is a fast sorting algorithm that sorts array elements from smallest to largest.

### Steps

1. Pick one element as the **pivot**.
2. Place all smaller elements on the left side of the pivot.
3. Place all larger elements on the right side of the pivot.
4. Recursively apply the same process to the left and right sub-arrays.
5. Continue until the array is fully sorted.

---

## 5. Counting Sort

Counting Sort sorts an array by counting the number of times each value appears.

### Steps

1. Create a counting array to store the frequency of each value.
2. Count the occurrences of each value.
3. Use the counting array to reconstruct the sorted array.
4. Continue until all values are placed in order.

---

## 6. Radix Sort

Radix Sort sorts numbers digit by digit, starting from the least significant digit (rightmost digit).

### Steps

1. Find the largest number in the array.
2. Sort all numbers according to the ones place.
3. Sort the numbers according to the tens place.
4. Continue sorting by hundreds, thousands, and higher place values.
5. Repeat until all digit positions have been processed.

---

## 7. Merge Sort

Merge Sort is a sorting algorithm that uses the **Divide and Conquer** technique.

### Steps

1. Divide the array into two halves.
2. Continue dividing each half until each sub-array contains only one element.
3. Merge two sub-arrays by placing elements in sorted order.
4. Continue merging until a single sorted array is obtained.

---

## 8. Linear Search

Linear Search is used to search for a value in an array and return its index.

### Steps

1. Start from the first element of the array.
2. Compare each element with the target value.
3. If the value is found, return its index.
4. If the end of the array is reached and the value is not found, return `-1`.

---

 ## Binary Search   
 Binary Search is a searching algorithm used it for search for a value  through an array and return the index of that value.  

 ### Steps  
1. Check the value in the center of the array.  
2. If the target value is lower, search the left half of the array. If the target value is higher, search the right half.  
3. Continue step 1 and 2 for the new reduced part of the array until the target value is found or until the search area is empty.  
4. If the value is found, return the target value index. If the target value is not found, return -1.  
--- 
## Linked List  
A Linked List is, as the word implies, a list where the nodes are linked together. Each node contains data and a pointer. The way they are linked together is that each node points to where in the memory the next node is placed.  
### Linked Lists vs Arrays
A linked list is a way of storing data using nodes that are connected to each other.  

Unlike arrays, which are already built into programming languages, a linked list is something we create ourselves.  

Each node in a linked list contains two things:  

The data (the value)  
A link (or pointer) to the next node  
### Linked Lists in Memory
A linked list is not stored in one straight line like an array. Instead, each item (node) can be stored in different places in memory.  

Each node has:  

The data  
A link (address/pointer) to the next node  

So the computer moves from one node to another by following these links.  

### Types of Linked List  
### 1. Singly Linked List  
A singly linked list is the simplest type.  
Each node has:  
Data  
A link to the next node only
You can move only forward, from the first node to the last.  

### Doubly Linked List     
A doubly linked list is a bit more advanced.  
Each node has:  
Data  
A link to the next node  
A link to the previous node  
### How it works:  
You can move:  
Forward  
Backward  

### Circular Doubly Linked
A Circular Doubly Linked List is a linked list where:  
Each node has 3 parts:  
Previous (prev) → Points to the previous node.  
Data → Stores the value.  
Next (next) → Points to the next node.  

### Traversing a Linked List

### What is Traversing?

**Traversing** means **visiting every node in a linked list one by one** from the **head** to the **last node**.

In simple words:

> **Traversing = Moving through the linked list and checking each node.**

## Steps

1. Start from the **head**.
2. Visit (read or print) the current node.
3. Move to the **next** node.
4. Repeat until the current node becomes `null`.


---
# Stack  
A stack is a data structure that can hold many elements.
## Important Built-in Function in Stack 
1.Push: Adds a new element on the stack.  
2.Pop: Removes and returns the top element from the stack.  
3.Peek: Returns the top element on the stack.  
4.isEmpty: Checks if the stack is empty.  
5.Size: Finds the number of elements in the stack.  

---

# Queues
A queue is a data structure that can hold many elements.The first person to stand in line is also the first who can pay and leave the supermarket. This way of organizing elements is called FIFO: First In First Out.
## Basic operations we can do on a queue are:  
Enqueue: Adds a new element to the queue.  
Dequeue: Removes and returns the first (front) element from the queue.  
Peek: Returns the first element in the queue.  
isEmpty: Checks if the queue is empty.  
Size: Finds the number of elements in the queue.  


 




    

       
     
    
    
     
    
  

   
    


