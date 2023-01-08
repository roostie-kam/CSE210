"""

File: Intro functions 3.
Author: Scott Kamerath
Purpose: Introducing functions.
Date: 1/7/2023

"""

# import datetime
from datetime import datetime
# print time stamps.

# Function to print the current date/time.
def print_time(task_name):
    # print('task completed')
    print(task_name)
    # print(datetime.datetime.now())
    print(datetime.now())
    print()

first_name = 'Scott'
print_time('first name assigned')
# print('task completed')
# print(datetime.datetime.now())
# print()

middle_name = 'Royal'
print_time('middle name assigned')
# print('task completed')
# print(datetime.datetime.now())
# print()

last_name = 'Kamerath'
print_time('last name assigned')
# print('task completed')
# print(datetime.datetime.now())
# print()

for x in range(0,10):
    print(x)
print_time('loop completed')
# print('task completed')
# print(datetime.datetime.now())
# print()