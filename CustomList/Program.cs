using CustomList.Collections;

//List<int> list = new List<int>();

//list.Add(1);
//list.Add(1);
//list.Add(2);
//list.Add(3);
//list.Add(4);

//Console.WriteLine(list.Capacity);

//list.Add(2);
//Console.WriteLine(list.Capacity);
////foreach (int i in List)
////{
////    Console.WriteLine(i);
////}
//Console.WriteLine(List.Contains());

MyList<int> myList = new MyList<int>();
myList.Capacity = 10;
myList.Add(4);
myList.Add(5);
myList.Add(1);
myList.Add(2);
 myList.CustomReverse();




foreach (var item in myList)
{
    Console.WriteLine(item);
}

//Console.WriteLine(myList.Find(n => n == 0));
//Console.WriteLine(myList.Capacity);

//myList.Capacity = 3;
//Console.WriteLine(myList.Contains(5));

//foreach (var item in myList)
//{
//    Console.WriteLine(item);
//}


//IEnumerable<int> GetEvenNumbers(int[] arr)
//{
//	foreach (var item in arr)
//	{
//		if (item % 2 == 0)
//			yield return item;
//	}
//}

//IEnumerable<int> res = GetEvenNumbers(new int[] { 1, 2, 3, 4, 5, 6, 7 });

//foreach (var item in res)
//{
//	Console.WriteLine(item);
//}

