﻿// Игра в пирамидки - Pyramid game

void Towers(string with = "1", string on = "3", string some = "2", int count = 7)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();