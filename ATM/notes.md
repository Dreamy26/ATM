# Lab10 ATM Lab10 - OOP


## Task: Using objects, write an ATM system that manages money in different accounts, while keeping users’ information private.

## Classes
- ATM
- Account

## Methods
- Register - Take in a name & password
- Login - Take in a username & password
-- Check if there isa a curently logged in user.
-- No Logged in account, search the account list for an account that matches the name and password.
-- Once found, set that account to the current account. 
### Should only work if there's a logged in account
- Logout - Set the current account to null
- CheckBalance - Print the ballance of the account
- Deposit - takes in an int and adds to the balance
- Withdraw - takes in an int and tries to substract it from the balance.
-- if the int is larger that the balance, do nothing and PRINT "an error message for the user. "

## OOP
The Account object will need to track the following:

- String Name
- String Password
- Int Balance 

## CSharp SoSharp Notes

## Resources


## Questions
