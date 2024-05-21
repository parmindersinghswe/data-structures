Here is the rephrased content for assignment of pointers in C#:

---

### Assignment of Pointers

- **Pointer Type Compatibility**
  - Pointers of the same type can be assigned to each other:
    ```csharp
     int* p1, p2;
     int intValue = 10;
     p1 = &intValue;
     float* fp;
     float floatValue = 10.3f;
     fp = &floatValue;
     p2 = p1; // Allowed
     p2 = fp; // Not Allowed
    ```

- **Type Casting**
  - If not the same type, a cast operator must be used:
    ```csharp
    p2 = (int*)fp; // Allowed
    ```

- **Exception: Pointer to `void`**
  - `void*` is a generic pointer type that can represent any type.
  - No casting is needed to convert a pointer to a `void` pointer.
  - `void` pointers cannot be dereferenced.

---

### Assignment of Pointers

- **Integer Assignment**
  - Only null can be assigned to a pointer directly. Other integer values are not allowed:
    ```csharp
    int* p1;
    p1 = 1000; // Not allowed
    p1 = (int*)1000; // Allowed
    p1 = null; // Allowed
    ```

- **Note:**
  - A pointer is an address. An address is an integer, but a pointer is not an integer!

---
