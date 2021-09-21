using System;

public class Node
{

    private string Text;

    private Node[] Child;

    public Node(string text, params Node[] child)         // констуктор узла в дереве
    {
        Text = text;
        Child = child;
    }

    public static Node AddNodes(string text, params Node[] child)
    {
        return new Node(text, child);
    }


    public override string ToString()  // печать первого элемента
    {
        string thisStr = Text + "\n";

        string nextPrefix = "";

        for (int i = 0; i < Child.Length - 1; i++)                      // Вывод детей 
            thisStr = thisStr + Child[i].PrintChild(nextPrefix, false);


        if (Child.Length > 0)
            thisStr = thisStr + Child[Child.Length - 1].PrintChild(nextPrefix, true);            // вывод последнего ребенка

        return thisStr;
    }

    private string PrintChild(string prefix, bool isLast)  // вывод детей    
    {
        string thisStr = "";
        string nextPrefix = "";

        if (isLast)
        {
            thisStr = prefix + "└─" + Text + "\n";
            nextPrefix = prefix + "  ";
        }
        else                                            //  создании префикса
        {
            thisStr = prefix + "├─" + Text + "\n";
            nextPrefix = prefix + "| ";
        }

        for (int i = 0; i < Child.Length - 1; i++)
            thisStr = thisStr + Child[i].PrintChild(nextPrefix, false);        // вывод детей

        if (Child.Length > 0)
            thisStr = thisStr + Child[Child.Length - 1].PrintChild(nextPrefix, true);           // отдельный вывод последнего ребенка


        return thisStr;
    }


}

public static class Derevo
{
    public static void Main()
    {
        Node Root = Node.AddNodes("A", Node.AddNodes("B", Node.AddNodes("C", Node.AddNodes("D")

                    ),
                    Node.AddNodes("E",
                        Node.AddNodes("F")

                    ),
                    Node.AddNodes("G")
                ),
                Node.AddNodes("X"),


                Node.AddNodes("T")
            );

        Console.WriteLine(Root);
    }
}