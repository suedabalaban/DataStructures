using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    public class AVLTree
    {
        public Node root;
        public void Print(Node currentNode, string space, bool Right)
        {
            if (currentNode!=null)
            {
                Console.WriteLine(space);
                if (Right)
                {
                    Console.Write("R---");
                    space += "    ";
                }
                else
                {
                    Console.Write("L---");
                    space += "|    ";
                }
                Console.WriteLine(currentNode.data);
                Print(currentNode.left, space, false);
                Print(currentNode.right, space, true);
            }
        }
        public int Height(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return node.height;
            }
        }
        public int Max(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
        public int ReturnBalance(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return Height(node.left) - Height(node.right);
            }
        }
        public Node TurnRight(Node incomingNode)
        {
            Node leftKid = incomingNode.left;
            Node leftKidRightKid = leftKid.right;
            leftKid.right = incomingNode;
            incomingNode.left = leftKidRightKid;
            incomingNode.height = Max(Height(incomingNode.left), Height(incomingNode.right)) + 1;
            leftKid.height = Max(Height(leftKid.left), Height(leftKid.right)) + 1;
            return leftKid;
        }
        public Node TurnLeft(Node incomingNode)
        {
            Node rightKid = incomingNode.right;
            Node rightKidLeftKid = rightKid.left;
            rightKid.left = incomingNode;
            incomingNode.right = rightKidLeftKid;
            incomingNode.height = Max(Height(incomingNode.left), Height(incomingNode.right))+1;
            rightKid.height = Max(Height(rightKid.left), Height(rightKid.right)) + 1;
            return rightKid;
        }
        public Node InsertNode(Node node, int data)
        {
            if (node == null)
            {
                return (new Node(data));
            }
            if (data < node.data)
            {
                node.left = InsertNode(node.left, data);
            }
            else if (data > node.data)
            {
                node.right = InsertNode(node.right, data);
            }
            else 
            { 
                return node;
            }
            node.height = Max(Height(node.left), Height(node.right)) + 1;
            int balance = ReturnBalance(node);
            if (balance > 1) //left side is bigger than right side
            {
                if (data < node.left.data)
                {
                    //turn to right
                    return TurnRight(node);

                }
                else if (data > node.left.data)
                {
                    //first turn to left then right
                    node.left = TurnLeft(node.left);
                    return TurnRight(node);

                }
            }
            if (balance < -1) //right side is bigger than left side
            {
                if (data < node.right.data)
                {
                    //turn to left
                    return TurnLeft(node);
                }
                else if (data < node.right.data)
                {
                    //first turn to right then left
                    node.right = TurnRight(node.right);
                    return TurnLeft(node);
                }
            }
            return node;
        }
    }
}
