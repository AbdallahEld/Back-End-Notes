
# Memory Management

C# Rely of **CLR** To manage memory you dont need to deallocate memory its handeled by one of the CLR Components **Garbage Collector**

```
Person p = new Person();
p = null;
```
- no object so its GC Mission to deallocate memory

## Why This is Important
it Fix some C++ Problems like 
- Memory Leak
```
int* x = new int(5);
// you forgot delete
```

- Dangling Pointers
```
int* ptr = new int(5)
delete ptr

ptr = new int(6) // dangling pointer
```

Garbage Collector Ensures no dangling pointers or memory leak but it doesnt Eliminate pointers you still can use them in blocks that are marked **unsafe**

