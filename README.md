# Exadel-Training

## Task 2.1 Formula calculations
Create a Console application and enter the integers "a" and "b".

For the number "a" calculate the formula a! * 0.05, where a! is the factorial of the number "a". For the number "b", calculate the natural logarithm of ln(b).

Calculations must be done with rounding and an accuracy of two decimal places. The results obtained must be compared and a text message displayed with the result. 

### Comment:

- ● Variable “a” must be in the range 0 <= a <= 5
- ● Variable “b” must be in the range 0 <= b <= 100
- ● In the message with the result, it is worth displaying the value of the variables
and more than, less than, equal this value relative to the second variable

### Example 1:

Input a: 5

Input b: 100

Output: "Number 'a' = 6.00 and more than number 'b' = 4.61"

### Example 2:

Input a: 0

Input b: 8

Output: "Number 'a' = 0.05 and less than number 'b' = 2.08"


## Task 2.2 Strings and files

There are 3 text files. Each file contains one sentence. All words are separated by spaces ' '. 

Users should open and read all these documents. Create a function that returns the words in reverse order.

If there are uppercase characters in the word then print them at the beginning of the word.

All special characters and numbers must be deleted.

The number of spaces remains unchanged.

After that, creating and writing result in a new text file from short to long sentences.
All original files must be deleted.
  
### Comment:

- ● String length less than or equal to 300 characters.
- ● String consists of lowercase and uppercase English letters, digits, or one of the
following characters "!@#$%^&*()_+-=',.:".
- ● The only space character in the string is ' '.

### Example 1:

File 1 Input: " Ak! NjodH22# pknGhb** gggruuee$67" File 2 Input: "fkrfji rgjir rmgjK"

File 3 Input: "1111 1$%^&*"

### Result file:

""

"Krmgj rgjir fkrfji"

"gggruuee Gpknhb NHjod Ak "
