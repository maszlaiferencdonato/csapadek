// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<byte> csapadek = new List<byte>();
Random random = new Random();

for (int i = 0; csapadek.Count!=365; i++)
{
    if (random.Next(1, 8) == 1)
    {
        csapadek.Add((byte)random.Next(1, 31));
    }
    else if(i>170 && i < 235)
    {
        if(random.Next(1, 18) == 1)
        {
            csapadek.Add((byte)random.Next(1, 20));
        }
    }
    else
    {
        csapadek.Add(0);
    }
}

for (int i = 0; i < csapadek.Count; i++)
{
    Console.WriteLine(csapadek[i]);
}

//3.
int legHosszabb = 1;
int jelenlegiLegHosszabb = 0;
for (int i = 0; i < csapadek.Count; i++)
{
    if (csapadek[i]==0)
    {
        jelenlegiLegHosszabb++;
    }
    else if(csapadek[i]!=0)
    {
        jelenlegiLegHosszabb = 1;
    }
    if (jelenlegiLegHosszabb > legHosszabb)
    {
        legHosszabb = jelenlegiLegHosszabb;
    }
}
Console.WriteLine(legHosszabb);

csapadek = File.ReadAllLines("C:\\adatok\\csapadek.txt").Select(sor => Convert.ToByte(sor)).ToList();

int napok10felett = 0;
for (int i = 0; i < length; i++)
{
    
}