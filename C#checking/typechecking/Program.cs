class program{
    static void Main(string[] args){
        var a = "hello";
        Console.WriteLine(a.GetType());
        var b=1.000;
        Console.WriteLine(b.GetType());
        var c = new List<int>();
        Console.WriteLine(c.GetType());
        var d = new Dictionary<int,int>();
        Console.WriteLine(d.GetType());
        var e = new int[5];
        Console.WriteLine(e.GetType());
        var f = new int[5,5];
        Console.WriteLine(f.GetType()); 
        var g = new int[5,5,5];
        Console.WriteLine(g.GetType());

}
}