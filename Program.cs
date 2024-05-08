using System;
public interface IMario
{
    void Ability();

}
class Mario:IMario{
    public virtual void Ability()
    {
        Console.WriteLine("Mario's Ability:Normal Dancing");
    }
}  
class SuperMario:Mario
{
    public new void Ability()
    {
        Console.WriteLine("Mario's Ability:Super Dancing");
    }
}
class Program
{
    static void Main(string[]args)
    {
        IMario mario=new Mario();
        SuperMario superMario=new SuperMario();
        mario.Ability();
        superMario.Ability();

    }
}