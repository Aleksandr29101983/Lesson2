double Vfriend1 = 1;
double Vfriend2 = 2;
double Vdog = 5;
double Sdistant = 10000;
bool Friend1 = true;
int Count = 0;
double Time;

while(Sdistant > 10)
{
    if (Friend1 == true) 
    {
        Time = Sdistant / (Vfriend2 + Vdog);
        Friend1 = false;
    }
    else
    {
        Time = Sdistant / (Vfriend1 + Vdog);
        Friend1 = true;
    }
    Sdistant = Sdistant - (Vfriend1 + Vfriend2) * Time;
    Count = Count + 1;
}
Console.WriteLine(Count);