// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DebugSpace
{
	class Proggram
	{
		static void main(string[] args)
		{
			int[] testArray = {4,7,4,2,7,3,7,8,3,9,1,9};
			int[] maxValIndices;
			int maxVal = Maxima(testArray,out maxValIndices);
			Console.WriteLine("Maximum value {0} found at element indices:",maxVal);
			foreach(int index in maxValIndices)
			{
				Console.WriteLine(index);
			}
			Console.ReadKey();
		}
		
		static int Maxima(int [] integers,out int[] indices)
		{
			Debug.WriteLine("Maximum value search started.");
			indices = new int[1];
			int maxVal = integers[0];
			indices[0] = 0;
			int count = 1;
			Debug.WriteLine(string.Format("Maxumum value initialized to {0},at element index 0.",maxVal));
			for(int i = 1;i<integers.Length;i++)
			{
				Debug.WriteLine(string.Format("Now looking at element at indexc{0}."i));
				if(integers[i]>maxVal)
				{
					maxVal = integers[i];
					count = 1;
					indices = new int[1];
					indices[0] = i;
					Debug.WriteLine(string.Format("New maximum found.New value is{0}, at element index{1}. ",maxVal,i));
				}
				else
				{
					if(integers[i] == maxVal)
					{
						count ++;
						int[] oldIndices = indices;
						indices = new int[count];
						oldIndices.CopyTo(indices,0);
						indices[count - 1 ] = i;
						Debug.WriteLine(string.Format("Duplicate maximum found at element index {0}.",i));
					}
				}
			
			}
		
			Trace.WriteLine(string.Format("Maximum value {0} found with{1} occurrences .",maxVal,count));
			Debug.WriteLine(string.Format("Maximum value search completed."));
			return maxVal;
		}
	}

}
