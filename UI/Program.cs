
using Application.BusinessLogic;

IDepartmentLogic departmentLogic = new DepartmentLogic();
var depts = departmentLogic.GetAll();

Console.WriteLine("Number Of Department are "+depts.Count());


//int[] Dids = { 1005, 1006, 1007 };
//foreach (var did in Dids)
//{
//    departmentBs.Delete(did);
//}