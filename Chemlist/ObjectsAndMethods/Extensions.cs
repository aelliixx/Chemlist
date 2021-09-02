using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemlist
{
	public static class Extensions
	{
		public static List<TreeNode> descendants(this TreeView tree)
		{
			var nodes = tree.Nodes.Cast<TreeNode>();
			return nodes.SelectMany(x => x.descendants()).Concat(nodes).ToList();
		}

		public static List<TreeNode> descendants(this TreeNode node)
		{
			var nodes = node.Nodes.Cast<TreeNode>().ToList();
			return nodes.SelectMany(x => descendants(x)).Concat(nodes).ToList();
		}
	}
}
