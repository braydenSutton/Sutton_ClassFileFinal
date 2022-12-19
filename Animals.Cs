

﻿using System;

public class User
{
    public string username;
    public string breed;
    public User(string un, string bd)
    {
        username = un;
        breed = bd;
    }
}

public class Dog : User
{
    public Dog(string un, string bd) : base(un, bd)
    {
        username = un;
       breed = bd;
    }
}

public class Cat : User
{
    public Cat(string un, string bd) : base(un, bd)
    {
        username = un;
        breed = bd;
    }
}
