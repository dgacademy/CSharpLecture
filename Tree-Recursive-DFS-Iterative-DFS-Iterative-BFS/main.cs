using System;
using System.Collections.Generic;

class TreeNode {
  public string Name { get; set; }
  public List<TreeNode> children;
  public TreeNode(string name) {
    Name = name;
    children = new List<TreeNode>();
  }
  public void AddChild(TreeNode node) {
    children.Add(node);
  }
}

class Tree {
  public TreeNode Root { get; set; }

  // https://en.wikipedia.org/wiki/Depth-first_search
  public string IterativeDFS(TreeNode node, Action<string> callback) {
    string s = String.Empty;
    Stack<TreeNode> stack = new Stack<TreeNode>();
    stack.Push(node);
    
    while(stack.Count > 0) {
      TreeNode n = stack.Pop();
      s += n.Name + " ";
      callback(n.Name);

      for (int i = n.children.Count-1; i >= 0; i--)
        stack.Push( n.children[i] );
    }
    return s;    
  }

  public string RecursiveDFS(TreeNode node) {
    string s = node.Name + " ";
    foreach(var n in node.children)
      s += RecursiveDFS(n);
    return s;
  }

  // https://en.wikipedia.org/wiki/Breadth-first_search
  public string IterativeBFS(TreeNode node, Action<string> callback) {
    string s = String.Empty;
    Queue<TreeNode> q = new Queue<TreeNode>();
    q.Enqueue(node);
    
    while(q.Count > 0) {
      TreeNode n = q.Dequeue();
      s += n.Name + " ";
      callback(n.Name);

      foreach(var c in n.children)
        q.Enqueue( c );
    }
    return s;
  }
  
}


class MainClass {
  public static void Main (string[] args) {
    Tree tree = new Tree();

    TreeNode root = new TreeNode("root");
    TreeNode a = new TreeNode("a");
    TreeNode b = new TreeNode("b");
    TreeNode c = new TreeNode("c");
    TreeNode d = new TreeNode("d");
    TreeNode e = new TreeNode("e");
    TreeNode f = new TreeNode("f");
    TreeNode g = new TreeNode("g");
    TreeNode h = new TreeNode("h");
    TreeNode i = new TreeNode("i");
    
    tree.Root = root;    
    
//             root
//           /   |   \
//         a     b    c
//       /  \   / \
//      d    e f   g 
//                / \
//               h   i
    
    root.AddChild(a); root.AddChild(b); root.AddChild(c);
    a.AddChild(d); a.AddChild(e);
    b.AddChild(f); b.AddChild(g);
    g.AddChild(h); g.AddChild(i);
    
    Console.WriteLine(root.Name + " " + tree.RecursiveDFS(a) + tree.RecursiveDFS(b) + tree.RecursiveDFS(c) == "root a d e b f g h i c ");
    Console.WriteLine(tree.RecursiveDFS(d) == "d " );
    Console.WriteLine(tree.RecursiveDFS(a) == "a d e " );
    Console.WriteLine(tree.RecursiveDFS(root) == "root a d e b f g h i c ");
    Console.WriteLine(tree.IterativeDFS(root, (s)=>{}) == "root a d e b f g h i c ");
    Console.WriteLine(tree.IterativeBFS(root, Console.WriteLine) == "root a b c d e f g h i ");
  }
}