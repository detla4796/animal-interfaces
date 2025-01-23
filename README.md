# **Working with Interfaces in C#**

This console application demonstrates the use of interfaces in C#. The `Animal` class is implemented, which interacts with the interfaces `IMove`, `IChangeName`, `IVoice`, `ICloneable`, and `IComparable`.

---

## **Interface Descriptions**

### 1. **`IMove`**
The `IMove` interface defines the `Move` method, which allows an object to move by a specified offset along the `X` and `Y` coordinates.

**Methods:**
- `void Move(int dx, int dy)` — moves the object by `dx` along the `X` axis and `dy` along the `Y` axis.

---

### 2. **`IChangeName`**
The `IChangeName` interface defines the `ChangeName` method, which allows changing the name of an object.

**Methods:**
- `void ChangeName(string newName)` — changes the object's name to `newName`.

---

### 3. **`IVoice`**
The `IVoice` interface defines the `Voice` method, which allows an object to "make a sound."

**Methods:**
- `void Voice()` — outputs a message indicating that the animal is making a sound.

---

### 4. **`ICloneable`**
The `ICloneable` interface defines the `Clone` method, which allows creating a copy of an object.

**Methods:**
- `object Clone()` — returns a copy of the object.

---

### 5. **`IComparable`**
The `IComparable` interface defines the `CompareTo` method, which allows comparing objects based on a specific criterion (in this case, the `X` coordinate).

**Methods:**
- `int CompareTo(object obj)` — compares the current object with another object and returns:
  - `0` if the coordinates are equal,
  - `1` if the current coordinate is greater,
  - `-1` if the current coordinate is smaller.

---

## **How It Works Together**
The `Animal` class implements all the above interfaces, allowing objects of this class to:
- Move (`IMove`).
- Change their name (`IChangeName`).
- Make a sound (`IVoice`).
- Clone themselves (`ICloneable`).
- Compare their coordinates (`IComparable`).
