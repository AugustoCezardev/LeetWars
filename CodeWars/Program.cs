// See https://aka.ms/new-console-template for more information

using System.Text.Json.Serialization;
using CodeWars.CodeWars;

var result = SempleAssemblerInterpreter.Interpret([
    "mov a 5",
    "inc a",
    "dec a",
    "dec a",
    "jnz a -1",
    "inc a",
    "mov a -10",
    "mov b a",
    "inc a",
    "dec b",
    "jnz a -2",
    "mov a 1",
    "mov b 1",
    "mov c 0",
    "mov d 26",
    "jnz c 2",
    "jnz 1 5",
    "mov c 7",
    "inc d",
    "dec c",
    "jnz c -2",
    "mov c a",
    "inc a",
    "dec b",
    "jnz b -2",
    "mov b c",
    "dec d",
    "jnz d -6",
    "mov c 18",
    "mov d 11",
    "inc a",
    "dec d",
    "jnz d -2",
    "dec c",
    "jnz c -5"
]);

foreach (KeyValuePair<string, int> kvp in result)
{
    //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
}