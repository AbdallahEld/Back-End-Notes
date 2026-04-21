
# How Jit Compiler Works

First We Need to understand what even is a Compiler and How the machine understand our code

## Can Machine Understand what i type ?

The Simple answer is no it understand binary code 0 and 1 so for the machine to understand for Example

``` C#
int x = 5;
```

it needs a translator someone who can tell her this means

```
11000111 01000101 11111100 00000101 00000000 00000000 00000000
```

and Here Comes **Compiler** but Compilers are not the only approach we can use to translate code we have also **Interpreter**

## Interpreter

Interpreter Translate High level programming code to machine code in a Line by Line approach it read the code Line by line at runtime it often used with Scripting Languages
That make Scripting Languages more flexible and easier to debug but this can cause lower Execution time cause each time you run the application it need to interpret your code line by line

## Compiler

Compilers do  the same job but diffrent approach it Translate all the before it run 
it take all your code and compile it into an Excutable **.Exe** file that can run so when you run this file it run directly but theres a trade of:

If you wanna refactor your code the Code have to be Compiled again in all the platforms you want to publish your program on so you have to compile it once for each platfrom 

and here comes the JIT Compiler

## Jit Compiler

is a Hybrid way. instead of Compiling Your C# Code to Binary Code directly it Compile it into something Called IL

so: Roslyn Compile it
``` C#
int x = 5;
```

become 
```
.locals init ([0] int32 x)
ldc.i4.5
stloc.0 
```

Here come the JIT Compiler it generate instructions from this IL

```
mov dword ptr [ebp-4], 5
```

Which CPU See as 
```
C7 45 FC 05 00 00 00
```