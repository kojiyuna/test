#! /usr/bin/python
# -*- coding: utf-8 -*- 

class Base(object):
    def __init__(self):
        print("aaa");

    def func(self):
        print("func");

class Gong(Base):
    def __init__(self):
        super(Gong, self).__init__();
        print("gong");



if __name__ == '__main__':
    #print("aaa");
    a = Gong();
