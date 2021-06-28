#!/bin/python3

import math
import os
import random
import re
import sys


class Rectangle:

    def __init__(self, breadth, length):
        self.breadth = breadth
        self.length = length


    def area(self):
        return (self.breadth * self.length)
    
    
    @property
    def breadth(self):
        return self._breadth 
    
    @breadth.setter
    def breadth(self, breadth):
        self._breadth = breadth
        
    @breadth.deleter
    def breadth(self):
        del self._breadth 
        
        
    @property
    def length(self):
        return self._length 
    
    @length.setter
    def length(self, length):
        self._length = length
        
    @length.deleter
    def length(self):
        del self._length 
    

class Circle:

    def __init__(self, radius):
        self.radius = radius


    def area(self):
        return (math.pi * (self.radius ** 2))
    
    
    @property
    def radius(self):
        return self._radius 
    
    @radius.setter
    def radius(self, radius):
        self._radius = radius
        
    @radius.deleter
    def radius(self):
        del self._radius 
    
    
if __name__ == '__main__':  
    
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    q = int(input())
    queries = []
    
    for _ in range(q):
        args = input().split()
        shape_name, params = args[0], tuple(map(int, args[1:]))
        
        if shape_name == "rectangle":
            a, b = params[0], params[1]
            shape = Rectangle(a, b)
        elif shape_name == "circle":
            r = params[0]
            shape = Circle(r)
        else:
            raise ValueError("invalid shape type")
    
        fptr.write("%.2f\n" % shape.area())
    fptr.close()
