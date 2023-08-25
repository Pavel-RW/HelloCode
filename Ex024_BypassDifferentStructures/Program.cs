// // Обход разных структур - Bypass different structures

// ((4-2)*(1+3))/10

//               /
// ((4-2)*(1+3))   10

//         /
//       *   10
// (4-2)         (1+3)

//        /
//      * 	 10
//   -  	     +
// 4	2      1   3



string[] tree = { "emp", "/", "*", "10", "-", "+", "emp", "emp", "4", "2", "1", "3" };

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length && tree[pos] != "emp")
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;

        if (left < tree.Length && tree[left] != "emp")
        {
            InOrderTraversal(left);
        }

        if (tree[pos] != "emp")
        {
            Console.Write(tree[pos] + " ");
        }

        if (right < tree.Length && tree[right] != "emp")
        {
            InOrderTraversal(right);
        }
    }
}

InOrderTraversal();
