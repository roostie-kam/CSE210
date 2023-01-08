"""

File: Intro functions 2.
Author: Scott Kamerath
Purpose: Introducing functions.
Date: 1/7/2023

"""

def get_initial(name):
    # initial = name[0:1]
    initial = name[0:1].upper()
    # initial = name[0:1].lower()
    return initial

first_name = input('Please enter your first name here: ')
# first_name_initial = first_name[0:1]
first_name_initial = get_initial(first_name)

middle_name = input('Please enter your middle name here: ')
middle_name_initial = get_initial(middle_name)
# middle_name_initial = middle_name[0:1]

last_name = input('Please enter your last name here: ')
last_name_initial = get_initial(last_name)
# last_name_initial = last_name[0:1]

# print('Your initials are: ' + first_name_initial + middle_name_initial + last_name_initial)
print('Your initials are: ' + get_initial(first_name) + get_initial(middle_name) + get_initial(last_name))