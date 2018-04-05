#! /usr/bin/python
# -*- coding: utf-8 -*- 

from __future__ import print_function, unicode_literals, division, absolute_import

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
    a = Gong();
