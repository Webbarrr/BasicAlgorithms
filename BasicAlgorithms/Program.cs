using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms
{
    class Program
    {
        static void Main()
        {
            // 1. Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
            Console.WriteLine(Ex1(1, 2));
            Console.WriteLine(Ex1(2, 2));

            // 2. Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
            Console.WriteLine(Ex2(53));
            Console.WriteLine(Ex2(30));
            Console.WriteLine(Ex2(51));

            // 3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30. 
            Console.WriteLine(Ex3(30, 0));
            Console.WriteLine(Ex3(25, 5));
            Console.WriteLine(Ex3(20, 30));
            Console.WriteLine(Ex3(20, 25));

            // 4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
            Console.WriteLine(Ex4(103));
            Console.WriteLine(Ex4(90));
            Console.WriteLine(Ex4(89));

            // 5. Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged.
            Console.WriteLine(Ex5("if else"));
            Console.WriteLine(Ex5("else"));

            // 6. Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive.
            Console.WriteLine(Ex6("Python", 1));
            Console.WriteLine(Ex6("Python", 0));
            Console.WriteLine(Ex6("Python", 4));

            // 7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
            Console.WriteLine(Ex7("abcd"));
            Console.WriteLine(Ex7("a"));
            Console.WriteLine(Ex7("xy"));

            // 8. Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string.
            // If the given string length is less than 2 return the original string.
            Console.WriteLine(Ex8("C Sharp"));
            Console.WriteLine(Ex8("JS"));
            Console.WriteLine(Ex8("a"));

            // 9. Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
            Console.WriteLine(Ex9("Red"));
            Console.WriteLine(Ex9("Green"));
            Console.WriteLine(Ex9("1"));

            // 10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.
            Console.WriteLine(Ex10(3));
            Console.WriteLine(Ex10(14));
            Console.WriteLine(Ex10(12));
            Console.WriteLine(Ex10(37));

            // 11. Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at 
            // both the front and back. If the given string length is less than 3, use whatever characters are there.
            Console.WriteLine(Ex11("Python"));
            Console.WriteLine(Ex11("JS"));
            Console.WriteLine(Ex11("Code"));

            // 12. Write a C# Sharp program to check if a given string starts with 'C#' or not.
            Console.WriteLine(Ex12("C# Sharp"));
            Console.WriteLine(Ex12("C#"));
            Console.WriteLine(Ex12("C++"));

            // 13. Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.
            Console.WriteLine(Ex13(120, -1));
            Console.WriteLine(Ex13(-1, 120));
            Console.WriteLine(Ex13(2, 120));

            // 14. Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
            Console.WriteLine(Ex14(100, 199));
            Console.WriteLine(Ex14(250, 300));
            Console.WriteLine(Ex14(105, 190));

            // 15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive.
            // Return true if 1 or more of them are in the said range otherwise false.
            Console.WriteLine(Ex15(11, 20, 12));
            Console.WriteLine(Ex15(30, 30, 17));
            Console.WriteLine(Ex15(25, 35, 50));
            Console.WriteLine(Ex15(15, 12, 8));

            // 16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. 
            // Return true if 1 or other is in the said range otherwise false.
            Console.WriteLine(Ex16(20, 84));
            Console.WriteLine(Ex16(14, 50));
            Console.WriteLine(Ex16(11, 45));
            Console.WriteLine(Ex16(25, 40));
            Console.WriteLine(Ex16(56, 57));

            // 17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' 
            // otherwise return the original string.
            Console.WriteLine(Ex17("Python"));
            Console.WriteLine(Ex17("ytade"));
            Console.WriteLine(Ex17("jsues"));

            // 18. Write a C# Sharp program to check the largest number among three given integers.
            Console.WriteLine(Ex18(1, 2, 3));
            Console.WriteLine(Ex18(1, 3, 2));
            Console.WriteLine(Ex18(1, 1, 1));
            Console.WriteLine(Ex18(1, 2, 2));

            // 19. Write a C# Sharp program to check which number nearest to the value 100 among two given integers. Return 0 if the two numbers are equal.
            Console.WriteLine(Ex19(78, 95));
            Console.WriteLine(Ex19(95, 95));
            Console.WriteLine(Ex19(99, 70));

            // 20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.
            Console.WriteLine(Ex20(78, 95));
            Console.WriteLine(Ex20(25, 35));
            Console.WriteLine(Ex20(40, 50));
            Console.WriteLine(Ex20(55, 60));

            // 21. Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, or return 0 if neither is in that range.
            Console.WriteLine(Ex21(78, 95));
            Console.WriteLine(Ex21(20, 30));
            Console.WriteLine(Ex21(21, 25));
            Console.WriteLine(Ex21(28, 28));

            // 22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character.
            Console.WriteLine(Ex22("frizz"));
            Console.WriteLine(Ex22("zane"));
            Console.WriteLine(Ex22("Zazz"));
            Console.WriteLine(Ex22("false"));

            // 23. Write a C# Sharp program to check if two given non-negative integers have the same last digit.
            Console.WriteLine(Ex23(123, 456));
            Console.WriteLine(Ex23(12, 512));
            Console.WriteLine(Ex23(7, 87));
            Console.WriteLine(Ex23(12, 45));

            // 24. Write a C# Sharp program to convert the last 3 characters of a given string in upper case. If the length of the string has less than 3 then uppercase all the characters.
            Console.WriteLine(Ex24("Python"));
            Console.WriteLine(Ex24("Javascript"));
            Console.WriteLine(Ex24("js"));
            Console.WriteLine(Ex24("PHP"));

            // 25. Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string.
            Console.WriteLine(Ex25("JS", 2));
            Console.WriteLine(Ex25("JS", 3));
            Console.WriteLine(Ex25("JS", 1));

            // 26. Write a C# Sharp program to create a new string which is n (non-negative integer) copies of the the first 3 characters of a given string. 
            // If the length of the given string is less than 3 then return n copies of the string.
            Console.WriteLine(Ex26("Python", 2));
            Console.WriteLine(Ex26("Python", 3));
            Console.WriteLine(Ex26("JS", 3));

            // 27. Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa".
            Console.WriteLine(Ex27("bbaaccaag"));
            Console.WriteLine(Ex27("jjkiaaasew"));
            Console.WriteLine(Ex27("JSaaakoiaa"));

            // 28. Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a".
            Console.WriteLine(Ex28("caabb"));
            Console.WriteLine(Ex28("babaaba"));
            Console.WriteLine(Ex28("aaaaa"));

            // 29. Write a C# Sharp program to create a new string made of every other character starting with the first from a given string.
            Console.WriteLine(Ex29("Python"));
            Console.WriteLine(Ex29("PHP"));
            Console.WriteLine(Ex29("JS"));

            // 30. Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd".
            Console.WriteLine(Ex30("abcd"));
            Console.WriteLine(Ex30("abc"));
            Console.WriteLine(Ex30("a"));

            // 31. Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string. Do not count the end substring.
            Console.WriteLine(Ex31("abcdsab"));
            Console.WriteLine(Ex31("abcdabab"));
            Console.WriteLine(Ex31("abcabdabab"));
            Console.WriteLine(Ex31("abcabd"));

            // 32. Write a C# Sharp program to check a specified number is preset in a given array of integers.
            Console.WriteLine(Ex32(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(Ex32(new[] { 1, 2, 2, 3 }, 2));
            Console.WriteLine(Ex32(new[] { 1, 2, 2, 3 }, 9));

            // 33. Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.
            Console.WriteLine(Ex33(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(Ex33(new[] { 1, 2, 3, 4, 5, 6 }, 2));
            Console.WriteLine(Ex33(new[] { 1, 2, 2, 3 }, 9));

            // 34. Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.
            Console.WriteLine(Ex34(new[] { 1, 1, 2, 3, 1 }));
            Console.WriteLine(Ex34(new[] { 1, 1, 2, 4, 1 }));
            Console.WriteLine(Ex34(new[] { 1, 1, 2, 1, 2, 3 }));

            // 35. Write a C# Sharp program to compare two given strings and return the number of the positions where they contain the same length 2 substring.
            Console.WriteLine(Ex35("abcdefgh", "abijsklm"));
            Console.WriteLine(Ex35("abcde", "osuefrcd"));
            Console.WriteLine(Ex35("pqrstuvwx", "pqkdiewx"));

            // 36. Write a C# Sharp program to create a new string from a given string where a specified character have been removed except starting and ending position of the given string
            Console.WriteLine(Ex36("xxHxix", "x"));
            Console.WriteLine(Ex36("abxdddca", "a"));
            Console.WriteLine(Ex36("xabjbhtrb", "b"));

            // 37. Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.
            Console.WriteLine(Ex37("Python"));
            Console.WriteLine(Ex37("JavaScript"));
            Console.WriteLine(Ex37("HTML"));

            // 38. Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. Also count the situation where the second 5 is actually a 6.
            Console.WriteLine(Ex38(new[] { 5, 5, 2 }));
            Console.WriteLine(Ex38(new[] { 5, 5, 2, 5, 5 }));
            Console.WriteLine(Ex38(new[] { 5, 6, 2, 9 }));

            // 39. Write a C# Sharp program to check if a triple is presents in an array of integers or not. If a value appears three times in a row in an array it is called a triple.
            Console.WriteLine(Ex39(new[] { 1, 1, 2, 2, 1 }));
            Console.WriteLine(Ex39(new[] { 1, 1, 2, 1, 2, 3 }));
            Console.WriteLine(Ex39(new[] { 1, 1, 1, 2, 2, 2, 1 }));

            // 40. Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30.
            Console.WriteLine(Ex40(12, 17));
            Console.WriteLine(Ex40(2, 17));
            Console.WriteLine(Ex40(22, 17));
            Console.WriteLine(Ex40(20, 0));

            // 41. Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5.
            Console.WriteLine(Ex41(5, 4));
            Console.WriteLine(Ex41(4, 3));
            Console.WriteLine(Ex41(1, 4));

            // 42. Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13.
            Console.WriteLine(Ex42(13));
            Console.WriteLine(Ex42(14));
            Console.WriteLine(Ex42(27));
            Console.WriteLine(Ex42(41));

            // 43. Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both.
            Console.WriteLine(Ex43(3));
            Console.WriteLine(Ex43(7));
            Console.WriteLine(Ex43(21));

            // 44. Write a C# Sharp program to check if a given number is within 2 of a multiple of 10.
            Console.WriteLine(Ex44(3));
            Console.WriteLine(Ex44(7));
            Console.WriteLine(Ex44(8));
            Console.WriteLine(Ex44(21));

            // 45. Write a C# Sharp program to compute the sum of the two given integers. If one of the given integer value is in the range 10..20 inclusive return 18.
            Console.WriteLine(Ex45(3, 7));
            Console.WriteLine(Ex45(10, 11));
            Console.WriteLine(Ex45(10, 20));
            Console.WriteLine(Ex45(21, 220));

            // 46. Write a C# Sharp program to check whether a given string starts with "F" or ends with "B". If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" 
            // If the string starts with "F" and ends with "B" return "FizzBuzz". In other cases return the original string.
            Console.WriteLine(Ex46("Founder"));
            Console.WriteLine(Ex46("founder"));
            Console.WriteLine(Ex46("club"));
            Console.WriteLine(Ex46("forb"));

            // 47. Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers.
            Console.WriteLine(Ex47(1, 2, 3));
            Console.WriteLine(Ex47(4, 5, 6));
            Console.WriteLine(Ex47(-1, 1, 0));

            // 48. Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.
            Console.WriteLine(Ex48(1, 2, 3));
            Console.WriteLine(Ex48(4, 5, 6));
            Console.WriteLine(Ex48(-1, 1, 0));

            // 49. Write a C# Sharp program to check if three given numbers are in strict increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8.
            // However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7.
            Console.WriteLine(Ex49(1, 2, 3, false));
            Console.WriteLine(Ex49(1, 2, 3, true));
            Console.WriteLine(Ex49(10, 2, 30, false));
            Console.WriteLine(Ex49(10, 10, 30, true));

            // 50. Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit.
            Console.WriteLine(Ex50(11, 21, 31));
            Console.WriteLine(Ex50(11, 22, 31));
            Console.WriteLine(Ex50(11, 22, 33));
            Console.WriteLine(Ex50(11, 257, 9001));

            // 51. Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others.
            Console.WriteLine(Ex51(11, 21, 31));
            Console.WriteLine(Ex51(11, 22, 31));
            Console.WriteLine(Ex51(10, 20, 15));

            // 52. Write a C# Sharp program to find the larger from two given integers. However if the two integers have the same remainder when divided by 7, 
            // then return the smaller integer. If the two integers are the same, return 0.
            Console.WriteLine(Ex52(11, 21));
            Console.WriteLine(Ex52(11, 20));
            Console.WriteLine(Ex52(10, 10));

            // 53. Write a C# Sharp program to check two given integers, each in the range 10..99. 
            // Return true if a digit appears in both numbers, such as the 3 in 13 and 33.
            Console.WriteLine(Ex53(13, 33));
            Console.WriteLine(Ex53(11, 21));
            Console.WriteLine(Ex53(11, 20));
            Console.WriteLine(Ex53(10, 10));

            // 54. Write a C# Sharp program to compute the sum of two given non-negative integers x and y as long as the sum has the same number of digits as x. 
            // If the sum has more digits than x then return x without y.
            Console.WriteLine(Ex54(4, 5));
            Console.WriteLine(Ex54(7, 4));
            Console.WriteLine(Ex54(10, 10));

            // 55. Write a C# Sharp program to compute the sum of three given integers. If the two values are same return the third value.
            Console.WriteLine(Ex55(4, 5, 7));
            Console.WriteLine(Ex55(7, 4, 12));
            Console.WriteLine(Ex55(10, 10, 12));
            Console.WriteLine(Ex55(12, 12, 18));

            // 56. Write a C# Sharp program to compute the sum of the three integers. If one of the values is 13 then do not count it and its right towards the sum.
            Console.WriteLine(Ex56(4, 5, 7));
            Console.WriteLine(Ex56(7, 4, 12));
            Console.WriteLine(Ex56(10, 13, 12));
            Console.WriteLine(Ex56(13, 12, 18));

            // 57. Write a C# Sharp program to compute the sum of the three given integers. However, if any of the values is in the range 10..20 inclusive then that value counts as 0, except 13 and 17.
            Console.WriteLine(Ex57(4, 5, 7));
            Console.WriteLine(Ex57(7, 4, 12));
            Console.WriteLine(Ex57(10, 13, 12));
            Console.WriteLine(Ex57(17, 12, 18));

            // 58. Write a C# Sharp program to check two given integers and return the value whichever value is nearest to 13 without going over. Return 0 if both numbers go over
            Console.WriteLine(Ex58(4, 5));
            Console.WriteLine(Ex58(7, 12));
            Console.WriteLine(Ex58(10, 13));
            Console.WriteLine(Ex58(17, 33));
            Console.WriteLine(Ex58(17, 33));

            // 59. Write a C# Sharp program to check three given integers (small, medium and large) and return true if the difference between small and medium and the difference between medium and large is same. 
            Console.WriteLine(Ex59(4, 5, 6));
            Console.WriteLine(Ex59(7, 12, 13));
            Console.WriteLine(Ex59(-1, 0, 1));

            // 60. Write a C# Sharp program to create a new string using two given strings s1, s2, the format of the new string will be s1s2s2s1.
            Console.WriteLine(Ex60("Hi", "Hello"));
            Console.WriteLine(Ex60("whats", "app"));

            // 61. Write a C# Sharp program to insert a given string into middle of the another given string of length 4.
            Console.WriteLine(Ex61("[[]]", "Hello"));
            Console.WriteLine(Ex61("(())", "Hi"));

            // 62. Write a C# Sharp program to create a new string using three copies of the last two character of a given string of length atleast two.
            Console.WriteLine(Ex62("Hello"));
            Console.WriteLine(Ex62("Hi"));

            // 63. Write a C# Sharp program to create a new string using first two characters of a given string. If the string length is less than 2 then return the original string.. 
            Console.WriteLine(Ex63("Hello"));
            Console.WriteLine(Ex63("Hi"));
            Console.WriteLine(Ex63("H"));
            Console.WriteLine(Ex63(" "));

            // 64. Write a C# Sharp program to create a new string of the first half of a given string of even length.
            Console.WriteLine(Ex64("Hello"));
            Console.WriteLine(Ex64("Hi"));

            // 65. Write a C# Sharp program to create a new string without the first and last character of a given string of length atleast two.
            Console.WriteLine(Ex65("Hello"));
            Console.WriteLine(Ex65("Hi"));
            Console.WriteLine(Ex65("Python"));

            // 66. Write a C# Sharp program to create a new string from two given string one is shorter and another is longer. The format of the new string will be long string + short string + long string.
            Console.WriteLine(Ex66("Hello", "Hi"));
            Console.WriteLine(Ex66("JS", "Python"));

            // 67. Write a C# Sharp program to concat two given string of length atleast 1, after removing their first character.
            Console.WriteLine(Ex67("Hello", "Hi"));
            Console.WriteLine(Ex67("JS", "Python"));

            // 68. Write a C# Sharp program to move the first two characters to the end of a given string of length at least two.
            Console.WriteLine(Ex68("Hello"));
            Console.WriteLine(Ex68("JS"));

            // 69. Write a C# Sharp program to move the last two characters to the start of a given string of length at least two.
            Console.WriteLine(Ex69("Hello"));
            Console.WriteLine(Ex69("JS"));

            // 70. Write a C# Sharp program to create a new string without the first and last character of a given string of any length.
            Console.WriteLine(Ex70("Hello"));
            Console.WriteLine(Ex70("JS"));
            Console.WriteLine(Ex70(""));

            // 71. Write a C# Sharp program to create a new string using the two middle characters of a given string of even length (at least 2).
            Console.WriteLine(Ex71("Hello"));
            Console.WriteLine(Ex71("JS"));
            Console.WriteLine(Ex71("Python"));

            // 72. Write a C# Sharp program to check if a given string ends with "on"
            Console.WriteLine(Ex72("Hello"));
            Console.WriteLine(Ex72("Python"));
            Console.WriteLine(Ex72("on"));
            Console.WriteLine(Ex72("o"));

            // 73. Write a C# Sharp program to create a new string using the first and last n characters from a given string of length at least n.
            Console.WriteLine(Ex73("Hello", 1));
            Console.WriteLine(Ex73("Python", 2));
            Console.WriteLine(Ex73("on", 1));
            Console.WriteLine(Ex73("o", 1));

            // 74. Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string.
            Console.WriteLine(Ex74("Hello", 1));
            Console.WriteLine(Ex74("Python", 2));
            Console.WriteLine(Ex74("on", 1));

            // 75. Write a C# Sharp program to create a new string taking 3 characters from the middle of a given string at least 3.
            Console.WriteLine(Ex75("Hello"));
            Console.WriteLine(Ex75("Python"));
            Console.WriteLine(Ex75("abc"));

            // 76. Write a C# Sharp program to create a new string of length 2, using first two characters of a given string. 
            // If the given string length is less than 2 use '#' as missing characters.
            Console.WriteLine(Ex76("Hello"));
            Console.WriteLine(Ex76("Python"));
            Console.WriteLine(Ex76("a"));
            Console.WriteLine(Ex76(""));

            // 77. Write a C# Sharp program to create a new string taking the first character from a given string and the last character from another given string. 
            // If the length of any given string is 0, use '#' as its missing character.
            Console.WriteLine(Ex77("Hello", "Hi"));
            Console.WriteLine(Ex77("Python", "PHP"));
            Console.WriteLine(Ex77("JS", "JS"));
            Console.WriteLine(Ex77("Csharp", ""));

            // 78. Write a C# Sharp program to concat two given strings. If there are any double character in new string then omit one character.
            Console.WriteLine(Ex78("Hello", "Hi"));
            Console.WriteLine(Ex78("Python", "PHP"));
            Console.WriteLine(Ex78("PHP", "PHP"));

            // 79. Write a C# Sharp program to create a new string from a given string after swapping last two characters.
            Console.WriteLine(Ex79("Hello"));
            Console.WriteLine(Ex79("Python"));
            Console.WriteLine(Ex79("PHP"));
            Console.WriteLine(Ex79("JS"));
            Console.WriteLine(Ex79("C"));

            // 80. Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'. 
            // If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return the empty string.
            Console.WriteLine(Ex80("abc"));
            Console.WriteLine(Ex80("abcdef"));
            Console.WriteLine(Ex80("C"));
            Console.WriteLine(Ex80("xyz"));
            Console.WriteLine(Ex80("xyzsder"));

            // 81. Write a C# Sharp program to check whether the first two characters and last two characters of a given string are same.
            Console.WriteLine(Ex81("abab"));
            Console.WriteLine(Ex81("abcdef"));
            Console.WriteLine(Ex81("xyzsderxy"));

            // 82.Write a C# Sharp program to concat two given strings. If the given strings have different length remove the characters from the longer string.
            Console.WriteLine(Ex82("abc", "abcd"));
            Console.WriteLine(Ex82("Python", "Python"));
            Console.WriteLine(Ex82("JS", "Python"));

            // 83. Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string. If the length of the given string is less than 2 use the whole string.
            Console.WriteLine(Ex83("abc"));
            Console.WriteLine(Ex83("Python"));
            Console.WriteLine(Ex83("J"));

            // 84. Write a C# Sharp program to create a new string from a given string. If the two characters of the given string from its beginning and end are same return the given string without 
            // the first two characters otherwise return the original string.
            Console.WriteLine(Ex84("abcab"));
            Console.WriteLine(Ex84("Python"));

            // 85. Write a C# Sharp program to create a new string from a given string without the first two characters. Keep the first character if it is "p" and keep the second character if it is "y".
            Console.WriteLine(Ex85("abcab"));
            Console.WriteLine(Ex85("python"));
            Console.WriteLine(Ex85("press"));
            Console.WriteLine(Ex85("jython"));

            // 86. Write a C# Sharp program to create a new string from a given string without the first and last character if the first or last characters are 'a' otherwise return the original given string.
            Console.WriteLine(Ex86("abcab"));
            Console.WriteLine(Ex86("python"));
            Console.WriteLine(Ex86("abcda"));
            Console.WriteLine(Ex86("jython"));

            // 87. Write a C# Sharp program to create a new string from a given string. If the first or first two characters is 'a', return the string without those 'a' characters otherwise return the original given string.
            Console.WriteLine(Ex87("abcab"));
            Console.WriteLine(Ex87("python"));
            Console.WriteLine(Ex87("aacda"));
            Console.WriteLine(Ex87("jython"));

            // 88. Write a C# Sharp program to check a given array of integers of length 1 or more and return true if 10 appears as either first or last element in the given array.
            Console.WriteLine(Ex88(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(Ex88(new[] { 5, 20, 40, 10 }));
            Console.WriteLine(Ex88(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(Ex88(new[] { 12, 24, 35, 55 }));

            // 89. Write a C# Sharp program to check a given array of integers of length 1 or more and return true if the first element and the last element are equal in the given array.
            Console.WriteLine(Ex89(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(Ex89(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(Ex89(new[] { 12, 24, 35, 55 }));

            // 90. Write a C# Sharp program to check two given arrays of integers of length 1 or more and return true if they have the same first element or they have the same last element.
            Console.WriteLine(Ex90(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 50 }));
            Console.WriteLine(Ex90(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 5 }));
            Console.WriteLine(Ex90(new[] { 10, 20, 40, 50 }, new[] { 1, 20, 40, 5 }));

            // 91. Write a C# Sharp program to compute the sum of the elements of an given array of integers.
            Console.WriteLine(Ex91(new[] { 10, 20, 30, 40, 50 }));
            Console.WriteLine(Ex91(new[] { 10, 20, -30, -40, 50 }));

            // 92. Write a C# Sharp program to rotate the elements of a given array of integers (length 4 ) in left direction and return the new array.
            int[] item = Ex92(new[] { 10, 20, -30, -40 });
            Console.Write("Rotated array: ");
            foreach (var i in item) Console.Write(i.ToString() + " ");

            // 93. Write a C# Sharp program to reverse a given array of integers and length 4.
            int[] a = Ex93(new[] { 10, 20, -30, -40, 50 });
            Console.Write("Reverse array: ");
            foreach (var i in a) Console.Write(i.ToString() + " ");

            // 94. Write a C# Sharp program to find out the maximum element between the first or last element in a given array of integers ( length 4), replace all elements with maximum element.
            int[] b = Ex94(new[] { 10, 20, -30, -40 });
            Console.Write("New array: ");
            foreach (var i in b) Console.Write(i.ToString() + " ");

            // 95. Write a C# Sharp program to create a new array containing the middle elements from the two given arrays of integers, each length 5.
            int[] c = Ex95(new[] { 10, 20, -30, -40, 30 }, new[] { 10, 20, 30, 40, 30 });
            Console.Write("New array: ");
            foreach (var i in c) Console.Write(i.ToString() + " ");

            // 96. Write a C# Sharp program to create a new array taking  the first and last elements of a given array of integers and length 1 or more.
            int[] d = Ex96(new[] { 10, 20, -30, -40, 30 });
            Console.Write("New array: ");
            foreach (var i in d) Console.Write(i.ToString() + " ");

            // 97. Write a C# Sharp program to check if a given array of integers and length 2, contains 15 or 20.
            Console.WriteLine(Ex97(new[] { 12, 20 }));
            Console.WriteLine(Ex97(new[] { 14, 15 }));
            Console.WriteLine(Ex97(new[] { 11, 21 }));

            // 98. Write a C# Sharp program to check if a given array of integers and length 2, does not contain 15 or 20.
            Console.WriteLine(Ex98(new[] { 12, 20 }));
            Console.WriteLine(Ex98(new[] { 14, 15 }));
            Console.WriteLine(Ex98(new[] { 11, 21 }));

            // 99. Write a C# Sharp program to create a new array of integers and length 1 or more. The length of the new array will be double length
            // of the given array and all the elements are 1 except the first element which is equal to the given array.
            int[] e = Ex99(new[] { 10, 20, -30, -40, 30 });
            Console.Write("New array: ");
            foreach (var i in e) Console.Write(i.ToString() + " ");

            // 100. Write a C# Sharp program to check a given array of integers and return true if the array contains 10 or 20 twice. 
            // The length of the array will be 0, 1, or 2.
            Console.WriteLine(Ex100(new[] { 12, 20 }));
            Console.WriteLine(Ex100(new[] { 20, 20 }));
            Console.WriteLine(Ex100(new[] { 10, 10 }));
            Console.WriteLine(Ex100(new[] { 10 }));

            // 101. Write a C# Sharp program to check a given array of integers, length 3 and create a new array. 
            // If there is a 5 in the given array immediately followed by a 7 then set 7 to 1.
            int[] f = Ex101(new[] { 1, 5, 7 });
            Console.Write("New array: ");
            foreach (var i in f) Console.Write(i.ToString() + " ");

            // 102. Write a C# Sharp program to compute the sum of the two given arrays of integers, length 3 and find the array which has the largest sum.
            int[] g = Ex102(new[] { 10, 20, -30 }, new[] { 10, 20, 30 });
            Console.Write("Larger array: ");
            foreach (var i in g) Console.Write(i.ToString() + " ");

            // 103. Write a C# Sharp program to create an array taking two middle elements from a given array of integers of length even.
            int[] h = Ex103(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("New array: ");
            foreach (var i in h) Console.Write(i.ToString() + " ");

            // 104. Write a C# Sharp program to create a new array from two give array of integers, each length 3.
            int[] j = Ex104(new[] { 10, 20, 30 }, new[] { 40, 50, 60 });
            Console.Write("New array: ");
            foreach (var i in j) Console.Write(i.ToString() + " ");

            // 105. Write a C# Sharp program to create a new array swapping the first and last elements of a given array of integers and length will be least 1.
            int[] k = Ex105(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("After swapping first and last elements: ");
            foreach (var i in k) Console.Write(i.ToString() + " ");

            // 106. Write a C# Sharp program to create a new array length 3 from a given array (length atleast 3) using the elements from the middle of the array. 
            int[] l = Ex106(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("New array: ");
            foreach (var i in l) Console.Write(i.ToString() + " ");

            // 107. Write a C# Sharp program to find the largest value from first, last, and middle elements of a given array of integers of odd length (atleast 1).
            Console.WriteLine(Ex107(new[] { 1 }));
            Console.WriteLine(Ex107(new[] { 1, 2, 9 }));
            Console.WriteLine(Ex107(new[] { 1, 2, 9, 3, 3 }));
            Console.WriteLine(Ex107(new[] { 1, 2, 3, 4, 5, 6, 7 }));
            Console.WriteLine(Ex107(new[] { 1, 2, 2, 3, 7, 8, 9, 10, 6, 5, 4 }));

            // 108. Write a C# Sharp program to create a new array taking the first two elements from a given array. If the length of the given array is less than 2 then return the given array.
            int[] m = Ex108(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("New array: ");
            foreach (var i in m) Console.Write(i.ToString() + " ");

            // 109. Write a C# Sharp program to count even number of elements in a given array of integers.
            Console.WriteLine(Ex109(new[] { 1, 5, 7, 9, 10, 12 }));

            // 110. Write a C# Sharp program to compute the difference between the largest and smallest values in a given array of integers and length one or more.
            Console.WriteLine("Difference between the largest and smallest values: ");
            Console.WriteLine(Ex110(new[] { 1, 5, 7, 9, 10, 12 }));

            // 111. Write a C# Sharp program to compute the sum of values in a given array of integers except the number 17. Return 0 if the given array has no integer.
            Console.WriteLine("Sum of values in the array of integers except the number 17: ");
            Console.WriteLine(Ex111(new[] { 1, 5, 7, 9, 10, 17 }));

            // 112. Write a C# Sharp program to compute the sum of the numbers in a given array except those numbers starting with 5 followed by atleast one 6. Return 0 if the given array has no integer.
            Console.WriteLine("Sum of the numbers of the said array except those numbers starting with 5 followed by atleast one 6: ");
            Console.WriteLine(Ex112(new[] { 1, 5, 6, 9, 10, 17 }));

            // 113. Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere.
            Console.WriteLine(Ex113(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(Ex113(new[] { 1, 5, 5, 9, 10, 17 }));
            //Console.WriteLine(Ex113(new[] { 1, 5, 5, 9, 10, 17, 5, 5 }));

            // 114. Write a C# Sharp program to check whether a given array of integers contains 5's and 7's.
            Console.WriteLine(Ex114(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(Ex114(new[] { 1, 4, 7, 9, 10, 17 }));
            Console.WriteLine(Ex114(new[] { 1, 1, 2, 9, 10, 17 }));

            // 115. Write a C# Sharp program to check if the sum of all 5's in the array exactly 15 in a given array of integers. 
            Console.WriteLine(Ex115(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(Ex115(new[] { 1, 5, 5, 5, 10, 17 }));
            Console.WriteLine(Ex115(new[] { 1, 1, 5, 5, 5, 5 }));

            // 116. Write a C# Sharp program to check if the number of 3's is greater than the number of 5's
            Console.WriteLine(Ex116(new[] { 1, 5, 6, 9, 3, 3 }));
            Console.WriteLine(Ex116(new[] { 1, 5, 5, 5, 10, 17 }));
            Console.WriteLine(Ex116(new[] { 1, 3, 3, 5, 5, 5 }));

            // 117. Write a C# Sharp program to check if a given array of integers contains a 3 or a 5.
            Console.WriteLine(Ex117(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(Ex117(new[] { 3, 3, 3, 3 }));
            Console.WriteLine(Ex117(new[] { 3, 3, 3, 5, 5, 5 }));
            Console.WriteLine(Ex117(new[] { 1, 6, 8, 10 }));

            // 118. Write a C# Sharp program to check if a given array of integers contains no 3 or a 5.
            Console.WriteLine(Ex118(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(Ex118(new[] { 3, 3, 3, 3 }));
            Console.WriteLine(Ex118(new[] { 3, 3, 3, 5, 5, 5 }));
            Console.WriteLine(Ex118(new[] { 1, 6, 8, 10 }));

            // 119. Write a C# Sharp program to check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both. 
            Console.WriteLine(Ex119(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(Ex119(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(Ex119(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(Ex119(new[] { 1, 5, 5, 7, 8, 10 }));

            // 120. Write a C# Sharp program to check a given array of integers and return true if the given array contains two 5's next to each other
            // , or two  5 separated by one element.
            Console.WriteLine(Ex120(new[] { 5, 5, 1, 5, 5 }));
            Console.WriteLine(Ex120(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(Ex120(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(Ex120(new[] { 1, 5, 5, 7, 8, 10 }));
            Console.WriteLine(Ex120(new[] { 1, 2, 5, 6, 5 }));

            // 121. Write a C# Sharp program to check a given array of integers and return true if there is a 3 with a 5 somewhere later in the given array.
            Console.WriteLine(Ex121(new[] { 3, 5, 1, 3, 7 }));
            Console.WriteLine(Ex121(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(Ex121(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(Ex121(new[] { 2, 5, 5, 7, 8, 10 }));

            // 122. Write a C# Sharp program to check a given array of integers and return true if the given array contains either 2 even or 2 odd values all next to each other.
            Console.WriteLine(Ex122(new[] { 3, 5, 1, 3, 7 }));
            Console.WriteLine(Ex122(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(Ex122(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(Ex122(new[] { 2, 4, 5, 6 }));

            // 123. Write a C# Sharp program to check a given array of integers and return true if the value 5 appears 5 times and there are no 5 next to each other.
            Console.WriteLine(Ex123(new[] { 3, 5, 1, 5, 3, 5, 7, 5, 1, 5 }));
            Console.WriteLine(Ex123(new[] { 3, 5, 5, 5, 5, 5, 5 }));
            Console.WriteLine(Ex123(new[] { 3, 5, 2, 5, 4, 5, 7, 5, 8, 5 }));
            Console.WriteLine(Ex123(new[] { 2, 4, 5, 5, 5, 5 }));
            Console.WriteLine(Ex123(new[] { 2, 5, 2, 5, 2, 5, 2, 5 }));

            // 124. Write a C# Sharp program to check a given array of integers and return true if every 5 that appears in the given array is next to another 5. 
            Console.WriteLine(Ex124(new[] { 3, 5, 5, 3, 7 }));
            Console.WriteLine(Ex124(new[] { 3, 5, 5, 4, 1, 5, 7 }));
            Console.WriteLine(Ex124(new[] { 3, 5, 5, 5, 5, 5 }));
            Console.WriteLine(Ex124(new[] { 2, 4, 5, 5, 6, 7, 5 }));

            // 125. Write a C# Sharp program to check a given array of integers and return true if the specified number of same elements appears at the start and end of the given array.
            Console.WriteLine(Ex125(new[] { 3, 7, 5, 5, 3, 7 }, 2));
            Console.WriteLine(Ex125(new[] { 3, 7, 5, 5, 3, 7 }, 3));
            Console.WriteLine(Ex125(new[] { 3, 7, 5, 5, 3, 7, 5 }, 3));

            // 126. Write a C# Sharp program to check a given array of integers and return true if the array contains three increasing adjacent numbers.
            Console.WriteLine(Ex126(new[] { 1, 2, 3, 5, 3, 7 }));
            Console.WriteLine(Ex126(new[] { 3, 7, 5, 5, 3, 7 }));
            Console.WriteLine(Ex126(new[] { 3, 7, 5, 5, 6, 7, 5 }));

            // 127. Write a C# Sharp program to shift an element in left direction and return a new array.
            int[] n = Ex127(new[] { 10, 20, -30, -40, 50 });
            Console.Write("New array: ");
            foreach (var i in n)
            {
                Console.Write(i.ToString() + " ");
            }

            // 128. Write a C# Sharp program to create a new array taking the elements before the element value 5 from a given array of integers.
            int[] o = Ex128(new[] { 1, 2, 3, 5, 7 });
            Console.Write("New array: ");
            foreach (var i in o)
            {
                Console.Write(i.ToString() + " ");
            }

            // 129. Write a C# Sharp program to create a new array taking the elements after the element value 5 from a given array of integers.
            int[] p = Ex129(new[] { 1, 2, 3, 5, 7, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in p)
            {
                Console.Write(i.ToString() + " ");
            }

            // 130. Write a C# Sharp program to create a new array from a given array of integers shifting all zeros to left direction.
            int[] q = Ex130(new[] { 1, 2, 0, 3, 5, 7, 0, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in q)
            {
                Console.Write(i.ToString() + " ");
            }

            // 131. Write a C# Sharp program to create a new array after replacing all the values 5 with 0 shifting all zeros to right direction.
            int[] r = Ex131(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in r)
            {
                Console.Write(i.ToString() + " ");
            }

            // 132. Write a C# Sharp program to create new array from a given array of integers shifting all even numbers before all odd numbers.
            int[] s = Ex132(new[] { 1, 2, 5, 3, 5, 4, 6, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in s)
            {
                Console.Write(i.ToString() + " ");
            }

            // 133. Write a C# Sharp program to check if the value of each element is equal or greater than the value of previous element of a given array of integers.
            Console.WriteLine(Ex133(new[] { 5, 5, 1, 5, 5 }));
            Console.WriteLine(Ex133(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(Ex133(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(Ex133(new[] { 1, 5, 5, 7, 8, 10 }));

            // 134. Write a C# Sharp program to check a given array (length will be atleast 2) of integers and return true if there are two values 15, 15 next to each other.
            Console.WriteLine(Ex134(new[] { 5, 5, 1, 15, 15 }));
            Console.WriteLine(Ex134(new[] { 15, 2, 3, 4, 15 }));
            Console.WriteLine(Ex134(new[] { 3, 3, 15, 15, 5, 5 }));
            Console.WriteLine(Ex134(new[] { 1, 5, 15, 7, 8, 15 }));
            Console.WriteLine(Ex134(new[] { 1, 2, 3 }));

            // 135. Write a C# Sharp program to find the larger average value between the first and the second half of a given array of integers and minimum length is atleast 2. 
            // Assume that the second half begins at index (array length)/2. 
            Console.WriteLine(Ex135(new[] { 1, 2, 3, 4, 6, 8 }));
            Console.WriteLine(Ex135(new[] { 15, 2, 3, 4, 15, 11 }));

            // 136. Write a C# Sharp program to count the number of strings with given length in given array of strings.
            Console.WriteLine(Ex136(new[] { "a", "b", "bb", "c", "ccc" }, 1));

            // 137. Write a C# Sharp program to create a new array using the first n strings from a given array of strings. 
            // (n>=1 and <=length of the array).
            string[] t = Ex137(new[] { "a", "b", "bb", "c", "ccc" }, 3);
            Console.Write("New array: ");
            foreach (var i in t)
            {
                Console.Write(i.ToString() + " ");
            }

            // 138. Write a C# Sharp program to create a new array from a given array of strings using all the strings whose length are matched with given string length.
            string[] u = Ex138(new[] { "a", "aaa", "b", "bbb", "c", "ccc" }, 3);
            Console.Write("New array: ");
            foreach (var i in u)
            {
                Console.Write(i.ToString() + " ");
            }

            // 139. Write a C# Sharp program to check a positive integer and return true if it contains a number 2.
            Console.WriteLine(Ex139(123));
            Console.WriteLine(Ex139(13));
            Console.WriteLine(Ex139(222));

            // 140. Write a C# Sharp program to create a new array of given length using the odd numbers from a given array of positive integers.
            int[] v = Ex140(new[] { 1, 2, 3, 5, 7, 9, 10 }, 3);
            Console.Write("New array: ");
            foreach (var i in v)
            {
                Console.Write(i.ToString() + " ");
            }

            // 141. Write a C# Sharp program to create a new list from a given list of integers where each element is multiplied by 3.
            List<int> mylist = Ex141(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }

            // 142. Write a C# Sharp program to create a new list from a given list of integers where each integer multiplied by itself three times.
            List<int> mylist2 = Ex142(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist2)
            {
                Console.Write(i.ToString() + " ");
            }

            // 143. Write a C# Sharp program to create a new list from a given list of strings where each element has "#" added at the beginning and end position.
            List<string> mylist3 = Ex143(new List<string>(new string[] { "1", "2", "3", "4" }));
            foreach (var i in mylist3)
            {
                Console.Write(i.ToString() + " ");
            }

            // 144. Write a C# Sharp program to create a new list from a given list of strings where each element is replaced by 4 copies of the string concatenated together.
            List<string> mylist4 = Ex144(new List<string>(new string[] { "1", "2", "3", "4" }));
            foreach (var i in mylist4)
            {
                Console.Write(i.ToString() + " ");
            }

            // 145. Write a C# Sharp program to create a new list from a given list of integers where each integer value is added to 2 and the result value is multiplied by 5.
            List<int> mylist5 = Ex145(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist5)
            {
                Console.Write(i.ToString() + " ");
            }

            // 146. Write a C# Sharp program to create a new list of the rightmost digits from a given list of positive integers. 
            List<int> mylist6 = Ex146(new List<int>(new int[] { 10, 22, 35, 41 }));
            foreach (var i in mylist6)
            {
                Console.Write(i.ToString() + " ");
            }

            // 147. Write a C# Sharp program to create a new list from a given list of strings where strings will be in upper case in new string.
            List<string> mylist7 = Ex147(new List<string>(new string[] { "Abc", "cdef", "js", "php" }));
            foreach (var i in mylist7)
            {
                Console.Write(i.ToString() + " ");
            }

            // 148. Write a C# Sharp program to remove all "a" in each string in given list of strings and return the new string. 
            List<string> mylist8 = Ex148(new List<string>(new string[] { "abc", "cdaef", "js", "php" }));
            foreach (var i in mylist8)
            {
                Console.Write(i.ToString() + " ");
            }

            // 149. Write a C# Sharp program to create a new list from a given list of integers removing those values which are less than 4.
            List<int> mylist9 = Ex149(new List<int>(new int[] { 0, -2, 1, 2, 3, 5, 4, 7, 8 }));
            foreach (var i in mylist9)
            {
                Console.Write(i.ToString() + " ");
            }

            // 150. Write a C# Sharp program to create a new list from a given list of integers removing those values end with 7.
            List<int> mylist10 = Ex150(new List<int>(new int[] { 10, 22, 35, 47, 53, 67 }));
            foreach (var i in mylist10)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadLine();
        }

        private static int Ex1(int n1, int n2)
        {
            return n1 == n2 ? (n1 + n2) * 3 : n1 + n2;
        }
        private static int Ex2(int n)
        {
            int i = 51;
            return n > i ? (n - i) * 3 : i - n;
        }
        private static bool Ex3(int n1, int n2)
        {
            return (n1 == 30 || n2 == 30) || n1 + n2 == 30 ? true : false;
        }
        private static bool Ex4(int n)
        {
            int range = 10;
            return Math.Abs(n - 100) <= range || Math.Abs(n - 200) <= range ? true : false;
        }
        private static string Ex5(string yourString)
        {
            return yourString.ToLower().StartsWith("if") ? yourString : "if " + yourString;
        }
        private static string Ex6(string yourString, int position)
        {
            return yourString.Remove(position, 1);
        }
        private static string Ex7(string yourString)
        {
            char[] letters = yourString.ToCharArray();
            int size = letters.Length - 1;

            StringBuilder retVal = new StringBuilder();
            retVal.Append(letters[size]);

            for (int i = 1; i < size; i++) retVal.Append(letters[i]);
            retVal.Append(letters[0]);

            return string.Join(null, retVal);
        }
        public static string Ex7Better(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
        public static string Ex8(string yourString)
        {
            StringBuilder retVal = new StringBuilder();
            if (yourString.Length < 2) return yourString;
            for (int i = 0; i < 4; i++) retVal.Append(yourString.Substring(0, 2));
            return retVal.ToString();
        }
        public static string Ex9(string yourString)
        {
            string letter = yourString.Substring(yourString.Length - 1);
            return yourString.Length < 1 ? yourString
                : letter + yourString + letter;
        }
        public static bool Ex10(int n)
        {
            if (n < 3) return false;
            return n % 3 == 0 || n % 7 == 0 ? true : false;
        }
        private static string Ex11(string yourString)
        {
            int size = 3;
            StringBuilder retVal = new StringBuilder();
            if (yourString.Length < size) for (int i = 0; i < 2; i++) retVal.Append(yourString);
            else
            {
                string letters = yourString.Substring(0, size);
                retVal.Append(letters);
                retVal.Append(yourString);
                retVal.Append(letters);
            }
            return retVal.ToString();
        }
        private static bool Ex12(string yourString, string startsWith = "C#")
        {
            return yourString.ToLower().StartsWith(startsWith.ToLower()) ? true : false;
        }
        private static bool Ex13(int temp1, int temp2)
        {
            int min = 0, max = 100;
            return (temp1 < min && temp2 > max) || (temp2 < min && temp1 > max) ? true : false;
        }
        private static bool Ex14(int n1, int n2)
        {
            int min = 100, max = 200;
            return (n1 >= min && n1 <= max) || (n2 >= min && n2 <= max) ? true : false;
        }
        private static bool Ex15(int n1, int n2, int n3)
        {
            int min = 20, max = 50;
            return (n1 >= min && n1 <= max) || (n2 >= min && n2 <= max) || (n3 >= min && n3 <= max) ? true : false;
        }
        private static bool Ex16(int n1, int n2)
        {
            int min = 20, max = 50;
            return (n1 >= min && n2 <= max) || (n2 >= min && n1 <= max);
        }
        private static string Ex17(string yourString)
        {
            return yourString.Substring(1, 2).ToString().ToLower() == "yt" ? yourString.Remove(1, 2) : yourString;
        }
        private static int Ex18(int n1, int n2, int n3)
        {
            return Math.Max(Math.Max(n1, n2), n3);
        }
        private static int Ex19(int n1, int n2)
        {
            if (n1 == n2) return 0;
            int max = 100;
            return Math.Abs(n1 - max) < Math.Abs(n2 - max) ? n1 : n2;
        }
        private static bool Ex20(int n1, int n2)
        {
            int lower1 = 40, lower2 = 50, increment = 10;
            return (n1 >= lower1 && n2 <= lower1 + increment) || (n2 >= lower1 && n1 <= lower1 + increment)
                || (n1 >= lower2 && n2 <= lower2 + increment) || (n2 >= lower2 && n1 <= lower2 + increment)
                ? true : false;
        }
        private static int Ex21(int n1, int n2)
        {
            int lower = 20, max = 30;
            return (n1 >= lower && n1 <= max) || (n2 >= lower && n2 <= max) ? Math.Max(n1, n2) : 0;
        }
        private static bool Ex22(string yourString)
        {
            string toStrip = "z";
            return (yourString.Replace(toStrip, null).Length <= yourString.Length - 2) || (yourString.Replace(toStrip, null).Length <= yourString.Length - 4);
        }
        private static bool Ex23(int n1, int n2)
        {
            if (n1 < 0 || n2 < 0) return false;
            char[] n1Array = n1.ToString().ToCharArray(), n2Array = n2.ToString().ToCharArray();
            return n1Array[n1Array.Length - 1] == n2Array[n2Array.Length - 1];
        }
        private static string Ex24(string yourString)
        {
            int len = yourString.Length, size = 3;
            return (len < size) ? yourString.ToUpper()
                : yourString.Substring(0, len - size) + yourString.Substring(len - size, size).ToUpper();
        }
        private static string Ex25(string yourString, int n)
        {
            StringBuilder retVal = new StringBuilder();
            for (int i = 0; i < n; i++) retVal.Append(yourString);
            return retVal.ToString();
        }
        private static string Ex26(string yourString, int n)
        {
            int len = 3;
            StringBuilder retVal = new StringBuilder();
            if (yourString.Length < len) for (int i = 0; i < n; i++) retVal.Append(yourString);
            else
            {
                string first = yourString.Substring(0, len);
                for (int i = 0; i < n; i++) retVal.Append(first);
            }
            return retVal.ToString();
        }
        private static int Ex27(string yourString)
        {
            int retVal = 0, len = yourString.Length - 1;
            for (int i = 0; i < len; i++) if (yourString.Substring(i, 2) == "aa") retVal++;
            return retVal;
        }
        private static bool Ex28(string yourString)
        {
            return yourString.ToLower().Substring(yourString.IndexOf("a"), 2) == "aa";
        }
        private static string Ex29(string yourString)
        {
            int length = yourString.Length;
            StringBuilder retVal = new StringBuilder();
            for (int i = 0; i < length; i += 2) retVal.Append(yourString.Substring(i, 1));
            return retVal.ToString();
        }
        private static string Ex30(string yourString)
        {
            int length = yourString.Length;
            StringBuilder retVal = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                retVal.Append(yourString.Substring(0, i + 1));
            }
            return retVal.ToString();
        }
        private static int Ex31(string yourString)
        {
            int length = yourString.Length - 2, retVal = 0;
            string last2 = yourString.Substring(length);
            for (int i = 0; i < length; i++) if (yourString.Substring(i, 2) == last2) retVal++;
            return retVal;
        }
        private static bool Ex32(int[] intArray, int n)
        {
            return intArray.Contains(n);
        }
        private static bool Ex33(int[] intArray, int n)
        {
            return intArray.Length < 4 ? intArray.Contains(n) : intArray.Take(4).Contains(n);
        }
        private static bool Ex34(int[] intArray)
        {
            int length = intArray.Length - 1;
            for (int i = 0; i < length; i++) if (intArray[i] == 1 && intArray[i + 1] == 2 && intArray[i + 2] == 3) return true;
            return false;
        }
        private static int Ex35(string str1, string str2)
        {
            int str1Len = str1.Length - 1, str2Len = str2.Length - 1, retVal = 0;
            for (int i = 0; i < str1Len; i++)
            {
                string mySubString = str1.Substring(i, 2);
                for (int n = 0; n < str2Len; n++) if (mySubString == str2.Substring(n, 2)) retVal++;
            }
            return retVal;
        }
        private static string Ex36(string yourString, string toRemove)
        {
            int length = yourString.Length - 1;
            return yourString.Substring(0, 1) + yourString.Substring(1, length - 1).Replace(toRemove, null) + yourString.Substring(length);
        }
        private static string Ex37(string yourString)
        {
            int[] positions = { 0, 1, 4, 5, 8, 9 };
            StringBuilder retVal = new StringBuilder();

            foreach (int num in positions)
            {
                if (num > yourString.Length - 1) break;
                retVal.Append(yourString.Substring(num, 1));
            }
            return retVal.ToString();
        }
        private static int Ex38(int[] intArray)
        {
            int retVal = 0, length = intArray.Length - 1;
            for (int i = 0; i < length; i++) if (intArray[i] == 5 && (intArray[i + 1] == 5 || intArray[i + 1] == 6)) retVal++;
            return retVal;
        }
        private static bool Ex39(int[] intArray)
        {
            int length = intArray.Length - 1, n = 0;
            for (int i = 0; i < length; i++)
            {
                n = intArray[i];
                if (n == intArray[i + 1] && n == intArray[i + 2]) return true;
            }
            return false;
        }
        private static int Ex40(int n1, int n2)
        {
            int retVal = n1 + n2;
            return retVal >= 10 && retVal <= 20 ? 30 : retVal;
        }
        private static bool Ex41(int n1, int n2)
        {
            int n = 5;
            return n1 == n || n2 == n || n1 + n2 == n || Math.Abs(n1 - n2) == n;
        }
        private static bool Ex42(int n)
        {
            int multiple = 13;
            return (n % multiple == 0) || ((n - 1) % multiple) == 0;
        }
        private static bool Ex43(int n)
        {
            int lower = 3, upper = 7;
            return n % lower == 0 && n % upper == 0 ? false
                : n % lower == 0 || n % upper == 0;
        }
        private static bool Ex44(int n)
        {
            return n % 10 <= 2 || n % 10 >= 8;
        }
        private static int Ex45(int num1, int num2)
        {
            int lower = 10, upper = 20;
            return (num1 >= lower && num1 <= upper) || (num2 >= lower && num2 <= upper) ? 18 : num1 + num2;
        }
        private static string Ex46(string yourString)
        {
            if (yourString.StartsWith("F") && yourString.EndsWith("B")) return "FizzBuzz";
            if (yourString.StartsWith("F")) return "Fizz";
            return yourString.StartsWith("B") ? "Buzz" : yourString;
        }
        private static bool Ex47(int n1, int n2, int n3)
        {
            return n1 == n2 + n3 || n2 == n1 + n3 || n3 == n1 + n2;
        }
        private static bool Ex48(int x, int y, int z)
        {
            return y > x && z > y;
        }
        private static bool Ex49(int x, int y, int z, bool allowEquality)
        {
            return allowEquality ? x <= y && y <= z : x < y && y < z;
        }
        private static bool Ex50(params int[] intArray)
        {
            string numberAsString = null, tmp = null;
            if (intArray.Length <= 1) return false;

            numberAsString = intArray[0].ToString();
            numberAsString = numberAsString.Substring(numberAsString.Length - 1);

            for (int i = 1; i < intArray.Length; i++)
            {
                tmp = intArray[i].ToString();
                tmp = tmp.Substring(tmp.Length - 1);
                if (numberAsString == tmp) return true;
            }

            return false;
        }
        private static bool Ex51(int x, int y, int z)
        {
            int limit = 20;
            return Math.Abs(x - y) >= limit || Math.Abs(x - z) >= limit || Math.Abs(y - z) >= limit;
        }
        private static int Ex52(int x, int y)
        {
            int n = 7;
            if (x == y) return 0;
            return x % n == y % n ? Math.Min(x, y) : Math.Max(x, y);
        }
        private static bool Ex53(int x, int y)
        {
            if (Math.Min(x, y) < 10 || Math.Max(x, y) > 99) return false;
            string str1 = x.ToString(), str2 = y.ToString();
            return str2.Contains(str1.Substring(0, 1)) || str2.Contains(str1.Substring(1, 1));
        }
        private static int Ex54(int x, int y)
        {
            int n = x + y;
            return n.ToString().Length == x.ToString().Length ? n : x;
        }
        private static int Ex55(int x, int y, int z)
        {
            if (x == y) return z;
            if (x == z) return y;
            return y == z ? x : x + y + z;
        }
        private static int Ex56(int x, int y, int z)
        {
            int n = 13;
            if (x == n) return 0;
            if (y == n) return x;
            return z == n ? y + z : x + y + z;
        }
        private static bool IsNInRangeOfXY(int n, int x, int y, bool inclusive = true)
        {
            if (inclusive) return n >= x && n <= y;
            return n > x && n < y;
        }
        private static int Ex57(int x, int y, int z)
        {
            int lower = 10, upper = 20;
            int[] allowed = new int[2] { 13, 17 };

            if (IsNInRangeOfXY(x, lower, upper) && (!allowed.Contains(x))) x = 0;
            if (IsNInRangeOfXY(y, lower, upper) && (!allowed.Contains(y))) y = 0;
            if (IsNInRangeOfXY(z, lower, upper) && (!allowed.Contains(z))) z = 0;

            return x + y + z;
        }
        private static int Ex58(int x, int y)
        {
            const int n = 13;
            return x > n && y > n ? 0 : Math.Max(x, y);
        }
        private static bool Ex59(int x, int y, int z)
        {
            return x - y == y - z;
        }
        private static string Ex60(string s1, string s2)
        {
            return $"{s1}{s2 + s2}{s1}";
        }
        private static string Ex61(string yourString, string input)
        {
            return yourString.Substring(0, 2) + input + yourString.Substring(2);
        }
        private static string Ex62(string s)
        {
            string str = s.Substring(s.Length - 2);
            return $"{str + str + str}";
        }
        private static string Ex63(string s)
        {
            return s.Length < 2 ? s : s.Substring(0, 2);
        }
        private static string Ex64(string s)
        {
            return s.Length % 2 != 0 ? s : s.Substring(0, s.Length / 2);
        }
        private static string Ex65(string s)
        {
            return s.Length < 2 ? s : s.Substring(1, s.Length - 2);
        }
        private static string Ex66(string s1, string s2)
        {
            return s1.Length > s2.Length ? $"{s2}{s1}{s2}" : $"{s1}{s2}{s1}";
        }
        private static string Ex67(string s1, string s2)
        {
            int n = 1;
            return s1.Substring(n) + s2.Substring(n);
        }
        private static string Ex68(string s)
        {
            return s.Substring(2) + s.Substring(0, 2);
        }
        private static string Ex69(string s)
        {
            return s.Substring(s.Length - 2) + s.Remove(s.Length - 2);
        }
        private static string Ex70(string s)
        {
            return s.Length < 2 ? null : s.Substring(1, s.Length - 2);
        }
        private static string Ex71(string s)
        {
            return (s.Length % 2 != 0) || (s.Length < 3) ? null
                : s.Substring((s.Length / 2) - 1, 2);
        }
        private static bool Ex72(string s)
        {
            return s.EndsWith("on");
        }
        private static string Ex73(string yourString, int lastNCharacters)
        {
            return yourString.Substring(0, lastNCharacters) + yourString.Substring(yourString.Length - lastNCharacters);
        }
        private static string Ex74(string s, int n)
        {
            return n + 2 <= s.Length ? s.Substring(n, 2) : s.Substring(0, 2);
        }
        private static string Ex75(string s)
        {
            return s.Length < 4 ? s
                : s.Substring((s.Length - 1) / 2 - 1, 3);
        }
        private static string Ex76(string s)
        {
            return s.Length > 2 ? s.Substring(0, 2) : s + "##".Substring(0, 2 - s.Length);
        }
        private static string Ex77(string s1, string s2)
        {
            string retVal;
            if (string.IsNullOrEmpty(s1)) retVal = "#";
            else retVal = s1[0].ToString();
            return string.IsNullOrEmpty(s2) ? retVal + "#" : retVal + s2[s2.Length - 1].ToString();
        }
        private static string Ex78(string s1, string s2)
        {
            string retVal = s1 + s2;
            int length = retVal.Length - 1;
            for (int i = 1; i < length; i++) if (retVal[i].ToString() == retVal[i - 1].ToString()) retVal = retVal.Remove(i, 1);
            return retVal;
        }
        private static string Ex79(string s)
        {
            return s.Length < 2 ? null : s.Substring(0, s.Length - 2) + s[s.Length - 1].ToString() + s.Substring(s.Length - 2, 1);
        }
        private static string Ex80(string s)
        {
            if (s.StartsWith("abc")) return "abc";
            return s.StartsWith("xyz") ? "xyz" : string.Empty;
        }
        private static bool Ex81(string s)
        {
            return s.Substring(0, 2) == s.Substring(s.Length - 2);
        }
        private static string Ex82(string s1, string s2)
        {
            if (s1.Length < s2.Length) return s1 + s2.Substring(s2.Length - s1.Length);
            return s1.Length > s2.Length ? s1.Substring(s1.Length - s2.Length) + s2 : s1 + s2;

        }
        private static string Ex83(string s)
        {
            return s.Length < 2 ? s + s + s : s.Substring(0, 2) + s.Substring(0, 2) + s.Substring(0, 2);
        }
        private static string Ex84(string s)
        {
            int n = 2;
            return s.Substring(0, n) == s.Substring(s.Length - n) ? s.Substring(n) : s;
        }
        private static string Ex85(string s)
        {
            string retVal = string.Empty;
            if (s[0].ToString() != "p") retVal = null;
            else retVal = s[0].ToString();

            return s[1].ToString() != "y" ? retVal + s.Substring(2) : retVal + s.Substring(1);
        }
        private static string Ex86(string s)
        {
            string retVal = string.Empty, test = "a";
            if (!s.StartsWith(test)) retVal = s.Substring(0, s.Length - 1);
            else retVal = s.Substring(2, s.Length - 2);
            return s.EndsWith(test) ? retVal : retVal + s.Substring(s.Length - 1);
        }
        private static string Ex87(string s)
        {
            return s.Substring(0, 2).Replace("a", null) + s.Substring(2);
        }
        private static bool Ex88(int[] array)
        {
            const int n = 10;
            return array[0] == n || array[array.Length - 1] == n;
        }
        private static bool Ex89(int[] array)
        {
            return array[0] == array[array.Length - 1];
        }
        private static bool Ex90(int[] x, int[] y)
        {
            return x[0] == y[0] || x[x.Length - 1] == y[y.Length - 1];
        }
        private static int Ex91(int[] x)
        {
            return x.Sum();
        }
        private static int[] Ex92(int[] x)
        {
            int[] retVal = x.Skip(1).ToArray();
            Array.Resize(ref retVal, x.Length);
            retVal[x.Length - 1] = x[0];
            return retVal;
        }
        private static int[] Ex93(int[] x)
        {
            int[] retVal = x;
            Array.Reverse(retVal);
            return retVal;
        }
        private static int[] Ex94(int[] x)
        {
            int[] retVal = x;
            Array.Sort(retVal);
            int n = retVal[x.Length - 1];
            for (int i = 0; i < retVal.Length - 1; i++) retVal[i] = n;
            return retVal;
        }
        private static int[] Ex95(int[] x, int[] y)
        {
            return new int[] { x[2], y[2] };
        }
        private static int[] Ex96(int[] x)
        {
            return x.Length > 1 ? new int[] { x[0], x[x.Length - 1] } : x;
        }
        private static bool Ex97(int[] x)
        {
            return x.Contains(15) || x.Contains(20);
        }
        private static bool Ex98(int[] x)
        {
            return !x.Contains(15) && !x.Contains(20);
        }
        private static int[] Ex99(int[] x)
        {
            int[] retVal = new int[x.Length * 2];
            retVal[0] = x[0];
            return retVal;
        }
        private static bool Ex100(int[] x)
        {
            int[] lower = x.Where(n => n == 10).Select(n => n).ToArray();
            int[] upper = x.Where(n => n == 20).Select(n => n).ToArray();
            return lower.Count() == 2 || upper.Count() == 2;
        }
        private static int[] Ex101(int[] x)
        {
            int[] retVal = x;
            for (int i = 0; i < x.Length - 1; i++) if (x[i] == 5 && x[i + 1] == 7) retVal[i + 1] = 1;
            return retVal;
        }
        private static int[] Ex102(int[] x, int[] y)
        {
            return x.Sum() > y.Sum() ? x : y;
        }
        private static int[] Ex103(int[] x)
        {
            return new int[] { x[x.Length / 2 - 1], x[x.Length / 2] };
        }
        private static int[] Ex104(int[] x, int[] y)
        {
            return new int[] { x[0], x[1], x[2], y[0], y[1], y[2] };
        }
        private static int[] Ex105(int[] x)
        {
            int first = x[0];
            x[0] = x[x.Length - 1];
            x[x.Length - 1] = first;
            return x;
        }
        private static int[] Ex106(int[] x)
        {
            if (x.Length < 3) return x;
            int n = x.Length / 3;
            return new int[] { x[n], x[n + 1], x[n + 2] };
        }
        private static int Ex107(int[] x)
        {
            return Math.Max(Math.Max(x[x.Length / 2], x[x.Length - 1]), x[0]);
        }
        private static int[] Ex108(int[] x)
        {
            return x.Length < 2 ? x : new int[] { x[0], x[1] };
        }
        private static int Ex109(int[] x)
        {
            int retVal = 0;
            foreach (int item in x) if (item % 2 == 0) retVal++;
            return retVal;
        }
        private static int Ex110(int[] x)
        {
            return x.Length < 1 ? x[0] : x.Max() - x.Min();
        }
        private static int Ex111(int[] x)
        {
            return x.Where(n => n != 17).Sum();
        }
        private static int Ex112(int[] x)
        {
            int retVal = 0;
            bool flag = false;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].ToString().Contains("5")) flag = true;
                else if (flag && x[i] == 6) flag = false;
                else if (!flag) retVal += x[i];
            }
            return retVal;
        }
        private static bool Ex113(int[] x)
        {
            for (int i = 0; i < x.Length; i++) if (x[i].ToString().Contains("5") && x[i + 1] == 5) return true;
            return false;
        }
        private static bool Ex114(int[] x)
        {
            return x.Where(n => n == 5).ToArray().Count() > 0 || x.Where(n => n == 7).ToArray().Count() > 0;
        }
        private static bool Ex115(int[] nums)
        {
            return nums.Where(n => n == 5).ToArray().Sum() == 15;
        }
        private static bool Ex116(int[] nums)
        {
            return nums.Where(n => n == 3).ToArray().Sum() > nums.Where(n => n == 5).ToArray().Sum();
        }
        private static bool Ex117(int[] nums)
        {
            return nums.Contains(3) || nums.Contains(5);
        }
        private static bool Ex118(int[] nums)
        {
            return !(nums.Contains(3) && nums.Contains(5));
        }
        private static bool Ex119(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++) if ((nums[i] == 3 && nums[i + 1] == 3) || (nums[i] == 5 && nums[i] == 5)) return true;
            return false;
        }
        private static bool Ex120(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++) if ((nums[i] == 5 && nums[i + 1] == 5) || (nums[i] == 5 && nums[i + 2] == 5)) return true;
            return false;
        }
        private static bool Ex121(int[] nums)
        {
            return (nums.Contains(3) && nums.Contains(5));

        }
        private static bool Ex122(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++) if ((nums[i] % 2 == 0 && nums[i + 1] % 2 == 0) || (nums[i] % 2 != 0) && nums[i + 1] % 2 != 0) return true;
            return false;
        }
        private static bool Ex123(int[] nums)
        {
            if (nums.Where(n => n == 5).Sum() < 25) return false;
            for (int i = 0; i < nums.Length - 1; i++) if (nums[i] == 5 && nums[i + 1] == 5) return false;
            return true;
        }
        private static bool Ex124(int[] nums)
        {
            int length = nums.Length;
            bool flag = true;

            for (int i = 0; i < length; i++)
            {
                if (nums[i] == 5)
                {
                    if ((i > 0 && nums[i - 1] == 5) || (i < length - 1 && nums[i + 1] == 5)) flag = true;
                    else if (i == length - 1) flag = false;
                    else return false;
                }
            }
            return flag;
        }
        private static bool Ex125(int[] nums, int length)
        {
            int[] firstN = (int[])nums.Take(length).ToArray(), lastN = (int[])nums.Skip(nums.Length - length).ToArray();
            return firstN.SequenceEqual(lastN);
        }
        private static bool Ex126(int[] nums)
        {
            int length = nums.Length-3;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] == nums[i + 1] - 1 && nums[i] == nums[i + 2] - 2) return true;
            }
            return false;
        }
        private static int[] Ex127(int[] nums)
        {
            int[] retVal = nums.Skip(1).ToArray();
            Array.Resize(ref retVal, nums.Length);
            retVal[nums.Length - 1] = nums[0];
            return retVal;
        }
        private static int[] Ex128(int[] nums)
        {
            int index = Array.IndexOf(nums, 5);
            return nums.Take(index).ToArray();
        }
        private static int[] Ex129(int[] nums)
        {
            int index = Array.IndexOf(nums, 5) +1;
            return nums.Skip(index).ToArray();
        }
        private static int[] Ex130(int[] nums)
        {
            int position = 0, length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] == 0)
                {
                    nums[i] = nums[position];
                    nums[position++] = 0;
                }
            }
            return nums;
        }
        private static int[] Ex131(int[] nums)
        {
            int length = nums.Length, ctr = 0;
            int[] retVal = new int[length];

            for (int i = 0; i < length; i++)
            {
                if (nums[i] != 5) retVal[ctr++] = nums[i];
            }

            return retVal;
        }
        private static int[] Ex132_old(int[] nums)
        {
            return nums.OrderByDescending(n => n % 2 == 0).ToArray();
        }
        private static int[] Ex132(int[] nums)
        {
            int length = nums.Length, tmp = 0, position = 0;
            int[] retVal = new int[length];

            for (int i = 0; i < length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    tmp = nums[position];
                    nums[position] = nums[i];
                    nums[i] = tmp;
                    position++;
                }
            }
            return retVal;
        }
        private static bool Ex133(int[] nums)
        {
            int[] temp = (int[]) nums.Clone();
            Array.Sort(temp);
            return nums.SequenceEqual(temp);
        }
        private static bool Ex134(int[] nums)
        {
            return !nums.Contains(15) ? false : nums[Array.IndexOf(nums, 15) + 1] == 15;
        }
        private static int Ex135(int[] nums)
        {
            return Math.Max(int.Parse(Math.Round(nums.Take(nums.Length / 2).Average()).ToString())
                , int.Parse(Math.Round(nums.Skip(nums.Length / 2).Average()).ToString()));
        }
        private static int Ex136(string[] words, int length)
        {
            return words.Where(w => w.Length == length).Count();
        }
        private static string[] Ex137(string[] words, int n)
        {
            return words.Take(n).ToArray();
        }
        private static string[] Ex138(string[] words, int n)
        {
            return words.Where(str => str.Length == n).ToArray();
        }
        private static bool Ex139(int n)
        {
            return n.ToString().Contains("2");
        }
        private static int[] Ex140(int[] nums, int length)
        {
            return nums.Where(n => n % 2 != 0).Take(length).ToArray();
        }
        private static List<int> Ex141(List<int> nums)
        {
            return nums.Select(n => n * 3).ToList<int>();
        }
        private static List<int> Ex142(List<int> nums)
        {
            return nums.Select(n => n * n * n).ToList();
        }
        private static List<string> Ex143(List<string> words)
        {
            return words.Select(word => "#" + word + "#").ToList();
        }
        private static List<string> Ex144(List<string> words)
        {
            return words.Select(str => str + str + str + str).ToList();
        }
        private static List<int> Ex145(List<int> nums)
        {
            return nums.Select(n => (n + 2) * 5).ToList();
        }
        private static List<int> Ex146(List<int> nums)
        {
            return nums.Select(n => n % 10).ToList();
        }
        private static List<string> Ex147(List<string> words)
        {
            return words.Select(s => s.ToUpper()).ToList();
        }
        private static List<string> Ex148(List<string> words)
        {
            return words.Select(s => s.Replace("a", null)).ToList();
        }
        private static List<int> Ex149(List<int> nums)
        {
            return nums.Where(n => n < 4).ToList();
        }
        private static List<int> Ex150(List<int> nums)
        {
            return nums.Where(n => n % 10 != 7).ToList();
        }
    }
}