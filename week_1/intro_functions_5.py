"""

File: Intro functions 5.
Author: Scott Kamerath
Purpose: Introducing functions.
Date: 1/7/2022

"""

def get_initial(name, force_uppercase):
    if force_uppercase:
        # initial = name[0:1]
        initial = name[0:1].upper()
        # initial = name[0:1].lower()
    else:
        initial = name[0:1]
        return initial

first_name = input('Please enter your first name here: ')
# first_name_initial = first_name[0:1]
first_name_initial = get_initial(force_uppercase = True, name = first_name)

# middle_name_initial = middle_name[0:1]
middle_name = input('Please enter your middle name here: ')
middle_name_initial = get_initial(middle_name)

# last_name_initial = last_name[0:1]
last_name = input('Please enter your last name here: ')
last_name_initial = get_initial(last_name)
# print('Your initials are: ' + first_name_initial + middle_name_initial + last_name_initial)
print('Your initials are: ' + get_initial(first_name) + get_initial(middle_name) + get_initial(last_name))