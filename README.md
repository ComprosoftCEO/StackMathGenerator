# Stack Math Generator
Generate Stack Math puzzles with this handy utility written in Visual Basic

## What is a Stack Math Puzzle?
Stack Math consists of a vertical list of numbers and a target number. Starting at the top of the list, your goal is to get the list of numbers to equal the target number using the 4 basic operators +, -, *, and /. However, you must __IGNORE ORDER OF OPERATIONS__ and instead go in the order of the stack. Consider the following puzzle:

|Stack|Target Number   |
|:---|:---:|
|5<br/>6<br/>8<br/>1<br/>8<br/>4 | 68 |

The answer is -++*+, because:
* 5 - 6 = -1
* -1 + 8 = 7
* 7 + 1 = 8
* 8 * 8 = 64
* 64 + 4 = 68

You see how the solution reads like a stack, hence the name "Stack Math"

<br/>

## How to use Stack Math Generator
Stack Math Generator has 2 modes of operation
* __Basic Mode__ - Select from 5 levels of difficulty, with the parameters already set
* __Advanced More__ - Set your own parameters

Click "Generate Puzzle" to generate a random puzzle. Or, using the date picker, seed the puzzle generator with a custom date to generate a daily puzzle. To do this, select the desired date, then click "Seed."

Once the puzzle is generated, the program displays the stack and the target number. Check "Show Answer" to reveal the answer for the current puzzle (__No Cheating!__). Or, you can copy the puzzle to the clipboard.

Finally, Stack Math Generator has a Solver utility that allows you to find the solution to a given puzzle.

<br/>

## Basic Mode
In every mode, the stack numbers range from 1 to 9, and there is only 1 solution to each puzzle. Here is a more detailed description for each of the following difficulty levels:
* __Easy__ - 4 numbers with the target from 1 to 50
* __Normal__ - 5 numbers with the target from 1 to 100
* __Intermediate__ - 6 numbers with the target from 1 to 250
* __Advanced__ - 7 numbers with the target from 1 to 500
* __Expert__ - 9 numbers with the target from 1 to 1000

<br/>

## Advanced Mode
Advanced Mode has 2 ways to generate the numbers stack
* __Random Stack__ - Computer generates the number on the stack
* __Custom Stack__ - You decide what numbers go on the stack

After the numbers are on the stack, the computer generates the actual puzzle. (*see Puzzle Generation*)

### Random Stack
This option has 2 parameters that you can modify when generating a stack:
* __Size__ - How many numbers are in the stack
* __Range__ - What is the range for each number in the stack

### Custom Stack
This option allows you to specify which numbers go on the stack.
* To add a number onto the stack, type the number into the number picker and click "Add"
* To remove a number from the stack, click on the number inside the stack and click "Remove"
* To modify an existing number, click on that number inside the stack and click "Update"
* To change the order of numbers on the stack, click on the number to move and use the up and down arrows to move the number up or down
* Click "Clear Stack" to remove all numbers from the stack

### Puzzle Generation
When generating the puzzle, there are a few parameters you can modify to specify what type of puzzle you want:
* __Target__ - Specify the range for the target number
* __Solutions__ - How many unique solutions should there be for a given puzzle
* __Choose Target__ - If selected, Stack Math Generator pulls up a dialog that shows all generated puzzles that meet the above criteria (*see Choose Target*) 

<br/>

## Choose Target
This dialog displays all generated puzzles that meet the parameters specified under Puzzle Generation. The list shows the target number of each puzzle and the number of solutions for that target number. Double click on a puzzle to place a check mark next to it. Clicking "Pick Selected" will randomly pick a puzzle from all checked puzzles. Use "Select All" to put a check mark next to all puzzles, or "Deselect All" to remove all checkmarks. Checking "Show Answer" will show the solution for the selected puzzle.

<br/>

## Solver
Adding numbers to the solver stack is exactly the same as adding numbers to the custom stack.
* To add a number onto the stack, type the number into the number picker and click "Add"
* To remove a number from the stack, click on the number inside the stack and click "Remove"
* To modify an existing number, click on that number inside the stack and click "Update"
* To change the order of numbers on the stack, click on the number to move and use the up and down arrows to move the number up or down
* Click "Clear Input" to remove all numbers from the stack and clear the Target Number

After you input the stack, type the target number, then click solve. All solutions for the given puzzle will appear in the box on the right. You can optionally copy all of these solutions to the clipboard

<br/>

----

<br/>

## Other Notes
Stack Math was invented for Mrs. Glaze, my math teacher at Pike High School. If you have her Pre-Calculus class, be sure to ask her about it. I used this utility to generate a TON of puzzles for her.
