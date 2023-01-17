"""
File: Grading Calculator
Date: 1/9/2023
Author: Scott Kamerath

Purpose: To learn how to write a Grading Calculator

"""
# Grading Scale

#  A >= 90

# B >= 80

# C >= 70

# D >= 60

# F < 60

# Core Requirements:

# Ask the user for their grade percentage, then write a series of if-elif-else statements 
# to print out the appropriate letter grade. 

# (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)

# Assume that you must have at least a 70 to pass the class. After determining the letter grade 
# and printing it out.
# Add a separate if statement to determine if the user passed the course, and if so display 
# a message to congratulate them. 
# If not, display a different message to encourage them for next time.

# Change your code from the first part, so that instead of printing the letter grade in the body of each 
# if, elif, or else block, instead create a new variable called letter and then in each block, set this 
# variable to the appropriate value. Finally, after the whole series of if-elif-else statements, have a 
# single print statement that prints the letter grade once.

# Ask the user for their grade?
from math import remainder


grade_input = float(input('What is your grade percentage? ')) # 98, 93.4, 32.91
letter = str("")

# Are they passing?
if (grade_input > 70):
    print('Hear, Hear! You passed the class!')
elif (grade_input == 70):
    print("You're skating on very thin ice, my friend. ")
else: 
    print("Frankly, you suck! ")

# Now give them their grade

if grade_input >= 90: # A >= 90
    letter = str("A")
elif grade_input >= 80: # B >= 80
    letter = str("B")
elif grade_input >= 70: # C >= 70
    letter = str("C")
elif grade_input >= 60: # D >= 60
    letter = str("D")
elif (grade_input < 60): # F < 60
    letter = str("F")
else:
    letter = str("Dude") # You killed the Xbox.

print(f"You have a {letter} in the class. ")

# Stretch Challenge

# Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. 
# For each grade, you'll know it is a "+" if the last digit is >= 7. You'll know it is a minus if 
# the last digit is < 3 and otherwise it has no sign. 

# After your logic to determine the grade letter, 
# add another section to determine the sign. Save this sign into a variable. 
# Then, display both the grade letter and the sign in one print statement.

# Hint: To get the last digit, you could divide the number by 10, and get the remainder. 
# You might refer back to the preparation material for Lesson 03 to see the operators 
# and find the one that does division and gives you the remainder.

# At this point, don't worry about the exceptional cases of A+, F+, or F-.

# Recognize that there is no A+ grade, only A and A-. 
# Add some additional logic to your program to detect this case and handle it correctly.

# Similarly, recognize that there is no F+ or F- grades, only F. 
# Add additional logic to your program to detect these cases and handle them correctly.

# A+, A-, B+, B-, and so on etc.
remainder = grade_input % 10
# Is it an A+
if (remainder >= 7):
    # Is it an A or an F?
    if (grade_input > 90):
        plus_minus = str("")
    elif (0 > grade_input < 60):
        plus_minus = str("")
    else:
        plus_minus = str("+")
# If it's an A-
elif (remainder <= 3):
    plus_minus = str("-")
else:
    plus_minus = str("")

print(f"You have a {letter}{plus_minus} in the class.")