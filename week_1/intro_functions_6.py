"""

File: Intro functions 6.
Author: Scott Kamerath
Purpose: Introducing function perameters.
Date: 1/7/2023

"""

def get_initial(name, force_uppercase = True):
    if force_uppercase:
        # initial = name[0:1]
        initial = name[0:1].upper()
        # initial = name[0:1].lower()
    else:
        initial = name[0:1]
        return initial
# Ask for name and return the value.
first_name = input('Please enter your first name here: ')
# first_name_initial = get_initial(first_name, False)
first_name_initial = get_initial(force_uppercase = False, name = first_name)

middle_name = input('Please enter your middle name here: ')
# middle_name_initial = get_initial(middle_name, False)
middle_name_initial = get_initial(force_uppercase = False, name = middle_name)

last_name = input('Please enter your last name here: ')
# last_name_initial = get_initial(last_name, False)
last_name_initial = get_initial(force_uppercase = False, name = last_name)

print('Your initials are: ' + get_initial(first_name) + get_initial(middle_name) + get_initial(last_name))