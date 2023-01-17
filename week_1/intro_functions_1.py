"""

File: Intro functions 1.
Author: Scott Kamerath
Purpose: Introducing functions.
Date: 1/7/2023

"""

# Import the datetime class from the datetime library.
from datetime import datetime
# Print the current time.
# def print_time():
def print_time(task_name):
    print(task_name)
    # print('task completed')
    # Now I don't need the extra datetime prefix.
    # print(datetime.datetime.now())
    print(datetime.now())
    print()

# To print a date and time stamp to see 
# how long the sections of code take to run.

first_name = 'Scott'
print_time('first name assigned')
print(first_name)
# print_time()
# print('task completed')
# print(datetime.datetime.now())
# print()

middle_name = 'Royal'
print_time('middle name assigned')
print(middle_name)
# print_time()
# print('task completed')
# print(datetime.datetime.now())
# print()

last_name = 'Kamerath'
print_time('last name assigned')
print(last_name)
# print_time()
# print('task completed')
# print(datetime.datetime.now())
# print()

for x in range(0,10):
    print(x)
print('loop completed')
# print_time()
# print('task completed')
# print(datetime.datetime.now())
# print(datetime.now())
# print()