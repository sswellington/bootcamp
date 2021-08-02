#!/bin/python3

def factorial(number):
    if(number != 0):
        return(number * factorial(number - 1))
    else:
        return(1)


if __name__ == '__main__':
    print(factorial(42))