// See https://aka.ms/new-console-template for more information

byte b = 5; // 1 byte yer kaplar.
sbyte c = 5; // 1 byte yer kaplar.

short s = 5; // 2 byte yer kaplar. -128 ile +127 arası
ushort us = 5; // 2 byte yer kaplar. 0-65635 arası değerler alır.

Int16 i16 = 2; // 2 byte yer kaplar.
int i = 2; // 4 byte yer kaplar.j
Int32 i32 = 2; // 4 byte yer kaplar.
Int64 i64 = 2; // 8 byte yer kaplar.

uint ui = 2; // 4 byte yer kaplar.
long l = 4; // 4 byte yer kaplar.
ulong ul = 4; // 8 byte yer kaplar.

// Reel Sayılar
float f = 3; // 4 byte yer kaplar.
double d = 4; // 8 byte yer kaplar.
decimal de = 4; // 16 byte yer kaplar.

char ch = "2"; // 2 byte yer kaplar.
string str = "Onur"; // Sınırsız.

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;
Console.WriteLine(dt)

object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;

// Stringler

string str1 = string.Empty;
str1 = "Onur COSKUN";
string ad = "Onur";
string soyad = "COSKUN";
string tamisim = ad + " " + soyad;

// Integer degiskenler

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;

// boolean

bool bool1 = 10<2;
bool bool2 = 10>2;

// Değişken Dönüşümleri

string str10 = "20";
int int21 = 20;

string yeniDeger = str10 + int21.ToString();

Console.WriteLine(yeniDeger); //Output = 2020


int int22 = int21 + Convert.ToInt32(str10);
Console.WriteLine(int22); // Output = 40

int int24 = int21 + int.Parse(str10); // Output = 40

// Datetime

string Datetime = DateTime.Now.ToString("dd.MM.yyyy"); // 22.01.2022

string hour = DateTime.Now.ToString("HH:mm");






