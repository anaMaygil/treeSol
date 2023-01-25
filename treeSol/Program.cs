

using treeSol;

internal class Program
{
    static int yellowCounter = 0;
    static int redCounter = 0;
    static int blueCounter = 0;

    private static void Main(string[] args)
    {
        Node root = new Node("S");
        root.Left = new Node("M");
        root.Right = new Node("S");
        root.Left.Left = new Node("S");
        root.Left.Right = new Node("");
        root.Right.Left = new Node("");
        root.Right.Right = new Node("M");
        root.Left.Left.Left = new Node("S");
        root.Left.Left.Right = new Node("K");
        root.Right.Right.Right = new Node("M");
        root.Right.Right.Left = new Node("K");

        CountColours(root);

        Console.Write("Kırmızı Bilye Sayısı:" + redCounter +"\nMavi Bilye Sayısı:"+ blueCounter+ "\nSarı Bilye Sayısı:"+yellowCounter);

    }

    public static void CountColours(Node CurrentNode)
    {

    


        if (CurrentNode == null || String.IsNullOrEmpty(CurrentNode.Value))
        { return; }

        CountColours(CurrentNode.Left);
        if (CurrentNode.Value == "K")
        {
            redCounter++;
        }
        else if (CurrentNode.Value == "M")
        {
            blueCounter++;
        }
        else if (CurrentNode.Value == "S")
        {
            yellowCounter++;
        }
        CountColours(CurrentNode.Right);


     


    }
}