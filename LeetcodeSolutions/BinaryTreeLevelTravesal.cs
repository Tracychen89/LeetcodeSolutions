using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
    public class TreeNode 
    {
     public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root)
    {

        IList<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        traversal(result, root, 1);
        return result;
    }
     
     public void traversal(IList<IList<int>> result, TreeNode node, int depth)
     {
         if(node == null)
         return;
         
         if(result.Count == depth -1)
        {
            List<int> l = new List<int>();
            l.Add(node.val);
            result.Add(l);
        }
        else if(result.Count >= depth)
        {
            IList<int> li = result[depth -1];
            li.Add(node.val);
            
        }
        
        traversal(result, node.left, depth + 1);
        traversal(result, node.right, depth +1);
        
     }
        
        
    }
}

       
   

