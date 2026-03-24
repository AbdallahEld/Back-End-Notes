
# How Garbage Collector Work

## 1- Allocation

```
var obj = new MyClass
```

- object sent to managed heap
- probably in **Generation 0**

## 2- Reachability
Garbage Collector check :

- Stack
- Static fields
- Cpu Registers

Any unreachable object get deleted
## 3- Generational Collection

Garbage collector split memory into 3 Generations

- Gen 0 

like new objects

- Gen 1

objects that lived longer

- Gen 3

objects that lived much longer like **Static Data** , **Caches**

## 4- Promotion
if object lived it gets promoted to next Gen

## 5- Compaction

After identifying the "garbage," the GC performs two final steps:
- **Sweep**: It reclaims the memory occupied by unreachable objects.
- **Compaction**: It moves the surviving objects closer together. This removes Memory Gaps and ensures that free memory is one large, contiguous block.

