## Overview
This solution repository includes,
- Solution class `Phone.cs` containing the implementation of method `OldPhonePad(string)`.
- The `Program.cs` file to debug the `Phone.OldPhonePad(string)` method using Console.
- The `Tests` project for unit tests.
    - The `Tests/PhoneTests.cs` file contains unit tests of a bunch of happy-unhappy cases.
- The `SolutionDocumentation.md` file for the mark-down documentation of the implementation.

## Methods
```cs
Phone.OldPhonePad(input)
```
This static method takes string as input. Calculates and returns the output as uppercase-alpha-string. i.e, ABC.

## Solution
1. At first keep the digit to letters mapping in a Dictionary.
    ***oldPhoneButtonMap***: *Dictionary<char, string>*
    `1 -> &'( ` `2 -> abc` `3 -> def `
    `4 -> ghi ` `5 -> jkl` `6 -> mno `
    `7 -> pqrs` `8 -> tuv` `9 -> wxyz`
    `- - - - -` `0 -> ' '` `- - - - -`

2. Taking a variable ***result***:*string* (with empty string). 
Will parse the input string and concat or delete *letter*s with/from ***result***. 
The final value of ***result*** is the expected output.

3. Travarse each digit in the `input` string once. 
    Count the consecutive repeated character Streak by using ***repeatCharStreak***:*int* while looping through each input character.
4. When the character is not a repeat to the previous character,
    Handle the *repeated Streak count of the previous digit* and choose the appropriete letter from the ***oldPhoneButtonMap***: *Dictionary*.
    ```cs
    var resultLetterIndex = (repeatCharStreak-1) % buttonString.Length;
    result += oldPhoneButtonMap[previousChar][resultLetterIndex];
    ```
    i.e, for 22234\*#, when coming to the 222<u>**3**</u>4\*# index, the previous digit is 2 and repeat Streak is 3. So, from `abc`, 3rd letter (index 2) will be chosen.

    When the previous character is <b>\*</b> (backspace). Remove characters from the end of ***result***:*string* by repeated count of <b>\*</b>.
    ```cs
    var removeCount = Math.Min(result.Length, repeatCharStreak);
    result = result.Substring(0, result.Length - removeCount);
    ```
    i.e, for 5223\*\*5#, when coming to the 5223\*\*<u><b>5</b></u># index, the previous character is * and repeat Streak is 2. From ***result***:*string* = *JBD*, remove last 2 letters (*BD*). So, ***result***:*string* = *J*
5. Now, reset the ***repeatCharStreak***:*int* to 1 for the current character in the ***foreach*** travarsal.
6. When a space `(' ')` is found, it will automatically handle the previous character streak and continue to the next character travarsal.
7. When a `#` is found, it will automatically handle the previous character streak and break the loop considering `#` as the last character in the input.
i.e, for 223#56, when coming to 223<u>**#**</U>56 index, the loop will break. So, ***result***:string = *BD*.

## Solution Complexity
##### Space Complexity: O(N) 
- Using a constant Dictionary ***oldPhoneButtonMap***: *Dictionary*. **O(1)**
- Using ***result***:*string* to store the output. **O(N)**
##### Time Complexity: O(N)
- Complexity of accessing a value by key in ***oldPhoneButtonMap***: *Dictionary* is constant. **O(1)**
- Travarsing through each characters in the input once. **O(N)**

## Test Coverage
* Correct Result On Exanple Unit Tests
    `33#` -> `E`
    `227*#` -> `B`
    `4433555 555666#` -> `HELLO`
    `8 88777444666*664#` -> `TURING`
* 1st Letter On Single Button press
    `0#` -> ` `
    `1#` -> `&`
    `2#` -> `A`
    `3#` -> `D`
    `4#` -> `G`
    `5#` -> `J`
    `6#` -> `M`
    `7#` -> `P`
    `8#` -> `T`
    `9#` -> `W`
* 2nd Letter On Twice Button press
    `00#` -> ` `
    `11#` -> `'`
    `22#` -> `B`
    `33#` -> `E`
    `44#` -> `H`
    `55#` -> `K`
    `66#` -> `N`
    `77#` -> `Q`
    `88#` -> `U`
    `99#` -> `X`
* 3rd Letter On Trice Button press
    `000#` -> ` `
    `111#` -> `(`
    `222#` -> `C`
    `333#` -> `F`
    `444#` -> `I`
    `555#` -> `L`
    `666#` -> `O`
    `777#` -> `R`
    `888#` -> `V`
    `999#` -> `Y`
* 4th Letter On 4 Times Button press
    `7777#` -> `S`
    `9999#` -> `Z`
* Circulated Letter On 5 times Button press
    `00000#` -> ` `
    `11111#` -> `'`
    `22222#` -> `B`
    `33333#` -> `E`
    `44444#` -> `H`
    `55555#` -> `K`
    `66666#` -> `N`
    `77777#` -> `P`
    `88888#` -> `U`
    `99999#` -> `W`
* Proper Result On Backspace Press`22 2225#` -> `BCJ`
    `22 2225*#` -> `BC`
    `22 2225**#` -> `B`
    `22***2225#` -> `CJ`
    `***2225#` -> `CJ`
    `22 2225***#` -> `
    `22 2225****#` -> `
    `22*222*5*#` -> `
    `***#` -> `
* Empty Result On No Button Press
    `#` -> `
* Skip Handling Characters After Hash Symbol In The Input
    `22#33445` -> `B`