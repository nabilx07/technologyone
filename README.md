# technologyone

Steps to test the application
1. Open your terminal or command prompt.
    Navigate to the directory where your project is located:
    ~\technologyone_asset.exe    
2. Run the application by executing 
3. Open APITester.html to test the application


Test Plan 

Simple Test Plan for Number to Words Converter
Goal:
We want to make sure that our magic tool that turns numbers into words works perfectly. It should be able to handle any number we give it, whether it's small, big, a bit negative, or has some small numbers after a dot (like prices in a store).

What You Need:
Magic Number Box (a computer with our program loaded)
Number Cards (different numbers written on pieces of paper)
How to Do the Magic Tests:
We'll use different sets of number cards to see if our magic number box can turn them all into word cards.

Test 1: Small Numbers
What to do:

Pick number cards from 0 to 9.
Feed each card to the magic number box.
Expected Magic Words:

0 should give us "Zero"
1 should give us "One"

Test 2: Teen Numbers (a little bigger than small numbers)
What to do:

Pick number cards from 10 to 19.
Feed each card to the magic number box.
Expected Magic Words:

10 should give us "Ten"
11 should give us "Eleven"
... (and so on up to 19)
Test 3: Big Round Numbers (like 20, 30, up to 90)
What to do:

Pick number cards like 20, 30, up to 90.
Feed each card to the magic number box.
Expected Magic Words:

20 should give us "Twenty"
30 should give us "Thirty"

Test 4: Hundreds (even bigger numbers)
What to do:

Pick number cards like 100, 200, up to 900.
Feed each card to the magic number box.
Expected Magic Words:

100 should give us "One Hundred"
200 should give us "Two Hundred"
Test 5: Thousands and Big, Big Numbers (like a storybook castle's age)
What to do:

Pick number cards like 1,000; 10,000; and 100,000.
Feed each card to the magic number box.
Expected Magic Words:

1,000 should give us "One Thousand"
10,000 should give us "Ten Thousand"
100,000 should give us "One Hundred Thousand"
Test 6: Numbers with Small Parts After a Dot (like when you buy candy and it costs not just 1 but 1.25)
What to do:

Pick number cards like 1.25, 100.50.
Feed each card to the magic number box.
Expected Magic Words:

1.25 should give us "One and Twenty-Five Cents"
100.50 should give us "One Hundred and Fifty Cents"
What If It Goes Wrong?
If any of the cards give us the wrong word, we write down what went wrong on a mistake card, so we can fix the magic number box later.

After the Test:
Gather all the mistake cards (if there are any), and give them to the magic box fixer (programmer). They'll know what to do to make the box work right every time!

Conclusion:
This test plan is designed to be as simple and understandable as possible, checking basic and complex number conversions to ensure the program is robust and reliable. Each test is crafted to check a specific functionality, and clear expected results help determine if the test passed or failed.
